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
    }
}
