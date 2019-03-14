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
    public partial class frmSupplyItems : Form
    {
        public static string supply_price = "";
        public static string supply_itemsID = "";
        public static string unitmeasure = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplyItems()
        {
            InitializeComponent();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supply_items WHERE supplyName = '" + txtName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count == 0)
            {
                //IF ELSE if there is sales price or not
                if (txtSales_Price.Text != "")
                {
                    myConn.Open();
                    string myQuery = "INSERT INTO supply_items (supplyName, supplyDescription, unitMeasure,sales_price) values('" + txtName.Text + "','" + txtDescription.Text + "','" + cboUnitMeasure.Text + "'," + txtSales_Price.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    myConn.Close();
                    MessageBox.Show("Insert Successful!");
                    RefreshDatabase();
                    txtDescription.Text = "";
                    txtName.Text = "";
                    cboUnitMeasure.Text = "";
                    txtSales_Price.Text = "";
                    cboUnitMeasure.SelectedIndex = -1;
                }
                else
                {
                    myConn.Open();
                    string myQuery = "INSERT INTO supply_items (supplyName, supplyDescription, unitMeasure) values('" + txtName.Text + "','" + txtDescription.Text + "','" + cboUnitMeasure.Text + "')";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    myConn.Close();
                    MessageBox.Show("Insert Successful!");
                    RefreshDatabase();
                    txtDescription.Text = "";
                    txtName.Text = "";
                    cboUnitMeasure.Text = "";
                    txtSales_Price.Text = "";
                    cboUnitMeasure.SelectedIndex = -1;
                }
            }
            else
            {
                lblValidate.Text = "Supply Items Already Exists!";
            }
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supply_itemsID,supplyName,supplyDescription,unitMeasure,IFNULL(sales_price,'Not for sale') as 'Sales Price' FROM supply_items";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            supplyItemsGrid.DataSource = Dt;
            myConn.Close();
            supplyItemsGrid.Columns["supply_itemsID"].Visible = false;
            supplyItemsGrid.Columns["supply_itemsID"].HeaderText = "ID";
            supplyItemsGrid.Columns["supplyName"].HeaderText = "Name";
            supplyItemsGrid.Columns["supplyDescription"].HeaderText = "Description";
            supplyItemsGrid.Columns["unitMeasure"].HeaderText = "Unit Measure";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "UPDATE supply_items SET supplyName = '" + txtName.Text + "',supplyDescription = " +
                "'" + txtDescription.Text + "', unitMeasure = '" + cboUnitMeasure.Text + "', sales_price = "  + txtSales_Price.Text + " WHERE supply_itemsID = " + supply_itemsID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
            txtDescription.Text = "";
            txtName.Text = "";
            cboUnitMeasure.Text = "";
            txtSales_Price.Text = "";
            cboUnitMeasure.SelectedIndex = -1;
            btnUpdate.Enabled = false;
        }

        private void supplyItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supply_price = supplyItemsGrid.CurrentRow.Cells[4].Value.ToString();
            unitmeasure = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();
            txtSales_Price.Text = supplyItemsGrid.CurrentRow.Cells[4].Value.ToString();
            if (txtSales_Price.Text == "Not for sale" && unitmeasure == "inches")
            {
                lblSupplyItemsID.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                supply_itemsID = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                lblNameUpdate.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                lblDescriptionUpdate.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                lblUnitMeasureUpdate.Text = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();
                txtSales_Price.Text = "0";
                txtName.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                cboUnitMeasure.SelectedIndex = 1;
                lblIDUpdate.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
            }
            else if (txtSales_Price.Text == "Not for sale" && unitmeasure == "ft")
            {
                lblSupplyItemsID.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                supply_itemsID = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                lblNameUpdate.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                lblDescriptionUpdate.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                lblUnitMeasureUpdate.Text = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();
                txtSales_Price.Text = "0";
                txtName.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                cboUnitMeasure.SelectedIndex = 0;
                lblIDUpdate.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
            }
            else if (txtSales_Price.Text != "Not for sale" && unitmeasure == "inches")
            {
                lblSupplyItemsID.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                supply_itemsID = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                lblNameUpdate.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                lblDescriptionUpdate.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                lblUnitMeasureUpdate.Text = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();
                txtSales_Price.Text = supplyItemsGrid.CurrentRow.Cells[4].Value.ToString(); ;
                txtName.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                cboUnitMeasure.SelectedIndex = 0;
                lblIDUpdate.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                lblSupplyItemsID.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                supply_itemsID = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                lblNameUpdate.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                lblDescriptionUpdate.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                lblUnitMeasureUpdate.Text = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();
                txtSales_Price.Text = supplyItemsGrid.CurrentRow.Cells[4].Value.ToString(); ;
                txtName.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
                cboUnitMeasure.SelectedIndex = 1;
                lblIDUpdate.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void frmSupplyItems_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supply_itemsID,supplyName,supplyDescription,unitMeasure,IFNULL(sales_price,'Not for sale') as 'Sales Price' FROM supply_items WHERE supplyName LIKE '%" + txtSearch.Text + "%' OR supplyDescription LIKE '%" + txtSearch.Text + "%' OR unitMeasure LIKE '%" + txtSearch.Text + "%' OR sales_price LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            supplyItemsGrid.DataSource = Dt;
            myConn.Close();
            supplyItemsGrid.Columns["supply_itemsID"].Visible = false;
            supplyItemsGrid.Columns["supplyName"].HeaderText = "Supply Name";
            supplyItemsGrid.Columns["supplyDescription"].HeaderText = "Details";
            supplyItemsGrid.Columns["unitMeasure"].HeaderText = "Unit Measure";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void functionAdd()
        {
            int supplyname = txtName.TextLength;
            int description = txtDescription.TextLength;
            int unitmeasure = cboUnitMeasure.SelectedIndex;
            if (supplyname > 0 && description > 0 && unitmeasure > -1)
            {
                addBtn.Enabled = true;
            }
            else
            {
                addBtn.Enabled = false;
            }
        }
        public void functionUpdate()
        {
            if (lblSupplyItemsID.Text != "")
            {
                btnStockIn.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnStockIn.Enabled = false;
                btnUpdate.Enabled = false ;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            functionAdd();
            functionUpdate();
        }

        private void txtSales_Price_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtSales_Price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            if (supply_price == "Not for sale")
            {
                MessageBox.Show("Material " + txtName.Text + " is not for sale");
            }
            else
            {
                materials_stockin materials_Stockin = new materials_stockin();
                materials_Stockin.lblsupply_itemsID.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
                materials_Stockin.txtMaterials.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
                materials_Stockin.ShowDialog();
                RefreshDatabase();
                txtDescription.Text = "";
                txtName.Text = "";
                cboUnitMeasure.Text = "";
                txtSales_Price.Text = "";
                cboUnitMeasure.SelectedIndex = -1;
                btnUpdate.Enabled = false;
                btnStockIn.Enabled = false;
            }
        }

        private void cboUnitMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionAdd();
        }
    }
}
