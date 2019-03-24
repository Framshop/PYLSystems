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
        public static string supplyItemID = "";
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
            //If supplier does not exist insert supplier
            if (myD.Rows.Count == 0)
            {
                //count total supplier in list view
                int max = lvwItemSold.Items.Count;
                myConn.Open();
                //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                string quer = "INSERT INTO supplier(supplierName,supplierDetails,contactDetails,address,active) VALUES('" + txtSupplierName.Text + "','" + txtDetails.Text + "','" + msktxtContactNumber.Text + "','" + txtAddress.Text + "',0)";
                MySqlCommand com = new MySqlCommand(quer, myConn);
                MySqlDataAdapter ap = new MySqlDataAdapter(com);
                DataTable d = new DataTable();
                ap.Fill(d);
                myConn.Close();


                if (max > 0)
                {
              

                    foreach (ListViewItem lsItem in lvwItemSold.Items)
                    {

                        if (lsItem.SubItems[0].Text == "" || lsItem.SubItems[1].Text == "")
                        {
                            // Do not insert entry that are empty
                        }
                        else
                        {
                            string supplierID_passer = "0";
                            myConn.Open();
                            string myQuer = "SELECT max(supplierID) as 'supplierID' FROM supplier";
                            MySqlCommand my1 = new MySqlCommand(myQuer, myConn);
                            MySqlDataAdapter my2 = new MySqlDataAdapter(my1);
                            myConn.Close();
                            myConn.Open();
                            MySqlDataReader myReader1;
                            try
                            {
                                myReader1 = my1.ExecuteReader();
                                while (myReader1.Read())
                                {
                                    supplierID_passer = myReader1.GetString(0);
                          
                                }
                                myConn.Close();
                            }
                            catch { }


                           
                            myConn.Close();
                            myConn.Open();
                                MySqlCommand myCo = new MySqlCommand("SELECT * FROM supplier_category WHERE supply_categoryID = " + lsItem.SubItems[1].Text + " AND supplierID = " + supplierID_passer, myConn);
                                myAd = new MySqlDataAdapter(myCo);
                             DataTable my = new DataTable();
                                //ADD ----------
                                MySqlDataReader myReade;
                                myAd.Fill(myD);

                                //ADD
                                myReade = myCo.ExecuteReader();
                            myConn.Close();
                            
                            //Check if there is an existing category for that supplier

                            if (myD.Rows.Count == 0)
                            {
                                myConn.Close();

                                myConn.Open();
                                //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                                string query = "INSERT INTO supplier_category(supplierID,supply_categoryID) VALUES(" + supplierID_passer + "," + lsItem.SubItems[1].Text + ")";
                                MySqlCommand comm = new MySqlCommand(query, myConn);
                                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                                DataTable dt = new DataTable();
                                adp.Fill(dt);
                                myConn.Close();

                                myConn.Open();
                                //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                                string quer1 = "INSERT INTO supplier_items(supplierID,supply_itemsID,active) VALUES(" + supplierID_passer + "," + lsItem.SubItems[0].Text + ",0)";
                                MySqlCommand com1 = new MySqlCommand(quer1, myConn);
                                MySqlDataAdapter ap1 = new MySqlDataAdapter(com1);
                                DataTable d1 = new DataTable();
                                ap1.Fill(d1);
                                myConn.Close();
                            }
                            else
                            {

                                MySqlDataAdapter myA;
                            
                                MySqlCommand myCm = new MySqlCommand("SELECT * FROM supplier_items WHERE supply_itemsID = " + lsItem.SubItems[0].Text + " AND supplierID = " + supplierID, myConn);
                                myA = new MySqlDataAdapter(myCom);
                                //ADD ----------
                                myConn.Close();
                                myConn.Open();
                                MySqlDataReader myRead;
                         
                                //ADD
                                myRead = myCm.ExecuteReader();
                                myConn.Close();
                                //Check if there is an existing category for that supplier

                                if (my.Rows.Count == 0)
                                {
                                    myConn.Open();
                                    //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                                    string quer2 = "INSERT INTO supplier_items(supplierID,supply_itemsID,active) VALUES(" + supplierID_passer + "," + lsItem.SubItems[0].Text + ",0)";
                                    MySqlCommand com2 = new MySqlCommand(quer2, myConn);
                                    MySqlDataAdapter ap2 = new MySqlDataAdapter(com2);
                                    DataTable d2 = new DataTable();
                                    ap2.Fill(d2);
                                    myConn.Close();
                                    MessageBox.Show("x");
                                }
                                else
                                {
                                    // DISREGARD the existing one which will not be inserted
                                }
                            }

                        }
                    }
                    MessageBox.Show("Insert Successful");


                }
                else
                {
                    string myQuery = "UPDATE supplier SET supplierName = '" + txtSupplierName.Text + "', supplierDetails = '" + txtDetails.Text + "', contactDetails = '" + msktxtContactNumber.Text + "', address = '" + txtAddress.Text + "' WHERE supplierID = " + supplierID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    MessageBox.Show("Update Successful");
                }
             
                RefreshDatabase();
                btnUpdate.Enabled = false;
                txtSupplierName.Text = "";
                txtDetails.Text = "";
                msktxtContactNumber.Text = "";
                txtAddress.Text = "";
                supplierID = "";
                dgvCategories.DataSource = null;
                validationUpdateSuppliers();
                 ListViewItem item1 = new ListViewItem();
                for (int index = 0; index < max; index++)
                {


                    try
                    {
                        //4 
                        lvwItemSold.Items.Remove(lvwItemSold.Items[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item1.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item1.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item1.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item1.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item1.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item1.SubItems[index]);


                    }
                    catch { }
                }
            }
            //If supplier exist prompt this message
            else
            {
                MessageBox.Show("Supplier " + txtSupplierName.Text + " already exist");
            }
            ListViewItem item = new ListViewItem();
         

        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supplierID as 'Supplier ID',supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details',address as 'Address' FROM supplier where active = 0";
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
            string query = "SELECT s_c.supply_categoryID as 'Supply Category ID',s_ca.categoryName FROM supplier_category s_c LEFT JOIN supply_category s_ca ON s_ca.supply_categoryID = s_c.supply_categoryID WHERE s_c.supplierID = " + supplierID;
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgvCategories.DataSource = myDt;
            myConn.Close();
            dgvCategories.Columns["Supply Category ID"].Visible = false;
            dgvCategories.Columns["categoryName"].HeaderText = "Category Name";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supplierID as 'Supplier ID',supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details',address as 'Address' FROM supplier WHERE supplierName LIKE  '%" + txtSearch.Text + "%' AND active = 0";
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
        
                int max = lvwItemSold.Items.Count;

           

            if (max > 0)
                {
                string myQuery = "UPDATE supplier SET supplierName = '" + txtSupplierName.Text + "', supplierDetails = '" + txtDetails.Text + "', contactDetails = '" + msktxtContactNumber.Text + "', address = '" + txtAddress.Text + "' WHERE supplierID = " + supplierID;
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);

                foreach (ListViewItem lsItem in lvwItemSold.Items)
                    {

                        if (lsItem.SubItems[0] == null || lsItem.SubItems[1] == null)
                        {
                            // Do not insert entry that are empty
                        }
                        else
                        {
                 
                            myConn.Open();
                            MySqlDataAdapter myAd;
                            DataTable myD = new DataTable();
                            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supplier_category WHERE supply_categoryID = " + lsItem.SubItems[1].Text + " AND supplierID = " + supplierID, myConn);
                            myAd = new MySqlDataAdapter(myCom);
                            //ADD ----------
                            MySqlDataReader myReader;
                            myAd.Fill(myD);
                            //ADD
                            myReader = myCom.ExecuteReader();
                           
                            //Check if there is an existing category for that supplier

                            if (myD.Rows.Count == 0)
                            {
                                myConn.Close();

                                myConn.Open();
                                //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                                string query = "INSERT INTO supplier_category(supplierID,supply_categoryID) VALUES(" + supplierID + "," + lsItem.SubItems[1].Text + ")";
                                MySqlCommand comm = new MySqlCommand(query, myConn);
                                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                                DataTable dt = new DataTable();
                                adp.Fill(dt);
                                myConn.Close();

                                myConn.Open();
                                //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                                string quer = "INSERT INTO supplier_items(supplierID,supply_itemsID,active) VALUES(" + supplierID + "," + lsItem.SubItems[0].Text + ",0)";
                                MySqlCommand com = new MySqlCommand(quer, myConn);
                                MySqlDataAdapter ap = new MySqlDataAdapter(com);
                                DataTable d = new DataTable();
                                ap.Fill(d);
                                myConn.Close();
                            }
                            else
                            {
                      
                            MySqlDataAdapter myA;
                            DataTable my = new DataTable();
                            MySqlCommand myCm = new MySqlCommand("SELECT * FROM supplier_items WHERE supply_itemsID = " + lsItem.SubItems[0].Text + " AND supplierID = " + supplierID, myConn);
                            myA = new MySqlDataAdapter(myCom);
                            //ADD ----------
                            myConn.Close();
                            myConn.Open();
                            MySqlDataReader myReade;
                            myA.Fill(my);
                            //ADD
                            myReade = myCm.ExecuteReader();
                            myConn.Close();
                            //Check if there is an existing category for that supplier

                            if (my.Rows.Count == 0)
                            {
                                myConn.Open();
                                //INSERT INTO jOrder_Details(jOrd_Num,supply_itemsID,size,unit_measure,quantity,price) VALUES (" + jOrdID + "," + lsItem.SubItems[0].Text + "," + lsItem.SubItems[3].Text + ",'" + lsItem.SubItems[4].Text + "'," + lsItem.SubItems[5].Text + "," + lsItem.SubItems[6].Text + ");"
                                string quer = "INSERT INTO supplier_items(supplierID,supply_itemsID,active) VALUES(" + supplierID + "," + lsItem.SubItems[0].Text + ",0)";
                                MySqlCommand com = new MySqlCommand(quer, myConn);
                                MySqlDataAdapter ap = new MySqlDataAdapter(com);
                                DataTable d = new DataTable();
                                ap.Fill(d);
                                myConn.Close();
                                MessageBox.Show("x");
                            }
                            else
                            {
                              // DISREGARD the existing one which will not be inserted
                            }
                            }
                        }
                    }
                    MessageBox.Show("Update Successful");

             
                }
                else
                {
                string myQuery = "UPDATE supplier SET supplierName = '" + txtSupplierName.Text + "', supplierDetails = '" + txtDetails.Text + "', contactDetails = '" + msktxtContactNumber.Text + "', address = '" + txtAddress.Text + "' WHERE supplierID = " + supplierID;
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                MessageBox.Show("Update Successful");
            }
            //lvwItemSold.Clear();
            ListViewItem item = new ListViewItem();
            for (int index = 0; index < max; index++)
            {

             
                    try
                    {
                        //4 
                        lvwItemSold.Items.Remove(lvwItemSold.Items[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                        lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);

         
                    }
                    catch { }
                }


                //Should get Category ID, Supplier ID, Supply Items ID, Category Name, Supply Name

            RefreshDatabase();
            btnUpdate.Enabled = false;
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
            if (Global.supply_categoryID_passer == "")
            {
                frmAddSupplierItems addSupplierCategory = new frmAddSupplierItems();
                addSupplierCategory.ShowDialog();

              
                frmSupplier supplier = new frmSupplier();
                ListViewItem item = new ListViewItem();
                int max = lvwItemSold.Items.Count;
                item = lvwItemSold.Items.Add(frmSupplier.Global.supply_itemsID_passer);
                item.SubItems.Add(frmSupplier.Global.supply_categoryID_passer);
                item.SubItems.Add(frmSupplier.Global.category_name_passer);
                item.SubItems.Add(frmSupplier.Global.supply_name_passer);
                //for (int index = 0; index < max; index++)
                //{

                //    if (lvwItemSold.Items[index].Text == Global.supply_itemsID_passer)
                //    {
                //        try
                //        {
                //            //4 
                //            lvwItemSold.Items.Remove(lvwItemSold.Items[index]);
                //            lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                //            lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                //            lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                //            lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                //            lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);
                //            lvwItemSold.Items[index].SubItems.Remove(item.SubItems[index]);

                //            item = lvwItemSold.Items.Add(frmSupplier.Global.supply_itemsID_passer);
                //            item.SubItems.Add(frmSupplier.Global.supply_categoryID_passer);
                //            item.SubItems.Add(frmSupplier.Global.category_name_passer);
                //            item.SubItems.Add(frmSupplier.Global.supply_name_passer);
                //        }
                //        catch { }
                //    }


                //    //Should get Category ID, Supplier ID, Supply Items ID, Category Name, Supply Name

                //}
                supply_categoryID = "";
                validationAddSuppliers();
                Global.supply_categoryID_passer = "";
            }
            else
            {
                Global.supply_categoryID_passer = "";
            }
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
            if (supplierDetails > 0 && address > 0 &&(contactDetails == 7 || contactDetails == 11 )&& supplierName > 0 && max > 0)
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
            btnArchiveSupplier.Enabled = true;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supply_categoryID = dgvCategories.CurrentRow.Cells[0].Value.ToString();
          
                myConn.Open();
                string query = "SELECT s_i.supply_itemsID,s_t.supplyName as 'Supply Name',s_t.supplyDescription as 'Supply Description' FROM supplier s LEFT JOIN supplier_items s_i ON s_i.supplierID = s.supplierID LEFT JOIN supplier_category s_c ON s_c.supplierID = s.supplierID LEFT JOIN supply_items s_t ON s_t.supply_itemsID = s_i.supply_itemsID  WHERE s_i.active = 0 AND s.supplierID =" + supplierID + " AND s_c.supply_categoryID =" + supply_categoryID;
;
                MySqlCommand comm = new MySqlCommand(query, myConn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvsupply_Items.DataSource = dt;
            dgvsupply_Items.Columns["supply_itemsID"].Visible = false;

                myConn.Close();
               
               
           
   
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

        private void lvwItemSold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwItemSold.SelectedItems.Count > 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwItemSold.SelectedItems)
            {
                lvwItemSold.Items.Remove(item);
            }
        }

        private void btnArchiveSupplier_Click(object sender, EventArgs e)
        {
            string myQuery = "update supplier set active = 1 where supplierID =  " + supplierID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Archive Success");
            RefreshDatabase();
            btnArchiveSupplier.Enabled = false;

            dgvCategories.DataSource = null;

            txtSupplierName.Clear();
            txtAddress.Clear();
            msktxtContactNumber.Clear();
            txtDetails.Clear();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnSupplyItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SupplyItemID:"+supplyItemID+" supplierID:"+ supplierID);

            string myQuery = "update supplier_items SET active = 1 where supplierID =  " + supplierID + " AND supply_itemsID =" + supplyItemID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Archive Success");

            btnArchiveSupplier.Enabled = false;
            dgvCategories.DataSource = null;
            RefreshDatabase();


            txtSupplierName.Clear();
            txtAddress.Clear();
            msktxtContactNumber.Clear();
            txtDetails.Clear();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            btnSupplyItem.Enabled = false;
        }

        private void btnArchiveSupplierList_Click(object sender, EventArgs e)
        {
            frmArchiveSupplier supplier = new frmArchiveSupplier();
            supplier.ShowDialog();
            RefreshDatabase();
        }

        private void btnArchiveSupplyItem_Click(object sender, EventArgs e)
        {
            frmArchiveSupplytItem supply = new frmArchiveSupplytItem();
            supply.ShowDialog();
        }

        private void dgvsupply_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplyItemID = dgvsupply_Items.CurrentRow.Cells[0].Value.ToString();
            btnSupplyItem.Enabled = true;
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
