using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TM_2
{
    public partial class ImportHourPowerForm : Form
    {
        DataTable resultTable;
        SqlDataAdapter dbAdapter;
        Point DateBeginCell;
        Point HourBeginCell;

        public ImportHourPowerForm()
        {
            InitializeComponent();
            InitializeBeginAdres();
        }


        void OpenXLSButtonClick(object sender, EventArgs e)
        {
            var openXLSDialog = new OpenFileDialog
                                               {
                                                   Filter = "XLS files (*.xls)|*.xls*|All files (*.*)|*.*",
                                                   FilterIndex = 1,
                                                   RestoreDirectory = true
                                               };

            if (openXLSDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    OpenFileStringBox.Text = openXLSDialog.FileName;
                    ReadXlsData(openXLSDialog.FileName);
                    uiDateColumnTextBox.ReadOnly = false;
                    uiDateRowTextBox.ReadOnly = false;
                    uiHourColumnTextBox.ReadOnly = false;
                    uiHourRowTextBox.ReadOnly = false;
                    uiLoadToDataBaseButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
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
                                                             new object[] { null, null, null, "TABLE" });
            var scheet1 = (string)schemaTable.Rows[0].ItemArray[2];
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
        
        
        void uiLoadToDataBaseButton_Click(object sender, EventArgs e)
        {
            DateBeginCell.X = Convert.ToInt16(uiDateColumnTextBox.Text);
            DateBeginCell.Y = Convert.ToInt16(uiDateRowTextBox.Text);
            HourBeginCell.X = Convert.ToInt16(uiHourColumnTextBox.Text);
            HourBeginCell.Y = Convert.ToInt16(uiHourRowTextBox.Text);
            using (var sqlProvider = Globals.GetSqlProvider())
            {
                int i = DateBeginCell.Y;
                while ((uiMainDataGridView.Rows.Count > i) &&
                       uiMainDataGridView.Rows[i].Cells[DateBeginCell.X].Value.ToString().Equals("") != true)
                {

                    DateTime date = Convert.ToDateTime(uiMainDataGridView.Rows[i].Cells[DateBeginCell.X].Value);
                    int hour = Convert.ToInt32(uiMainDataGridView.Rows[i].Cells[HourBeginCell.X].Value);
                    sqlProvider.AddCommand(@"IF EXISTS(SELECT Date FROM [CalcEnergy].[PowerHour] WHERE Date = @Date)
                                                BEGIN
                                                    UPDATE [CalcEnergy].[PowerHour] SET Hour = @Hour
                                                    WHERE Date = @Date
                                                END
                                            ELSE
                                                BEGIN
                                                    INSERT INTO [CalcEnergy].[PowerHour] (Date, Hour) VALUES (@Date, @Hour)
                                                END");
                    sqlProvider.SetParameter("@Date", date);
                    sqlProvider.SetParameter("@Hour", hour);
                    i++;
                }
                try
                {
                    sqlProvider.Commit();
                    MessageBox.Show("Изменения в базе данных выполнены", "Уведомление о результатах");
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Уведомление о результатах");
                }
            }
        }
        
        void InitializeBeginAdres()
        {
            DateBeginCell = new Point(0, 8);
            HourBeginCell = new Point(1, 8);
            
            uiDateColumnTextBox.Text = DateBeginCell.X.ToString();
            uiDateRowTextBox.Text = DateBeginCell.Y.ToString();
            uiHourColumnTextBox.Text = HourBeginCell.X.ToString();
            uiHourRowTextBox.Text = HourBeginCell.Y.ToString();
        }
    }
}
