using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practika
{
    public partial class OperatorForm : Form
    {
        public OperatorForm()
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

        private void AbonentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SD.DataTable dt = new SD.DataTable();
                int rowIndex = e.RowIndex;
                DataGridViewRow row = AbonentDataGridView.Rows[rowIndex];

                string User_FIO = row.Cells["ФИО"].Value.ToString();
                string Personal_Account = row.Cells["Лицевой_счёт"].Value.ToString();

                openConnection();
                string commandString = $"select User_Login from Contract_Data where User_FIO ='{User_FIO}' and Personal_Account='{Personal_Account}'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);

                string Login = Convert.ToString(dt.Rows[0][0]);

                ContractDataForm contractDataForm = new ContractDataForm(Login);
                contractDataForm.Show();

                closeConnection();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT User_FIO as ФИО, Contract_Number as Номер_абонента ,Personal_Account as Лицевой_счёт, Services as Услуги FROM Contract_Data", sqlConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            AbonentDataGridView.DataSource = db.Tables[0];

            closeConnection();
        }
    }
}
