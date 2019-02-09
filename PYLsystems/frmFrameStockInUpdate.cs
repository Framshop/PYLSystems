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
    public partial class frmFrameStockInUpdate : Form
    {
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmFrameStockInUpdate()
        {

            InitializeComponent();
        }
        public void FillFrameMaterials()
        {
            string myQuery = "SELECT s_d.supplyID,f_m.fixedQuantity FROM frame_materials f_m LEFT JOIN supply_details s_d ON s_d.supplyID = f_m.supply_detailsID WHERE frameItemID = " + lblFrameItemID.Text;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string frameList = myReader.GetString(0);
                    cboFrame_materials.Items.Add(frameList);

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStockIn_KeyPress(object sender, KeyPressEventArgs e)
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
        public void functionUpdate()
        {
            int stockin = txtStockIn.TextLength;
            if (stockin > 0)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index, max;
            max = cboFrame_materials.Items.Count;
            myConn.Open();
            string query = "UPDATE framestock_in SET stockinQuantity = stockinQuantity + " + txtStockIn.Text + ", dateModified = NOW() WHERE frameItemID = " + lblFrameItemID.Text;
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            myConn.Close();

            for (index = 0; index < max; index++)
            {
                myConn.Open();
                string quer = "UPDATE frame_materials SET stockout_quantity = stockout_quantity + " + cboFixedQuantity.Items[index].ToString() + " WHERE frameItemID = " + lblFrameItemID.Text + " AND frame_materialsID = " + cboFrame_materials.Items[index];
                MySqlCommand com = new MySqlCommand(quer, myConn);
                MySqlDataAdapter Ad = new MySqlDataAdapter(com);
                DataTable d = new DataTable();
                Ad.Fill(d);
                myConn.Close();
            }
            MessageBox.Show("Update Successful!");
            this.Close();
        }

        private void txtStockIn_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
        }

        private void frmFrameStockInUpdate_Load(object sender, EventArgs e)
        {

        }

        private void frmFrameStockInUpdate_MouseHover(object sender, EventArgs e)
        { 
        }
    }
}
