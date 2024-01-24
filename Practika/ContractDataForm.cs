using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD= System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Practika
{
    public partial class ContractDataForm : Form
    {
        string Login;
        public ContractDataForm(string Login)
        {
            InitializeComponent();
            this.Login = Login;
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

        private void ContractDataForm_Load(object sender, EventArgs e)
        {
            openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Applications_for_the_operator where Abonent_login = '{Login}'", sqlConnection);

            DataSet db = new DataSet();

            dataAdapter.Fill(db);

            dataGridView1.DataSource = db.Tables[0];

            closeConnection();
        }
    }
}
