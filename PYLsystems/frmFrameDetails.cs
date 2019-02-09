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
    public partial class frmFrameDetails : Form
    {
        public static string frameItemID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmFrameDetails()
        {
            InitializeComponent();
        }

        private void frmFrameDetails_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }
        public void RefreshDatabase()
        {
            functionEnable();
            myConn.Open();
            string query = "SELECT f_i.frameItemID,f_l.frameName,f_i.stockinQuantity,f_l.unitprice,f_l.dimension, f_i.dateStockIn,IFNULL(dateModified,'N / A') as 'dateModified' FROM framestock_in f_i LEFT JOIN frame_list f_l ON f_l.frameItemID = f_i.frameItemID ";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvFrameStockInDetails.DataSource = Dt;
            myConn.Close();
            dgvFrameStockInDetails.Columns["frameItemID"].Visible = false;
            dgvFrameStockInDetails.Columns["frameItemID"].HeaderText = "Frame Item ID";
            dgvFrameStockInDetails.Columns["stockinQuantity"].HeaderText = "Stock In Quantity";
            dgvFrameStockInDetails.Columns["frameName"].HeaderText = "Frame Name";
            dgvFrameStockInDetails.Columns["dimension"].HeaderText = "Dimension";
            dgvFrameStockInDetails.Columns["unitprice"].HeaderText = "Unit Price";
            dgvFrameStockInDetails.Columns["dateStockIn"].HeaderText = "Date Stock In";
            dgvFrameStockInDetails.Columns["dateModified"].HeaderText = "Date Modified";
        }

        private void dgvFrameStockInDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frameItemID = dgvFrameStockInDetails.CurrentRow.Cells[0].Value.ToString();
                lblSupplyName.Text = dgvFrameStockInDetails.CurrentRow.Cells[1].Value.ToString();
                functionEnable();
                myConn.Open();
                string query = "SELECT s_d.supplyID,f_m.frame_materialsID,s.suppliername, s_i.supplyName, f_m.stockout_quantity, f_m.unittype, f_m.fixedQuantity FROM frame_materials f_m LEFT JOIN supply_details s_d ON s_d.supplyID=f_m.supply_detailsID LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supplyID LEFT JOIN frame_list f_l ON f_l.frameItemID = f_m.frameItemID WHERE f_l.frameItemID = " + frameItemID;
                MySqlCommand comm = new MySqlCommand(query, myConn);
                MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);

                dgvSupply.DataSource = Dt;
                myConn.Close();
                dgvSupply.Columns["frame_materialsID"].Visible = false;
                dgvSupply.Columns["frame_materialsID"].HeaderText = "Frame Materials ID";
                dgvSupply.Columns["supplyID"].Visible = false;
                dgvSupply.Columns["supplyID"].HeaderText = "Supply ID";
                dgvSupply.Columns["suppliername"].HeaderText = "Supplier Name";
                dgvSupply.Columns["supplyname"].HeaderText = "Supply Name";
                dgvSupply.Columns["stockout_quantity"].HeaderText = "Stock Out Quantity";
                dgvSupply.Columns["unittype"].HeaderText = "Unit Type";
                dgvSupply.Columns["fixedquantity"].HeaderText = "Fixed Quantity";
            }
            catch (Exception ex)
            {

            }
        }
        public void functionEnable()
        {
            if (lblSupplyName.Text != "")
            {
                btnFrameUpdate.Enabled = true;
            }
            else
            {
                btnFrameUpdate.Enabled = false;
            }
           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFrameAdd_Click(object sender, EventArgs e)
        {
            frmFrameStockInSupplyStockOut frameStockInSupplyStockOut = new frmFrameStockInSupplyStockOut();
            frameStockInSupplyStockOut.ShowDialog();
        }

        private void btnFrameUpdate_Click(object sender, EventArgs e)
        {
            frmFrameStockInUpdate stockInUpdate = new frmFrameStockInUpdate();
            stockInUpdate.txtFrameName.Text = dgvFrameStockInDetails.CurrentRow.Cells[1].Value.ToString();
            stockInUpdate.lblFrameItemID.Text = dgvFrameStockInDetails.CurrentRow.Cells[0].Value.ToString();

            string myQuery = "SELECT s_d.supplyID,f_m.frame_materialsID,s.suppliername, s_i.supplyName, f_m.stockout_quantity, f_m.unittype, f_m.fixedQuantity FROM frame_materials f_m LEFT JOIN supply_details s_d ON s_d.supplyID=f_m.supply_detailsID LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supplyID LEFT JOIN frame_list f_l ON f_l.frameItemID = f_m.frameItemID WHERE f_l.frameItemID = " + frameItemID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string frameList = myReader.GetString(1);
                    string fixed_quantity = myReader.GetString(6);
                    stockInUpdate.cboFrame_materials.Items.Add(frameList);
                    stockInUpdate.cboFixedQuantity.Items.Add(fixed_quantity);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            stockInUpdate.ShowDialog();
            RefreshDatabase();
            lblSupplyName.Text = "";
            frameItemID = "";


            this.dgvSupply.DataSource = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            functionEnable();
            myConn.Open();
            string query = "SELECT f_i.frameItemID,f_l.frameName,f_i.stockinQuantity,f_l.unitprice,f_l.dimension, f_i.dateStockIn,IFNULL(dateModified,'N / A') as 'dateModified' FROM framestock_in f_i LEFT JOIN frame_list f_l ON f_l.frameItemID = f_i.frameItemID  WHERE f_l.frameName LIKE '%" + txtSearch.Text + "%' OR f_i.stockinQuantity LIKE '%" + txtSearch.Text + "%' OR f_l.unitprice LIKE '%" + txtSearch.Text + "%' OR f_l.dimension LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvFrameStockInDetails.DataSource = Dt;
            myConn.Close();
            dgvFrameStockInDetails.Columns["frameItemID"].Visible = false;
            dgvFrameStockInDetails.Columns["frameItemID"].HeaderText = "Frame Item ID";
            dgvFrameStockInDetails.Columns["stockinQuantity"].HeaderText = "Stock In Quantity";
            dgvFrameStockInDetails.Columns["frameName"].HeaderText = "Frame Name";
            dgvFrameStockInDetails.Columns["dimension"].HeaderText = "Dimension";
            dgvFrameStockInDetails.Columns["unitprice"].HeaderText = "Unit Price";
            dgvFrameStockInDetails.Columns["dateStockIn"].HeaderText = "Date Stock In";
            dgvFrameStockInDetails.Columns["dateModified"].HeaderText = "Date Modified";
        }
    }
}
