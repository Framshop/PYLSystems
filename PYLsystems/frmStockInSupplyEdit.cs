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
    public partial class frmStockInSupplyEdit : Form
    {
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public double rawPurchasePriceInitial;
        public class Global
        {
            public static string supplyID = "";
            public static string supplierID = "";
        }
        public frmStockInSupplyEdit()
        {
            InitializeComponent();
        }
        public void RefreshSupplier()
        {
            myConn.Open();
            string query = "SELECT supplierID,supplierName as 'Supplier Name',supplierDetails as 'Supplier Details',contactDetails as 'Contact Details' FROM supplier";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvSupplier.DataSource = dt;
            myConn.Close();
            dgvSupplier.Columns["supplierID"].Visible = false;
        }
        private void frmStockInSupplyEdit_Load(object sender, EventArgs e)
        {
            RefreshSupplier();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionUpdate()
        {
   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void btnSaveValidation()
        {
            int quantity = txtQuantity.TextLength;
            int actualPurchasePrice = txtActualPurchasePrice.TextLength;
            if (quantity > 0 && actualPurchasePrice > 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string myQuery = "UPDATE supply_details SET supplierID = " + lblsupplierID.Text + ", delivery_date = '" + txtDeliveryDate.Value.ToString("yyyy-MM-dd") + "',stockin_quantity = " + txtQuantity.Text + ", pricePurchaseTotal = " +  txtActualPurchasePrice.Text + ",active = " + cboActive.SelectedIndex + ", dateModified = NOW() WHERE supplyID = " + Global.supplyID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            MessageBox.Show("Update Successful");
            this.Close();
        }
        private void calculateTotalRaw()
        {
            double rawPurchaseTotal = 0;
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
            rawPurchaseTotal = quantity * rawPurchasePriceInitial;
            txtRawPurchasePrice.Text = rawPurchaseTotal.ToString();
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            btnSaveValidation();
            calculateTotalRaw();
        }

        private void txtActualPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            btnSaveValidation();
        }

        private void txtActualPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblsupplierID.Text = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
