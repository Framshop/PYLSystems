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

        public static string supply_itemsID_passer = "";
        public static string supplierID = "";
        public static string supply_detailsID = "";
        public class Global
        {
            public static string supplyID;
            public static string supply_itemsID;

        }
        DateTime DateStart;
        DateTime DateEnd;
        public double rawPurchasePriceInitial;
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplyStockIn()
        {

            InitializeComponent();

   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



        }
 

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboSupplyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void msktxtDeliveryDate_TextChanged(object sender, EventArgs e)
        { 
        }
        private void DefaultDatesInitializer()
        {
            DateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddHours(0).AddMinutes(0).AddSeconds(0);
            DateEnd = DateStart.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            startDatePicker.Value = DateStart;
            endDatePicker.Value = DateEnd;
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT s.supplierID,s.supplierName as 'Supplier Name',s.supplierDetails as 'Supplier Details',s.address as 'Address' FROM supplier_items s_i LEFT JOIN supplier s ON s.supplierID = s_i.supplierID WHERE s_i.supply_itemsID = " + lblsupply_itemsID.Text;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvSupplier.DataSource = dt;
            myConn.Close();
            dgvSupplier.Columns["supplierID"].Visible = false;

        }
        public void RefreshStockIn()
        {
            myConn.Open();
            string query = "SELECT s_d.supplyID as 'Supply ID',s_i.supplyName as 'Supply Name',s.supplierName as 'Supplied By',s_d.delivery_date as 'Date Delivered',s_d.stockin_quantity AS 'Stock In Quantity',s_d.priceRawTotal,s_d.pricePurchaseTotal,IF(s_d.active=0,'Active','Inactive') as 'active', s_d.stockin_quantity 'Calculated Total Purchase Price',s_d.pricePurchaseTotal as 'Actual Total Purchase Price' FROM supply_details s_d LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID WHERE s_d.supply_itemsID = " + lblsupply_itemsID.Text;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvStockIn.DataSource = dt;
            myConn.Close();
            dgvStockIn.Columns["Supply ID"].Visible = false;
            dgvStockIn.Columns["pricePurchaseTotal"].Visible = false;
            dgvStockIn.Columns["priceRawTotal"].Visible = false;
            dgvStockIn.Columns["active"].Visible = false;
        }
        private void frmSupplyStockIn_Load(object sender, EventArgs e)
        {
            supply_itemsID_passer = Global.supply_itemsID;
            //DefaultDatesInitializer();
            RefreshDatabase();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridSupplyStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
           
        }
        public void functionUpdate()
        {
           
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
        public void validationStockInItem()
        {
            int quantity = txtQuantity.TextLength;
            int purchasePrice = txtActualPurchasePrice.TextLength;
            int rawPurchasePrice = txtRawPurchasePrice.TextLength;
            if (quantity > 0 && purchasePrice > 0 &&   supplierID != "" && (rawPurchasePrice > 0 && txtRawPurchasePrice.Text != "0"))
            {
                btnStockInItem.Enabled = true;
            }
            else
            {
                btnStockInItem.Enabled = false;
            }
        }
         private void btnStockInItem_Click(object sender, EventArgs e)
        {
            string myQuery = "INSERT INTO supply_details (supplierID,supply_itemsID,stockin_quantity,priceRawTotal,pricePurchaseTotal,active,delivery_date) values(" + supplierID + "," + Global.supplyID + "," + txtQuantity.Text + "," + float.Parse(txtRawPurchasePrice.Text) + "," + float.Parse(txtActualPurchasePrice.Text) + ",0,NOW())";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn); 
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            RefreshDatabase();
            RefreshStockIn();
            MessageBox.Show("Insert Successful");
            txtQuantity.Text = "";
            txtActualPurchasePrice.Text = "";
            txtRawPurchasePrice.Text = "";

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void calculateTotalRaw()
        { 
            double quantity = 0;
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                quantity = 0;
          
            }
            else
            {
                quantity = Double.Parse(txtQuantity.Text);
            }
            //if (!String.IsNullOrEmpty(txtRawPurchasePrice.Text))
            //{
            //    rawPurchaseTotal = 0;
            //}

            txtActualPurchasePrice.Text = (quantity * double.Parse(txtRawPurchasePrice.Text)).ToString();
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calculateTotalRaw();
            validationStockInItem();
        }

        private void txtActualPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            validationStockInItem();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierID = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            validationStockInItem();
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                string query = "SELECT s_d.supplyID as 'Supply ID',s_i.supplyName as 'Supply Name',s.supplierName as 'Supplied By',s_d.delivery_date as 'Date Delivered',s_d.stockin_quantity AS 'Stock In Quantity',s_d.priceRawTotal,s_d.pricePurchaseTotal,IF(s_d.active=0,'Active','Inactive') as 'active', s_d.priceRawTotal 'Purchase Price',s_d.pricePurchaseTotal as 'Actual Total Purchase Price' FROM supply_details s_d LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID WHERE s_d.delivery_date BETWEEN '" + startDatePicker.Value.ToString("yyyy-MM-dd") + "' AND '" + endDatePicker.Value.ToString("yyyy-MM-dd") + "' AND s_d.supply_itemsID = " + lblsupply_itemsID.Text;
                MySqlCommand comm = new MySqlCommand(query, myConn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvStockIn.DataSource = dt;
                myConn.Close();
                dgvStockIn.Columns["Supply ID"].Visible = false;
                dgvStockIn.Columns["pricePurchaseTotal"].Visible = false;
                dgvStockIn.Columns["priceRawTotal"].Visible = false;
                dgvStockIn.Columns["active"].Visible = false;
            }
            catch { }
            
        }
        public void editDetails()
        {
            if (supply_detailsID != "")
            {
                btnEditDetails.Enabled = true;
            }
            else
            {
                btnEditDetails.Enabled = false;
            }
        }
        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            frmStockInSupplyEdit stockInSupplyEdit = new frmStockInSupplyEdit();
            frmStockInSupplyEdit.Global.supplyID = dgvStockIn.CurrentRow.Cells["Supply ID"].Value.ToString();
            frmStockInSupplyEdit.Global.supplierID = dgvStockIn.CurrentRow.Cells["Calculated Total Purchase Price"].Value.ToString();
            stockInSupplyEdit.lblsupplierID.Text = dgvStockIn.CurrentRow.Cells["Calculated Total Purchase Price"].Value.ToString();
            stockInSupplyEdit.txtItemName.Text = dgvStockIn.CurrentRow.Cells["Supply Name"].Value.ToString();
            stockInSupplyEdit.txtDeliveryDate.Text =  dgvStockIn.CurrentRow.Cells["Date Delivered"].Value.ToString();
            stockInSupplyEdit.txtQuantity.Text =  dgvStockIn.CurrentRow.Cells["Stock In Quantity"].Value.ToString();
            stockInSupplyEdit.txtRawPurchasePrice.Text =  dgvStockIn.CurrentRow.Cells["priceRawTotal"].Value.ToString();
            stockInSupplyEdit.rawPurchasePriceInitial = Double.Parse(dgvStockIn.CurrentRow.Cells["priceRawTotal"].Value.ToString());
            stockInSupplyEdit.txtActualPurchasePrice.Text =  dgvStockIn.CurrentRow.Cells["pricePurchaseTotal"].Value.ToString();
            stockInSupplyEdit.cboActive.Text =  dgvStockIn.CurrentRow.Cells["active"].Value.ToString();
            stockInSupplyEdit.ShowDialog();
            RefreshStockIn();
            RefreshDatabase();
            txtQuantity.Text = "";
            txtActualPurchasePrice.Text = "";
        }

        private void dgvStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supply_detailsID = dgvStockIn.CurrentRow.Cells["Supply ID"].Value.ToString();
            editDetails();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT s_d.supplyID as 'Supply ID',s_i.supplyName as 'Supply Name',s.supplierName as 'Supplied By',s_d.delivery_date as 'Date Delivered',s_d.stockin_quantity AS 'Stock In Quantity',s_d.priceRawTotal,s_d.pricePurchaseTotal,IF(s_d.active=0,'Active','Inactive') as 'active', s_d.priceRawTotal 'Purchase Price',s_d.pricePurchaseTotal as 'Actual Total Purchase Price' FROM supply_details s_d LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID WHERE s_d.delivery_date BETWEEN '" + startDatePicker.Value.ToString("yyyy-MM-dd") + "' AND '" + endDatePicker.Value.ToString("yyyy-MM-dd") + "'AND s_d.supply_itemsID = " + lblsupply_itemsID.Text;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvStockIn.DataSource = dt;
            myConn.Close();
            dgvStockIn.Columns["Supply ID"].Visible = false;
            dgvStockIn.Columns["pricePurchaseTotal"].Visible = false;
            dgvStockIn.Columns["priceRawTotal"].Visible = false;
            dgvStockIn.Columns["active"].Visible = false;
            
        }

        private void frmSupplyStockIn_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            lblsupply_itemsID.Visible = false;
            RefreshStockIn();
        }

        private void txtRawPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRawPurchasePrice_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(txtRawPurchasePrice.Text))
                {
                    txtRawPurchasePrice.Text = "0";
                }
                else
                {
                    txtRawPurchasePrice.Text = (Double.Parse(txtRawPurchasePrice.Text)).ToString();

                }
                //if (!String.IsNullOrEmpty(txtRawPurchasePrice.Text))
                //{
                //    rawPurchaseTotal = 0;
                //}
                txtActualPurchasePrice.Text = (double.Parse(txtQuantity.Text) * double.Parse(txtRawPurchasePrice.Text)).ToString();
            }
            catch { }
        }
    }
}
