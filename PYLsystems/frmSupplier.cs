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
    public partial class frmSupplier : Form
    {
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // ADD Supplier
            myConn.Open();
            string myQuery = "INSERT INTO supplier (supplierName, supplierDetails, contactDetails) values('" + txtName.Text + "','" + txtDetails.Text + "','" + txtContact.Text + "')";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Insert Successful!");
            RefreshDatabase();
            txtDetails.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supplierID,supplierName,supplierDetails,contactDetails FROM supplier";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            supplierGrid.DataSource = Dt;
            myConn.Close();
            supplierGrid.Columns["supplierID"].Visible = false;
            supplierGrid.Columns["supplierID"].HeaderText = "ID";
            supplierGrid.Columns["supplierName"].HeaderText = "Name";
            supplierGrid.Columns["supplierDetails"].HeaderText = "Details";
            supplierGrid.Columns["contactDetails"].HeaderText = "Contact";
            supplierGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void supplierGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            //SHOW Supplier List
            RefreshDatabase();
        }

        private void supplierGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNameUpdate.Text = supplierGrid.CurrentRow.Cells[1].Value.ToString();
            lblDetailsUpdate.Text = supplierGrid.CurrentRow.Cells[2].Value.ToString();
            lblContactUpdate.Text = supplierGrid.CurrentRow.Cells[3].Value.ToString();

            txtName.Text = supplierGrid.CurrentRow.Cells[1].Value.ToString();
            txtDetails.Text = supplierGrid.CurrentRow.Cells[2].Value.ToString();
            txtContact.Text = supplierGrid.CurrentRow.Cells[3].Value.ToString();
            
            lblIDUpdate.Text = supplierGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supplierID,supplierName,supplierDetails,contactDetails FROM supplier WHERE supplierName LIKE '%" + txtSearch.Text + "%' OR supplierDetails LIKE '%" + txtSearch.Text + "%' OR contactDetails LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            supplierGrid.DataSource = Dt;
            myConn.Close();
            supplierGrid.Columns["supplierID"].Visible = false;
            supplierGrid.Columns["supplierID"].HeaderText = "ID";
            supplierGrid.Columns["supplierName"].HeaderText = "Name";
            supplierGrid.Columns["supplierDetails"].HeaderText = "Details";
            supplierGrid.Columns["contactDetails"].HeaderText = "Contact";
            supplierGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "UPDATE supplier SET supplierName = '" + txtName.Text + "',supplierDetails =  " +
                "'" + txtDetails.Text + "', contactDetails = '" + txtContact.Text + "'WHERE supplierName = '" + lblNameUpdate.Text + "'AND supplierDetails = '" +
                lblDetailsUpdate.Text + "' AND contactDetails = '" + lblContactUpdate.Text + "'"; 
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
            txtDetails.Text = "";
            txtName.Text = "";
            txtContact.Text = "";

        }
    }
}
