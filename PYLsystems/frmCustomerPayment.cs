using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;

namespace PYLsystems
{
    public partial class frmCustomerPayment : Form
    {
        public static string balance = "";
        public static string customerPayment = "";
        public static string customerID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmCustomerPayment()
        {
            InitializeComponent();
            fillCustomerName();
        }
        private void fillCustomerName()
        {
            string myQuery = "SELECT * FROM customer_account WHERE customerID =" + customerID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string customerList = myReader.GetString(1);
                    txtCustomerName.Text = customerList;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void frmCustomerPayment_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT j.jOrd_Num,c_a.customerFullname,CONCAT(e.lastname,' ',e.firstname) as 'Name',j.totalamount, IF(j.paymenttype=0,'Cash','Credit Card') as 'PaymentType',j.joborderdate,IFNULL(j.voidreason,'On-Going') as 'voidreason' FROM jobOrder j LEFT JOIN customer_account c_a ON c_a.customerID = j.customerID LEFT JOIN jOrder_details j_d ON j_d.jOrd_Num = j.jOrd_Num LEFT JOIN employee e ON e.employeeID = j.employeeID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvJobOrder.DataSource = dt;
            dgvJobOrder.Columns["jOrd_Num"].HeaderText = "Job Order Number";
            dgvJobOrder.Columns["customerFullname"].HeaderText = "Custmer Name";
            dgvJobOrder.Columns["Name"].HeaderText = "Employee Name";
            dgvJobOrder.Columns["totalamount"].HeaderText = "Total Amount";
            dgvJobOrder.Columns["paymenttype"].HeaderText = "Payment Type";
            dgvJobOrder.Columns["joborderdate"].HeaderText = "Job Order Date";
            dgvJobOrder.Columns["voidreason"].HeaderText = "Transaction Type";
            myConn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
