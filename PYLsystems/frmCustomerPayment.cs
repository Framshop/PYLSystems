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

namespace PYLsystems
{
    public partial class frmCustomerPayment : Form
    {
        public static string customerPayment = "";
        public static string jobOrderNumber = "";
        public static string totalAmount = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmCustomerPayment()
        {
            InitializeComponent();
        }

            private void frmCustomerPayment_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            myConn.Close();
            myConn.Open();
            string query = "SELECT j.jOrd_Num,j.jobOrderDate,j.totalAmount,c_p.customer_payment FROM joborder j LEFT JOIN customer_payment c_p ON j.jOrd_Num = c_p.jOrd_Num LEFT JOIN customer_account c_a ON c_a.customerID = c_p.customerID WHERE c_a.customerID =" + lblCustomerID.Text +  " AND j.totalAmount != c_p.customer_payment";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvJobOrder.DataSource = dt;
            dgvJobOrder.Columns["jOrd_Num"].HeaderText = "Job Order Number";
            dgvJobOrder.Columns["totalamount"].HeaderText = "Total Amount Order";
            dgvJobOrder.Columns["joborderdate"].HeaderText = "Job Order Date";
            dgvJobOrder.Columns["customer_payment"].HeaderText = "Total Amount Paid";
            myConn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvJobOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddPayment.Enabled = true;
            jobOrderNumber = dgvJobOrder.CurrentRow.Cells[0].Value.ToString();
            totalAmount = dgvJobOrder.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "UPDATE customer_payment c_p LEFT JOIN joborder j ON j.jOrd_Num =  c_p.jOrd_Num SET customer_payment =" + totalAmount + ", j.voidreason = 'Done Transaction' WHERE c_p.customerID ='" + lblCustomerID.Text + " ' AND c_p.jOrd_Num =" + jobOrderNumber;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
        }
    }
}
