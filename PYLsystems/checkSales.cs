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
    public partial class checkSales : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        DataTable salesOrderdt;
        DataView sOrdDefaultFilter;
        //--------------Initial Load--------------
        public checkSales()
        {
            InitializeComponent();
        }       
        private void checkSales_Load(object sender, EventArgs e)
        {
            checkSales_Loader();
        }

        //-------------Process and Calculation Methods--------------
        //Sales Orders Loader
        private void checkSales_Loader()
        {
            
            this.salesOrdersGrid.DataSource = null;
            this.salesOrdersGrid.Rows.Clear();
            String salesOrderString = "SELECT sOrd_Num AS \"Receipt Number\", sOrd_Date AS \"Date\", " +
                "DATE(sOrd_Date) AS \"datePick\", sOrd_status from salesOrder";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand salesOrdList_command = new MySqlCommand(salesOrderString, my_conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(salesOrdList_command);

            salesOrderdt = new DataTable();
            my_adapter.Fill(salesOrderdt);

            sOrdDefaultFilter = new DataView(salesOrderdt);
            sOrdDefaultFilter.RowFilter = "sOrd_status = 0";
            salesOrdersGrid.DataSource = sOrdDefaultFilter;
            salesOrdersGrid.Columns["sOrd_status"].Visible = false;
            salesOrdersGrid.Columns["datePick"].Visible = false;
        }
        //DateFilters
        private void checkSalesFilterDate_Loader(String date, int startOrEnd){
            String FilterStringComparison;
            if (startOrEnd == 0)
            {
                FilterStringComparison = " AND datePick>= #";
                //Replace
                if (sOrdDefaultFilter.RowFilter.Contains(FilterStringComparison)) {
                    int indexOfDateFilter = sOrdDefaultFilter.RowFilter.IndexOf(FilterStringComparison)+(FilterStringComparison.Length);
                    String FilterStringReplacement= sOrdDefaultFilter.RowFilter.Substring(indexOfDateFilter,10);
                    sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison + FilterStringReplacement,FilterStringComparison + date);
                }
                //Append
                else {
                    sOrdDefaultFilter.RowFilter += FilterStringComparison + date + "#";
                }
                
            }
            else if (startOrEnd == 1)
            {
                FilterStringComparison = " AND datePick<= #";
                //Replace
                if (sOrdDefaultFilter.RowFilter.Contains(FilterStringComparison))
                {
                    int indexOfDateFilter = sOrdDefaultFilter.RowFilter.IndexOf(FilterStringComparison) + (FilterStringComparison.Length);
                    String FilterStringReplacement = sOrdDefaultFilter.RowFilter.Substring(indexOfDateFilter, 10);
                    sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison + FilterStringReplacement, FilterStringComparison + date);
                }
                //Append
                else
                {
                    sOrdDefaultFilter.RowFilter += FilterStringComparison + date + "#";
                }
            }
            salesOrdersGrid.Update();
            salesOrdersGrid.Refresh();
        }
        private void checkSalesFilterDate_Loader(String Start, String End, int startOrEnd)
        {
            String FilterStringComparison;
            if (startOrEnd == 0)
            {
                FilterStringComparison = " AND datePick<= #";
                //Replace
                if (sOrdDefaultFilter.RowFilter.Contains(FilterStringComparison))
                {
                    int indexOfDateFilter = sOrdDefaultFilter.RowFilter.IndexOf(FilterStringComparison) + (FilterStringComparison.Length);
                    String FilterStringReplacement = sOrdDefaultFilter.RowFilter.Substring(indexOfDateFilter, 10);
                    sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison + FilterStringReplacement, FilterStringComparison + End);
                }
                //Append
                else
                {
                    sOrdDefaultFilter.RowFilter += FilterStringComparison + End + "#";
                }
            }
            else if (startOrEnd == 1)
            {
                FilterStringComparison = " AND datePick>= #";
                
                //Replace
                if (sOrdDefaultFilter.RowFilter.Contains(FilterStringComparison))
                {
                    int indexOfDateFilter = sOrdDefaultFilter.RowFilter.IndexOf(FilterStringComparison) + (FilterStringComparison.Length);
                    String FilterStringReplacement = sOrdDefaultFilter.RowFilter.Substring(indexOfDateFilter, 10);
                    sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison + FilterStringReplacement, FilterStringComparison + Start);
                }
                //Append
                else
                {
                    sOrdDefaultFilter.RowFilter += FilterStringComparison + Start + "#";
                }
            }
            salesOrdersGrid.Update();
            salesOrdersGrid.Refresh();
        }
        //Check Cancelled Sales Orders
        private void checkSalesCancelled() {
            String FilterStringComparison; 
            //Replace
            if (hideActiveSOCheckB.Checked) {
                FilterStringComparison = "sOrd_status > 1";
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison, "sOrd_status = 1");
            }
            else if (!hideActiveSOCheckB.Checked)
            {
                FilterStringComparison = "sOrd_status = 0";
                if (!sOrdDefaultFilter.RowFilter.Contains(FilterStringComparison))
                {
                    FilterStringComparison = "sOrd_status > 1";
                }
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison, "sOrd_status >= 0");
            }

            salesOrdersGrid.Update();
            salesOrdersGrid.Refresh();
        }
        private void hideActiveSalesOrders() {
            String FilterStringComparison;
            //Replace
            if (shCancelSOCheckB.Checked)
            {
                FilterStringComparison = "sOrd_status >= 0";
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison, "sOrd_status = 1");
            }
            else if (!shCancelSOCheckB.Checked)
            {
                FilterStringComparison = "sOrd_status = 0";
                if (!sOrdDefaultFilter.RowFilter.Contains(FilterStringComparison)) {
                    FilterStringComparison = "sOrd_status >= 0";
                }
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace(FilterStringComparison, "sOrd_status > 1");
            }
            salesOrdersGrid.Update();
            salesOrdersGrid.Refresh();
        }
        //Return DateTime
        /*private String getDateTimePicker(int startOrEnd) {
            String Datetime="";
            if (startOrEnd == 0)
            {
                Datetime = startDatePicker.Value.ToString("yyyy/MM/dd H:mm:ss");
            }
            else if (startOrEnd == 1) {
                Datetime = endDatePicker.Value.ToString("yyyy/MM/dd H:mm:ss");
            }
            return Datetime;
        }*/
        private String getDateTimePicker(int startOrEnd)
        {
            String Datetime = "";
            if (startOrEnd == 0)
            {
                Datetime = startDatePicker.Value.ToString("yyyy/MM/dd");
            }
            else if (startOrEnd == 1)
            {
                Datetime = endDatePicker.Value.ToString("yyyy/MM/dd");
            }
            return Datetime;
        }
        //DateStringRemover
        private void dateStringRemover(int startOrEnd) {
            String FilterStringComparison;
            if (startOrEnd == 0)
            {
                FilterStringComparison = " AND datePick<= #";
                //Remove
                int indexOfDateFilter = sOrdDefaultFilter.RowFilter.IndexOf(FilterStringComparison);
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Remove(indexOfDateFilter,
                    FilterStringComparison.Length + 11);
            }
            else if (startOrEnd == 1) {
                FilterStringComparison = " AND datePick>= #";
                //Remove
                int indexOfDateFilter = sOrdDefaultFilter.RowFilter.IndexOf(FilterStringComparison);
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Remove(indexOfDateFilter,
                    FilterStringComparison.Length + 11);
            }
        }
        //Sales Orders Details Loader
        private void salesOrderDetGrid_Loader(int sOrd_Num)
        {
            //Datagridview load
            int rawTotal = 0;
            int discountTotal = 0;
            String salesOrderDetails = "SELECT FL.frameName AS Item, FL.Dimension, SOD.sOrd_Quantity AS Quantity, SOD.sOrd_UnitPrice AS 'Unit Price', SOD.frameItemID, SOD.sOrd_DetailsID FROM sOrder_Details as SOD " +
                "LEFT JOIN frame_list AS FL ON SOD.frameItemID = FL.frameItemID " +
                "WHERE sOrd_Num = @sOrd_Num; ";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand salesOrdDet_command = new MySqlCommand(salesOrderDetails, my_conn);
            salesOrdDet_command.Parameters.AddWithValue("@sOrd_Num", sOrd_Num);

            MySqlDataAdapter salesOrdDet_adapter = new MySqlDataAdapter(salesOrdDet_command);
            DataTable salesOrdDet_dt = new DataTable();
            salesOrdDet_adapter.Fill(salesOrdDet_dt);

            sOrdDetGrid.DataSource = salesOrdDet_dt;
            sOrdDetGrid.Columns["Dimension"].ReadOnly = true;
            sOrdDetGrid.Columns["Quantity"].ReadOnly = true;
            sOrdDetGrid.Columns["Unit Price"].ReadOnly = true;
            sOrdDetGrid.Columns["frameItemID"].Visible = false;
            sOrdDetGrid.Columns["sOrd_DetailsID"].Visible = false;
            //Totals
            for (int i = 0; i < salesOrdDet_dt.Rows.Count; i++)
            {
                DataRow salesOrdDet_dRows = salesOrdDet_dt.Rows[i];
                rawTotal += Int32.Parse(salesOrdDet_dRows["Quantity"].ToString()) * Int32.Parse(salesOrdDet_dRows["Unit Price"].ToString());
            }
            String totalsString = "SELECT SO.sOrd_Num,SO.sOrd_Date,SO.sOrd_totalPaid,SO.discount,SO.employeeID," +
                                    "CONCAT(emp.lastName,', ',emp.firstName) AS EmpName " +
                                    "FROM salesOrder AS SO " +
                                    "LEFT JOIN Employee AS emp ON SO.employeeID = emp.employeeID " +
                                    "WHERE SO.sOrd_Num = @sOrd_Num; ";
            MySqlCommand totalsString_command = new MySqlCommand(totalsString, my_conn);
            totalsString_command.Parameters.AddWithValue("@sOrd_Num", sOrd_Num);

            MySqlDataAdapter totalsString_adapter = new MySqlDataAdapter(totalsString_command);
            DataTable totalsString_dt = new DataTable();
            totalsString_adapter.Fill(totalsString_dt);

            DataRow receiptRow = totalsString_dt.Rows[0];
            discountTotal = rawTotal - Int32.Parse(receiptRow["discount"].ToString());
            this.totalPaidTextBox.Text = receiptRow["sOrd_totalPaid"].ToString();
            this.discountTextBox.Text = receiptRow["discount"].ToString();
            this.rawTotalTextBox.Text = rawTotal.ToString();
            this.trueTotalTextBox.Text = discountTotal.ToString();

            //Info
            this.receiptNoTextBox.Text = receiptRow["sOrd_Num"].ToString();
            this.receiptDateTextBox.Text = receiptRow["sOrd_Date"].ToString();
            this.employeeTextBox.Text = receiptRow["EmpName"].ToString();
        }
        //Cancel Sales Orders
        internal void cancelSalesOrder()
        {
            int firstRowIndex = salesOrdersGrid.SelectedRows.Count - 1;
            int sOrd_Num = Int32.Parse(salesOrdersGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString());
            String sOrdDet_cancelString = "UPDATE salesOrder SET sOrd_status=1 WHERE sOrd_Num=@sOrd_Num;";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand sOrdDet_Cancelcommand = new MySqlCommand(sOrdDet_cancelString, my_conn);
            sOrdDet_Cancelcommand.Parameters.AddWithValue("@sOrd_Num", sOrd_Num);
            MySqlDataReader dataReader;
            my_conn.Open();
            dataReader = sOrdDet_Cancelcommand.ExecuteReader();
            while (dataReader.Read())
            {
            }
            my_conn.Close();
            checkSales_Loader();
        }
        //salesOrderGridUpdate
        private void salesOrderGridUpdate() {
            if (salesOrdersGrid.SelectedRows.Count != 0) { 
                int firstRowIndex = salesOrdersGrid.SelectedRows.Count - 1;
                int sOrd_Num = Int32.Parse(salesOrdersGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString());
                int sOrd_status = Int32.Parse(salesOrdersGrid.SelectedRows[firstRowIndex].Cells["sOrd_status"].Value.ToString());
                salesOrderDetGrid_Loader(sOrd_Num);
                if (sOrd_status == 0)
                {
                    cancelBtn.Enabled = true;
                }
                else
                {
                    cancelBtn.Enabled = false;
                }
            }
        }
        //getFrameID
        private int getFrameID(String frameName, String dimension) {
            int frameItemID;
            String getfiIDString = "SELECT FL.frameItemID FROM frame_list AS FL WHERE frameName=@frameName AND dimension=@dimension";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand framelistID_command = new MySqlCommand(getfiIDString, my_conn);
            framelistID_command.Parameters.AddWithValue("@frameName", frameName);
            framelistID_command.Parameters.AddWithValue("@dimension",dimension);

            MySqlDataAdapter framelistID_adapter = new MySqlDataAdapter(framelistID_command);
            DataTable framelistID_dt = new DataTable();
            framelistID_adapter.Fill(framelistID_dt);
            frameItemID = Int32.Parse(framelistID_dt.Rows[0][0].ToString());
            //frameItemID = (int) framelistID_command.ExecuteScalar();

            return frameItemID;
        }
        //----------------Event Methods-----------------
        private void salesOrdersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            salesOrderGridUpdate();
        }

        private void startCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (startCheck.Checked)
            {
                startDatePicker.Enabled = true;
            }
            else {
                startDatePicker.Enabled = false;
            }
        }

        private void endCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (endCheck.Checked)
            {
                endDatePicker.Enabled = true;
            }
            else
            {
                endDatePicker.Enabled = false;
            }
        }

        private void startDatePicker_EnabledChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled && !endDatePicker.Enabled)
            {
                if (sOrdDefaultFilter.RowFilter.Contains(" AND datePick<= #"))
                {
                    dateStringRemover(0);
                }
                checkSalesFilterDate_Loader(getDateTimePicker(0), 0);
            }
            else if (endDatePicker.Enabled && !startDatePicker.Enabled)
            {
                if (sOrdDefaultFilter.RowFilter.Contains(" AND datePick>= #"))
                {
                    dateStringRemover(1);
                }
                checkSalesFilterDate_Loader(getDateTimePicker(1), 1);
            }
            else if (startDatePicker.Enabled && endDatePicker.Enabled)
            {
                checkSalesFilterDate_Loader(getDateTimePicker(0), getDateTimePicker(1),1);
            }
            else if (!(startDatePicker.Enabled || endDatePicker.Enabled)) {
                checkSales_Loader();
                if (shCancelSOCheckB.Checked) {
                    checkSalesCancelled();
                }
                if (hideActiveSOCheckB.Checked)
                {
                    hideActiveSalesOrders();
                }
            }
        }

        private void endDatePicker_EnabledChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled && !startDatePicker.Enabled)
            {
                if (sOrdDefaultFilter.RowFilter.Contains(" AND datePick>= #"))
                {
                    dateStringRemover(1);
                }
                checkSalesFilterDate_Loader(getDateTimePicker(1), 1);
            }
            else if (startDatePicker.Enabled && !endDatePicker.Enabled)
            {
                if (sOrdDefaultFilter.RowFilter.Contains(" AND datePick<= #"))
                {
                    dateStringRemover(0);
                }
                checkSalesFilterDate_Loader(getDateTimePicker(0), 0);
            }
            else if (startDatePicker.Enabled && endDatePicker.Enabled)
            {
                checkSalesFilterDate_Loader(getDateTimePicker(0), getDateTimePicker(1), 0);
            }
            else if (!(startDatePicker.Enabled || endDatePicker.Enabled))
            {
                checkSales_Loader();
                if (shCancelSOCheckB.Checked)
                {
                    checkSalesCancelled();
                }
                if (hideActiveSOCheckB.Checked)
                {
                    hideActiveSalesOrders();
                }
            }
        }
        /*Update sales order. Can only update type of frame used but must be same price as old. Otherwise, make a new sales order.*/
        private void sOrdDetGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int sOrdDet_unitPrice = Int32.Parse(sOrdDetGrid["Unit Price", sOrdDetGrid.CurrentCell.RowIndex].Value.ToString());

            DataGridViewComboBoxCell sOrdDetGrid_CBCell = new DataGridViewComboBoxCell();
            sOrdDetGrid[e.ColumnIndex, e.RowIndex] = sOrdDetGrid_CBCell;
            String sOrdDet_CBCellString = "SELECT FL.frameName \"Item\" FROM frame_list AS FL " +
                "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS 'Stockin' FROM framestock_in AS FS GROUP BY FS.frameItemID) AS FS ON FL.frameItemID = FS.frameItemID " +
                "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS 'Stockout' FROM sorder_details AS SOD GROUP BY SOD.frameItemID) AS SOD ON FL.frameItemID = SOD.frameItemID " +
                "WHERE(FS.Stockin - SOD.stockout) > 0 AND FL.unitPrice = @sOrdDet_unitPrice; ";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand salesOrdDet_CBCellcommand = new MySqlCommand(sOrdDet_CBCellString, my_conn);
            salesOrdDet_CBCellcommand.Parameters.AddWithValue("@sOrdDet_unitPrice", sOrdDet_unitPrice);

            MySqlDataAdapter salesOrdDet_CBCelladapter = new MySqlDataAdapter(salesOrdDet_CBCellcommand);
            DataTable salesOrdDet_CBCelldt = new DataTable();
            salesOrdDet_CBCelladapter.Fill(salesOrdDet_CBCelldt);

            sOrdDetGrid_CBCell.DataSource = salesOrdDet_CBCelldt;
            sOrdDetGrid_CBCell.ValueMember = "Item";
            sOrdDetGrid_CBCell.DisplayMember = "Item";
            
        }

        private void sOrdDetGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateBtn.Enabled = true;
            resetBtn.Enabled = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            int firstRowIndex = salesOrdersGrid.SelectedRows.Count - 1;
            int sOrd_Num = Int32.Parse(salesOrdersGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString());
            salesOrderDetGrid_Loader(sOrd_Num);
            updateBtn.Enabled = false;
            resetBtn.Enabled = false;
        }
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
           // String[] updateItemsArray = new String[sOrdDetGrid.Rows.Count];
            String[] sOrdDetailsID = new String[sOrdDetGrid.Rows.Count];
            int[] frameItemID = new int[sOrdDetGrid.Rows.Count];
            for (int i = 0; i < sOrdDetGrid.Rows.Count; i++)
            {
                //MessageBox.Show(i.ToString());
                frameItemID[i] = getFrameID(sOrdDetGrid.Rows[i].Cells["Item"].Value.ToString(), sOrdDetGrid.Rows[i].Cells["Dimension"].Value.ToString());
                //updateItemsArray[i] = sOrdDetGrid.Rows[i].Cells["Item"].Value.ToString();
                sOrdDetailsID[i] = sOrdDetGrid.Rows[i].Cells["sOrd_DetailsID"].Value.ToString();
            }
            for (int i = 0; i < sOrdDetGrid.Rows.Count; i++) {
                String sOrdDet_UpdateString = "UPDATE sOrder_Details AS SOD " +
                    "SET SOD.frameItemID = @frameItemID " +
                    "WHERE SOD.sOrd_DetailsID = @sOrd_DetailsID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand sOrdDet_Updatecommand = new MySqlCommand(sOrdDet_UpdateString, my_conn);
                //sOrdDet_Updatecommand.Parameters.AddWithValue("@Items", updateItemsArray[i]);
                sOrdDet_Updatecommand.Parameters.AddWithValue("@frameItemID", frameItemID[i]);
                sOrdDet_Updatecommand.Parameters.AddWithValue("@sOrd_DetailsID", sOrdDetailsID[i]);
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = sOrdDet_Updatecommand.ExecuteReader();
                while (dataReader.Read()) {
                }
                my_conn.Close();
            }
            updateBtn.Enabled = false;
            resetBtn.Enabled = false;
            int firstRowIndex = salesOrdersGrid.SelectedRows.Count - 1;
            int sOrd_Num = Int32.Parse(salesOrdersGrid.SelectedRows[firstRowIndex].Cells[0].Value.ToString());
            salesOrderDetGrid_Loader(sOrd_Num);
        }

        private void shCancelSOCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (shCancelSOCheckB.Checked)
            {
                checkSalesCancelled();
            }
            else if (hideActiveSOCheckB.Checked && !shCancelSOCheckB.Checked)
            {
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace("sOrd_status = 1", "sOrd_status > 1");
            }
            else {
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace("sOrd_status >= 0", "sOrd_status = 0");
            }
        }
        private void hideActiveSOCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (hideActiveSOCheckB.Checked)
            {
                hideActiveSalesOrders();
            }
            else if (shCancelSOCheckB.Checked && !hideActiveSOCheckB.Checked)
            {
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace("sOrd_status = 1", "sOrd_status >= 0");
            }
            else
            {
                sOrdDefaultFilter.RowFilter = sOrdDefaultFilter.RowFilter.Replace("sOrd_status > 1", "sOrd_status = 0");
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancelSalesConfirm cancelDlg = new cancelSalesConfirm(this);
            cancelDlg.ShowDialog();
        }

        private void salesOrdersGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            salesOrderGridUpdate();
        }

        private void addSalesOrder_Click(object sender, EventArgs e)
        {
            addSales addSalesDlg = new addSales(this);
            addSalesDlg.ShowDialog();
        }
    }
}
