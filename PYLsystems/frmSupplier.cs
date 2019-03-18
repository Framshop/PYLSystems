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
        public static string maxSupplierID = "";
        public class Global
        {
            public static string supply_categoryID_passer = "";
            public static string supply_itemsID_passer = "";
            public static string category_name_passer = "";
            public static string supply_name_passer = "";


        }
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Check if suppliers exist
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supplier WHERE supplierName = '" + txtSupplierName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            //Check if there is an existing category for that supplier
            if (myD.Rows.Count == 0)
            {
                myConn.Open();
                string myQuery = "INSERT INTO supplier(suppliername,supplierdetails,contactdetails,address) VALUES('" + txtSupplierName.Text + "','" + txtDetails.Text + "','" + msktxtContactNumber.Text + "','" + txtAddress.Text + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                myConn.Close();

                myConn.Open();
                string myQuer = "SELECT max(supplierID) as 'jOrd_Num' FROM supplier";
                MySqlCommand xmyCom = new MySqlCommand(myQuer, myConn);
                MySqlDataAdapter xmyAd = new MySqlDataAdapter(xmyCom);
                myConn.Close();
                myConn.Open();
                MySqlDataReader xmyReader;
                try
                {
                    xmyReader = xmyCom.ExecuteReader();
                    while (xmyReader.Read())
                    {
                        maxSupplierID = xmyReader.GetString(0);
                    }
                    myConn.Close();

                }
                catch { }

                    foreach (ListViewItem lsItem in lvwItemSold.Items)
                {
                    myConn.Open();
                    //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                    string query = "INSERT INTO supplier_category(supplierID,supply_categoryID) VALUES(" + maxSupplierID + ","  + lsItem.SubItems[1].Text + ")";
                    MySqlCommand comm = new MySqlCommand(query, myConn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    myConn.Close();

                    myConn.Open();
                    //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                    string quer = "INSERT INTO supplier_items(supplierID,supply_itemsID) VALUES(" + maxSupplierID + "," + lsItem.SubItems[0].Text + ")";
                    MySqlCommand com = new MySqlCommand(quer, myConn);
                    MySqlDataAdapter ap = new MySqlDataAdapter(com);
                    DataTable d = new DataTable();
                    ap.Fill(d);
                    myConn.Close();

                }

                MessageBox.Show("Insert Successful!");
                RefreshDatabase();
                Global.supply_categoryID_passer = "";
                Global.supply_itemsID_passer = "";
                Global.category_name_passer = "";
                Global.supply_name_passer = "";
                 supplierID = "";
                  supply_categoryID = "";
                  address = "";
                  maxSupplierID = "";
                lvwItemSold.Clear();
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
            dgvsupply_Items.DataSource = null;
        }

        private void supplierGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void supplierGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RefreshCategory()
        {
            string query = "SELECT s_c.supply_categoryID,s_ca.categoryName FROM supplier_category s_c LEFT JOIN supply_category s_ca ON s_ca.supply_categoryID = s_c.supply_categoryID WHERE s_c.supplierID = " + supplierID;
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgvCategories.DataSource = myDt;
            myConn.Close();
            dgvCategories.Columns["supply_categoryID"].Visible = false;
            dgvCategories.Columns["categoryName"].HeaderText = "Category Name";
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
            dgvsupply_Items.DataSource = null;
            dgvCategories.DataSource = null;
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
            
            ListViewItem item = new ListViewItem();
            int max;
            //Should get Category ID, Supplier ID, Supply Items ID, Category Name, Supply Name
            max = lvwItemSold.Items.Count;
            item = lvwItemSold.Items.Add(Global.supply_itemsID_passer);
            item.SubItems.Add(Global.supply_categoryID_passer);
            item.SubItems.Add(Global.category_name_passer);
            item.SubItems.Add(Global.supply_name_passer);
            supplierID = "";
            supply_categoryID = "";
            validationAddSuppliers();
        }
        public void validationAddSuppliers()
        {
            ListViewItem item = new ListViewItem();
            int max;
            //Should get Category ID, Supplier ID, Supply Items ID, Category Name, Supply Name
            max = lvwItemSold.Items.Count;
            int supplierName = txtSupplierName.TextLength;
            int supplierDetails = txtDetails.TextLength;
            int contactDetails = msktxtContactNumber.TextLength;
            int address = txtAddress.TextLength;
            if (supplierDetails > 0 && address > 0 && contactDetails == 11 && supplierName > 0 && max > 0)
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
            dgvsupply_Items.DataSource = null;
           
            supplierID = dgvSuppliers.CurrentRow.Cells[0].Value.ToString();
            validationUpdateSuppliers();

            txtSupplierName.Text = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();
            txtDetails.Text = dgvSuppliers.CurrentRow.Cells[2].Value.ToString();
            msktxtContactNumber.Text = dgvSuppliers.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvSuppliers.CurrentRow.Cells[4].Value.ToString();
            RefreshCategory();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            myConn.Open();
            string query = "SELECT s_i.supplyName as 'Supply Name',s_i.supplyDescription as 'Supply Description' FROM supplier_items sr_i LEFT JOIN supply_items s_i ON s_i.supply_itemsID = sr_i.supply_itemsID WHERE supplierID =" + supplierID;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvsupply_Items.DataSource = dt;
            myConn.Close();
            supply_categoryID = dgvCategories.CurrentRow.Cells[0].Value.ToString();
   
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvwItemSold_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
 
        }

        private void msktxtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
