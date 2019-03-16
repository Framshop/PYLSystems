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
    public partial class frmAddSupplierItems : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmAddSupplierItems()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmAddSupplierItems_Load(object sender, EventArgs e)
        {
            reload();
        }

        public void reload()
        {
            string query = "select sg.supply_categoryID, si.supply_itemsID, sg.categoryName,si.supplyName from supply_items si left join supply_category sg on sg.supply_categoryID = si.supply_categoryID";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgSupplies.DataSource = myDt;
            conn.Close();

            dgSupplies.Columns["supply_categoryID"].Visible = false;
            dgSupplies.Columns["Supply_itemsID"].Visible = false;
            dgSupplies.Columns["categoryName"].HeaderText = "Category Name";
            dgSupplies.Columns["supplyName"].HeaderText = "Supply Name";
 

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select sg.supply_categoryID, si.supply_itemsID, sg.categoryName,si.supplyName from supply_items si left join supply_category sg on sg.supply_categoryID = si.supply_categoryID where sg.supply_categoryID LIKE '%" + txtSearch.Text + "%' OR si.supply_itemsID LIKE '%" + txtSearch.Text + "%' OR si.supply_itemsID LIKE '%" + txtSearch.Text + "%' OR si.supplyName  LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand myComm = new MySqlCommand(query, conn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgSupplies.DataSource = myDt;
            conn.Close();
        }
    }
}
