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
        public static string supplierID = "";
        public class Global
        {
            public static string supplyID;

        }
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
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT s.supplierID as 'Supplier ID',s.supplierName 'Supplier Name',s.supplierDetails as 'Supplier Details',s.contactDetails as 'Contact Details' FROM supplier_items s_i LEFT JOIN supplier s ON s_i.supplierID = s.supplierID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvSupplier.DataSource = dt;
            myConn.Close();

        }

        private void frmSupplyStockIn_Load(object sender, EventArgs e)
        {
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
            if (quantity > 0 && purchasePrice > 0 &&   supplierID != "")
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
            string myQuery = "INSERT INTO supply_details (supplierID,supply_itemsID,stockin_quantity,priceRawTotal,pricePurchaseTotal,active,delivery_date) values(" + supplierID + "," + Global.supplyID + "" ;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            RefreshDatabase();
            MessageBox.Show("Insert Successful");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            validationStockInItem();
        }

        private void txtActualPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            validationStockInItem();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierID = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
