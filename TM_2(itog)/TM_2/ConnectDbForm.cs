using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TM_2
{
    public partial class ConnectDbForm : Form
    {
        public ConnectDbForm()
        {
            InitializeComponent();

            LoadData_from_txt();
        }

        private static List<string> GetDatabaseList(string Server, string User, string Passvord)
        {
            List<string> bases = new List<string>();

            SqlConnectionStringBuilder conStringBuilder = new SqlConnectionStringBuilder();
            conStringBuilder.DataSource = Server;
            conStringBuilder.UserID = User;
            conStringBuilder.Password = Passvord;
            int connError = 0;

            SqlConnection connection = new SqlConnection(conStringBuilder.ToString());
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                connError = ex.Number;
                MessageBox.Show(ex.Message, "Error: " + connError.ToString());
            }

            if (connError == 0)
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
            foreach (string item in items)
            {
                comboBox_DB.Items.Add(item);
            }
        }

        /*---------------------------------------------------------*/

        /*Заполнение comboBox_DB при нажатии*/

        private void comboBox_DBClick(object sender, EventArgs e)
        {
            string Server = textBox_server.Text;
            string User = textBox_user.Text;
            string Passvord = textBox_passvord.Text;

            List<string> bases = GetDatabaseList(Server, User, Passvord);
            InitComboBoxItems(bases);
        }

        /*---------------------------------------------------------*/

        /*Открытие соединения с базой при нажатии на кнопку ОК*/

        private void Connect_to_DB_buttonClick(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            SqlConnectionStringBuilder conStringBuilder = new SqlConnectionStringBuilder();
            conStringBuilder.DataSource = textBox_server.Text;
            conStringBuilder.UserID = textBox_user.Text;
            conStringBuilder.Password = textBox_passvord.Text;
            conStringBuilder.InitialCatalog = comboBox_DB.Text;
            int connError = 0;

            if (comboBox_DB.Text == String.Empty)
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
                catch (SqlException ex)
                {
                    connError = ex.Number;
                    MessageBox.Show(ex.Message, "Error: " + connError.ToString());
                }

                if (connError == 0)
                {
                    connection.Dispose();
                    SaveData_to_txt();
                    var calculateForm = new CalculateForm();
                    Hide();
                	calculateForm.ShowDialog();
                	Close();
                }
            }
        }

        /*---------------------------------------------------------*/

        /*Отмена*/

        private void Cancel_connectDB_buttonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*---------------------------------------------------------*/

        /*Функция для сохранения введенных данных в txt файл*/

        private void SaveData_to_txt()
        {
            StreamWriter writer = new StreamWriter("savedata.txt", false, Encoding.GetEncoding("windows-1251"));
            writer.WriteLine(textBox_server.Text);
            writer.WriteLine(textBox_user.Text);
            writer.WriteLine(comboBox_DB.SelectedItem);
            writer.Dispose();
        }

        /*---------------------------------------------------------*/

        /*Функция для чтения сохраненных данных из txt файла*/

        private void LoadData_from_txt()
        {
            StreamReader reader = new StreamReader("savedata.txt", Encoding.GetEncoding("windows-1251"));
            textBox_server.AppendText(reader.ReadLine());
            textBox_user.AppendText(reader.ReadLine());
            comboBox_DB.Items.Add(reader.ReadLine());
            comboBox_DB.SelectedIndex = 0;
            reader.Dispose();
        }

        /*---------------------------------------------------------*/

        private void textBox_passvord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connect();
            }
        }
    }
}
