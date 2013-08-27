/*
 * Created by SharpDevelop.
 * User: Виктор
 * Date: 31.05.2013
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TM_2
{
    public partial class ConnectDb : Form
    {
        public const string FileName = "savedata.txt";
        public ConnectDb()
        {
            InitializeComponent();
            LoadDataFromFile();
        }
        
    
        /*Функция для получения списка баз данных на сервере
          * подключается к базе;
          * возвращает список всех баз в переменной bases;*/
        private static List<string> GetDatabaseList(string server, string user, string password)
        {
            var bases = new List<string>();
            var conStringBuilder = new SqlConnectionStringBuilder();
            conStringBuilder.DataSource = server;
            conStringBuilder.UserID = user;
            conStringBuilder.Password = password;
            int connError = 0;
            
            var connection = new SqlConnection(conStringBuilder.ToString());
            try
            {
                connection.Open();
            }
            catch(SqlException ex)
            {
                connError = ex.Number;
                MessageBox.Show(ex.Message, "Error: " + connError.ToString());
            }

            if(connError == 0)
            {
                SqlCommand command = new SqlCommand("sp_databases", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
            
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        bases.Add(reader.GetString(0));
            
                connection.Dispose();
            }
            return bases;
        }
        /*---------------------------------------------------------*/
        
        /*Функция для заполнения comboBox_DB*/
        private void InitComboBoxItems(List<string> items)
            {
                comboBox_DB.Items.Clear();
                foreach(string item in items)
                {
                    comboBox_DB.Items.Add(item);
                }
            }
        /*---------------------------------------------------------*/
        
        /*Заполнение comboBox_DB при нажатии*/
        void comboBox_DBClick(object sender, EventArgs e)
        {
            string Server = textBox_server.Text;
            string User = textBox_user.Text;
            string Passvord = textBox_passvord.Text;
            
            List<string> bases = GetDatabaseList(Server, User, Passvord);
            InitComboBoxItems(bases);
        }
        /*---------------------------------------------------------*/
        
        /*Открытие соединения с базой при нажатии на кнопку ОК*/
        void ConnectToDbButton_Click(object sender, EventArgs e)
        {
            var conStringBuilder = new SqlConnectionStringBuilder();
            conStringBuilder.DataSource = textBox_server.Text;
            conStringBuilder.UserID = textBox_user.Text;
            conStringBuilder.Password = textBox_passvord.Text;
            conStringBuilder.InitialCatalog = comboBox_DB.Text;
            int connError = 0;
            
            if(comboBox_DB.Text == String.Empty)
            {
                MessageBox.Show("Не выбрана база данных", "Error");
            } 
            
            else
            {
                Globals.ConnectionString = conStringBuilder.ToString();
                var connection = new SqlConnection(Globals.ConnectionString);

            try
            {
                connection.Open();
            }
            catch(SqlException ex)
            {
                connError = ex.Number;
                MessageBox.Show(ex.Message, "Error: " + connError.ToString());
            }
            
                if(connError == 0)
                {
                    connection.Dispose();
                    SaveDataToFile();
                    this.Dispose();
                }
            }
        }
        /*---------------------------------------------------------*/

        /*Отмена*/
        void Cancel_connectDB_buttonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*---------------------------------------------------------*/

        /*Функция для сохранения введенных данных в txt файл*/
        private void SaveDataToFile()
        {
            var writer = new StreamWriter(FileName, false, Encoding.GetEncoding("windows-1251"));
            writer.WriteLine(textBox_server.Text);
            writer.WriteLine(textBox_user.Text);
            writer.WriteLine(comboBox_DB.SelectedItem);
            writer.Dispose();
        }
        /*---------------------------------------------------------*/

        /*Функция для чтения сохраненных данных из txt файла*/
        private void LoadDataFromFile()
        {
            var reader = new StreamReader(FileName, Encoding.GetEncoding("windows-1251"));
            textBox_server.AppendText(reader.ReadLine());
            textBox_user.AppendText(reader.ReadLine());
            comboBox_DB.Items.Add(reader.ReadLine());
            comboBox_DB.SelectedIndex = 0;
            reader.Dispose();
        }
        /*---------------------------------------------------------*/	
    }
}
