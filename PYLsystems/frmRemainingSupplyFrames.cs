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
    public partial class frmRemainingSupplyFrames : Form
    {
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
            string query = "SELECT s.supplierName as 'supplierName',s_i.supplyName as 'supplyName',s_d.supply_price as 'supply_price',s_d.stockin_quantity as 'StockInSupply',SUM(f_m.stockout_quantity) as 'StockOutSupply',SUM(s_d.stockin_quantity - f_m.stockout_quantity) as 'AvailableSupply' FROM frame_materials f_m LEFT JOIN supply_details s_d ON s_d.supplyID = f_m.supply_detailsID LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supplier s ON s.supplierID = s_d.supplierID GROUP BY s_d.supplyID ORDER BY 'AvailableSupply' ";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            dgvSupply.DataSource = Dt;
            for (int i = 0; i < dgvSupply.Rows.Count; i++)
            {
                if (float.Parse(dgvSupply.Rows[i].Cells[5].Value.ToString()) <= 0)
                {
                    dgvSupply.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                if (float.Parse(dgvSupply.Rows[i].Cells[5].Value.ToString()) >= 1 && float.Parse(dgvSupply.Rows[i].Cells[5].Value.ToString()) <= 20)
                {
                    dgvSupply.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else
                {
                    dgvSupply.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            myConn.Close();
            dgvSupply.Columns["suppliername"].HeaderText = "Supplier Name";
            dgvSupply.Columns["supply_price"].HeaderText = "Supply Price";
            dgvSupply.Columns["supplyname"].HeaderText = "Supply Name";
            dgvSupply.Columns["stockinsupply"].HeaderText = "Stock In Supply";
            dgvSupply.Columns["stockoutsupply"].HeaderText = "Stock Out Supply";
            dgvSupply.Columns["availablesupply"].HeaderText = "Available Supply";
           
        }


        private void frmRemainingSupplyFrames_Load(object sender, EventArgs e)
        {
            FillRemainingSupply();
        }
    }
}
