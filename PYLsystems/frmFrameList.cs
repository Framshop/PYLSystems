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
using UnitsNet;

namespace PYLsystems
{
    public partial class frmFrameList : Form
    {
       
        private int employeeId;
        private int employeeStatus;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        DataTable dtFrameList;
        DataTable dtSelectSupplies; //Selected from Database
        DataTable dtSelectSuppliesFiltered; //removed Original UnitMeasure and PURCHASE UnitPrice. Use this for merging
        DataTable dtSuppliesUsed; //Merged DataTable
        internal List<suppliesCosting> costingListCalc;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmFrameList()
        {
            InitializeComponent();
            this.employeeId = 1;
            this.employeeStatus = 1;
        }
        public frmFrameList(int employeeId, int employeeStatus)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeStatus = employeeStatus;
        }
        private void frmFrameList_Load(object sender, EventArgs e)
        {
            frameList_Loader();
            suppliesUsed_Loader();
        }

        //-------------Process and Calculation Methods--------------
        //First time load
        private void frameList_Loader()
        {
            try
            {
                this.datagridFrameList.DataSource = null;
                this.datagridFrameList.Rows.Clear();
                String frameAvailString = "SELECT FL.frameName AS Frame, FL.Dimension, FL.frameDescription, fl.UnitSalesPrice AS 'Unit Price', IFNULL(FS.Stockin - (IFNULL(SOD.Stockout,0)),0) AS 'Quantity Left', " +
                    "FL.frameItemID FROM frame_list AS FL " +
                    "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS Stockin FROM framestock_in AS FS GROUP BY FS.frameItemID) " +
                    "AS FS ON FL.frameItemID = FS.frameItemID " +
                    "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD LEFT JOIN salesOrder AS SO ON SOD.sOrd_Num=SO.sOrd_Num WHERE SO.sOrd_status>0 GROUP BY SOD.frameItemID) " +
                    "AS SOD ON FL.frameItemID = SOD.frameItemID " +
                    "WHERE FL.active = '0' ORDER BY FL.frameName; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand frameAvail_command = new MySqlCommand(frameAvailString, my_conn);
                MySqlDataAdapter frameAvail_adapter = new MySqlDataAdapter(frameAvail_command);

                dtFrameList = new DataTable();
                frameAvail_adapter.Fill(dtFrameList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //frameAvailDefaultFilter = new DataView(dtFrameList);
            //frameAvailDefaultFilter.RowFilter = "sOrd_status = 0";
            datagridFrameList.DataSource = dtFrameList;
            datagridFrameList.Columns["frameItemID"].Visible = false;
            datagridFrameList.Columns["Unit Price"].DefaultCellStyle.Format = "0.00";
            datagridFrameList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
        private void suppliesUsed_Loader()
        {
            try
            {
                this.dataGridSuppliesUsed.DataSource = null;
                this.dataGridSuppliesUsed.Rows.Clear();
                dtSuppliesUsed = new DataTable();
                dtSuppliesUsed.Columns.Add("supply_itemsId", typeof(int));
                dtSuppliesUsed.Columns.Add("Supply Name", typeof(String));
                dtSuppliesUsed.Columns.Add("Category", typeof(String));
                dtSuppliesUsed.Columns.Add("Usage", typeof(String));
                dtSuppliesUsed.Columns.Add("Unit Measure", typeof(String));
                dtSuppliesUsed.Columns.Add("Cost/Unit Measure", typeof(decimal));
                dtSuppliesUsed.Columns.Add("Raw Cost", typeof(decimal));



                int currRowIndex = datagridFrameList.SelectedRows[0].Index;
                int selectedFrameItemId = Int32.Parse(datagridFrameList.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());

                selectSuppliesLoader(selectedFrameItemId);
                dtSuppliesUsed.Merge(dtSelectSuppliesFiltered);

                dataGridSuppliesUsed.DataSource = dtSuppliesUsed;

                costingCalculate();
                dataGridSuppliesUsed.Columns["Cost/Unit Measure"].DefaultCellStyle.Format = "P0.0000";
                dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
                dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
                dataGridSuppliesUsed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
            catch { }
        }
        private void selectSuppliesLoader(int selectedFrameItemId)
        {
            try
            {
                String stringSuppliesSelect =
                    "SELECT sui.supply_itemsId, suc.typeOfMeasure, " +
                    "fm.measureADeduction, fm.measureBDeduction, " +
                    "fm.unitMeasure AS `Unit Measure`," +
                    "sui.unitMeasure AS `OGUnitMeasure`, sui.unitPurchasePrice AS `OGUnitPrice`," +
                    "sui.measureA, sui.measureB, fm.measureAtoOG as `ConvertedAtoOG`, fm.measureBtoOG `ConvertedBtoOG` " +
                    "FROM frame_materials AS fm " +
                    "LEFT JOIN supply_items AS sui ON sui.supply_itemsID = fm.supply_itemsID " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE fm.frameItemId = @frameItemID AND fm.active=0; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSelectSupplies = new DataTable();
                my_adapter.Fill(dtSelectSupplies);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                String stringSuppliesSelect =
                    "SELECT sui.supply_itemsId, sui.supplyName AS `Supply Name`, suc.categoryName AS `Category`, " +
                    "if(suc.typeOfMeasure='area',concat(fm.measureADeduction,' x ',fm.measureBDeduction),fm.measureADeduction) AS `Usage`, " +
                    "fm.unitMeasure AS `Unit Measure` " +
                    "FROM frame_materials AS fm " +
                    "LEFT JOIN supply_items AS sui ON sui.supply_itemsID = fm.supply_itemsID " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE fm.frameItemId = @frameItemID AND fm.active=0; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSelectSuppliesFiltered = new DataTable();
                my_adapter.Fill(dtSelectSuppliesFiltered);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //COSTS CALCULATION. FOR SELECTED UNIT PRICE AND RAW COST
        private void costingCalculate()
        {
            if (dtSelectSupplies.Rows.Count > 0)
            {
                for (int i = 0; i < dtSelectSupplies.Rows.Count; i++)
                {
                    String unitOfMeasure_Used = dtSelectSupplies.Rows[i]["Unit Measure"].ToString();
                    String unitOfMeasure_OG = dtSelectSupplies.Rows[i]["OGUnitMeasure"].ToString();
                    double unitPriceOG = Double.Parse(dtSelectSupplies.Rows[i]["OGUnitPrice"].ToString());


                    if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Whole"))
                    {
                        double measureA = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());

                        double rawCost = measureA * unitPriceOG;

                        dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = unitPriceOG;
                        dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;
                    }
                    else if (String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {                                       
                        if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Area"))
                        {
                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());
                            double measureB_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureB"].ToString());
                            double area_OG = measureA_OG * measureB_OG;
                            double trueUnitPrice = unitPriceOG / area_OG;
                            double measureAUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureADeduction"].ToString());
                            double measureBUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureBDeduction"].ToString());
                            double areaOfUsed = measureAUsed * measureBUsed;

                            double rawCost = areaOfUsed * trueUnitPrice;

                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;
                            measureAUsed = measureConverter(measureAUsed, "feet", "inches");
                            
                        }
                        else
                        {
                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());
                            double trueUnitPrice = unitPriceOG / measureA_OG;

                            double measureAUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureADeduction"].ToString());

                            double rawCost = measureAUsed * trueUnitPrice;

                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;
                        }
                    }
                    else
                    {
                        //Jan 18, 2019 to change!!! From used to original measure conversion
                        if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Area"))
                        {
                            //double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());
                            //double measureB_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureB"].ToString());
                            ////String unitOfMeasure_OG = dtSelectSupplies.Rows[i]["OGUnitMeasure"].ToString();

                            //double measureAConverted = measureConverter(measureA_OG,unitOfMeasure_OG, unitOfMeasure_Used);
                            //double measureBConverted = measureConverter(measureB_OG, unitOfMeasure_OG, unitOfMeasure_Used);

                            //double area_OG_Converted = measureAConverted * measureBConverted;


                            //double trueUnitPrice = unitPriceOG / area_OG_Converted;

                            //double measureAUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureADeduction"].ToString());
                            //double measureBUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureBDeduction"].ToString());
                            //double areaOfUsed = measureAUsed * measureBUsed;

                            //double rawCost = areaOfUsed * trueUnitPrice;

                            //dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            //dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;


                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString()); //Get purchase measures from Supply_Item table
                            double measureB_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureB"].ToString());

                            double area_OG = measureA_OG * measureB_OG; // Get area of original measures from purchase on Supply_Item table

                            double trueUnitPrice = unitPriceOG / area_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                            //Get the already converted Measurements in frame_materials table.
                            //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                            double measureAConverted = Double.Parse(dtSelectSupplies.Rows[i]["ConvertedAtoOG"].ToString()); 
                            double measureBConverted = Double.Parse(dtSelectSupplies.Rows[i]["ConvertedBtoOG"].ToString());

                            double areaOfUsed = measureAConverted * measureBConverted; //Calculate the area of Use of the used up converted measurements

                            double rawCost = areaOfUsed * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;


                        }
                        else
                        {
                            //String unitOfMeasure_OG = dtSelectSupplies.Rows[i]["OGUnitMeasure"].ToString();
                            //String unitOfMeasure_Used = dtSelectSupplies.Rows[i]["Unit Measure"].ToString();

                            //double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());
                            //double measureA_converted;

                            //if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Volume"))
                            //{
                            //    measureA_converted = measureConverter(measureA_OG, unitOfMeasure_OG, unitOfMeasure_Used, 0);
                            //}
                            //else
                            //{
                            //    measureA_converted = measureConverter(measureA_OG, unitOfMeasure_OG, unitOfMeasure_Used);
                            //}


                            //double trueUnitPrice = unitPriceOG / measureA_converted;

                            //double measureAUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureADeduction"].ToString());

                            //double rawCost = measureAUsed * trueUnitPrice;

                            //dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            //dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;


                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString()); //Get purchase measures of A and B from Supply_Item table

                            double trueUnitPrice = unitPriceOG / measureA_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                            //Get the already converted Measurements in frame_materials table.
                            //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                            double measureAConverted = Double.Parse(dtSelectSupplies.Rows[i]["ConvertedAtoOG"].ToString());

                            double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price

                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;

                        }
                    }
                }
            }
        }

        private double measureConverter(double measure_forCvt, String unitOfMeasure_OG, String unitOfMeasure_Used)
        {
            double measureConverted = 0;
            Length measureLength = Length.FromMeters(1);
            Mass measureMass = Mass.FromGrams(1);

            //Initialize
            if (String.Equals(unitOfMeasure_Used, "feet"))
            {
                measureLength = Length.FromFeet(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "meters"))
            {
                measureLength = Length.FromMeters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "centimeters"))
            {
                measureLength = Length.FromCentimeters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "millimeters"))
            {
                measureLength = Length.FromMillimeters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "inches"))
            {
                measureLength = Length.FromInches(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "ounces"))
            {
                measureMass = Mass.FromOunces(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "gram/s"))
            {
                measureMass = Mass.FromGrams(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "kilogram/s"))
            {
                measureMass = Mass.FromKilograms(measure_forCvt);
            }

