using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

namespace TM_2
{
    public partial class MainForm : Form
    {
        private DataTable resultTable;
        private double resultEnergiCoast = 0;
        private double resultPowerCoast = 0;
        private double resultEnergi = 0;
        private double resultCoast = 0;
        private string NameObjekt = null;
        private string Period = null;

        public MainForm()
        {
            var connectForm = new ConnectDbForm();
            connectForm.ShowDialog();

            InitializeComponent();

            resultTable = new DataTable("RESULTAT");
            resultTable.Columns.Add("MeasureDate", typeof (DateTime));
            resultTable.Columns.Add("Energi", typeof (double));
            resultTable.Columns.Add("Tarif", typeof (double));
            resultTable.Columns.Add("Summa", typeof (double));

            treeView_Init();
            Inizialize_ComboBox();
        }

        /*Функция для заполнения списка объектов учета*/

        public void treeView_Init()
        {
            View_Obj_Registration.BeginUpdate();
            View_Obj_Registration.Nodes.Clear();

            Categories_0(View_Obj_Registration);

            Categories_1(View_Obj_Registration);

            View_Obj_Registration.EndUpdate();
        }

        /*---------------------------------------------------------------------------------*/

        /*Функция для заполнения первого уровня списка*/

        private void Categories_0(TreeView Node)
        {

            string cmdText =
                "SELECT ID_Point, NamePoint FROM tbl_Points WHERE (TypePoint=1) AND (ID_Parent=0) AND (ID_Point=2)";

            DataTable table;
            table = RunSqlCmd(cmdText);

            foreach (DataRow row in table.Rows)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = row["NamePoint"].ToString();
                newNode.Name = row["ID_Point"].ToString();

                Node.Nodes.Add(newNode.Text);
            }
        }

        /*---------------------------------------------------------------------------------*/

        /*Функция для заполнения второго уровня списка*/

