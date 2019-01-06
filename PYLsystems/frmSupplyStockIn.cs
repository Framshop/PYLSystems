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
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmSupplyStockIn()
        {
            InitializeComponent();
            FillSupplier();
            FillSupply_Items();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            string query = "SELECT supplyID,if(sd.active=1,'Active','Inactive') as active,sd.delivery_date,sd.stockin_quantity,sd.supply_price,si.supplyName,s.supplierName FROM supply_details sd LEFT JOIN supply_items si ON sd.supply_itemsID = si.supply_itemsID LEFT JOIN supplier s ON s.supplierID=sd.supplierID";
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
           
            dataGridSupplyStockIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void frmSupplyStockIn_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmStockInSupplyEdit myStockInSupplyEdit = new frmStockInSupplyEdit();
            myStockInSupplyEdit.txtStockInQuantity.Text = dataGridSupplyStockIn.CurrentRow.Cells[4].Value.ToString();
            myStockInSupplyEdit.txtUnitPrice.Text = dataGridSupplyStockIn.CurrentRow.Cells[3].Value.ToString();
            myStockInSupplyEdit.lblSupplyID.Text = dataGridSupplyStockIn.CurrentRow.Cells[0].Value.ToString();
            myStockInSupplyEdit.ShowDialog();
            RefreshDatabase();
        }

        private void dataGridSupplyStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSupplyID.Text = dataGridSupplyStockIn.CurrentRow.Cells[0].Value.ToString();
            lblsupplyStockInQuantityUpdate.Text = dataGridSupplyStockIn.CurrentRow.Cells[3].Value.ToString();
            lblUnitPriceUpdate.Text = dataGridSupplyStockIn.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
