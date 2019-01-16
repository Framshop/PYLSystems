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
        private DataTable addSalesDT;
        internal List<frame_ItemsforList> frameItemsList;
        //--------------Initial Load--------------
        public addSales()
        {
            InitializeComponent();
        }
        public addSales(checkSales ParentForm)
        {
            InitializeComponent();
            checkSalesPForm = ParentForm;
        } 
        private void addSales_Load(object sender, EventArgs e)
        {
            addSales_Loader();
        }
        //-------------Process and Calculation Methods--------------
        private void addSales_Loader() {
            frameItemsList = new List<frame_ItemsforList>();
            addSalesDT = new DataTable();
            addSalesDT.Columns.Add("Item");
            addSalesDT.Columns.Add("Dimension");
            addSalesDT.Columns.Add("Quantity");
            addSalesDT.Columns.Add("Unit Price");
            addSalesDT.Columns.Add("Total");
            addSalesGrid.DataSource = addSalesDT;
        }
        internal void addSales_Refresher() {
            this.addSalesGrid.DataSource = null;
            this.addSalesGrid.Rows.Clear();
            this.addSalesGrid.DataSource = addSalesDT;
            //January 16, 2019 edit note: finish method to refresh addSales form once AddSalesAvailability adds item. Refresh shall
            //base on List frameItemsList to fill datatable and grid.
            //Next to-do is to add edit method to open addSalesAvailability and replace currently selected row.
            //--calculate totalPrice=unitPrice*quantity
            //--calculate total prices
            //--calculate Discounted Total = total-discount
            //--get total paid
            //--insert using list with for loop
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

        private void addSalesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addSalesAvailability AvailabilityForm = new addSalesAvailability(this);
            AvailabilityForm.ShowDialog();
        }
    }
    class frame_ItemsforList
    {
        internal String frameName { get; set; }
        internal String dimension { get; set; }
        internal String unitPrice { get; set; }
        internal int frameItemID { get; set; }
        internal int quantity { get; set; }
        public frame_ItemsforList(String frameName, String dimension, String unitPrice, int frameItemID, int quantity)
        {
            this.frameName = frameName;
            this.dimension = dimension;
            this.unitPrice = unitPrice;
            this.frameItemID = frameItemID;
            this.quantity = quantity;
        }

    }
}
