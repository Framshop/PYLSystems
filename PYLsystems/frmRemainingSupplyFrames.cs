﻿using System;
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
    public partial class frmRemainingSupplyFrames : Form
    {
        DataTable frameAvail_dt;
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmRemainingSupplyFrames()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillRemainingFrames()
        {
            myConn.Open();
            string query = "";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvFrames.DataSource = Dt;
            myConn.Close();
            dgvFrames.Columns["unitmeasure"].HeaderText = "Unit Measure";
            dgvFrames.Columns["unitmeasure"].Visible = false;
            dgvFrames.Columns["active"].HeaderText = "Active";
            dgvFrames.Columns["delivery_date"].HeaderText = "Delivery Date";
            dgvFrames.Columns["stockin_quantity"].HeaderText = "Stock In Quantity";
            dgvFrames.Columns["supply_price"].HeaderText = "Price";
            dgvFrames.Columns["supplyName"].HeaderText = "Supply Name";
            dgvFrames.Columns["supplierName"].HeaderText = "Supplier Name";
        }
        public void FillRemainingSupply()
        {
            myConn.Open();
            string query = "SELECT s.supplierName as 'Supplier Name',s_i.supplyName as 'Supply Name',SUM(s_d.stockin_quantity) as 'Supply Stock In',SUM(ifnull(quantity,0)) as 'Stock Out in Job Order',SUM(ifnull(f_m.stockout_quantity,0)) as 'Stock Out in Inventory',SUM(ifnull(f_m.stockout_quantity,0)) + SUM(ifnull(quantity,0)) as 'Overall Stock Out',SUM(s_d.stockin_quantity) - SUM(ifnull(f_m.stockout_quantity,0)) - SUM(ifnull(quantity,0)) as 'Remaining Supplies' FROM supply_details s_d LEFT JOIN jorder_details j_d ON s_d.supplyID = j_d.supply_itemsID LEFT JOIN frame_materials f_m ON f_m.supply_detailsID = s_d.supplierID LEFT JOIN supplier s ON s.supplierID = s_d.supplierID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID GROUP BY s_d.supplyID";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            dgvSupply.DataSource = Dt;
            for (int i = 0; i < dgvSupply.Rows.Count; i++)
            {
                if (float.Parse(dgvSupply.Rows[i].Cells[6].Value.ToString()) <= 0)
                {
                    dgvSupply.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else if (float.Parse(dgvSupply.Rows[i].Cells[6].Value.ToString()) >= 1 && float.Parse(dgvSupply.Rows[i].Cells[6].Value.ToString()) <= 20)
                {
                    dgvSupply.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgvSupply.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            myConn.Close();

        }
        private void addSalesAvail_Loader()
        {
            String frameAvailString = "SELECT FL.frameName AS Frame, FL.Dimension, FL.UnitPrice AS 'Unit Price', IFNULL(FS.Stockin - (IFNULL(SOD.Stockout,0)),0) AS 'Quantity Left', " +
            "FL.frameItemID FROM frame_list AS FL " +
            "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS Stockin FROM framestock_in AS FS GROUP BY FS.frameItemID) " +
            "AS FS ON FL.frameItemID = FS.frameItemID " +
            "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD LEFT JOIN salesOrder AS SO ON SOD.sOrd_Num=SO.sOrd_Num WHERE SO.sOrd_status>0 GROUP BY SOD.frameItemID) " +
            "AS SOD ON FL.frameItemID = SOD.frameItemID " +
            "WHERE FL.active = 'active' ORDER BY FL.frameName; ";
        MySqlCommand frameAvail_command = new MySqlCommand(frameAvailString, myConn);
        MySqlDataAdapter frameAvail_adapter = new MySqlDataAdapter(frameAvail_command);
        frameAvail_dt = new DataTable();
        frameAvail_adapter.Fill(frameAvail_dt);
            dgvFrames.DataSource = frameAvail_dt;
            for (int i = 0; i < dgvFrames.Rows.Count; i++)
            {
                if (float.Parse(dgvFrames.Rows[i].Cells[3].Value.ToString()) <= 0)
                {
                    dgvFrames.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else if (float.Parse(dgvFrames.Rows[i].Cells[3].Value.ToString()) >= 1 && float.Parse(dgvFrames.Rows[i].Cells[3].Value.ToString()) <= 20)
                {
                    dgvFrames.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgvFrames.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            dgvFrames.Columns["frameItemID"].Visible = false;
            dgvFrames.Columns["Unit Price"].DefaultCellStyle.Format = "0.00";
        }
        private void frmRemainingSupplyFrames_Load(object sender, EventArgs e)
        {
            FillRemainingSupply();
            addSalesAvail_Loader();
        }
    }
}
