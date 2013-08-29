/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 29.05.2013
 * Time: 15:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management.Instrumentation;
using System.Linq;
using System.Media;
using System.Collections.Generic;
using System.Windows;

namespace TM_2
{
    /// <summary>
    /// Description of Form1.
    /// </summary>
    public partial class LoadHourDialog : Form
    {
        MainForm mainForm;
        DataTable resultTable;
        SqlDataAdapter dbAdapter;
        Point DateBeginCell;
        Point HourBeginCell;
        
        public LoadHourDialog(MainForm mainForm)
        {
            this.mainForm = mainForm;
            
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            InitializeBeginAdres();
        }
        
        void DataBaseWork(string sql)
        {
            resultTable = new DataTable();
            SqlConnection connection = new SqlConnection(TM_2.Program.ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            dbAdapter = new SqlDataAdapter(command);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(resultTable);
            connection.Close();
        }
        
        void OpenXLSButtonClick(object sender, EventArgs e)
        {
            Stream openStream = null;
            OpenFileDialog openXLSDialog = new OpenFileDialog();
            
            openXLSDialog.InitialDirectory = "C:\\";
            openXLSDialog.Filter = "XLS files (*.xls)|*.xls*|All files (*.*)|*.*";
            openXLSDialog.FilterIndex = 1;
            openXLSDialog.RestoreDirectory = true;
            
            if (openXLSDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openStream = openXLSDialog.OpenFile()) != null)
                    {
                        OpenFileStringBox.Text = openXLSDialog.FileName;
                        readXLSdata(openXLSDialog.FileName);
                        
                        textBox_DateColumn.ReadOnly = false;
                        textBox_DateRow.ReadOnly = false;
                        textBox_HourColumn.ReadOnly = false;
                        textBox_HourRow.ReadOnly = false;
                        OKButton.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        
        void CancelButtonClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        void readXLSdata(string filename)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            string connString = String.Format ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename +
            ";Extended Properties=\"Excel 8.0;HDR=No;IMEX=1\"");
            DataSet data = new DataSet("EXCEL");
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                                             new object[] {null, null, null, "TABLE"});
            string scheet1 = (string) schemaTable.Rows[0].ItemArray[2];
            string select = String.Format("SELECT * FROM [{0}]", scheet1);
            OleDbDataAdapter adapter = new OleDbDataAdapter(select, conn);
            adapter.Fill(data);
            DataTable table = new DataTable();
            table = data.Tables[0];
            dataGridView1.DataSource = table;
            conn.Close();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
            }
            
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Value = i.ToString();
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        
        
        void OKButtonClick(object sender, EventArgs e)
        {
            DataBaseWork("DELETE FROM PowerHour");
            DataBaseWork("SET dateformat dmy SELECT * FROM PowerHour");
            DateBeginCell.X = Convert.ToInt16(textBox_DateColumn.Text);
            DateBeginCell.Y = Convert.ToInt16(textBox_DateRow.Text);
            HourBeginCell.X = Convert.ToInt16(textBox_HourColumn.Text);
            HourBeginCell.Y = Convert.ToInt16(textBox_HourRow.Text);

            int i = DateBeginCell.Y;
            while((dataGridView1.Rows.Count > i) && dataGridView1.Rows[i].Cells[DateBeginCell.X].Value.ToString().Equals("") != true)
            {
                resultTable.Rows.Add(dataGridView1.Rows[i].Cells[DateBeginCell.X].Value, dataGridView1.Rows[i].Cells[HourBeginCell.X].Value);
                i++;
            }
            try
            {
                dbAdapter.Update(resultTable);
                MessageBox.Show("Изменения в базе данных выполнены", "Уведомление о результатах");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Применить изменения не удалось. Проверьте соединение с базой данных", "Уведомление о результатах");
            }
        }
        
        void InitializeBeginAdres()
        {
            DateBeginCell = new Point(0, 8);
            HourBeginCell = new Point(1, 8);
            
            textBox_DateColumn.Text = DateBeginCell.X.ToString();
            textBox_DateRow.Text = DateBeginCell.Y.ToString();
            textBox_HourColumn.Text = HourBeginCell.X.ToString();
            textBox_HourRow.Text = HourBeginCell.Y.ToString();
            
        }
        
    
    }
}
