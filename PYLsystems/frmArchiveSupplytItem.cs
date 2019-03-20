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
    public partial class frmArchiveSupplytItem : Form
    {
        public static string supplier = "";
        public static string supplyItemID = "";

        public static string supply_categoryID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmArchiveSupplytItem()
        {
            InitializeComponent();
        }

        private void frmArchiveSupplytItem_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT s.supplierID,sr_i.supply_itemsID,s.supplierName as 'Supplier Name',s_i.supplyName as 'Supply Name',s_i.supplyDescription as 'Supply Description' FROM supplier_items sr_i LEFT JOIN supply_items s_i ON s_i.supply_itemsID = sr_i.supply_itemsID LEFT JOIN supplier s ON s.supplierID = sr_i.supplierID WHERE sr_i.active = 1";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgSupplyItem.DataSource = dt;
            myConn.Close();
            //supply_categoryID = dgSupplyItem.CurrentRow.Cells[0].Value.ToString();

       
            dgSupplyItem.Columns["supplierID"].Visible = false;
            dgSupplyItem.Columns["supply_itemsID"].Visible = false;

        }

        private void dgSupplyItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierID.Text = dgSupplyItem.CurrentRow.Cells[0].Value.ToString();
            supplyItemID = dgSupplyItem.CurrentRow.Cells[1].Value.ToString();
            btnReturn.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string myQuery = "update supplier_items set active = 0 where supplierID =  " + supplierID.Text + " AND supply_itemsID =" + supplyItemID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            myConn.Close();
            MessageBox.Show("Success");
            RefreshDatabase();
            btnReturn.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT s.supplierID,sr_i.supply_itemsID,s.supplierName as 'Supplier Name',s_i.supplyName as 'Supply Name',s_i.supplyDescription as 'Supply Description' FROM supplier_items sr_i LEFT JOIN supply_items s_i ON s_i.supply_itemsID = sr_i.supply_itemsID LEFT JOIN supplier s ON s.supplierID = sr_i.supplierID WHERE supplierName LIKE  '%" + txtSearch.Text + "%' AND sr_i.active = 1";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgSupplyItem.DataSource = dt;
            myConn.Close();
            //supply_categoryID = dgSupplyItem.CurrentRow.Cells[0].Value.ToString();


            dgSupplyItem.Columns["supplierID"].Visible = false;
            dgSupplyItem.Columns["supply_itemsID"].Visible = false;
        }
    }
}
