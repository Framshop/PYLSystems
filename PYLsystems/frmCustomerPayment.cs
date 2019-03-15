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
        public static string totalAmount = "";
        public static string jobOrderNumber = "";
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
            string query = "SELECT c_p.jOrd_Num as 'Job Order Number',j.jobOrderDate as 'Job Order Date',c_p.customer_payment as 'Customer Payment',j.totalAmount as 'Total Amount' FROM customer_payment c_p LEFT JOIN joborder j ON j.jOrd_Num = c_p.jOrd_Num LEFT JOIN customer_account c_a ON c_a.customerID = c_p.customerID WHERE customer_payment != totalAmount AND c_p.customerID = " + lblCustomerID.Text;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvJobOrder.DataSource = dt;
            myConn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "UPDATE customer_payment SET customer_payment =" + totalAmount + " WHERE jOrd_Num = " + jobOrderNumber;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();


            myConn.Open();
            string myQuer = "UPDATE joborder SET voidReason = 'Done Transaction' WHERE jOrd_Num = " + jobOrderNumber;
            MySqlCommand myCom = new MySqlCommand(myQuer, myConn);
            MySqlDataAdapter myAd = new MySqlDataAdapter(myCom);
            DataTable myD = new DataTable();
            myAd.Fill(myD);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
            btnAddPayment.Enabled = false; 
        }

        private void dgvJobOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddPayment.Enabled = true;
            totalAmount = dgvJobOrder.CurrentRow.Cells[3].Value.ToString();
            jobOrderNumber = dgvJobOrder.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
