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
    public partial class frmSupplyStockIn : Form
    {
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplyStockIn()
        {
            InitializeComponent();
            FillSupplier();
            FillSupply_Items();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter myAd;
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supply_details WHERE supplierID = " + lblsupplierID.Text + " AND supply_itemsID = " + lbl_supply_itemsID.Text, myConn);
            myAd = new MySqlDataAdapter(myCom);
            DataTable myD = new DataTable();
            myAd.Fill(myD);
            //ADD

            if (myD.Rows.Count == 0)
            {
                myConn.Open();
                string myQuery = "INSERT INTO supply_details (active, delivery_date, stockin_quantity,supply_price,supplierID,supply_itemsID) values(" + cboActive.SelectedIndex + ",'" + txtDeliveryDate.Text + "'," + txtStockInQuantity.Text + "," + txtSupplyPrice.Text + "," + lblsupplierID.Text + "," + lbl_supply_itemsID.Text + ")";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                myConn.Close();
                MessageBox.Show("Insert Successful!");
                RefreshDatabase();
                cboSupplierName.SelectedIndex = -1;
                cboSupplyName.SelectedIndex = -1;
                cboActive.SelectedIndex = -1;
                msktxtDeliveryDate.Text = "";
                txtStockInQuantity.Text = "";
                txtSupplierDetails.Text = "";
                txtSupplyDescription.Text = "";
                txtContactDetails.Text = "";
                txtSupplyPrice.Text = "";
                txtUnitMeasure.Text = "";
            }
            else
            {
                MessageBox.Show("The supplier " + cboSupplierName.Text + " already have an existing item for " + cboSupplyName.Text);
            }
           
        }
        private void FillSupplier()
        {
            string myQuery = "SELECT * FROM supplier";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string supplierName = myReader.GetString(1);
                    cboSupplierName.Items.Add(supplierName);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillSupply_Items()
        {
            string myQuery = "SELECT * FROM supply_items";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string supply_name = myReader.GetString(1);
                    cboSupplyName.Items.Add(supply_name);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
            string myQuery = "SELECT * FROM supplier WHERE supplierName = '" + cboSupplierName.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string myContactDetails = myReader.GetString(3);
                    txtContactDetails.Text = myContactDetails;

                    string myDetails = myReader.GetString(2);
                    txtSupplierDetails.Text = myDetails;

                    string myId = myReader.GetString(0);
                    lblsupplierID.Text = myId;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboSupplyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
            string myQuery = "SELECT * FROM supply_items WHERE supplyName = '" + cboSupplyName.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string myUnitmeasure = myReader.GetString(3);
                    txtUnitMeasure.Text = myUnitmeasure;

                    string myDescription = myReader.GetString(2);
                    txtSupplyDescription.Text = myDescription;

                    string myId = myReader.GetString(0);
                    lbl_supply_itemsID.Text = myId;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void msktxtDeliveryDate_TextChanged(object sender, EventArgs e)
        {
            txtDeliveryDate.Text = msktxtDeliveryDate.Text;
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supplyID,si.supplyName,s.supplierName,sd.supply_price,sd.stockin_quantity,if(sd.active=1,'active','inactive') as active,sd.delivery_date FROM supply_details sd LEFT JOIN supply_items si ON sd.supply_itemsID = si.supply_itemsID LEFT JOIN supplier s ON s.supplierID=sd.supplierID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dataGridSupplyStockIn.DataSource = Dt;
            myConn.Close();
       
            dataGridSupplyStockIn.Columns["supplyID"].HeaderText = "Supply ID";
            dataGridSupplyStockIn.Columns["supplyID"].Visible = false;
            dataGridSupplyStockIn.Columns["active"].HeaderText = "Active";
            dataGridSupplyStockIn.Columns["delivery_date"].HeaderText = "Delivery Date";
            dataGridSupplyStockIn.Columns["stockin_quantity"].HeaderText = "Stock In Quantity";
            dataGridSupplyStockIn.Columns["supply_price"].HeaderText = "Price";
            dataGridSupplyStockIn.Columns["supplyName"].HeaderText = "Supply Name";
            dataGridSupplyStockIn.Columns["supplierName"].HeaderText = "Supplier Name";
           
          
        }

        private void frmSupplyStockIn_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStockInSupplyEdit myStockInSupplyEdit = new frmStockInSupplyEdit();
            myStockInSupplyEdit.txtSupplierName.Text = dataGridSupplyStockIn.CurrentRow.Cells[1].Value.ToString();
            myStockInSupplyEdit.txtSupplyName.Text = dataGridSupplyStockIn.CurrentRow.Cells[2].Value.ToString();
            myStockInSupplyEdit.txtCurrentQuantity.Text = dataGridSupplyStockIn.CurrentRow.Cells[4].Value.ToString();
            myStockInSupplyEdit.txtDeliveryDate.Text = dataGridSupplyStockIn.CurrentRow.Cells[6].Value.ToString();
            myStockInSupplyEdit.txtUnitPrice.Text = dataGridSupplyStockIn.CurrentRow.Cells[3].Value.ToString();
            myStockInSupplyEdit.lblSupplyID.Text = dataGridSupplyStockIn.CurrentRow.Cells[0].Value.ToString();
            myStockInSupplyEdit.ShowDialog();
            RefreshDatabase();
        }

        private void dataGridSupplyStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            functionUpdate();
            lbelsupplyID.Text = dataGridSupplyStockIn.CurrentRow.Cells[0].Value.ToString();
            lblSupplyID.Text = dataGridSupplyStockIn.CurrentRow.Cells[0].Value.ToString();
            lblsupplyStockInQuantityUpdate.Text = dataGridSupplyStockIn.CurrentRow.Cells[3].Value.ToString();
            lblUnitPriceUpdate.Text = dataGridSupplyStockIn.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridSupplyStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void functionAdd()
        {
            int suppliername = cboSupplierName.SelectedIndex;
            int supplyname = cboSupplyName.SelectedIndex;
            int deliverydate = txtDeliveryDate.TextLength;
            int txtunitprice = txtSupplyPrice.TextLength;
            int stock_in_quantity = txtStockInQuantity.TextLength;
            int active = cboActive.SelectedIndex;
            if (suppliername > -1 && supplyname > -1 && deliverydate == 16 && txtunitprice > 0 && stock_in_quantity > 0 && active > -1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        public void functionUpdate()
        {
            if (lbelsupplyID.Text != "")
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supplyID,si.supplyName,s.supplierName,sd.supply_price,sd.stockin_quantity,if(sd.active=1,'active','inactive') as active,sd.delivery_date FROM supply_details sd LEFT JOIN supply_items si ON sd.supply_itemsID = si.supply_itemsID LEFT JOIN supplier s ON s.supplierID=sd.supplierID WHERE si.supplyName LIKE '%" + txtSearch.Text + "%' OR s.supplierName LIKE '%" + txtSearch.Text + "%' OR sd.supply_price LIKE '%" + txtSearch.Text + "%' OR  sd.stockin_quantity LIKE '%" + txtSearch.Text + "%' OR sd.active LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dataGridSupplyStockIn.DataSource = Dt;
            myConn.Close();

            dataGridSupplyStockIn.Columns["supplyID"].HeaderText = "Supply ID";
            dataGridSupplyStockIn.Columns["supplyID"].Visible = false;
            dataGridSupplyStockIn.Columns["active"].HeaderText = "Active";
            dataGridSupplyStockIn.Columns["delivery_date"].HeaderText = "Delivery Date";
            dataGridSupplyStockIn.Columns["stockin_quantity"].HeaderText = "Stock In Quantity";
            dataGridSupplyStockIn.Columns["supply_price"].HeaderText = "Price";
            dataGridSupplyStockIn.Columns["supplyName"].HeaderText = "Supply Name";
            dataGridSupplyStockIn.Columns["supplierName"].HeaderText = "Supplier Name";
        }

        private void txtDeliveryDate_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
        }

        private void cboActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
        }

        private void txtStockInQuantity_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
        }

        private void txtSupplyPrice_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
        }

        private void txtStockInQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
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
