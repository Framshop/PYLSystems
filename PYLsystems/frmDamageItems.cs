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
    public partial class frmDamageItems : Form
    {
        public static string lastname = "";
        public static string firstname = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmDamageItems()
        {
            InitializeComponent();
            FillFrameList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionAdd()
        {
            
            int framename = cboFrameName.SelectedIndex;
            int quantity = txtQuantity.TextLength;
            int damagreason = txtDamageReason.TextLength;
            if (framename > -1 && quantity > 0 && damagreason > 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "INSERT INTO damaged_items(inventoryID,damageReason,quantity) VALUES(" + lblFrameItemID.Text + ",'" + txtDamageReason.Text + "'," + txtQuantity.Text+ ")";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Insert Successful!");
            RefreshDatabase();
        }
        public void FillFrameList()
        {
            string myQuery = "SELECT f_i.inventoryID,f_l.frameName FROM framestock_in f_i LEFT JOIN frame_list f_l ON f_l.frameItemID = f_i.frameItemID";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string frameList = myReader.GetString(1);
                    cboFrameName.Items.Add(frameList);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myQuery = "SELECT employeeID FROM employee WHERE lastname = '" + lastname + "' OR firstname = '" + firstname + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string myId = myReader.GetString(0);
                    lblEmployeeID.Text = myId;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboFrameName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myQuery = "SELECT f_i.inventoryID,f_l.frameName FROM framestock_in f_i LEFT JOIN frame_list f_l ON f_l.frameItemID = f_i.frameItemID WHERE f_l.frameName = '" + cboFrameName.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {

                    string myId = myReader.GetString(0);
                    lblFrameItemID.Text = myId;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtDamageReason_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT d_i.damagedItemsID,CONCAT(e.lastname,', ',e.firstname) as 'EmployeeName',f_l.frameName,d_i.quantity,d_i.damageReason FROM damaged_items d_i LEFT JOIN framestock_in f_i ON f_i.inventoryID = d_i.inventoryID LEFT JOIN frame_list f_l ON f_l.frameItemID = f_i.frameItemID LEFT JOIN employee e ON e.employeeID = f_i.employeeID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvDamageItems.DataSource = Dt;
            myConn.Close();
            dgvDamageItems.Columns["damagedItemsID"].Visible = false;
            dgvDamageItems.Columns["damagedItemsID"].HeaderText = "Damage Items ID";
            dgvDamageItems.Columns["EmployeeName"].HeaderText = "EmployeeName";
            dgvDamageItems.Columns["frameName"].HeaderText = "Frame Name";
            dgvDamageItems.Columns["quantity"].HeaderText = "Quantity";
            dgvDamageItems.Columns["damagereason"].HeaderText = "Damage Reason";
        }

        private void frmDamageItems_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
    }
}
