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
    public partial class sales_materials : Form
    {
        public static float remainingItem = 0;
        public static string supply_itemsID = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public sales_materials()
        {
            InitializeComponent();
            FillSupplyItems();
        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT s_m.sales_materialsID,s_i.supplyName as 'Supply Name',s_m.quantity as 'Quantity',s_m.date_created 'Date Created' FROM sales_materials s_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_m.supply_itemsID WHERE s_i.supply_itemsID IS NOT NULL ORDER BY date_created DESC";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter Adp = new MySqlDataAdapter(comm);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);

            dgvDamage_Materials.DataSource = Dt;
            dgvDamage_Materials.Columns["sales_materialsID"].Visible = false;
            myConn.Close();



        }
        private void FillSupplyItems()
        {
            string myQuery = "SELECT * FROM supply_items WHERE sales_price > 0";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string supplyName = myReader.GetString(1);
                    cboSupply_Items.Items.Add(supplyName);
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

        private void cboSupply_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            validate();
            string myQuery = "SELECT * FROM supply_items WHERE supplyName = '" + cboSupply_Items.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string myId = myReader.GetString(0);
                    supply_itemsID = myId;

                    string sales_price = myReader.GetString(4);
                    txtSales_Price.Text = sales_price;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validateUpdate();
            myConn.Open();
            MySqlDataAdapter myAd;

            MySqlCommand myCom = new MySqlCommand("SELECT * FROM stockin_materials WHERE supply_itemID = " + supply_itemsID, myConn);
            myAd = new MySqlDataAdapter(myCom);
            DataTable myD = new DataTable();
            //ADD ----------
            myAd.Fill(myD);
            //ADD
            if (myD.Rows.Count > 0)
            {
                string myQuer = "SELECT s_i.supplyName as 'Material',IFNULL(s_m.StockInMaterials,0) as 'Stock In',IFNULL(d_m.DamagedMaterials,0) as 'Damaged Stocks',IFNULL(s_ma.SalesMaterials,0) as 'Sales Stock Out',IFNULL(s_m.StockInMaterials,0) - IFNULL(d_m.DamagedMaterials,0) - IFNULL(s_ma.SalesMaterials,0) 'Available Materials'FROM supply_items s_i LEFT JOIN (SELECT s_m.supply_itemsID,SUM(IFNULL(s_m.quantity,0)) as 'StockInMaterials' FROM stockin_materials s_m GROUP BY s_m.supply_itemsID) s_m ON s_i.supply_itemsID = s_m.supply_itemsID LEFT JOIN (SELECT d_m.supply_itemsID,SUM(IFNULL(d_m.quantity,0)) as 'DamagedMaterials' FROM damaged_materials d_m GROUP BY d_m.supply_itemsID) d_m ON d_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN (SELECT s_ma.supply_itemsID,SUM(IFNULL(s_ma.quantity,0)) as 'SalesMaterials' FROM sales_materials s_ma GROUP BY s_ma.supply_itemsID) s_ma ON s_ma.supply_itemsID = s_i.supply_itemsID WHERE s_m.StockInMaterials > 0";
                MySqlCommand myCo = new MySqlCommand(myQuer, myConn);
                MySqlDataReader myReader;
                try
                {
                    myConn.Open();
                    myReader = myCo.ExecuteReader();
                    while (myReader.Read())
                    {
                        remainingItem = myReader.GetFloat(4);
                    }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (remainingItem < Int32.Parse(txtQuantity.Text.ToString()))
                {
                    MessageBox.Show("Your input " + txtQuantity.Text + " has exceeded to the remaining item you selected which is only left of " + remainingItem);
                }
                else
                {
                    myConn.Open();
                    string myQuery = "INSERT INTO sales_materials(quantity,supply_itemsID,date_created) VALUES(" + txtQuantity.Text + "," + supply_itemsID + ",NOW())";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    myConn.Close();
                    MessageBox.Show("Insert Successful!");
                    RefreshDatabase();
                    cboSupply_Items.SelectedIndex = -1;
                    txtSales_Price.Text = "";
                    txtQuantity.Text = "";
                    supply_itemsID = "";
                }
            }
            else
            {
                MessageBox.Show("The material " + cboSupply_Items.Text + "doesn't have any stock in created");
            }
        }

        private void lblSales_Price_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmsales_materials_update materials_Update = new frmsales_materials_update();
            materials_Update.lblsupply_itemsID.Text = dgvDamage_Materials.CurrentRow.Cells[0].Value.ToString();
            materials_Update.txtMaterials.Text = dgvDamage_Materials.CurrentRow.Cells[1].Value.ToString();
            materials_Update.txtQuantity.Text = dgvDamage_Materials.CurrentRow.Cells[2].Value.ToString();
            materials_Update.ShowDialog();
            RefreshDatabase();
            supply_itemsID = "";
        }
        public void validateUpdate()
        {
            if (supply_itemsID != "")
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
        public void validate()
        {
            int quantity = txtQuantity.TextLength;
            int supply_items = cboSupply_Items.SelectedIndex;
            if (quantity > 0 && supply_items > 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void sales_materials_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void dgvDamage_Materials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validateUpdate();
            supply_itemsID = dgvDamage_Materials.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