        private void Categories_1(TreeView Node)
        {
            const string cmdText = "SELECT ID_Point, NamePoint FROM tbl_Points WHERE (TypePoint=3) AND (ID_Parent=2)";
            DataTable table = RunSqlCmd(cmdText);

            foreach (DataRow row in table.Rows)
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = row["NamePoint"].ToString();
                newNode.Name = row["ID_Point"].ToString();

                Node.Nodes[0].Nodes.Add(newNode.Text);

            }
        }

        /*---------------------------------------------------------------------------------*/

        /*Функция для получения результатов запроса из базы*/

        private DataTable RunSqlCmd(string cmdText)
        {
            SqlCommand command = new SqlCommand(cmdText);
            SqlConnection DBconnection = new SqlConnection(Program.connectionString);
            SqlDataAdapter dbAdapter = new SqlDataAdapter();
            dbAdapter.SelectCommand = command;
            command.Connection = DBconnection;

            DataSet resultsDataSet = new DataSet();
            try
            {
                dbAdapter.Fill(resultsDataSet);
                return resultsDataSet.Tables[0];
            }
            catch
            {
                MessageBox.Show(
                    "Нет объектов в базе или не правильно выбрана база данных. Перезапустите приложение и выберете другую базу данных.");
                Application.Exit();
                DataTable table = new DataTable(null);
                return table;
            }

        }

        /*---------------------------------------------------------------------------------*/

        private void Button_CalcClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Calculate(); Cursor = Cursors.Default;
        }

        private void Calculate()
        {
            NameObjekt = "ПС Правобережная";
            dataGridView.Rows.Clear();
            dataGridView1.Rows.Clear();
            resultTable.Rows.Clear();
            resultEnergi = 0;
            resultEnergiCoast = 0;
            resultPowerCoast = 0;

            string mindate = "01." + Convert.ToString(comboBox_Month.SelectedIndex + 1) + "." +
                             comboBox_Year.SelectedItem;
            string maxdate = "01." + Convert.ToString(comboBox_Month.SelectedIndex + 2) + "." +
                             comboBox_Year.SelectedItem;

            string cmdText = "SET dateformat dmy SELECT MeasureDate, Value FROM Mains WHERE (MeasureDate >= '" + mindate +
                             "' AND MeasureDate <= '" + maxdate + "') AND (ID_Channel = 34)";
            DataTable tableEnergi1 = RunSqlCmd(cmdText);

            cmdText = "SET dateformat dmy SELECT MeasureDate, Value FROM Mains WHERE (MeasureDate >= '" + mindate +
                      "' AND MeasureDate <= '" + maxdate + "') AND (ID_Channel = 70)";
            DataTable tableEnergi2 = RunSqlCmd(cmdText);

            cmdText = "SET dateformat dmy SELECT MeasureDate, Value FROM PriceHour WHERE (MeasureDate >= '" + mindate +
                      "' AND MeasureDate <= '" + maxdate + "')";
            DataTable tableTarif = RunSqlCmd(cmdText);

            cmdText = "SET dateformat dmy SELECT MeasureDate, Hours FROM PowerHour WHERE (MeasureDate >= '" + mindate +
                      "' AND MeasureDate <= '" + maxdate + "')";
            DataTable tablePower = RunSqlCmd(cmdText);

            TestMethodForGritsina(tableEnergi1,tableEnergi2,tablePower,tableTarif);

            int metka = 0;
            int j = 0;
            for (int i = 1; i < tableEnergi1.Rows.Count - 1; i = i + 2)
            {
                resultTable.Rows.Add(null, null, null, null);
                resultTable.Rows[j][0] = tableEnergi1.Rows[i - 1][0];
                resultTable.Rows[j][1] =
                    (Convert.ToDouble(tableEnergi1.Rows[i][1]) + Convert.ToDouble(tableEnergi1.Rows[i + 1][1]) +
                     Convert.ToDouble(tableEnergi2.Rows[i][1]) + Convert.ToDouble(tableEnergi2.Rows[i + 1][1])).ToString
                        ("#.00");
                for (int count = 0; count < tableTarif.Rows.Count; count++)
                {
                    if (resultTable.Rows[j][0].ToString() == tableTarif.Rows[count][0].ToString())
                    {
                        metka = count;
                        break;
                    }
                }
                //resultEnergi = resultEnergi + Convert.ToDouble(resultTable.Rows[j][1]);

                if (tableTarif.Rows.Count > 1)
                {
                    resultTable.Rows[j][2] = Convert.ToDouble(tableTarif.Rows[metka][1]) / 1000;
                    resultTable.Rows[j][3] =
                        (Convert.ToDouble(resultTable.Rows[j][1]) * Convert.ToDouble(resultTable.Rows[j][2])).ToString(
                            "#.00");
                    resultEnergiCoast = resultEnergiCoast + Convert.ToDouble(resultTable.Rows[j][3]);
                }
                j++;
            }


            for (int i = 0; i < resultTable.Rows.Count; i++)
            {
                dataGridView.Rows.Add(resultTable.Rows[i][0], resultTable.Rows[i][1],
                                      resultTable.Rows[i][2], resultTable.Rows[i][3]);
                resultEnergi = resultEnergi + Convert.ToDouble(resultTable.Rows[i][1]);
            }
            //MessageBox.Show(resultEnergi.ToString("#.00"));

            /*Заполнение таблицы расчета стоимости мощности и вывод результатов расчета*/
            if (tablePower.Rows.Count > 1)
            {
                string datepower = null;
                double summa = 0;
                for (int i = 0; i < tablePower.Rows.Count; i++)
                {
                    datepower = tablePower.Rows[i][0].ToString().Replace("0:00:00",
                                                                         (Convert.ToInt16(tablePower.Rows[i][1]) - 1 + 3)
                                                                             .ToString() + ":00:00");
                    for (int count = 0; count < resultTable.Rows.Count; count++)
                    {
                        if (datepower == resultTable.Rows[count][0].ToString())
                        {
                            metka = count;
                            break;
                        }
                    }
                    summa = Convert.ToDouble(resultTable.Rows[metka][1]) * TM_2.Program.PowerCoast / 1000;
                    dataGridView1.Rows.Add(tablePower.Rows[i][0].ToString().Replace("0:00:00", ""),
                                           (Convert.ToInt16(tablePower.Rows[i][1]) + 3).ToString(),
                                           Convert.ToDouble(resultTable.Rows[metka][1]).ToString("#.00"),
                                           summa.ToString("#.00"));
                    resultPowerCoast = resultPowerCoast + summa;
                }
                resultCoast = resultEnergiCoast + resultPowerCoast / tablePower.Rows.Count;
                label10.Text = resultEnergiCoast.ToString("#.00") + " + " +
                               (resultPowerCoast / dataGridView1.Rows.Count).ToString("#.00") + " = " +
                               resultCoast.ToString("#.00");
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }
            /*---------------------------------------------------------------------------------------------------------*/
           
        }

        private void TestMethodForGritsina(DataTable tableEnergi1, DataTable tableEnergi2, DataTable tablePower, DataTable tableTarif)
        {
            WriteAndStartFile("tableEnergi1.txt", tableEnergi1);
            WriteAndStartFile("tableEnergi2.txt", tableEnergi2);
            WriteAndStartFile("tableTarif.txt", tableTarif);
            WriteAndStartFile("table.txt", tablePower);
        }

        private void WriteAndStartFile(string nameTxt, DataTable table)
        {
            var test4 = "";
            foreach (DataRow row in table.Rows)
            {
                test4 += row[0] + " / ";
                test4 += row[1] + Environment.NewLine;
            }

            StreamWriter writer4 = new StreamWriter(nameTxt, false, Encoding.GetEncoding("windows-1251"));
            writer4.WriteLine(test4);
            writer4.Dispose();
            Process.Start(nameTxt);
        }

        private void Button_Enrgy_HoursClick(object sender, EventArgs e)
        {
            LoadHourDialog dialog = new LoadHourDialog(this);
            dialog.ShowDialog();
        }

        private void Button_Price_HoursClick(object sender, EventArgs e)
        {
            Form2 dialog = new Form2(this);
            dialog.Show();
        }

        private void Inizialize_ComboBox()
        {
            int maxyear = System.DateTime.Now.Year;
            int minyear = maxyear - 10;

            int i = minyear;
            while (i <= maxyear)
            {
                comboBox_Year.Items.Add(i);
                i++;
            }
            comboBox_Year.SelectedIndex = maxyear - minyear;
            comboBox_Month.SelectedIndex = System.DateTime.Now.Month - 2;
        }


        private void Button_Word_SaveClick(object sender, EventArgs e)
        {

        }


        private void View_Obj_RegistrationAfterSelect(object sender, TreeViewEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridView.Rows.Clear();
            dataGridView1.Rows.Clear();
            resultTable.Rows.Clear();
            resultEnergi = 0;
            resultEnergiCoast = 0;
            resultPowerCoast = 0;

            string mindate = "01." + Convert.ToString(comboBox_Month.SelectedIndex + 1) + "." +
                             comboBox_Year.SelectedItem;
            string maxdate = "01." + Convert.ToString(comboBox_Month.SelectedIndex + 2) + "." +
                             comboBox_Year.SelectedItem;

            string cmdText = null;

            if (View_Obj_Registration.SelectedNode.Text == "Фидер №725")
            {
                NameObjekt = "Фидер №725";
                cmdText = "SET dateformat dmy SELECT MeasureDate, Value FROM Mains WHERE (MeasureDate >= '" + mindate +
                          "' AND MeasureDate <= '" + maxdate + "') AND (ID_Channel = 34)";
            }
            else
            {
                if (View_Obj_Registration.SelectedNode.Text == "Фидер №728")
                {
                    NameObjekt = "Фидер №728";
                    cmdText = "SET dateformat dmy SELECT MeasureDate, Value FROM Mains WHERE (MeasureDate >= '" +
                              mindate + "' AND MeasureDate <= '" + maxdate + "') AND (ID_Channel = 70)";
                }
                else
                {
                    if (View_Obj_Registration.SelectedNode.Text == "ПС Правобережная")
                    {
                        Button_CalcClick(this, null);
                        goto a;
                    }
                }
            }
            DataTable tableEnergi;
            tableEnergi = RunSqlCmd(cmdText);

            cmdText = "SET dateformat dmy SELECT MeasureDate, Value FROM PriceHour WHERE (MeasureDate >= '" + mindate +
                      "' AND MeasureDate <= '" + maxdate + "')";
            DataTable tableTarif;
            tableTarif = RunSqlCmd(cmdText);

            cmdText = "SET dateformat dmy SELECT MeasureDate, Hours FROM PowerHour WHERE (MeasureDate >= '" + mindate +
                      "' AND MeasureDate <= '" + maxdate + "')";
            DataTable tablePower;
            tablePower = RunSqlCmd(cmdText);

            int metka = 0;
            int j = 0;
            for (int i = 1; i < tableEnergi.Rows.Count - 1; i = i + 2)
            {
                resultTable.Rows.Add(null, null, null, null);
                resultTable.Rows[j][0] = tableEnergi.Rows[i - 1][0];
                resultTable.Rows[j][1] =
                    (Convert.ToDouble(tableEnergi.Rows[i][1]) + Convert.ToDouble(tableEnergi.Rows[i + 1][1])).ToString(
                        "#.00");
                for (int count = 0; count < tableTarif.Rows.Count; count++)
                {
                    if (resultTable.Rows[j][0].ToString() == tableTarif.Rows[count][0].ToString())
                    {
                        metka = count;
                        break;
                    }
                }
                resultEnergi = resultEnergi + Convert.ToDouble(resultTable.Rows[j][1]);
                    //Сумма потребленной энергии кВт/ч.

                if (tableTarif.Rows.Count > 1)
                {
                    resultTable.Rows[j][2] = Convert.ToDouble(tableTarif.Rows[metka][1])/1000;
                    resultTable.Rows[j][3] =
                        (Convert.ToDouble(resultTable.Rows[j][1])*Convert.ToDouble(resultTable.Rows[j][2])).ToString(
                            "#.00");
                    resultEnergiCoast = resultEnergiCoast + Convert.ToDouble(resultTable.Rows[j][3]);
                }
                j++;
            }


            for (int i = 0; i < resultTable.Rows.Count; i++)
            {
                dataGridView.Rows.Add(resultTable.Rows[i][0], resultTable.Rows[i][1],
                                      resultTable.Rows[i][2], resultTable.Rows[i][3]);
            }
            //MessageBox.Show(resultEnergi.ToString("#.00"), "Потребленная энергия кВт/ч");

            /*Заполнение таблицы расчета стоимости мощности и вывод результатов расчета*/
            if (tablePower.Rows.Count > 1)
            {
                string datepower = null;
                double summa = 0;
                for (int i = 0; i < tablePower.Rows.Count; i++)
                {
                    datepower = tablePower.Rows[i][0].ToString().Replace("0:00:00",
                                                                         (Convert.ToInt16(tablePower.Rows[i][1]) - 1 + 3)
                                                                             .ToString() + ":00:00");
                    for (int count = 0; count < resultTable.Rows.Count; count++)
                    {
                        if (datepower == resultTable.Rows[count][0].ToString())
                        {
                            metka = count;
                            break;
                        }
                    }
                    summa = Convert.ToDouble(resultTable.Rows[metka][1])*TM_2.Program.PowerCoast/1000;
                    dataGridView1.Rows.Add(tablePower.Rows[i][0].ToString().Replace("0:00:00", ""),
                                           (Convert.ToInt16(tablePower.Rows[i][1]) + 3).ToString(),
                                           Convert.ToDouble(resultTable.Rows[metka][1]).ToString("#.00"),
                                           summa.ToString("#.00"));
                    resultPowerCoast = resultPowerCoast + summa;
                }
                resultCoast = resultEnergiCoast + resultPowerCoast/tablePower.Rows.Count;
                label10.Text = resultEnergiCoast.ToString("#.00") + " + " +
                               (resultPowerCoast/dataGridView1.Rows.Count).ToString("#.00") + " = " +
                               resultCoast.ToString("#.00");
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }
            /*---------------------------------------------------------------------------------------------------------*/
            Cursor = Cursors.Default;
            a: // what is it? :c
            ;
        }

        private void writeXLSdata(string filename)
        {
            //string filename = "C:\\ItogData.xls";
            OleDbConnection xlsConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename +
                                                          ";Extended Properties=\"Excel 8.0\"");
            xlsConn.Open();
            OleDbCommand xlsCmd = new OleDbCommand();
            xlsCmd.Connection = xlsConn;
            xlsCmd.CommandText = "INSERT INTO MyTable VALUES ('" + NameObjekt + "', '" + Period + "', '" +
                                 resultEnergi.ToString("#.00") + "', '"
                                 + resultCoast.ToString("#.00") + "', '" + (resultCoast*0.18).ToString("#.00") + "', '" +
                                 (resultCoast*1.18).ToString("#.00") + "')";
            xlsCmd.ExecuteNonQuery();

            xlsConn.Close();
        }

        private void Button_Excel_SaveClick(object sender, EventArgs e)
        {
            var saveXLSdialog = new SaveFileDialog
                                    {
                                        InitialDirectory = "C:\\",
                                        Filter = "XLS files (*.xls)|*.xls*|All files (*.*)|*.*",
                                        FilterIndex = 1,
                                        RestoreDirectory = true,
                                        DefaultExt = "xls",
                                        AddExtension = true
                                    };

            if (saveXLSdialog.ShowDialog() == DialogResult.OK)
            {
                Period = "01." + Convert.ToString(comboBox_Month.SelectedIndex + 1) + "." +
                         comboBox_Year.SelectedItem +
                         " - " +
                         System.DateTime.DaysInMonth(Convert.ToInt16(comboBox_Year.SelectedItem),
                                                     (comboBox_Month.SelectedIndex + 1)) +
                         "." + Convert.ToString(comboBox_Month.SelectedIndex + 1) + "." +
                         comboBox_Year.SelectedItem;

                string path1 = "ItogData.xls";
                string path2 = saveXLSdialog.FileName;
                File.Copy(path1, path2, true);

                writeXLSdata(path2);
            }
        }
    }
}
