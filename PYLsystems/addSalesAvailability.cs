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
     

        int frameItemIDEdit;
        int itemQuantityEdit;
        int selectedAddSRowIndex;
        bool editMode;
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
        public addSalesAvailability(addSales addSalesPForm, int frameItemIDEdit, int itemQuantityEdit, int selectedAddSRowIndex)
        {
            InitializeComponent();
            this.addSalesPForm = addSalesPForm;
            this.frameItemIDEdit = frameItemIDEdit;
            editMode = true;
            this.itemQuantityEdit = itemQuantityEdit;
            this.selectedAddSRowIndex = selectedAddSRowIndex;

        }
        private void addSalesAvailability_Load(object sender, EventArgs e)
        {
            if (editMode) {
                editAddSalesAvail_Loader();
            }
            else { 
                addSalesAvail_Loader();
            }
        }
        //-------------Process and Calculation Methods--------------
        //Load default
        private void addSalesAvail_Loader() {
            try
            {
                this.frameInvGrid.DataSource = null;
                this.frameInvGrid.Rows.Clear();
                String frameAvailString = "SELECT FL.frameName AS Frame, FL.Dimension, fl.UnitSalesPrice AS 'Unit Price', IFNULL(FS.Stockin - (IFNULL(SOD.Stockout,0)),0) AS 'Quantity Left', " +
                    "FL.frameItemID FROM frame_list AS FL " +
                    "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS Stockin FROM framestock_in AS FS GROUP BY FS.frameItemID) " +
                    "AS FS ON FL.frameItemID = FS.frameItemID " +
                    "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD LEFT JOIN salesOrder AS SO ON SOD.sOrd_Num=SO.sOrd_Num WHERE SO.sOrd_status>0 GROUP BY SOD.frameItemID) " +
                    "AS SOD ON FL.frameItemID = SOD.frameItemID " +
                    "WHERE FL.active = '0' ORDER BY FL.frameName; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand frameAvail_command = new MySqlCommand(frameAvailString, my_conn);
                MySqlDataAdapter frameAvail_adapter = new MySqlDataAdapter(frameAvail_command);

                frameAvail_dt = new DataTable();
                frameAvail_adapter.Fill(frameAvail_dt);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            //frameAvailDefaultFilter = new DataView(frameAvail_dt);
            //frameAvailDefaultFilter.RowFilter = "sOrd_status = 0";
            frameInvGrid.DataSource = frameAvail_dt;
            frameInvGrid.Columns["frameItemID"].Visible = false;
            frameInvGrid.Columns["Unit Price"].DefaultCellStyle.Format = "0.00";
        }
        //Load Edit Mode
        private void editAddSalesAvail_Loader() {
            int rowIndex = 0;
            try
            {
                this.frameInvGrid.DataSource = null;
                this.frameInvGrid.Rows.Clear();
                String frameAvailString = "SELECT FL.frameName AS Frame, FL.Dimension, fl.UnitSalesPrice AS 'Unit Price', IFNULL(FS.Stockin - (IFNULL(SOD.Stockout,0)),0) AS 'Quantity Left', " +
                    "FL.frameItemID FROM frame_list AS FL " +
                    "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS Stockin FROM framestock_in AS FS GROUP BY FS.frameItemID) " +
                    "AS FS ON FL.frameItemID = FS.frameItemID " +
                    "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD LEFT JOIN salesOrder AS SO ON SOD.sOrd_Num=SO.sOrd_Num WHERE SO.sOrd_status>0 GROUP BY SOD.frameItemID) " +
                    "AS SOD ON FL.frameItemID = SOD.frameItemID " +
                    "WHERE FL.active = '0'; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand frameAvail_command = new MySqlCommand(frameAvailString, my_conn);
                MySqlDataAdapter frameAvail_adapter = new MySqlDataAdapter(frameAvail_command);

                frameAvail_dt = new DataTable();
                frameAvail_adapter.Fill(frameAvail_dt);
                rowIndex = 0;          
                //frameAvailDefaultFilter = new DataView(frameAvail_dt);
                //frameAvailDefaultFilter.RowFilter = "sOrd_status = 0";
                frameInvGrid.DataSource = frameAvail_dt;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < frameInvGrid.Rows.Count; i++)
            {
                //String comp = frameInvGrid.Rows[i].Cells["frameItemID"].Value.ToString();
                if (Int32.Parse(frameInvGrid.Rows[i].Cells["frameItemID"].Value.ToString()) == frameItemIDEdit)
                {
                    rowIndex = i;
                    //MessageBox.Show(rowIndex.ToString());
                }

            }
            frameInvGrid.ClearSelection();
            frameInvGrid.Columns["frameItemID"].Visible = false;
            frameInvGrid.Rows[rowIndex].Selected = true;

            quantityTextBox.Text = itemQuantityEdit.ToString();
        }
        //add
        private void addtoSalesPForm() {
            String frameName;
            String Dimension;
            double unitPrice;
            int frameItemID;
            int quantity;
            int quantityOfItem;
            int curRowIndex = frameInvGrid.SelectedRows[0].Index;
            //int firstRowIndex = frameInvGrid.SelectedRows.Count - 1;
            quantityOfItem = Int32.Parse(frameInvGrid.Rows[curRowIndex].Cells[3].Value.ToString());
            quantity = Int32.Parse(quantityTextBox.Text.ToString());
            //Validation
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
                int checkExist=0;
                int i;
                frameName = frameInvGrid.Rows[curRowIndex].Cells[0].Value.ToString();
                Dimension = frameInvGrid.Rows[curRowIndex].Cells[1].Value.ToString();
                unitPrice = Double.Parse(frameInvGrid.Rows[curRowIndex].Cells[2].Value.ToString());
                frameItemID = Int32.Parse(frameInvGrid.Rows[curRowIndex].Cells[4].Value.ToString());
                for (i = 0; i < addSalesPForm.frameItemsList.Count; i++) {
                    if (addSalesPForm.frameItemsList[i].frameItemID==frameItemID) {
                        checkExist = 1;
                        break;
                   }
                }
                if (checkExist == 1) {
                    int quantityChecker = addSalesPForm.frameItemsList[i].quantity + quantity;
                    if (quantityChecker > quantityOfItem) {
                        MessageBox.Show("Quantity exceeds Quantity Left");
                        return;
                    }
                    else { 
                        addSalesPForm.frameItemsList[i].quantity += quantity;
                    }
                }
                else { 
                    addSalesPForm.frameItemsList.Add(new frame_ItemsforList(frameName, Dimension, unitPrice, frameItemID, quantity));
                }
                //MessageBox.Show(addSalesPForm.frameItemsList[0].frameName + " " + addSalesPForm.frameItemsList[0].dimension + " " + addSalesPForm.frameItemsList[0].unitPrice + " " + addSalesPForm.frameItemsList[0].frameItemID);
                addSalesPForm.addSales_Refresher();
                //update textbox check if empty  recalculate everything if not empty January 31, 2019
                if (!string.IsNullOrEmpty(addSalesPForm.totalPaidTextBox.Text)) {

                }
                this.Close();
            }
        }
        //edit
        private void editToAddSalesPForm() {
            int curRowIndex = frameInvGrid.SelectedRows[0].Index;
            //int firstRowIndex = frameInvGrid.SelectedRows.Count - 1;
            int quantityOfItem = Int32.Parse(frameInvGrid.Rows[curRowIndex].Cells[3].Value.ToString());
            int quantity = Int32.Parse(quantityTextBox.Text.ToString());
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
                String frameName = frameInvGrid.Rows[curRowIndex].Cells[0].Value.ToString();
                String Dimension = frameInvGrid.Rows[curRowIndex].Cells[1].Value.ToString();
                int unitPrice = Int32.Parse(frameInvGrid.Rows[curRowIndex].Cells[2].Value.ToString());
                int frameItemID = Int32.Parse(frameInvGrid.Rows[curRowIndex].Cells[4].Value.ToString());
                addSalesPForm.frameItemsList[selectedAddSRowIndex].frameName = frameName;
                addSalesPForm.frameItemsList[selectedAddSRowIndex].dimension = Dimension;
                addSalesPForm.frameItemsList[selectedAddSRowIndex].unitPrice = unitPrice;
                addSalesPForm.frameItemsList[selectedAddSRowIndex].frameItemID = frameItemID;
                addSalesPForm.frameItemsList[selectedAddSRowIndex].quantity = quantity;
                //MessageBox.Show(selectedAddSRowIndex.ToString());
            }
            addSalesPForm.addSales_Refresher();
            this.Close();
        }
        //----------------Event Methods-----------------
        //Close Button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (editMode) {
                editToAddSalesPForm();
            }
            else
            {
                addtoSalesPForm();
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)frameInvGrid.DataSource).DefaultView.RowFilter = string.Format("Frame LIKE '%{0}%'", searchTextBox.Text);
        }
    }
}
