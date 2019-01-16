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
    public partial class addSalesAvailability : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        addSales addSalesPForm;
        DataTable frameAvail_dt;
        DataView frameAvailDefaultFilter;
        //--------------Initial Load--------------
        public addSalesAvailability()
        {
            InitializeComponent();
        }
        public addSalesAvailability(addSales addSalesPForm)
        {
            InitializeComponent();
            this.addSalesPForm = addSalesPForm;
        }
        private void addSalesAvailability_Load(object sender, EventArgs e)
        {
            addSalesAvail_Loader();
        }
        //-------------Process and Calculation Methods--------------
        //Load default
        private void addSalesAvail_Loader() {
            this.frameInvGrid.DataSource = null;
            this.frameInvGrid.Rows.Clear();
            String frameAvailString = "SELECT FL.frameName AS Frame, FL.Dimension, FL.UnitPrice AS 'Unit Price', IFNULL(FS.Stockin - SOD.Stockout, 0) AS 'Quantity Left', " +
                "FL.frameItemID FROM frame_list AS FL " +
                "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS Stockin FROM framestock_in AS FS GROUP BY FS.frameItemID) " +
                "AS FS ON FL.frameItemID = FS.frameItemID " +
                "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD GROUP BY SOD.frameItemID) " +
                "AS SOD ON FL.frameItemID = SOD.frameItemID " +
                "WHERE FL.active = 'active'; ";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand frameAvail_command = new MySqlCommand(frameAvailString, my_conn);
            MySqlDataAdapter frameAvail_adapter = new MySqlDataAdapter(frameAvail_command);

            frameAvail_dt = new DataTable();
            frameAvail_adapter.Fill(frameAvail_dt);

            frameAvailDefaultFilter = new DataView(frameAvail_dt);
            //frameAvailDefaultFilter.RowFilter = "sOrd_status = 0";
            frameInvGrid.DataSource = frameAvailDefaultFilter;
            frameInvGrid.Columns["frameItemID"].Visible = false;
        }
        private void addtoSalesPForm() {
            String frameName;
            String Dimension;
            String unitPrice;
            int frameItemID;
            int quantity;
            int quantityOfItem;
            int firstRowIndex = frameInvGrid.SelectedRows.Count - 1;
            quantityOfItem = Int32.Parse(frameInvGrid.SelectedRows[firstRowIndex].Cells[3].Value.ToString());
            quantity = Int32.Parse(quantityTextBox.Text.ToString());
            if (quantity == 0)
            {
                MessageBox.Show("Quantity cannot be zero");
                return;
            }
            else if (quantity > quantityOfItem)
            {
                MessageBox.Show("Quantity exceeds Quantity Left");
                return;
            }
            else { 
                frameName = frameInvGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
                Dimension = frameInvGrid.SelectedRows[firstRowIndex].Cells[1].Value.ToString();
                unitPrice = frameInvGrid.SelectedRows[firstRowIndex].Cells[2].Value.ToString();
                frameItemID = Int32.Parse(frameInvGrid.SelectedRows[firstRowIndex].Cells[4].Value.ToString());

                addSalesPForm.frameItemChanged.Add(new frame_ItemsforList(frameName, Dimension, unitPrice, frameItemID, quantity));

                MessageBox.Show(addSalesPForm.frameItemChanged[0].frameName + " " + addSalesPForm.frameItemChanged[0].dimension + " " + addSalesPForm.frameItemChanged[0].unitPrice + " " + addSalesPForm.frameItemChanged[0].frameItemID);
                addSalesPForm.addSales_Refresher();
                //this.Close();
            }
        }
        //----------------Event Methods-----------------
        //Close Button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addtoSalesPForm();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
