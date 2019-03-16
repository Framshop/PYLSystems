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
        public static string supplierID = "";
        public static string supply_categoryID = "";
        public static string address = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supplier WHERE supplyName = '" + txtSupplierName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count == 0)
            {
                string myQuery = "INSERT INTO supplier(suppliername,supplierdetails,contactdetails,address) VALUES('" + txtSupplierName.Text + "','" + txtDetails.Text + "','" + msktxtContactNumber.Text + "','" + txtAddress.Text + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);

                MessageBox.Show("Insert Successful");
                RefreshDatabase();
                txtSupplierName.Text = "";
                txtDetails.Text = "";
                msktxtContactNumber.Text = "";
                txtAddress.Text = "";
                supplierID = "";
            }
            else
            {
                MessageBox.Show("Supplier " + txtSupplierName.Text + " already exist");
            }
        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supplierID as 'Supplier ID',supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details',address as 'Address' FROM supplier";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvSuppliers.DataSource = dt;
            myConn.Close();
            dgvSuppliers.Columns["Supplier ID"].Visible = false;
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

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supplierID as 'Supplier ID',supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details',address as 'Address' FROM supplier WHERE supplierName LIKE  '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvSuppliers.DataSource = dt;
            myConn.Close();
            dgvSuppliers.Columns["Supplier ID"].Visible = false;
            dgvCategories.DataSource = null;
            dgvsupply_Items.DataSource = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string myQuery = "UPDATE supplier SET supplierName = '" + txtSupplierName.Text + "', supplierDetails = '" + txtDetails.Text + "', contactDetails = '" + msktxtContactNumber.Text + "', address = '" + txtAddress.Text + "' WHERE supplierID = " + supplierID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            RefreshDatabase();
            MessageBox.Show("Update Successful");

            RefreshDatabase();
            txtSupplierName.Text = "";
            txtDetails.Text = "";
            msktxtContactNumber.Text = "";
            txtAddress.Text = "";
            supplierID = "";
            dgvCategories.DataSource = null;
            validationUpdateSuppliers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void msktxtContactNumber_TextChanged(object sender, EventArgs e)
        {
            validationAddSuppliers();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validationAddSuppliers();
        }

        private void txtDetails_TextAlignChanged(object sender, EventArgs e)
        {
           
         
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSupplierItems addSupplierCategory = new frmAddSupplierItems();
            addSupplierCategory.ShowDialog();
        }
        public void validationAddSuppliers()
        {
            int supplierName = txtSupplierName.TextLength;
            int supplierDetails = txtDetails.TextLength;
            int contactDetails = msktxtContactNumber.TextLength;
            int address = txtAddress.TextLength;
            if (supplierDetails > 0 && address > 0 && contactDetails == 11 && supplierName > 0)
            {
                btnAddSupplier.Enabled = true;
            }
            else
            {
                btnAddSupplier.Enabled = false;
            }
        }
        public void validationUpdateSuppliers()
        {
            if (supplierID != "")
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            validationAddSuppliers();
        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            validationAddSuppliers();
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCategories.DataSource = null;
            supplierID = dgvSuppliers.CurrentRow.Cells[0].Value.ToString();
            validationUpdateSuppliers();

            txtSupplierName.Text = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();
            txtDetails.Text = dgvSuppliers.CurrentRow.Cells[2].Value.ToString();
            msktxtContactNumber.Text = dgvSuppliers.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvSuppliers.CurrentRow.Cells[4].Value.ToString();

            myConn.Open();
            string query = "SELECT s_c.supply_categoryID as 'Supply Category ID',s_c.categoryName as 'Category Name' FROM supplier_category sr_c LEFT JOIN supply_category s_c ON s_c.supply_categoryID = sr_c.supply_categoryID WHERE sr_c.supplierID = " + supplierID;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvCategories.DataSource = dt;
            myConn.Close();
            dgvCategories.Columns["Supply Category ID"].Visible = false;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            myConn.Open();
            string query = "SELECT s_i.supplyName as 'Supply Name',s_i.supplyDescription as 'Supply Description' FROM supplier_items sr_i LEFT JOIN supply_items s_i ON s_i.supply_itemsID = sr_i.supply_itemsID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvsupply_Items.DataSource = dt;
            myConn.Close();
            
        }
    }
}
