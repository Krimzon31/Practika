using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD= System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practika
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=Krimzon; Initial Catalog=TehPod; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            string Login = LoginTextBox.Text.ToString();
            string Password = PasswordTextBox.Text.ToString();
            SD.DataTable dt = new SD.DataTable();
            string PasswordZap = CreateMD5(Password);

            openConnection();
            string commandString = $"select User_Role from Autorization_data where User_Login ='{Login}' and User_Password='{PasswordZap}'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt);
            try
            {
                string role = Convert.ToString(dt.Rows[0][0]);

                if (Proverka(Login, Password) == true)
                {
                    if (role == RoleComboBox.SelectedItem.ToString())
                    {
                        if (role == "Админ")
                        {

                        }
                        else if (role == "Оператор")
                        {
                            MessageBox.Show("авторизация выполнена", ":)");
                            OperatorForm operatorForm = new OperatorForm();
                            operatorForm.Show();
                        }
                        else if (role == "Абонент")
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выбрана неправильная роль", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка");
                }
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private Boolean Proverka(string log, string pass)
        {
            SD.DataTable table = new SD.DataTable();
            string Login_l = log;
            string Password_p = pass;

            Password_p = CreateMD5(Password_p);

            string commandString = $"select User_Login, User_Password from Autorization_data where User_Login='{Login_l}' and User_Password='{Password_p}'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
