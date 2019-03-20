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
    public partial class frmArchiveSupplier : Form
    {

        public static string supplerID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmArchiveSupplier()
        {
            InitializeComponent();
        }

        private void frmArchiveSupplier_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supplierID as 'Supplier ID',supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details',address as 'Address' FROM supplier where active = 1";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgArchiveSupplier.DataSource = dt;
            myConn.Close();
            dgArchiveSupplier.Columns["Supplier ID"].Visible = false;


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string myQuery = "update supplier set active = 0 where supplierID = " + supplierID.Text ;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Success");
            RefreshDatabase();
            btnReturn.Enabled = false;
        }

        private void dgArchiveSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierID.Text = dgArchiveSupplier.CurrentRow.Cells[0].Value.ToString();
            btnReturn.Enabled = true;
        }


        public void validate()
        {
            if (supplierID.Text != "")
            { btnReturn.Enabled = true; }
            else
            {
                btnReturn.Enabled = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supplierID as 'Supplier ID',supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details',address as 'Address' FROM supplier WHERE supplierName LIKE  '%" + txtSearch.Text + "%' AND active = 1";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgArchiveSupplier.DataSource = dt;
            myConn.Close();
            dgArchiveSupplier.Columns["Supplier ID"].Visible = false;
          
        }
    }
}
