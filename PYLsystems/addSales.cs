using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
namespace PYLsystems
{
    public partial class addSales : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        // private int sample;
        checkSales checkSalesPForm;
        private DataTable addSalesDT;
        internal List<frame_ItemsforList> frameItemsList;
        double rawTotal;
        double trueTotal;
        int employeeId;
        //--------------Initial Load--------------
        public addSales()
        {
            InitializeComponent();
        }
        public addSales(checkSales ParentForm,int employeeId)
        {
            InitializeComponent();
            checkSalesPForm = ParentForm;
            this.employeeId = employeeId;
        } 
        private void addSales_Load(object sender, EventArgs e)
        {
            addSales_Loader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void addSales_Loader() {
            frameItemsList = new List<frame_ItemsforList>();
            addSalesDT = new DataTable();
            addSalesDT.Columns.Add("Item");
            addSalesDT.Columns.Add("Dimension");
            addSalesDT.Columns.Add("Quantity");
            addSalesDT.Columns.Add("Unit Price");
            addSalesDT.Columns.Add("Total");
            addSalesGrid.DataSource = addSalesDT;

            String receiptNumberPrevString = "SELECT sOrd_Num FROM salesOrder WHERE sOrd_Num=(SELECT MAX(sOrd_Num) FROM salesOrder); ";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand receiptNumberPrev_command = new MySqlCommand(receiptNumberPrevString, my_conn);
            MySqlDataAdapter receiptNumberPrev_adapter = new MySqlDataAdapter(receiptNumberPrev_command);

            DataTable receiptNumberPrev_dt = new DataTable();
            receiptNumberPrev_adapter.Fill(receiptNumberPrev_dt);
            int receiptNum = Int32.Parse(receiptNumberPrev_dt.Rows[0][0].ToString())+1;

            this.receiptTextBox.Text =receiptNum.ToString("0000000");
            //frameAvailDefaultFilter = new DataView(frameAvail_dt);
            //frameAvailDefaultFilter.RowFilter = "sOrd_status = 0";

        }
        /*private void addSales_dtColumns() {
            addSalesDT.Columns.Add("Item");
            addSalesDT.Columns.Add("Dimension");
            addSalesDT.Columns.Add("Quantity");
            addSalesDT.Columns.Add("Unit Price");
            addSalesDT.Columns.Add("Total");
        }*/
        //Refresh
        internal void addSales_Refresher() {
            this.addSalesGrid.DataSource = null;
            this.addSalesGrid.Rows.Clear();
            this.addSalesDT.Clear();
            DataRow addSalesRow = null;
            double Total=0;
            double totalRaw=0;
            for (int i = 0; i < frameItemsList.Count;i++) {
                Total = calculateTotalpItem(frameItemsList[i].quantity, frameItemsList[i].unitPrice);
                addSalesRow = addSalesDT.NewRow();
                addSalesRow["Item"] = frameItemsList[i].frameName;
                addSalesRow["Dimension"] = frameItemsList[i].dimension;
                addSalesRow["Quantity"] = frameItemsList[i].quantity;
                addSalesRow["Unit Price"] = frameItemsList[i].unitPrice;
                addSalesRow["Total"] = Total;
                addSalesDT.Rows.Add(addSalesRow);
                totalRaw += Total;
            }
            this.addSalesGrid.DataSource = addSalesDT;
            addSalesGrid.Columns["Unit Price"].DefaultCellStyle.Format = "0.00";

            rawTotalTextBox.Text = totalRaw.ToString("0.00");
            trueTotalTextBox.Text = totalRaw.ToString("0.00");
            rawTotal = totalRaw;
            //January 16, 2019 edit note: finish method to refresh addSales form once AddSalesAvailability adds item. Refresh shall
            //base on List frameItemsList to fill datatable and grid.-----Done
            //Next to-do is to add edit method to open addSalesAvailability and replace currently selected row.--Done
            //--calculate totalPrice=unitPrice*quantity---Done
            //--calculate total prices---Done
            //--calculate Discounted Total = total-discount---Done
            //--get total paid---Done
            //--insert using list with for loop--Done
        }
        //Get FrameItemID
        private int getFrameID(String frameName, String Dimension) {
            int frameItemID = 0;
            return frameItemID;
        }
        //Calculate ItemPriceTotal=unitPrice*Quantity
        private double calculateTotalpItem(int Quantity, double UnitPrice) {
            double Total = ((double)Quantity)*UnitPrice;
            return Total;
        }
        //addSalesAvailabilityForNewItem
        private void newItem() {
            addSalesAvailability AvailabilityForm = new addSalesAvailability(this);
            AvailabilityForm.ShowDialog();
        }
        //addSalesAvailabilityForEditItem
        private void editItem(int frameItemIDEdit, int itemQuantityEdit, int rowIndex) {
            addSalesAvailability AvailabilityForm = new addSalesAvailability(this,frameItemIDEdit,itemQuantityEdit,rowIndex);
            AvailabilityForm.ShowDialog();
        }
        //Delete Item along with it in the list
        private void deleteItem(int listIndex) {
            frameItemsList.RemoveAt(listIndex);
        }
        internal void insertToSalesOrder() {
            int sOrd_Num;
            int finalDiscount;
            //MessageBox.Show(employeeId.ToString());
            
            String addSalesOrderString = "INSERT INTO salesOrder (sOrd_Date,sOrd_totalPaid,employeeID,discount,sOrd_Status) VALUES " +
                "(NOW(),@sOrd_TotalPaid,@employeeID,@discount,1);";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand addSalesOrdercommand = new MySqlCommand(addSalesOrderString, my_conn);
            addSalesOrdercommand.Parameters.AddWithValue("@sOrd_TotalPaid", totalPaidTextBox.Text);
            addSalesOrdercommand.Parameters.AddWithValue("@employeeID", employeeId);
            if (discountTextBox.Text == "")
            {
                finalDiscount = 0;
                addSalesOrdercommand.Parameters.AddWithValue("@discount", finalDiscount);
            }
            else {
                addSalesOrdercommand.Parameters.AddWithValue("@discount", discountTextBox.Text);
            }
            MySqlDataReader dataReader;
            my_conn.Open();
            dataReader = addSalesOrdercommand.ExecuteReader();
            while (dataReader.Read())
            {
            }
            my_conn.Close();
            String sOrdNum_getString = "SELECT sOrd_Num FROM salesOrder WHERE sOrd_Num = (SELECT MAX(sOrd_Num) FROM salesOrder);";
            MySqlCommand sOrdNum_getCommand = new MySqlCommand(sOrdNum_getString, my_conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(sOrdNum_getCommand);

            DataTable sOrdNum_dt = new DataTable();
            my_adapter.Fill(sOrdNum_dt);
            sOrd_Num = Int32.Parse(sOrdNum_dt.Rows[0][0].ToString());
            insertToSOrdDet(sOrd_Num);
            //January 18, 2019 Finish insertToSalesOrder after redoing checkCancelled methods in checkSales
        }
        private void insertToSOrdDet(int sOrd_Num) {
            StringBuilder addSOrderDetString = new StringBuilder("INSERT INTO sOrder_Details (sOrd_Num, frameItemID, sOrd_UnitPrice, sOrd_Quantity) VALUES ");
            using (MySqlConnection my_conn = new MySqlConnection(connString))
            {
                List<string> frameItemsAdd = new List<string>();
                for (int i = 0; i < frameItemsList.Count; i++)
                {
                    frameItemsAdd.Add(string.Format("('{0}','{1}','{2}','{3}')",
                        MySqlHelper.EscapeString(sOrd_Num.ToString()),
                        MySqlHelper.EscapeString(frameItemsList[i].frameItemID.ToString()),
                        MySqlHelper.EscapeString(frameItemsList[i].unitPrice.ToString()),
                        MySqlHelper.EscapeString(frameItemsList[i].quantity.ToString())));
                }
                addSOrderDetString.Append(string.Join(",", frameItemsAdd));
                addSOrderDetString.Append(";");
                my_conn.Open();
                using (MySqlCommand addSalesO_command = new MySqlCommand(addSOrderDetString.ToString(), my_conn))
                {
                    addSalesO_command.CommandType = CommandType.Text;
                    addSalesO_command.ExecuteNonQuery();
                }
            }
        }
        //----------------Event Methods-----------------
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSalesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int curRowIndex = addSalesGrid.SelectedRows[0].Index;
            //int eaafirstRowsdfIndex = addSalesGrid.SelectedRows.Count - 1;
            //MessageBox.Show(e.RowIndex.ToString());
            //MessageBox.Show(addSalesGrid.Rows.Count.ToString());
            if (addSalesGrid.Rows[curRowIndex].Cells[0].Value.ToString() == String.Empty && addSalesGrid.Rows[curRowIndex].Cells[1].Value.ToString() == String.Empty
                && addSalesGrid.Rows[curRowIndex].Cells[2].Value.ToString() == String.Empty && addSalesGrid.Rows[curRowIndex].Cells[3].Value.ToString() == String.Empty)
            {
                newItem();
            }
            else if (addSalesGrid.Rows[curRowIndex].Cells[0].Value == null && addSalesGrid.Rows[curRowIndex].Cells[1].Value == null
                 && addSalesGrid.Rows[curRowIndex].Cells[2].Value == null && addSalesGrid.Rows[curRowIndex].Cells[3].Value == null)
            {
                newItem();
            }
            else {               
                editItem(frameItemsList[e.RowIndex].frameItemID,frameItemsList[e.RowIndex].quantity,e.RowIndex);
            }
           
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            newItem();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int curRowIndex = addSalesGrid.SelectedRows[0].Index;
             if (addSalesGrid.CurrentCell == null)
            {
                MessageBox.Show("Can't edit item.");
            }
            else if (addSalesGrid.Rows[curRowIndex].Cells[0].Value == null && addSalesGrid.Rows[curRowIndex].Cells[1].Value == null
               && addSalesGrid.Rows[curRowIndex].Cells[2].Value  == null && addSalesGrid.Rows[curRowIndex].Cells[3].Value == null)
            {
                MessageBox.Show("Can't edit item.");
            }
           
            else {
                //MessageBox.Show((addSalesGrid.RowCount-1).ToString());
                editItem(frameItemsList[curRowIndex].frameItemID, frameItemsList[curRowIndex].quantity, curRowIndex);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //int firstRowIndex = addSalesGrid.SelectedRows.Count - 1;
            //MessageBox.Show(addSalesGrid.CurrentCell.RowIndex.ToString());
            int curRowIndex = addSalesGrid.SelectedRows[0].Index;
            deleteItem(curRowIndex);
            addSales_Refresher();
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            //TrueTotal=RawTotal-Discount
            double Discount;
            if (discountTextBox.Text.ToString() == "")
            {
                Discount = 0;
            }
            else if (discountTextBox.Text.ToString() == ".")
            {
                Discount = 0.0;
            }
            else {
                Discount = Double.Parse(discountTextBox.Text.ToString());
            }
            double trueTotal = rawTotal - Discount;
            trueTotalTextBox.Text = trueTotal.ToString("0.00");
            this.trueTotal = trueTotal;
        }

        private void discountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
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

        private void totalPaidTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (addSalesGrid.Rows[0].Cells[0].Value == null && addSalesGrid.Rows[0].Cells[1].Value == null
               && addSalesGrid.Rows[0].Cells[2].Value == null && addSalesGrid.Rows[0].Cells[3].Value == null) {
                MessageBox.Show("Item List cannot be empty.");
                return;
            }
            else if (totalPaidTextBox.Text=="") {
                MessageBox.Show("Must input Customer payment.");
                return;
            }
            else {
                addSalesConfirm ConfirmWin = new addSalesConfirm(this);
                ConfirmWin.ShowDialog();
                checkSalesPForm.checkSales_Loader();
                this.Close();
            }
        }

        private void totalPaidTextBox_TextChanged(object sender, EventArgs e)
        {
            //Paid-trueTotal=Change;
            double change;
            double Paid;
            if (totalPaidTextBox.Text.ToString() == "")
            {
                Paid = 0;
            }
            else if (totalPaidTextBox.Text.ToString() == ".")
            {
                Paid = 0.0;
            }
            else
            {
                Paid = Double.Parse(totalPaidTextBox.Text.ToString());
            }
            change = Paid - this.trueTotal;
            changeTextBox.Text = change.ToString("0.00");
        }
    }
    class frame_ItemsforList
    {
        internal String frameName { get; set; }
        internal String dimension { get; set; }
        internal double unitPrice { get; set; }
        internal int frameItemID { get; set; }
        internal int quantity { get; set; }
       // public frame_ItemsforList() {
        //}
        public frame_ItemsforList(String frameName, String dimension, double unitPrice, int frameItemID, int quantity)
        {
            this.frameName = frameName;
            this.dimension = dimension;
            this.unitPrice = unitPrice;
            this.frameItemID = frameItemID;
            this.quantity = quantity;
        }

    }
}
