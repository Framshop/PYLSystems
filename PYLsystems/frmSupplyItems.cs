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
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=");
        public frmSupplyItems()
        {
            InitializeComponent();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           
            myConn.Open();
            string myQuery = "INSERT INTO supply_items (supplyName, supplyDescription, unitMeasure) values('" + txtName.Text + "','" + txtDescription.Text + "','" + txtUnitMeasure.Text + "')";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Insert Successful!");
            RefreshDatabase();
            txtDescription.Text = "";
            txtName.Text = "";
            txtUnitMeasure.Text = "";
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT supply_itemsID,supplyName,supplyDescription,unitMeasure FROM supply_items";
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
            supplyItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myConn.Open();
            string myQuery = "UPDATE supply_items SET supplyName = '" + txtName.Text + "',supplyDescription =  " +
                "'" + txtDescription.Text + "', unitMeasure = '" + txtUnitMeasure.Text + "'WHERE supplyName = '" + lblNameUpdate.Text + "'AND supplyDescription = '" +
                lblDescriptionUpdate.Text + "' AND unitMeasure = '" + lblUnitMeasureUpdate.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Update Successful!");
            RefreshDatabase();
            txtDescription.Text = "";
            txtName.Text = "";
            txtUnitMeasure.Text = "";
        }

        private void supplyItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNameUpdate.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
            lblDescriptionUpdate.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
            lblUnitMeasureUpdate.Text = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();

            txtName.Text = supplyItemsGrid.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = supplyItemsGrid.CurrentRow.Cells[2].Value.ToString();
            txtUnitMeasure.Text = supplyItemsGrid.CurrentRow.Cells[3].Value.ToString();

            lblIDUpdate.Text = supplyItemsGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmSupplyItems_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT supply_itemID,supplyName,supplyDescription,unitMeasure FROM supply_items WHERE supplyName LIKE '%" + txtSearch.Text + "%' OR supplyDescription LIKE '%" + txtSearch.Text + "%' OR unitMeasure LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            supplyItemsGrid.DataSource = Dt;
            myConn.Close();
            supplyItemsGrid.Columns["supplierID"].Visible = false;
            supplyItemsGrid.Columns["supplierID"].HeaderText = "ID";
            supplyItemsGrid.Columns["supplierName"].HeaderText = "Name";
            supplyItemsGrid.Columns["supplierDetails"].HeaderText = "Details";
            supplyItemsGrid.Columns["contactDetails"].HeaderText = "Contact";
            supplyItemsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
           
        }
    }
}
