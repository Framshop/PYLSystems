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
    public partial class frmFrameList : Form
    {
        public static string frameItemID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmFrameList()
        {
            InitializeComponent();
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM frame_list WHERE frameName = '" + txtName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count==0) {
                myConn.Open();
                string myQuery = "INSERT INTO frame_list (frameName, frameDescription, active,dimension,unitPrice) values('" + txtName.Text + "','" + txtDescription.Text + "','" + cboActive.Text + "','" + txtDimension.Text + "','" + txtUnitPrice.Text + "')";
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                myConn.Close();
                MessageBox.Show("Insert Successful!");
                RefreshDatabase();
            }
            else
            {
                lblValidate.Text = "Frame Name already exists!";
            }
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT frameItemID,frameName,frameDescription,active,dimension,unitPrice FROM frame_list";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();

            Adp.Fill(Dt);

            frameItemsGrid.DataSource = Dt;
            myConn.Close();
            frameItemsGrid.Columns["frameItemID"].Visible = false;
            frameItemsGrid.Columns["frameItemID"].HeaderText = "ID";
            frameItemsGrid.Columns["frameName"].HeaderText = "Name";
            frameItemsGrid.Columns["frameDescription"].HeaderText = "Description";
            frameItemsGrid.Columns["active"].HeaderText = "Active";
            frameItemsGrid.Columns["dimension"].HeaderText = "Dimension";
            frameItemsGrid.Columns["unitPrice"].HeaderText = "Unit Price";
        }

        private void frameItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblFrameID.Text = frameItemsGrid.CurrentRow.Cells[0].Value.ToString();
            lblIDUpdate.Text = frameItemsGrid.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = frameItemsGrid.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = frameItemsGrid.CurrentRow.Cells[2].Value.ToString();
            cboActive.Text = frameItemsGrid.CurrentRow.Cells[3].Value.ToString();
            txtDimension.Text = frameItemsGrid.CurrentRow.Cells[4].Value.ToString();
            txtUnitPrice.Text = frameItemsGrid.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "UPDATE frame_list SET frameName = '" + txtName.Text + "',frameDescription =  " +
                "'" + txtDescription.Text + "', active = '" + cboActive.Text + "', dimension = '" + txtDimension.Text + "', unitPrice = " + txtUnitPrice.Text + " WHERE frameItemID = " + lblIDUpdate.Text;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
            txtDescription.Text = "";
            txtName.Text = "";
            txtDimension.Text = "";
            txtUnitPrice.Text = "";
            cboActive.Text = "";
            btnUpdate.Enabled = false;
        }

        private void frmFrameList_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT frameItemID,frameName,frameDescription,active,dimension,unitPrice FROM frame_list WHERE frameName LIKE '%" + txtSearch.Text + "%' OR frameDescription LIKE '%" + txtSearch.Text + "%' OR dimension LIKE '%" + txtSearch.Text + "%' OR active LIKE '%" + txtSearch.Text + "%' OR unitPrice LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            frameItemsGrid.DataSource = Dt;
            myConn.Close();
            frameItemsGrid.Columns["frameItemID"].Visible = false;
            frameItemsGrid.Columns["frameItemID"].HeaderText = "ID";
            frameItemsGrid.Columns["frameName"].HeaderText = "Name";
            frameItemsGrid.Columns["frameDescription"].HeaderText = "Description";
            frameItemsGrid.Columns["active"].HeaderText = "Active";
            frameItemsGrid.Columns["dimension"].HeaderText = "Dimension";
            frameItemsGrid.Columns["unitPrice"].HeaderText = "Unit Price";
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {

        }

        private void cboSupplyName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionAdd()
        {
            int name = txtName.TextLength;
            int description = txtDescription.TextLength;
            int active = cboActive.SelectedIndex;
            int dimension = txtDimension.TextLength;
            int unitprice = txtUnitPrice.TextLength;
            if (name == 0 && description == 0 && active < 0 && dimension == 0 && unitprice == 0)
            {
                MessageBox.Show("Please Input the required fields");
            }
            else
            {
            
              
                    if (name > 0 && description > 0 && active >= 0 && dimension > 0 && unitprice > 0)
                    {
                        btbAdd.Enabled = true;
                    }
                    else
                    {
                        btbAdd.Enabled = false;
                    }
            }

        }
        public void functionUpdate()
        {
           string frameID = lblFrameID.Text;
            if (frameID != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
            functionAdd(); 
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
            functionAdd();
        }

        private void cboActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionUpdate();
            functionAdd();
        }

        private void txtDimension_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
            functionAdd();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            functionUpdate();
            functionAdd();
        }
    }
}
