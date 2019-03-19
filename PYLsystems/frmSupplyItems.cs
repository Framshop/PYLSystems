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
    public partial class frmSupplyItems : Form
    {
        public static string supplyID = "";
        public static string typeOfMeasure_dbCellClick = "";
        public static string supply_categoryID = "";
        public static string typeOfMeasure_db = "";
        public static string quantity_left = "";
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public frmSupplyItems()
        {
            InitializeComponent();
            FillSupplyCategory();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
        public void RefreshDatabase()
        {
            myConn.Open();
            string query = "SELECT s_i.supply_itemsID as 'Supply ID',s_c.supply_categoryID as 'Supply Category ID'," +
"s_i.supplyName as 'Supply Name',s_c.categoryName as 'Category Name',s_c.typeOfMeasure as 'Type of Measure'," +
"s_i.supplyDescription as 'Supply Description',s_i.measureA as 'Measurement A',IFNULL(s_i.measureB, 'Not Applicable') as " +
"'Measurement B',case when s_i.measureB is not null then CONCAT(s_i.measureA,' x ',s_i.measureB) else s_i.measureA end" +
 " as 'Measurement',s_i.unitMeasure as 'Unit Measure',s_i.unitPurchasePrice as 'Purchase Price'," +
" IF(active = 0, 'Active', 'Inactive') as 'Active',s_c.typeOfMeasure," +
 " IFNULL(IF(s_c.typeOfMeasure = 'Volume', (1 - ((IFNULL(d_m4.DamagedMaterials, 0) + IFNULL(f_m4.FrameMaterials, 0) + IFNULL(j_d4.JobOrderDetailsMaterials, 0)) / (s_d4.StockInVolume * s_i.measureA))) * (s_d4.StockInVolume), IF(s_c.typeOfMeasure = 'Weight', (1 - ((IFNULL(d_m3.DamagedMaterials, 0) + IFNULL(f_m3.FrameMaterials, 0) + IFNULL(j_d3.JobOrderDetailsMaterials, 0)) / (s_d2.StockInWeight * s_i.measureA))) * (s_d2.StockInWeight), IF(s_c.typeOfMeasure = 'Length', (1 - ((IFNULL(d_m.DamagedMaterials, 0) + IFNULL(f_m.FrameMaterials, 0) + IFNULL(j_d.JobOrderDetailsMaterials, 0)) / (s_d3.StockInLength * s_i.measureA))) * (s_d3.StockInLength), IF(s_c.typeOfMeasure = 'Area', (1 - ((IFNULL(d_m1.DamagedMaterials, 0) + IFNULL(f_m1.FrameMaterials, 0) + IFNULL(j_d1.JobOrderDetailsMaterials, 0)) / (s_d0.StockInArea * (s_i.measureA * s_i.measureB)))) * (s_d0.StockInArea), IF(s_c.typeOfMeasure = 'Whole', IFNULL(s_d1.StockInWhole, 0) - IFNULL(d_m2.DamagedMaterials, 0) + IFNULL(f_m2.FrameMaterials, 0) + IFNULL(j_d2.JobOrderDetailsMaterials, 0), 0))))), 0) as 'Quantity Left'," +
 "   IFNULL(IF(s_c.typeOfMeasure = 'Volume',(s_i.measureA * s_d4.StockInVolume) - IFNULL(d_m4.DamagedMaterials, 0)+ IFNULL(f_m4.FrameMaterials, 0) + IFNULL(j_d4.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Weight', (s_i.measureA * s_d2.StockInWeight) - IFNULL(d_m3.DamagedMaterials, 0)+ IFNULL(f_m3.FrameMaterials, 0) + IFNULL(j_d3.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Length',(s_i.measureA * s_d3.StockInLength) - IFNULL(d_m.DamagedMaterials, 0)+ IFNULL(f_m.FrameMaterials, 0) + IFNULL(j_d.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Area', ((s_i.measureA * s_i.measureB) * s_d0.StockInArea) - IFNULL(d_m1.DamagedMaterials, 0)+ IFNULL(f_m1.FrameMaterials, 0) + IFNULL(j_d1.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Whole',s_i.measureA * s_d1.StockInWhole -  IFNULL(d_m2.DamagedMaterials, 0)+ IFNULL(f_m2.FrameMaterials, 0) + IFNULL(j_d2.JobOrderDetailsMaterials, 0), 0))))), 0) as 'Quantity Left in Measurement' " +
 " FROM supply_items s_i" +
 " LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) " +
" as d_m ON d_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) " +
" as f_m ON f_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) " +
" as j_d ON j_d.supply_itemsID = s_i.supply_itemsID" +

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) " +
" as d_m1 ON d_m1.supply_itemsID = s_i.supply_itemsID  LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) " +
" as f_m1 ON f_m1.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) " +
" as j_d1 ON j_d1.supply_itemsID = s_i.supply_itemsID" +


" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) " +
" as d_m2 ON d_m2.supply_itemsID = s_i.supply_itemsID  LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) " +
" as f_m2 ON f_m2.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) " +
" as j_d2 ON j_d2.supply_itemsID = s_i.supply_itemsID" +

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) " +
" as d_m3 ON d_m3.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) " +
" as f_m3 ON f_m3.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) " +
" as j_d3 ON j_d3.supply_itemsID = s_i.supply_itemsID" +

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_i.supply_itemsID) " +
" as d_m4 ON d_m4.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_i.supply_itemsID) " +
" as f_m4 ON f_m4.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume'GROUP BY s_i.supply_itemsID) " +
" as j_d4 ON j_d4.supply_itemsID = s_i.supply_itemsID" +

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInArea' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_d.supply_itemsID) s_d0 ON s_d0.supply_itemsID = s_i.supply_itemsID" +
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInWhole' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_d.supply_itemsID) s_d1 ON s_d1.supply_itemsID = s_i.supply_itemsID" +
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as  'StockInWeight'FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_d.supply_itemsID) s_d2 ON s_d2.supply_itemsID = s_i.supply_itemsID" +
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInLength' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_d.supply_itemsID) s_d3 ON s_d3.supply_itemsID = s_i.supply_itemsID" +
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInVolume' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_d.supply_itemsID) s_d4 ON s_d4.supply_itemsID = s_i.supply_itemsID WHERE s_i.supplyName LIKE '%" + txtSearch.Text + "%' OR s_c.categoryName LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgSupplyItems.DataSource = dt;
            myConn.Close();
            dgSupplyItems.Columns["Supply ID"].Visible = false;
            dgSupplyItems.Columns["Supply Category ID"].Visible = false;
            dgSupplyItems.Columns["Measurement A"].Visible = false;
            dgSupplyItems.Columns["Measurement B"].Visible = false;
            dgSupplyItems.Columns["typeOfMeasure"].Visible = false;
            dgSupplyItems.Columns["Active"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void supplyItemsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSupplyItems_Load(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            myConn.Open();
            string query = "SELECT s_i.supply_itemsID as 'Supply ID',s_c.supply_categoryID as 'Supply Category ID'," +
"s_i.supplyName as 'Supply Name',s_c.categoryName as 'Category Name',s_c.typeOfMeasure as 'Type of Measure'," +
"s_i.supplyDescription as 'Supply Description',s_i.measureA as 'Measurement A',IFNULL(s_i.measureB, 'Not Applicable') as "+
"'Measurement B',case when s_i.measureB is not null then CONCAT(s_i.measureA,' x ',s_i.measureB) else s_i.measureA end"+
 " as 'Measurement',s_i.unitMeasure as 'Unit Measure',s_i.unitPurchasePrice as 'Purchase Price',"+
" IF(active = 0, 'Active', 'Inactive') as 'Active',s_c.typeOfMeasure,"+
 " IFNULL(IF(s_c.typeOfMeasure = 'Volume', (1 - ((IFNULL(d_m4.DamagedMaterials, 0) + IFNULL(f_m4.FrameMaterials, 0) + IFNULL(j_d4.JobOrderDetailsMaterials, 0)) / (s_d4.StockInVolume * s_i.measureA))) * (s_d4.StockInVolume), IF(s_c.typeOfMeasure = 'Weight', (1 - ((IFNULL(d_m3.DamagedMaterials, 0) + IFNULL(f_m3.FrameMaterials, 0) + IFNULL(j_d3.JobOrderDetailsMaterials, 0)) / (s_d2.StockInWeight * s_i.measureA))) * (s_d2.StockInWeight), IF(s_c.typeOfMeasure = 'Length', (1 - ((IFNULL(d_m.DamagedMaterials, 0) + IFNULL(f_m.FrameMaterials, 0) + IFNULL(j_d.JobOrderDetailsMaterials, 0)) / (s_d3.StockInLength * s_i.measureA))) * (s_d3.StockInLength), IF(s_c.typeOfMeasure = 'Area', (1 - ((IFNULL(d_m1.DamagedMaterials, 0) + IFNULL(f_m1.FrameMaterials, 0) + IFNULL(j_d1.JobOrderDetailsMaterials, 0)) / (s_d0.StockInArea * (s_i.measureA * s_i.measureB)))) * (s_d0.StockInArea), IF(s_c.typeOfMeasure = 'Whole', IFNULL(s_d1.StockInWhole, 0) - IFNULL(d_m2.DamagedMaterials, 0) + IFNULL(f_m2.FrameMaterials, 0) + IFNULL(j_d2.JobOrderDetailsMaterials, 0), 0))))), 0) as 'Quantity Left'," +
 "   IFNULL(IF(s_c.typeOfMeasure = 'Volume',(s_i.measureA * s_d4.StockInVolume) - IFNULL(d_m4.DamagedMaterials, 0)+ IFNULL(f_m4.FrameMaterials, 0) + IFNULL(j_d4.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Weight', (s_i.measureA * s_d2.StockInWeight) - IFNULL(d_m3.DamagedMaterials, 0)+ IFNULL(f_m3.FrameMaterials, 0) + IFNULL(j_d3.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Length',(s_i.measureA * s_d3.StockInLength) - IFNULL(d_m.DamagedMaterials, 0)+ IFNULL(f_m.FrameMaterials, 0) + IFNULL(j_d.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Area', ((s_i.measureA * s_i.measureB) * s_d0.StockInArea) - IFNULL(d_m1.DamagedMaterials, 0)+ IFNULL(f_m1.FrameMaterials, 0) + IFNULL(j_d1.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Whole',s_i.measureA * s_d1.StockInWhole -  IFNULL(d_m2.DamagedMaterials, 0)+ IFNULL(f_m2.FrameMaterials, 0) + IFNULL(j_d2.JobOrderDetailsMaterials, 0), 0))))), 0) as 'Quantity Left in Measurement' " +
 " FROM supply_items s_i" +
 " LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) "+
" as d_m ON d_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) "+
" as f_m ON f_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) "+
" as j_d ON j_d.supply_itemsID = s_i.supply_itemsID"+

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) "+
" as d_m1 ON d_m1.supply_itemsID = s_i.supply_itemsID  LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) "+
" as f_m1 ON f_m1.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) "+
" as j_d1 ON j_d1.supply_itemsID = s_i.supply_itemsID"+


" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) "+
" as d_m2 ON d_m2.supply_itemsID = s_i.supply_itemsID  LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) "+
" as f_m2 ON f_m2.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) "+
" as j_d2 ON j_d2.supply_itemsID = s_i.supply_itemsID"+

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) "+
" as d_m3 ON d_m3.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) "+
" as f_m3 ON f_m3.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) "+
" as j_d3 ON j_d3.supply_itemsID = s_i.supply_itemsID"+

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_i.supply_itemsID) "+
" as d_m4 ON d_m4.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_i.supply_itemsID) "+
" as f_m4 ON f_m4.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume'GROUP BY s_i.supply_itemsID) "+
" as j_d4 ON j_d4.supply_itemsID = s_i.supply_itemsID"+

" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInArea' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_d.supply_itemsID) s_d0 ON s_d0.supply_itemsID = s_i.supply_itemsID"+
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInWhole' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_d.supply_itemsID) s_d1 ON s_d1.supply_itemsID = s_i.supply_itemsID"+
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as  'StockInWeight'FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_d.supply_itemsID) s_d2 ON s_d2.supply_itemsID = s_i.supply_itemsID"+
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInLength' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_d.supply_itemsID) s_d3 ON s_d3.supply_itemsID = s_i.supply_itemsID"+
" LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInVolume' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_d.supply_itemsID) s_d4 ON s_d4.supply_itemsID = s_i.supply_itemsID WHERE s_i.supplyName LIKE '%" + txtSearch.Text +  "%' OR s_c.categoryName LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand comm = new MySqlCommand(query, myConn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgSupplyItems.DataSource = dt;
            myConn.Close();
            dgSupplyItems.Columns["Supply ID"].Visible = false;
            dgSupplyItems.Columns["Supply Category ID"].Visible = false;
            dgSupplyItems.Columns["Measurement A"].Visible = false;
            dgSupplyItems.Columns["Measurement B"].Visible = false;
            dgSupplyItems.Columns["typeOfMeasure"].Visible = false;
            dgSupplyItems.Columns["Active"].Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validationCreateItem();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            validationCreateItem();
        }

        private void txtSales_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSales_Price_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {

        }

        private void cboSupplyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            validationCreateItem();
            string myQuery = "SELECT * FROM supply_category WHERE categoryName = '" + cboSupplyCategory.Text + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = myComm.ExecuteReader();
            while (myReader.Read())
            {

                string myId = myReader.GetString(0);
                string typeOfMeasure = myReader.GetString(3);

                supply_categoryID = myId;
                typeOfMeasure_db = typeOfMeasure;
            }
            if (typeOfMeasure_db == "Area")
            {
                //TRUE
                lblArea.Enabled = true;
                txtArea1.Enabled = true;
                txtArea2.Enabled = true;
                cboArea.Enabled = true;
                lblX.Enabled = true;

                //FALSE

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                txtLength.Text = "";
                cboLength.SelectedIndex = -1;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else if (typeOfMeasure_db == "Length")
            {
                //TRUE
                txtLength.Enabled = true;
                cboLength.Enabled = true;
                lblLength.Enabled = true;

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else if (typeOfMeasure_db == "Weight")
            {
                //TRUE
                lblWeight.Enabled = true;
                txtWeight.Enabled = true;
                cboWeight.Enabled = true;

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";

                cboWhole.SelectedIndex = -1;
            }
            else if (typeOfMeasure_db == "Volume")
            {
                //TRUE
                cboVolume.Enabled = true;
                lblVolume.Enabled = true;
                txtVolume.Enabled = true;

                //FALSE
                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;
            }
            else
            {
                //TRUE
                cboWhole.Enabled = true;
                lblWhole.Enabled = true;

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            myConn.Close();
            
        }
        public void FillSupplyCategory()
        {
            string myQuery = "SELECT * FROM supply_category";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myComm.ExecuteReader();
                while (myReader.Read())
                {
                    string categoryName = myReader.GetString(1);
                    cboSupplyCategory.Items.Add(categoryName);

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStockInSelectedItem_Click(object sender, EventArgs e)
        {
            frmSupplyStockIn supplyStockIn = new frmSupplyStockIn();
            supplyStockIn.lblsupply_itemsID.Text = dgSupplyItems.CurrentRow.Cells[0].Value.ToString();
            frmSupplyStockIn.Global.supplyID = dgSupplyItems.CurrentRow.Cells[0].Value.ToString();
            supplyStockIn.txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
            supplyStockIn.txtRawPurchasePrice.Text = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();
            supplyStockIn.ShowDialog();
            RefreshDatabase();
            cboSupplyCategory.SelectedIndex = -1;
            txtItemName.Text = "";
            txtItemDescription.Text = "";
            cboActive.SelectedIndex = -1;

            txtPurchaseUnitPrice.Text = "";
            supply_categoryID = "";
            typeOfMeasure_db = "";
            supplyID = "";

            lblArea.Enabled = false;
            txtArea1.Enabled = false;
            txtArea2.Enabled = false;
            cboArea.Enabled = false;
            lblX.Enabled = false;

            txtLength.Enabled = false;
            cboLength.Enabled = false;
            lblLength.Enabled = false;

            lblWeight.Enabled = false;
            txtWeight.Enabled = false;
            cboWeight.Enabled = false;

            cboVolume.Enabled = false;
            lblVolume.Enabled = false;
            txtVolume.Enabled = false;
            cboWhole.Enabled = false;
            lblWhole.Enabled = false;
            btnStockInSelectedItem.Enabled = false;
            btnUpdateDetails.Enabled = false;
            btnDamageItem.Enabled = false;
            txtVolume.Text = "";
            cboVolume.SelectedIndex = -1;

            txtArea1.Text = "";
            txtArea2.Text = "";
            cboActive.SelectedIndex = -1;

            cboLength.SelectedIndex = -1;
            txtLength.Text = "";

            txtWeight.Text = "";
            cboWeight.SelectedIndex = -1;

            cboWhole.SelectedIndex = -1;

            cboVolume.SelectedIndex = -1;
            txtVolume.Text = "";
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            myConn.Open();
            MySqlDataAdapter myAd;
            DataTable myD = new DataTable();
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM supply_items WHERE supplyName = '" + txtItemName.Text + "'", myConn);
            myAd = new MySqlDataAdapter(myCom);
            //ADD ----------
            MySqlDataReader myReader;
            myAd.Fill(myD);
            //ADD
            myReader = myCom.ExecuteReader();
            myConn.Close();
            if (myD.Rows.Count == 0)
            {
                if (typeOfMeasure_db == "Length")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,unitPurchasePrice,active) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtLength.Text + ",'" + cboLength.Text + "'," + txtPurchaseUnitPrice.Text + "," + cboActive.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else if (typeOfMeasure_db == "Area")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,measureB,unitMeasure,unitPurchasePrice,active) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtArea1.Text + "," + txtArea2.Text + ",'" + cboArea.Text + "'," + txtPurchaseUnitPrice.Text + "," + cboActive.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else if (typeOfMeasure_db == "Weight")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,unitPurchasePrice,active) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtWeight.Text + ",'" + cboWeight.Text + "'," + txtPurchaseUnitPrice.Text + "," + cboActive.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else if (typeOfMeasure_db == "Volume")
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,unitPurchasePrice,active) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + txtVolume.Text + ",'" + cboVolume.Text + "'," + txtPurchaseUnitPrice.Text + "," + cboActive.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                else
                {
                    string myQuery = "INSERT INTO supply_items (supply_categoryID,supplyName,supplyDescription,measureA,unitMeasure,unitPurchasePrice,active) values(" + supply_categoryID + ",'" + txtItemName.Text + "','" + txtItemDescription.Text + "'," + 1 + ",'" + cboWhole.Text + "'," + txtPurchaseUnitPrice.Text + "," + cboActive.Text + ")";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Insert Successful");
                }
                RefreshDatabase();
                cboSupplyCategory.SelectedIndex = -1;
                txtItemName.Text = "";
                txtItemDescription.Text = "";
                cboActive.SelectedIndex = -1;

                txtPurchaseUnitPrice.Text = "";
                supply_categoryID = "";
                typeOfMeasure_db = "";
                supplyID = "";

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;


                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboActive.SelectedIndex = -1;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";


                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.SelectedIndex = -1;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else
            {
                MessageBox.Show(txtItemName.Text + " already exist in your inventory");
            }
    }
        public void validationUpdateItem()
        {
            if (supplyID != "")
            {
                btnDamageItem.Enabled = true;
                btnUpdateDetails.Enabled = true;
                btnStockInSelectedItem.Enabled = true;
            }
            else
            {

                btnDamageItem.Enabled = false;
                btnUpdateDetails.Enabled = false;
                btnStockInSelectedItem.Enabled = false;
            }
        }
        public void validationCreateItem()
        {
            int supply_category = cboSupplyCategory.SelectedIndex;
            int supply_name = txtItemName.TextLength;
            int supply_description = txtItemDescription.TextLength;
            int active = cboActive.SelectedIndex;
            int purchasePrice = txtPurchaseUnitPrice.TextLength;
            //Others are for measurements without assigning into another variable
            if (lblLength.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && active > -1 && purchasePrice > 0 && cboLength.SelectedIndex > -1 && txtLength.TextLength > 0)
                {
                    btnCreateItem.Enabled = true; 
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblWeight.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && active > -1 && purchasePrice > 0 && cboWeight.SelectedIndex > -1 && txtWeight.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblWhole.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && active > -1 && purchasePrice > 0 && cboWhole.SelectedIndex > -1)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else if (lblVolume.Enabled == true)
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && active > -1 && purchasePrice > 0 && cboVolume.SelectedIndex > -1 && txtVolume.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
            else
            {
                if (supply_category > -1 && supply_name > 0 && supply_description > 0 && active > -1 && purchasePrice > 0 && cboArea.SelectedIndex > -1 && txtArea1.TextLength > 0 && txtArea2.TextLength > 0)
                {
                    btnCreateItem.Enabled = true;
                }
                else
                {
                    btnCreateItem.Enabled = false;
                }
            }
        }

        private void dgSupplyItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSupplyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            quantity_left = dgSupplyItems.CurrentRow.Cells[13].Value.ToString();
           supplyID = dgSupplyItems.CurrentRow.Cells[0].Value.ToString();
            validationUpdateItem();
            typeOfMeasure_dbCellClick = dgSupplyItems.CurrentRow.Cells[4].Value.ToString();
            if (typeOfMeasure_dbCellClick == "Area")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells[1].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells[3].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells[5].Value.ToString();
                cboActive.Text = dgSupplyItems.CurrentRow.Cells[11].Value.ToString();
                txtPurchaseUnitPrice.Text = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();


                //TRUE
                lblArea.Enabled = true;
                txtArea1.Enabled = true;
                txtArea2.Enabled = true;
                cboArea.Enabled = true;
                lblX.Enabled = true;

                //supplyItemsGrid.DataSource = Dt;
                //myConn.Close();
                //supplyItemsGrid.Columns["supply_itemsID"].Enabled = false;
                //supplyItemsGrid.Columns["supplyName"].HeaderText = "Supply Name";
                //supplyItemsGrid.Columns["supplyDescription"].HeaderText = "Details";
                //supplyItemsGrid.Columns["unitMeasure"].HeaderText = "Unit Measure";




                txtArea1.Text = dgSupplyItems.CurrentRow.Cells[6].Value.ToString();
                txtArea2.Text = dgSupplyItems.CurrentRow.Cells[7].Value.ToString();
                cboArea.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();

                //FALSE

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
            else if (typeOfMeasure_dbCellClick == "Length")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells[1].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells[3].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells[5].Value.ToString();
                cboActive.Text = dgSupplyItems.CurrentRow.Cells[11].Value.ToString();
                txtPurchaseUnitPrice.Text = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();

                //TRUE
                txtLength.Enabled = true;
                cboLength.Enabled = true;
                lblLength.Enabled = true;

                cboLength.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                txtLength.Text = dgSupplyItems.CurrentRow.Cells[6].Value.ToString();

                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
            else if (typeOfMeasure_dbCellClick == "Weight")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells[1].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells[3].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells[5].Value.ToString();
                cboActive.Text = dgSupplyItems.CurrentRow.Cells[11].Value.ToString();
                txtPurchaseUnitPrice.Text = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();

                //TRUE
                lblWeight.Enabled = true;
                txtWeight.Enabled = true;
                cboWeight.Enabled = true;

                txtWeight.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                cboWeight.Text = dgSupplyItems.CurrentRow.Cells[6].Value.ToString();
                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;


                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
            else if (typeOfMeasure_dbCellClick == "Volume")
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells[1].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells[3].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells[5].Value.ToString();
                cboActive.Text = dgSupplyItems.CurrentRow.Cells[11].Value.ToString();
                txtPurchaseUnitPrice.Text = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();
                //TRUE
                lblVolume.Enabled = true;
                txtVolume.Enabled = true;
                cboVolume.Enabled = true;

                txtVolume.Text = dgSupplyItems.CurrentRow.Cells[6].Value.ToString();
                cboVolume.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();

                //FALSE
                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

                cboWhole.SelectedIndex = -1;
            }
            else
            {
                supply_categoryID = dgSupplyItems.CurrentRow.Cells[1].Value.ToString();
                cboSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells[3].Value.ToString();
                txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
                txtItemDescription.Text = dgSupplyItems.CurrentRow.Cells[5].Value.ToString();
                cboActive.Text = dgSupplyItems.CurrentRow.Cells[11].Value.ToString();
                txtPurchaseUnitPrice.Text = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();

                //TRUE
                cboWhole.Enabled = true;
                lblWhole.Enabled = true;

                cboWhole.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                //FALSE
                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtArea1.Text = "";
                txtArea2.Text = "";
                cboArea.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;
            }
        }

        private void txtPurchaseUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cboActive_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            validationCreateItem();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            validationCreateItem();
        }

        private void cboLength_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            validationCreateItem();
        }

        private void txtArea1_TextChanged(object sender, EventArgs e)
        {
  
            validationCreateItem();
        }

        private void txtArea2_TextChanged(object sender, EventArgs e)
        {

            validationCreateItem();
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            validationCreateItem();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
       
            validationCreateItem();
        }

        private void cboWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            validationCreateItem();
        }

        private void cboWhole_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            validationCreateItem();
        }

        private void txtPurchaseUnitPrice_TextChanged(object sender, EventArgs e)
        {
     
            validationCreateItem();
        }


        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            btnUpdateDetails.Enabled = false;
            btnStockInSelectedItem.Enabled = false;
            btnDamageItem.Enabled = false;
          
                if (typeOfMeasure_db == "Length")
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtLength.Text + ", unitMeasure = '" + cboLength.Text + "', unitPurchasePrice = " + txtPurchaseUnitPrice.Text + ", active = " + cboActive.SelectedIndex + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
                if (typeOfMeasure_db == "Area")
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtArea1.Text + ", measureB = " + txtArea2.Text + ", unitMeasure = '" + cboLength.Text + "', unitPurchasePrice = " + txtPurchaseUnitPrice.Text + ", active = " + cboActive.SelectedIndex + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
                if (typeOfMeasure_db == "Weight")
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtWeight.Text + ", unitMeasure = '" + cboWeight.Text + "', unitPurchasePrice = " + txtPurchaseUnitPrice.Text + ", active = " + cboActive.SelectedIndex + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
            if (typeOfMeasure_db == "Volume")
            {
                string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + txtVolume.Text + ", unitMeasure = '" + cboVolume.Text + "', unitPurchasePrice = " + txtPurchaseUnitPrice.Text + ", active = " + cboActive.SelectedIndex + " WHERE supply_itemsID = " + supplyID;
                MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                DataTable myDt = new DataTable();
                myAdp.Fill(myDt);
                RefreshDatabase();
                MessageBox.Show("Update Successful");
            }
            else
                {
                    string myQuery = "UPDATE supply_items SET supply_categoryID = " + supply_categoryID + ", supplyName = '" + txtItemName.Text + "', supplyDescription = '" + txtItemDescription.Text + "', measureA = " + 1 + ", unitMeasure = '" + cboWhole.Text + "', unitPurchasePrice = " + txtPurchaseUnitPrice.Text + ", active = " + cboActive.SelectedIndex + " WHERE supply_itemsID = " + supplyID;
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    RefreshDatabase();
                    MessageBox.Show("Update Successful");
                }
                RefreshDatabase();
                cboSupplyCategory.SelectedIndex = -1;
                txtItemName.Text = "";
                txtItemDescription.Text = "";
                cboActive.SelectedIndex = -1;

                txtPurchaseUnitPrice.Text = "";
                supply_categoryID = "";
                typeOfMeasure_db = "";
                supplyID = "";

                txtVolume.Text = "";
                cboVolume.SelectedIndex = -1;

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

            txtArea1.Text = "";
            txtArea2.Text = "";
            cboActive.SelectedIndex = -1;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

            cboLength.SelectedIndex = -1;
            txtLength.Text = "";

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;
            txtWeight.Text = "";
            cboWeight.SelectedIndex = -1;

                cboWhole.Enabled = false;
                lblWhole.Enabled = false;

            cboWhole.SelectedIndex = -1;

                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboVolume.Enabled = false;

            cboVolume.SelectedIndex = -1;
            txtVolume.Text = "";
        }

        private void frmSupplyItems_Load_1(object sender, EventArgs e)
        {
            RefreshDatabase();
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArea2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnDamageItem_Click(object sender, EventArgs e)
        {
            double quantity = double.Parse(quantity_left);
            if (quantity > 0)
            {

                frmSupplyDamage damagedItems = new frmSupplyDamage();
                frmSupplyDamage.Global.quantity_left = dgSupplyItems.CurrentRow.Cells[13].Value.ToString();
                frmSupplyDamage.Global.supply_category_typeOfMeasure = dgSupplyItems.CurrentRow.Cells[12].Value.ToString();
                frmSupplyDamage.Global.supply_itemsID = dgSupplyItems.CurrentRow.Cells[0].Value.ToString();
                damagedItems.txtItemName.Text = dgSupplyItems.CurrentRow.Cells[2].Value.ToString();
                damagedItems.txtSupplyCategory.Text = dgSupplyItems.CurrentRow.Cells[3].Value.ToString();
                frmSupplyDamage.Global.supply_purchase_price = dgSupplyItems.CurrentRow.Cells[10].Value.ToString();
                frmSupplyDamage.Global.measureAOG = dgSupplyItems.CurrentRow.Cells[6].Value.ToString();
                frmSupplyDamage.Global.measureBOG = dgSupplyItems.CurrentRow.Cells[7].Value.ToString();
                damagedItems.txtUnitMeasure.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();


                if (typeOfMeasure_dbCellClick == "Length")
                {
                    damagedItems.cboLength.Enabled = true;
                    damagedItems.txtLength.Enabled = true;
                    damagedItems.lblLength.Enabled = true;
                    damagedItems.cboLength.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                }
                else if (typeOfMeasure_dbCellClick == "Area")
                {
                    damagedItems.cboArea.Enabled = true;
                    damagedItems.cboArea.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                    damagedItems.txtArea1.Enabled = true;
                    damagedItems.txtArea2.Enabled = true;
                    damagedItems.lblX.Enabled = true;
                    damagedItems.lblArea.Enabled = true;
                }
                else if (typeOfMeasure_dbCellClick == "Weight")
                {
                    damagedItems.txtWeight.Enabled = true;
                    damagedItems.lblWeight.Enabled = true;
                    damagedItems.cboWeight.Enabled = true;
                    damagedItems.cboWeight.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                }
                else if (typeOfMeasure_dbCellClick == "Volume")
                {
                    damagedItems.txtVolume.Enabled = true;
                    damagedItems.lblVolume.Enabled = true;
                    damagedItems.cboVolume.Enabled = true;
                    damagedItems.cboVolume.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                }
                else
                {
                    damagedItems.lblWhole.Enabled = true;
                    damagedItems.cboWhole.Enabled = true;
                    damagedItems.txtWhole.Enabled = true;
                    damagedItems.cboWhole.Text = dgSupplyItems.CurrentRow.Cells[9].Value.ToString();
                }
                damagedItems.ShowDialog();
                RefreshDatabase();
                frmSupplyDamage.Global.quantity_left = "";
                frmSupplyDamage.Global.supply_category_typeOfMeasure = "";
                frmSupplyDamage.Global.supply_purchase_price = "";
                frmSupplyDamage.Global.supply_itemsID = "";
                frmSupplyDamage.Global.measureAOG = "";
                frmSupplyDamage.Global.measureBOG = "";
                cboSupplyCategory.SelectedIndex = -1;
                txtItemName.Text = "";
                txtItemDescription.Text = "";
                cboActive.SelectedIndex = -1;

                txtPurchaseUnitPrice.Text = "";
                supply_categoryID = "";
                typeOfMeasure_db = "";
                supplyID = "";

                lblArea.Enabled = false;
                txtArea1.Enabled = false;
                txtArea2.Enabled = false;
                cboArea.Enabled = false;
                lblX.Enabled = false;

                txtLength.Enabled = false;
                cboLength.Enabled = false;
                lblLength.Enabled = false;

                lblWeight.Enabled = false;
                txtWeight.Enabled = false;
                cboWeight.Enabled = false;

                cboVolume.Enabled = false;
                lblVolume.Enabled = false;
                txtVolume.Enabled = false;
                cboWhole.Enabled = false;
                lblWhole.Enabled = false;
                btnStockInSelectedItem.Enabled = false;
                btnUpdateDetails.Enabled = false;
                btnDamageItem.Enabled = false;
                txtArea1.Text = "";
                txtArea2.Text = "";
                cboActive.SelectedIndex = -1;

                cboLength.SelectedIndex = -1;
                txtLength.Text = "";


                txtWeight.Text = "";
                cboWeight.SelectedIndex = -1;

                cboWhole.SelectedIndex = -1;

                cboVolume.SelectedIndex = -1;
                txtVolume.Text = "";
            }
            else
            {
                MessageBox.Show(txtItemName.Text + " needs to be stock in first!");
            }
        }
    }
    }

