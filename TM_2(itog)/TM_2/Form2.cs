/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 17.06.2013
 * Time: 6:06
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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace TM_2
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		MainForm mainForm;
		DataTable resultTable;
		SqlDataAdapter dbAdapter;
		Point DateBeginCell;
		Point CoastBeginCell;
		public Form2(MainForm mainForm)
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
			SqlConnection connection = new SqlConnection(TM_2.Program.connectionString);
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
						textBox_CoastColumn.ReadOnly = false;
						textBox_CoastRow.ReadOnly = false;
						OKButton.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
				
				//PdfReader pdfread = new PdfReader(openXLSDialog.OpenFile());
				//string text = null;
				//ITextExtractionStrategy strategy;
				
				//text = PdfTextExtractor.GetTextFromPage(pdfread,2)+PdfTextExtractor.GetTextFromPage(pdfread,3);
				//SaveData_to_txt(text);
				
				//PdfPTable sss = new PdfPTable();
				
				//MessageBox.Show("Готово");
				//dataGridView1.DataSource  = text;
				
			}
		}
		/*
		private void SaveData_to_txt(string text)
		{
			StreamWriter writer = new StreamWriter("savedatapdf.txt", false, Encoding.GetEncoding("windows-1251"));
			writer.WriteLine(text);
			writer.Dispose();
		}*/
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void readXLSdata(string filename)
		{
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

		}

	
		void OKButtonClick(object sender, EventArgs e)
		{   
			DataBaseWork("DELETE FROM PriceHour");
			DataBaseWork("SET dateformat dmy SELECT * FROM PriceHour");
			DateBeginCell.X = Convert.ToInt16(textBox_DateColumn.Text);
			DateBeginCell.Y = Convert.ToInt16(textBox_DateRow.Text);
			CoastBeginCell.X = Convert.ToInt16(textBox_CoastColumn.Text);
			CoastBeginCell.Y = Convert.ToInt16(textBox_CoastRow.Text);
			
			int i = DateBeginCell.Y;
			string measuredate = null;
			while((dataGridView1.Rows.Count > i) && dataGridView1.Rows[i].Cells[DateBeginCell.X].Value.ToString().Equals("") != true && dataGridView1.Rows[i].Cells[CoastBeginCell.X].Value.ToString().Equals("") != true)
			{
				measuredate = dataGridView1.Rows[i].Cells[DateBeginCell.X].Value.ToString() + " " + dataGridView1.Rows[i].Cells[DateBeginCell.X + 1].Value.ToString() + ":00:00.0000";
				resultTable.Rows.Add(measuredate, Convert.ToDouble(dataGridView1.Rows[i].Cells[CoastBeginCell.X].Value.ToString().Replace(",",".")));
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
			DateBeginCell = new Point(0, 41);
			CoastBeginCell = new Point(5, 41);
			
			textBox_DateColumn.Text = DateBeginCell.X.ToString();
			textBox_DateRow.Text = DateBeginCell.Y.ToString();
			textBox_CoastColumn.Text = CoastBeginCell.X.ToString();
			textBox_CoastRow.Text = CoastBeginCell.Y.ToString();
			
		}
		
		
		
	}
}
