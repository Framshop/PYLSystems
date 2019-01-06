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
            string myQuery = "UPDATE supply_details SET stockin_quantity = " + txtStockInQuantity.Text + ",supply_price =  " +
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
    }
}
