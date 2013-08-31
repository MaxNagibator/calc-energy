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
                    uiLoadToDataBaseButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
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

            using (var sqlProvider = Globals.GetSqlProvider())
            {
                while ((uiMainDataGridView.Rows.Count > rowIndex) &&
                       uiMainDataGridView.Rows[rowIndex].Cells[dateColumn].Value.ToString().Equals("") != true &&
                       uiMainDataGridView.Rows[rowIndex].Cells[costColumn].Value.ToString().Equals("") != true)
                {
                    DateTime date = GetDateFromGridView(rowIndex, dateColumn, hourColumn);
                    var cost = GetCostFromGridView(rowIndex, costColumn); 
                    sqlProvider.AddCommand(@"IF EXISTS(SELECT Date FROM [CalcEnergy].[HourPrice] WHERE Date = @Date)
                                                BEGIN
                                                    UPDATE [CalcEnergy].[HourPrice] SET Cost = @Cost
                                                    WHERE Date = @Date
                                                END
                                            ELSE
                                                BEGIN
                                                    INSERT INTO [CalcEnergy].[HourPrice] (Date, Cost) VALUES (@Date, @Cost)
                                                END");
                    sqlProvider.SetParameter("@Date", date);
                    sqlProvider.SetParameter("@Cost", cost);
                    rowIndex++;
                }
                try
                {
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

        private DateTime GetDateFromGridView(int rowIndex, int dateColumn, int hourColumn)
        {
            return Convert.ToDateTime(uiMainDataGridView.Rows[rowIndex].Cells[dateColumn].Value + " " +
                                      uiMainDataGridView.Rows[rowIndex].Cells[hourColumn].Value + ":00:00.0000");
        }

        private Double GetCostFromGridView(int rowIndex, int costColumn)
        {
            return Convert.ToDouble(
                uiMainDataGridView.Rows[rowIndex].Cells[costColumn].Value.ToString().Replace(".", ","));
        }

        private void InitializeBeginPosition()
        {
            var dateBeginCell = new Point(0, 41);
            var costBeginCell = new Point(5, 41);
            uiDateColumnTextBox.Text = dateBeginCell.X.ToString();
            uiDateRowTextBox.Text = dateBeginCell.Y.ToString();
            uiCostColumnTextBox.Text = costBeginCell.X.ToString();
            uiCoastRowTextBox.Text = costBeginCell.Y.ToString();
        }
    }
}