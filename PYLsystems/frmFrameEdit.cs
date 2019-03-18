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
using UnitsNet;

namespace PYLsystems
{
    public partial class frmFrameEdit : Form
    {
        private int frameItemId;
        private String frameName;
        private String frameDimension;
        private String frameDescription;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";

        DataTable dtSelectSupplies; //Selected from Database
        DataTable dtSelectSuppliesFiltered; //removed Original UnitMeasure and PURCHASE UnitPrice. Use this for merging
        DataTable dtSuppliesUsed; //Merged DataTable

        DataTable dtSelectSuppliesSaved;
        DataTable dtSuppliesUsedSaved;

        List<int> RemovedSuppliesItemId;

        List<suppliesSavedForUpdates> suppliesConvertedtoOG;
        //--------------Initial Load--------------
        //----for programming initializer

        public frmFrameEdit()
        {
            InitializeComponent();
            this.frameItemId = 1;
            this.frameName = "BLACK2L00001A8 8X10WM";
            this.frameDimension = "8x10";
            this.frameDescription = "BLACK2L00001A8 8X10\" With Matting";
        }
        public frmFrameEdit(int frameItemId, String frameName, String frameDimension, String frameDescription)
        {
            InitializeComponent();
            this.frameItemId = frameItemId;
            this.frameName = frameName;
            this.frameDimension = frameDimension;
            this.frameDescription = frameDescription;
        }
        private void frmFrameEdit_Load(object sender, EventArgs e)
        {
            frmFrameEdit_Loader();
        }

        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmFrameEdit_Loader()
        {
            this.txtBoxFrameName.Text = this.frameName;
            this.txtBoxDimension.Text = this.frameDimension;
            this.txtBoxDescription.Text = this.frameDescription;

            suppliesUsed_Loader();
            

        }
        private void suppliesUsed_Loader()
        {
            RemovedSuppliesItemId = new List<int>();
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

            selectSuppliesLoader(this.frameItemId);
            dtSuppliesUsed.Merge(dtSelectSuppliesFiltered);

            dtSuppliesUsedSaved = dtSuppliesUsed.Copy();

            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;

            costingCalculate();
            dataGridSuppliesUsed.Columns["Cost/Unit Measure"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            dataGridSuppliesUsed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
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
                    "sui.measureA, sui.measureB " +
                    "FROM supply_items AS sui " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "LEFT JOIN frame_materials AS fm ON sui.supply_itemsID = fm.supply_itemsID " +
                    "WHERE fm.frameItemId = @frameItemID; ";

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
                    "FROM supply_items AS sui " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "LEFT JOIN frame_materials AS fm ON sui.supply_itemsID = fm.supply_itemsID " +
                    "WHERE fm.frameItemId = @frameItemID; ";

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
            dtSelectSuppliesSaved = dtSelectSupplies.Copy();
        }
        //COSTS CALCULATION. FOR SELECTED UNIT PRICE AND RAW COST
        private void originalCostingCalculate()
        {

        }
        private void costingCalculate() //Retrieve from Database and calculate
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

                            //double measureAConverted = measureConverter(measureA_OG,unitOfMeasure_Used, unitOfMeasure_OG);
                            //double measureBConverted = measureConverter(measureB_OG, unitOfMeasure_Used, unitOfMeasure_OG);

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
                            //    measureA_converted = measureConverter(measureA_OG, unitOfMeasure_Used, unitOfMeasure_OG, 0);
                            //}
                            //else
                            //{
                            //    measureA_converted = measureConverter(measureA_OG, unitOfMeasure_Used,unitOfMeasure_OG);
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
        private double measureConverter(double measure_OG, String unitOfMeasure_OG, String unitOfMeasure_Used)
        {
            double measureConverted = 0;
            Length measureLength = Length.FromMeters(1);
            Mass measureMass = Mass.FromGrams(1);

            //Initialize
            if (String.Equals(unitOfMeasure_Used, "feet"))
            {
                measureLength = Length.FromFeet(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "meters"))
            {
                measureLength = Length.FromMeters(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "centimeters"))
            {
                measureLength = Length.FromCentimeters(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "millimeters"))
            {
                measureLength = Length.FromMillimeters(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "inches"))
            {
                measureLength = Length.FromInches(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "ounces"))
            {
                measureMass = Mass.FromOunces(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "gram/s"))
            {
                measureMass = Mass.FromGrams(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "kilogram/s"))
            {
                measureMass = Mass.FromKilograms(measure_OG);
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
        private double measureConverter(double measure_OG, String unitOfMeasure_Used, String unitOfMeasure_OG, int overload)
        {
            double measureConverted = 0;
            Volume measureVolume = Volume.FromLiters(1);

            if (String.Equals(unitOfMeasure_Used, "ounces"))
            {
                measureVolume = Volume.FromUsOunces(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "liters"))
            {
                measureVolume = Volume.FromLiters(measure_OG);
            }
            else if (String.Equals(unitOfMeasure_Used, "milliliters"))
            {
                measureVolume = Volume.FromMilliliters(measure_OG);
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
        //March 17,2019 - Before Adding a Row, check RemovedSuppliesItemId first if it contains supply_ItemsId being added.
        private void deleteRowFromDataGrid(int currRowIndex)
        {
            bool checkIfInDatabase=false;
            int suppliesItemId=-1;
            //Check if deleted item is in database or from the datatable retrieved from the database
            for(int i=0; i < dtSelectSupplies.Rows.Count; i++)
            {
                if (Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["supply_itemsId"].Value.ToString())==Int32.Parse(dtSelectSupplies.Rows[i]["supply_itemsId"].ToString()))
                {
                    checkIfInDatabase=true;
                    suppliesItemId = Int32.Parse(dtSelectSupplies.Rows[i]["supply_itemsId"].ToString());
                    MessageBox.Show(this.dataGridSuppliesUsed.SelectedRows[0].Index+" "+checkIfInDatabase);
                }
            }
            //If it exists, put to a list later for active
            if (checkIfInDatabase)
            {
                if (suppliesItemId > 0) { 
                    RemovedSuppliesItemId.Add(suppliesItemId);
                    dataGridSuppliesUsed.Rows.RemoveAt(this.dataGridSuppliesUsed.SelectedRows[0].Index);
                }
            }
            else
            {
                dataGridSuppliesUsed.Rows.RemoveAt(this.dataGridSuppliesUsed.SelectedRows[0].Index);
            }
            MessageBox.Show(suppliesItemId+" "+RemovedSuppliesItemId[0]+"");
        }
        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed frmAddSupplies = new frmFrameAddSuppliesUsed();
            frmAddSupplies.ShowDialog();
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            frmFrameEditSuppliesUsed frmEditSupplies = new frmFrameEditSuppliesUsed();
            frmEditSupplies.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currRowIndex = dataGridSuppliesUsed.SelectedRows[0].Index;
            deleteRowFromDataGrid(currRowIndex);
        }
    }
    class suppliesSavedForUpdates
    {
        internal int supplyItemsId { get; set; }
        internal String typeOfMeasure { get; set; }
        internal double measureAConvertedOG { get; set; }
        internal double measureBConvertedOG { get; set; }

        // public frame_ItemsforList() {
        //}
        public suppliesSavedForUpdates(int supplyItemsId, String typeOfMeasure, double measureAConvertedOG, double measureBConvertedOG)
        {
            this.supplyItemsId = supplyItemsId;
            this.typeOfMeasure = typeOfMeasure;
            this.measureAConvertedOG = measureAConvertedOG;
            this.measureBConvertedOG = measureBConvertedOG;

        }
    }
}
