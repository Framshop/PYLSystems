using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class addSales : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        // private int sample;
        checkSales checkSalesPForm;
        DataTable addSalesDT;
        List<frame_ItemsforList> frameItemChanged;

        public addSales()
        {
            InitializeComponent();
        }
        public addSales(checkSales ParentForm)
        {
            InitializeComponent();
            checkSalesPForm = ParentForm;
        }
        //--------------Initial Load--------------
        private void addSales_Load(object sender, EventArgs e)
        {
            frameItemChanged = new List<frame_ItemsforList>();
            addSalesDT = new DataTable();
            addSalesDT.Columns.Add("Item");
            addSalesDT.Columns.Add("Dimension");
            addSalesDT.Columns.Add("Quantity");
            addSalesDT.Columns.Add("Unit Price");
            addSalesDT.Columns.Add("Total");
            addSalesGrid.DataSource = addSalesDT;

            addSalesGrid.Columns["Unit Price"].ReadOnly = true;
            addSalesGrid.Columns["Total"].ReadOnly = true;
            addSalesGrid.Columns["Dimension"].ReadOnly = true;


        }
        //-------------Process and Calculation Methods--------------
        private void fillItemCB(DataGridViewCellCancelEventArgs e) {
            DataGridViewComboBoxCell addSalesGridItem_CBCell = new DataGridViewComboBoxCell();
            addSalesGrid[e.ColumnIndex, e.RowIndex] = addSalesGridItem_CBCell;
            String addSalesItems_CBCellString = "SELECT FL.frameName AS \"Item\" " +
                "FROM frame_list AS FL " +
                "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS 'Stockin' FROM framestock_in AS FS GROUP BY FS.frameItemID) AS FS ON FL.frameItemID = FS.frameItemID " +
                "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS 'Stockout' FROM sorder_details AS SOD GROUP BY SOD.frameItemID) AS SOD ON FL.frameItemID = SOD.frameItemID " +
                "WHERE (FS.Stockin-(IFNULL(SOD.stockout,0)))>0 " +
                "GROUP BY FL.frameName; ";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand addSalesItems_CBCellcommand = new MySqlCommand(addSalesItems_CBCellString, my_conn);
            //salesOrdDet_CBCellcommand.Parameters.AddWithValue("@sOrdDet_unitPrice", sOrdDet_unitPrice);

            MySqlDataAdapter addSalesItems_CBCelladapter = new MySqlDataAdapter(addSalesItems_CBCellcommand);
            DataTable addSalesItems_CBCelldt = new DataTable();
            addSalesItems_CBCelladapter.Fill(addSalesItems_CBCelldt);

            addSalesGridItem_CBCell.DataSource = addSalesItems_CBCelldt;
            addSalesGridItem_CBCell.ValueMember = "Item";
            addSalesGridItem_CBCell.DisplayMember = "Item";
            if (addSalesGrid.Columns["Dimension"].ReadOnly)
            {
                addSalesGrid.Rows[e.RowIndex].Cells["Dimension"].ReadOnly = false;
            }
        }
        private void fillDimensionCB(String frameName, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewComboBoxCell addSalesGridDim_CBCell = new DataGridViewComboBoxCell();
            addSalesGrid[e.ColumnIndex, e.RowIndex] = addSalesGridDim_CBCell;
            String addSalesDim_CBCellString = "SELECT FL.Dimension AS Dimension " +
                "FROM frame_list AS FL " +
                "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS 'Stockin' FROM framestock_in AS FS GROUP BY FS.frameItemID) AS FS ON FL.frameItemID = FS.frameItemID " +
                "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS 'Stockout' FROM sorder_details AS SOD GROUP BY SOD.frameItemID) AS SOD ON FL.frameItemID = SOD.frameItemID " +
                "WHERE(FS.Stockin - (IFNULL(SOD.stockout, 0))) > 0 AND FL.frameName = @frameName;";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand addSalesDim_CBCellcommand = new MySqlCommand(addSalesDim_CBCellString, my_conn);
            addSalesDim_CBCellcommand.Parameters.AddWithValue("@frameName", frameName);

            MySqlDataAdapter addSalesDim_CBCelladapter = new MySqlDataAdapter(addSalesDim_CBCellcommand);
            DataTable addSalesDim_CBCelldt = new DataTable();
            addSalesDim_CBCelladapter.Fill(addSalesDim_CBCelldt);

            addSalesGridDim_CBCell.DataSource = addSalesDim_CBCelldt;
            addSalesGridDim_CBCell.ValueMember = "Dimension";
            addSalesGridDim_CBCell.DisplayMember = "Dimension";
        }
        private void fillDimensionCB(String frameName, DataGridViewCellEventArgs e)
        {
            DataGridViewComboBoxCell addSalesGridDim_CBCell = new DataGridViewComboBoxCell();
            addSalesGrid["Dimension", addSalesGrid.CurrentCell.RowIndex] = addSalesGridDim_CBCell;
            String addSalesDim_CBCellString = "SELECT FL.Dimension AS Dimension, FL.UnitPrice " +
                "FROM frame_list AS FL " +
                "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS 'Stockin' FROM framestock_in AS FS GROUP BY FS.frameItemID) AS FS ON FL.frameItemID = FS.frameItemID " +
                "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS 'Stockout' FROM sorder_details AS SOD GROUP BY SOD.frameItemID) AS SOD ON FL.frameItemID = SOD.frameItemID " +
                "WHERE(FS.Stockin - (IFNULL(SOD.stockout, 0))) > 0 AND FL.frameName = @frameName;";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand addSalesDim_CBCellcommand = new MySqlCommand(addSalesDim_CBCellString, my_conn);
            addSalesDim_CBCellcommand.Parameters.AddWithValue("@frameName", frameName);

            MySqlDataAdapter addSalesDim_CBCelladapter = new MySqlDataAdapter(addSalesDim_CBCellcommand);
            DataTable addSalesDim_CBCelldt = new DataTable();
            addSalesDim_CBCelladapter.Fill(addSalesDim_CBCelldt);

            addSalesGridDim_CBCell.DataSource = addSalesDim_CBCelldt;
            addSalesGridDim_CBCell.ValueMember = "Dimension";
            addSalesGridDim_CBCell.DisplayMember = "Dimension";
            if (String.IsNullOrEmpty(addSalesGrid.CurrentRow.Cells["Dimension"].Value.ToString())) {
                addSalesGrid.CurrentRow.Cells["Dimension"].Value = addSalesDim_CBCelldt.Rows[0]["Dimension"].ToString();
            }
            //addSalesGrid.Rows[e.RowIndex].Cells["Unit Price"].Value = addSalesDim_CBCelldt.Rows[0]["UnitPrice"].ToString();

            //1/13/2019 12:07am - NOTE: Get unit price of item and get cell value change first column current row for combobox
        }
        private void fillUnitPrice(String frameName, String Dimension, int RowIndex) {
            String addSalesUP_String = "SELECT FL.UnitPrice FROM frame_list AS FL WHERE FL.frameName=@frameName AND FL.Dimension=@Dimension";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand addSalesUP_command = new MySqlCommand(addSalesUP_String, my_conn);
            addSalesUP_command.Parameters.AddWithValue("@frameName", frameName);
            addSalesUP_command.Parameters.AddWithValue("@Dimension", Dimension);

            MySqlDataAdapter addSales_UnitPAdapter = new MySqlDataAdapter(addSalesUP_command);
            DataTable UnitPrice_dt = new DataTable();
            addSales_UnitPAdapter.Fill(UnitPrice_dt);

            addSalesGrid.Rows[RowIndex].Cells["Unit Price"].Value = UnitPrice_dt.Rows[0]["UnitPrice"].ToString();
        }
        private int getFrameID(String frameName, String Dimension) {
            int frameItemID = 0;
            return frameItemID;
        }
        //----------------Event Methods-----------------
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSalesGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            String frameName;
            if (addSalesGrid.CurrentCell.ColumnIndex == 0)
            {
                fillItemCB(e);
            }
            if (addSalesGrid.CurrentCell.ColumnIndex == 1)
            {
                frameName = addSalesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                fillDimensionCB(frameName,e);
            }
        }
        private void addSalesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String frameName = addSalesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            fillDimensionCB(frameName, e);
            String Dimension = addSalesGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            frameItemChanged.Add(new frame_ItemsforList(frameName, Dimension));
            MessageBox.Show(frameItemChanged[0].frameName+" "+frameItemChanged[0].dimension);
        }
    }
    class frame_ItemsforList
    {
        public String frameName { get; set; }
        public String dimension { get; set; }
        public frame_ItemsforList(String frameName, String dimension)
        {
            this.frameName = frameName;
            this.dimension = dimension;
        }

    }
}
