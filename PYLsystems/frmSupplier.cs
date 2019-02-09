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
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // ADD Supplier
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supplier WHERE supplierName = '" + txtName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count == 0)
            {
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
            else
            {
                lblValidate.Text = "Supplier Name already exists!";
            }
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
            lblSupplierID.Text = supplierGrid.CurrentRow.Cells[0].Value.ToString();
            lblNameUpdate.Text = supplierGrid.CurrentRow.Cells[1].Value.ToString();
            lblDetailsUpdate.Text = supplierGrid.CurrentRow.Cells[2].Value.ToString();
            lblContactUpdate.Text = supplierGrid.CurrentRow.Cells[3].Value.ToString();
            txtName.Text = supplierGrid.CurrentRow.Cells[1].Value.ToString();
            txtDetails.Text = supplierGrid.CurrentRow.Cells[2].Value.ToString();
            msktxtContactNumber.Text = supplierGrid.CurrentRow.Cells[3].Value.ToString();
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
            msktxtContactNumber.Text = "";
            btnUpdate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionAdd()
        {
            int name = txtName.TextLength;
            int details = txtDetails.TextLength;
            int contactnumber = txtContact.TextLength;
            if (name > 0 && details > 0 && contactnumber==11)
            {
                addBtn.Enabled = true;
            }
            else
            {
                addBtn.Enabled = false;
            }
        }
        public void functionUpdate()
        {
            if (lblSupplierID.Text != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void msktxtContactNumber_TextChanged(object sender, EventArgs e)
        {
            txtContact.Text = msktxtContactNumber.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtDetails_TextAlignChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }
    }
}
