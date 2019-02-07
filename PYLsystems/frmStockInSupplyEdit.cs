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
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");

        public frmStockInSupplyEdit()
        {
            InitializeComponent();
        }

        private void frmStockInSupplyEdit_Load(object sender, EventArgs e)
        {
            frmSupplyStockIn mySupplyStockIn = new frmSupplyStockIn();
            if (mySupplyStockIn.lblActiveUpdate.Text == "Active")
            {
                cboActive.SelectedIndex = 0;
            }
            else
            {
                cboActive.SelectedIndex = 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmSupplyStockIn mySupplyStockIn = new frmSupplyStockIn();
            myConn.Open();
            string myQuery = "UPDATE supply_details SET stockin_quantity =  stockin_quantity + " + txtStockInQuantity.Text + ",supply_price =  " +
                "" + txtUnitPrice.Text + ",active =  " +
                "" + cboActive.SelectedIndex + " WHERE supplyID = " + lblSupplyID.Text;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);

            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            this.Close();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionUpdate()
        {
            int active = cboActive.SelectedIndex;
            int stock_in_quantity = txtStockInQuantity.TextLength;
            int unitprice = txtUnitPrice.TextLength;
            if (active > -1 && stock_in_quantity > 0 && unitprice > 0)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }     
        }

        private void cboActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionUpdate();
        }

        private void txtStockInQuantity_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
        }
    }
}