            //Convert
            if (String.Equals(unitOfMeasure_OG, "feet"))
            {
                measureConverted = measureLength.Feet;
            }
            else if (String.Equals(unitOfMeasure_OG, "meters"))
            {
                measureConverted = measureLength.Meters;
            }
            else if (String.Equals(unitOfMeasure_OG, "centimeters"))
            {
                measureConverted = measureLength.Centimeters;
            }
            else if (String.Equals(unitOfMeasure_OG, "millimeters"))
            {
                measureConverted = measureLength.Millimeters;
            }
            else if (String.Equals(unitOfMeasure_OG, "inches"))
            {
                measureConverted = measureLength.Inches; ;
            }
            else if (String.Equals(unitOfMeasure_OG, "ounces"))
            {
                measureConverted = measureMass.Ounces;
            }
            else if (String.Equals(unitOfMeasure_OG, "gram/s"))
            {
                measureConverted = measureMass.Grams;
            }
            else if (String.Equals(unitOfMeasure_OG, "kilogram/s"))
            {
                measureConverted = measureMass.Kilograms;
            }
            return measureConverted;
        }
        private double measureConverter(double measure_forCvt, String unitOfMeasure_OG, String unitOfMeasure_Used, int overload)
        {
            double measureConverted = 0;
            Volume measureVolume = Volume.FromLiters(1);

            if (String.Equals(unitOfMeasure_Used, "ounces"))
            {
                measureVolume = Volume.FromUsOunces(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "liters"))
            {
                measureVolume = Volume.FromLiters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "milliliters"))
            {
                measureVolume = Volume.FromMilliliters(measure_forCvt);
            }

            if (String.Equals(unitOfMeasure_OG, "ounces"))
            {
                measureConverted = measureVolume.UsOunces;
            }
            else if (String.Equals(unitOfMeasure_OG, "liters"))
            {
                measureConverted = measureVolume.Liters;
            }
            else if (String.Equals(unitOfMeasure_OG, "milliliters"))
            {
                measureConverted = measureVolume.Milliliters;
            }
            return measureConverted;
        }
        //----------------Event Methods-----------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCreateFrame_Click(object sender, EventArgs e)
        {
            frmFrameCreate formCreateAFrame = new frmFrameCreate();
            formCreateAFrame.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int currRowIndex = datagridFrameList.SelectedRows[0].Index;
            int selectedFrameItemId = Int32.Parse(datagridFrameList.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());
            String frameName = datagridFrameList.Rows[currRowIndex].Cells["Frame"].Value.ToString();
            String frameDimension = datagridFrameList.Rows[currRowIndex].Cells["Dimension"].Value.ToString();
            String frameDescription = datagridFrameList.Rows[currRowIndex].Cells["frameDescription"].Value.ToString();
            frmFrameEdit formEditFrame = new frmFrameEdit(selectedFrameItemId, frameName, frameDimension, frameDescription);
            formEditFrame.ShowDialog();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmFrameStockInAdd formFrameStockIn = new frmFrameStockInAdd();
            formFrameStockIn.ShowDialog();
        }

        private void btnArchiveList_Click(object sender, EventArgs e)
        {
            frmFrameArchivedList formFrameArchiveL = new frmFrameArchivedList();
            formFrameArchiveL.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            frmFrameDamagedItems frmFrameDmg = new frmFrameDamagedItems();
            frmFrameDmg.ShowDialog();
        }

        private void datagridFrameList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            suppliesUsed_Loader();
        }
    }
    class suppliesCosting
    {
        internal int supplyItemsId { get; set; }
        internal double costPerUnitMeasure { get; set; }
        internal double rawCost { get; set; }//RAW COST = costPerUnitMeasure * measureA OR Raw Cost = costPerUnitMeasure * (measureA*measureB)
        // public frame_ItemsforList() {
        //}
        public suppliesCosting(int employeeID,  double philHealth, double sss)
        {
            this.supplyItemsId = employeeID;
            this.costPerUnitMeasure = philHealth;
            this.rawCost = sss;
        }

    }
}
