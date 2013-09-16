using System;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TM_2
{
    public partial class ImportCostForm : Form
    {
        public ImportCostForm()
        {
            InitializeComponent();
            InitializeBeginPosition();
        }

        private void uiOpenXlsButton_Click(object sender, EventArgs e)
        {
            var openXlsDialog = new OpenFileDialog
                                    {
                                        Filter = "XLS files (*.xls)|*.xls*|All files (*.*)|*.*",
                                        FilterIndex = 1,
                                        RestoreDirectory = true
                                    };

            if (openXlsDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OpenFileStringBox.Text = openXlsDialog.FileName;
                    ReadXlsData(openXlsDialog.FileName);

                    uiDateColumnTextBox.ReadOnly = false;
                    uiDateRowTextBox.ReadOnly = false;
                    uiCostColumnTextBox.ReadOnly = false;
                    uiCoastRowTextBox.ReadOnly = false;
                    uiPowerAverageCostTextBox.ReadOnly = false;
                    uiPowerAverageCostRowTextBox.ReadOnly = false;
                    uiPowerAverageCostColumnTextBox.ReadOnly = false;
                    uiLoadToDataBaseButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при прочтении фаила: " + ex.Message);
                }
            }
        }

        private void uiCancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ReadXlsData(string filename) //толяну привет
        {
            Cursor = Cursors.WaitCursor;
            string connString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename +
                                              ";Extended Properties=\"Excel 8.0;HDR=No;IMEX=1\"");
            var data = new DataSet("EXCEL");
            var conn = new OleDbConnection(connString);
            conn.Open();

            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                                             new object[] {null, null, null, "TABLE"});
            var scheet1 = (string) schemaTable.Rows[0].ItemArray[2];
            string select = String.Format("SELECT * FROM [{0}]", scheet1);
            var adapter = new OleDbDataAdapter(select, conn);
            adapter.Fill(data);
            var table = new DataTable();
            table = data.Tables[0];
            uiMainDataGridView.DataSource = table;
            conn.Close();
            for (int i = 0; i < uiMainDataGridView.Rows.Count; i++)
            {
                uiMainDataGridView.Rows[i].HeaderCell.Value = i.ToString();
            }

            for (int i = 0; i < uiMainDataGridView.Columns.Count; i++)
            {
                uiMainDataGridView.Columns[i].HeaderCell.Value = i.ToString();
                uiMainDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Cursor = Cursors.Default;
        }

        private void uiLoadToDataBaseButton_Click(object sender, EventArgs e)
        {
            int rowIndex = Convert.ToInt16(uiDateRowTextBox.Text);
            int dateColumn = Convert.ToInt16(uiDateColumnTextBox.Text);
            int hourColumn = dateColumn + 1;
            int costColumn = Convert.ToInt16(uiCostColumnTextBox.Text);

            DateTime? powerAverageCostDate = null;
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                while ((uiMainDataGridView.Rows.Count > rowIndex) &&
                       uiMainDataGridView.Rows[rowIndex].Cells[dateColumn].Value.ToString().Equals("") != true &&
                       uiMainDataGridView.Rows[rowIndex].Cells[costColumn].Value.ToString().Equals("") != true)
                {
                    DateTime date = GetDateFromGridView(rowIndex, dateColumn, hourColumn);
                    var cost = GetCostFromGridView(rowIndex, costColumn);
                    sqlProvider.AddCommand(@"IF EXISTS(SELECT Date FROM [dbo].[CalcEnergyHourPrice] WHERE Date = @Date)
                                                BEGIN
                                                    UPDATE [dbo].[CalcEnergyHourPrice] SET Cost = @Cost
                                                    WHERE Date = @Date
                                                END
                                            ELSE
                                                BEGIN
                                                    INSERT INTO [dbo].[CalcEnergyHourPrice] (Date, Cost) VALUES (@Date, @Cost)
                                                END");
                    powerAverageCostDate = date;
                    sqlProvider.SetParameter("@Date", date);
                    sqlProvider.SetParameter("@Cost", cost);
                    rowIndex++;
                }
                try
                {
                    ImportPowerAverageCostTextBox(powerAverageCostDate);
                    sqlProvider.Commit();
                    MessageBox.Show("Изменения в базе данных выполнены", "Уведомление о результатах");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Уведомление о результатах");
                }
            }
        }

        private void ImportPowerAverageCostTextBox(DateTime? date)
        {
            if (date != null)
            {
                try
                {
                    double value;
                    var c = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                    if (uiPowerAverageCostTextBox.Text == "")
                    {
                        int averageCostColumn = Convert.ToInt16(uiPowerAverageCostColumnTextBox.Text);
                        int averageCostRow = Convert.ToInt16(uiPowerAverageCostRowTextBox.Text);
                        value =
                            Convert.ToDouble(
                                uiMainDataGridView[averageCostColumn, averageCostRow].Value.ToString().Replace('.', c).
                                    Replace(',', c));
                    }
                    else
                    {
                        value = Convert.ToDouble(uiPowerAverageCostTextBox.Text.Replace('.', c).Replace(',', c));
                    }
                    using (var sqlProvider = Globals.GetSqlProvider())
                    {
                        var d = new DateTime(date.Value.Year, date.Value.Month, 1);
                        sqlProvider.SetParameter("@Date", d);
                        sqlProvider.SetParameter("@PowerAverageCost", value / 1000);
                        sqlProvider.ExecuteNonQuery(@"
                                            IF EXISTS(SELECT Date FROM [dbo].[CalcEnergyCoefficients] WHERE Date = @Date)
                                                BEGIN
                                                    UPDATE [dbo].[CalcEnergyCoefficients]
                                                    SET PowerAverageCost = @PowerAverageCost
                                                    WHERE Date = @Date
                                                END
                                            ELSE
                                                BEGIN
                                                    INSERT INTO [dbo].[CalcEnergyCoefficients] (PowerAverageCost, Date) VALUES (@PowerAverageCost, @Date)
                                                END");
                    }
                }
                catch
                {
                    MessageBox.Show(
                        "Неудалось занести в базу данных 'Средневзвешенная нерегулируемая цена на мощность на оптовом рынке. руб/МВт', не удалось считать данные");
                }
            }
            else
            {
                MessageBox.Show(
                    "Неудалось занести в базу данных 'Средневзвешенная нерегулируемая цена на мощность на оптовом рынке. руб/МВт', не удалось прочитать дату");
            }
        }

        private DateTime GetDateFromGridView(int rowIndex, int dateColumn, int hourColumn)
        {
            return Convert.ToDateTime(uiMainDataGridView.Rows[rowIndex].Cells[dateColumn].Value + " " +
                                      uiMainDataGridView.Rows[rowIndex].Cells[hourColumn].Value + ":00:00.0000");
        }

        private Double GetCostFromGridView(int rowIndex, int costColumn)
        {
            var c = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            var costFromGridView = (float) Convert.ToDouble(
                uiMainDataGridView.Rows[rowIndex].Cells[costColumn].Value.ToString().Replace('.', c).Replace(',', c));
            return costFromGridView;
        }

        private void InitializeBeginPosition()
        {
            var dateBeginCell = new Point(0, 41);
            var costBeginCell = new Point(5, 41);
            var powerAverageCostCell = new Point(1, 24);
            uiPowerAverageCostColumnTextBox.Text = powerAverageCostCell.X.ToString();
            uiPowerAverageCostRowTextBox.Text = powerAverageCostCell.Y.ToString();
            uiDateColumnTextBox.Text = dateBeginCell.X.ToString();
            uiDateRowTextBox.Text = dateBeginCell.Y.ToString();
            uiCostColumnTextBox.Text = costBeginCell.X.ToString();
            uiCoastRowTextBox.Text = costBeginCell.Y.ToString();
        }
    }
}