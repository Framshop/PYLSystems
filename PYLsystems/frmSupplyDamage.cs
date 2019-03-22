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
    public partial class frmSupplyDamage : Form
    {
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        int supply_itemsId;
        double quantityLeft;
        double quantityLeftinMeasurement;
        DataTable dtSuppliesList;
        DataTable dtDamageList;
        DataTable dtSupplyInfo;
        DateTime DateStart;
        DateTime DateEnd;
        String typeOfMeasure;

        //--------------Initial Load--------------
        //----for programming initializer
        public frmSupplyDamage()
        {
            InitializeComponent();
        }
        public frmSupplyDamage(int supply_itemsId, double quantityLeft, double quantityLeftinMeasurement)
        {
            InitializeComponent();
            this.supply_itemsId = supply_itemsId;
            this.quantityLeft = quantityLeft;
            this.quantityLeftinMeasurement = quantityLeftinMeasurement;
        }
        private void frmSupplyDamage_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            startDatePicker.Enabled = true;
            endDatePicker.Enabled = true;
            suppliesLoader();
            controlsLimit();
            damage_materialsLoader();
            supplyInfoLoader();
            //MessageBox.Show(DateStart+" "+DateEnd);
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        public void damage_materialsLoader() {
            try
            {
                String stringDamageList = "SELECT sui.supply_itemsID,sui.supplyName AS `Supply Name`, dm.Description, " +
                    "if (suc.typeOfMeasure = 'Area', concat(dm.measureADeducted, ' x ', measureBDeducted),dm.measureADeducted) AS `Measures Deducted`," +
                    "     dm.unitMeasure AS `Unit Measure`, dm.totalQuantityStockedOut AS `Quantity Stocked Out`, dm.date_created AS `Date Stocked Out`," +
                    "dm.totalCostStockedOut AS `Cost of Stock Out` " +
                    "FROM damaged_Materials AS dm " +
                    "LEFT JOIN supply_items AS sui ON sui.supply_itemsiD = dm.supply_itemsID " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE sui.supply_itemsID = @supply_itemsID AND dm.date_created BETWEEN @DateStart AND @DateEnd;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdDamageList = new MySqlCommand(stringDamageList, my_conn);
                cmdDamageList.Parameters.AddWithValue("@supply_itemsID", this.supply_itemsId);
                cmdDamageList.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdDamageList.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdDamageList);

                dtDamageList = new DataTable();
                my_adapter.Fill(dtDamageList);

                dgvStockOut.DataSource = dtDamageList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            dgvStockOut.Columns["supply_itemsID"].Visible = false;
        }
        public void supplyInfoLoader()
        {
            try
            {
                String stringSupplyInfo = "SELECT sui.supply_itemsID, sui.supplyName, sui.unitMeasure, suc.categoryName, suc.typeOfMeasure " +
                    "FROM supply_items AS sui " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE sui.supply_itemsID = @supply_itemsID;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSupplyInfo = new MySqlCommand(stringSupplyInfo, my_conn);
                cmdSupplyInfo.Parameters.AddWithValue("@supply_itemsID", this.supply_itemsId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSupplyInfo);

                dtSupplyInfo = new DataTable();
                my_adapter.Fill(dtSupplyInfo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            txtItemName.Text = dtSupplyInfo.Rows[0]["supplyName"].ToString();
            txtSupplyCategory.Text = dtSupplyInfo.Rows[0]["categoryName"].ToString();
            txtUnitMeasure.Text = dtSupplyInfo.Rows[0]["unitMeasure"].ToString();

        }
        public void suppliesLoader()
        {
            try
            {
                String stringSuppliesList =
                    "SELECT si.supply_itemsID, si.supplyName AS `Supply Name`, si.supplyDescription AS `Supply Descripton`,  sc.categoryName AS `Category`, sc.typeOfMeasure," +
                    "                si.measureA AS `measureAOG`,si.measureB AS `measureBOG`," +
                    "                if (sc.typeOfMeasure = 'Area',concat(si.measureA, ' x ', si.measureB),si.measureA) AS `Base Measurements`," +
                    "                si.unitMeasure AS `Base Unit Measure`, " +
                    "                ifnull( if (sc.typeOfMeasure = 'Area',ROUND(((1 - (supsoA.stockOut / (si.measureA * si.measureB * supsiA.stockIn))) * supsiA.stockIn), 3)," +
                    "                												if (sc.typeOfMeasure = 'Whole',supsi.stockIn - supso.stockOut," +
                    "                																							ROUND(((1 - (supso.stockOut / (si.measureA * supsi.stockIn))) * supsi.stockIn), 3))), 0) AS `Quantity Left`," +
                    "                 ifnull( if (sc.typeOfMeasure = 'Area',ROUND(((si.measureA * si.measureB * supsiA.stockIn) - supsoA.stockOut), 3)," +
                    "                												if (sc.typeOfMeasure = 'Whole',supsi.stockIn - supso.stockOut," +
                    "                																							ROUND(((si.measureA * supsi.stockIn) - supso.stockOut), 3))), 0) AS `Quantity Left in Measurement`," +
                    "                ifnull(supsi.unitPrice, 0) AS `Cost per Unit`" +
                    "                FROM supply_items AS si" +
                    "                LEFT JOIN supply_Category AS sc ON si.supply_categoryID = sc.supply_categoryID" +
                    "                LEFT JOIN(SELECT supply_itemsID, SUM(stockin_quantity) `stockIn`, MAX(delivery_date) AS `Latest`, priceRawTotal AS `UnitPrice` FROM supply_details GROUP BY supply_itemsID) AS supsi ON si.supply_itemsID = supsi.supply_itemsID" +
                    "                LEFT JOIN(SELECT sui.supply_itemsID, SUM(IFNULL(dm.stockedOut,0)+IFNULL(fm.stockedOut, 0) + IFNULL(jo.stockedOut, 0)) AS `stockOut` " +
                    "                FROM supply_items AS sui" +
                    "                        LEFT JOIN(SELECT supply_itemsID, SUM(totalQuantityStockedOut) AS `totalStockedOut`, SUM(measureAtoOGUnit) AS `stockedOut`" +
                    "                                  FROM damaged_materials GROUP BY supply_itemsID) AS dm ON sui.supply_itemsID = dm.supply_itemsID" +
                    "                                  LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG) * SUM(fs.stockinQuantity) as `stockedOut` /*Measurements*/" +
                    "											FROM frame_materials as sfm" +
                    "                                            LEFT JOIN frame_list as fl ON sfm.frameItemID = fl.frameItemID" +
                    "                                            LEFT JOIN frameStock_In as fs ON fl.frameItemID = fs.frameItemID" +
                    "                                            GROUP BY supply_itemsID,fl.frameItemID) AS fm ON sui.supply_ItemsID = fm.supply_ItemsID" +
                    "                                  LEFT JOIN(SELECT sjo.supply_itemsID, SUM(sjo.measureAtoOG) * SUM(job.jobOrderQuantity) as `stockedOut` /*Measurements*/" +
                    "											FROM jOrder_Details as sjo" +
                    "                                            LEFT JOIN jobOrder as job ON sjo.jOrd_Num = job.jOrd_Num" +
                    "                                            GROUP BY supply_itemsID) AS jo ON sui.supply_ItemsID = jo.supply_ItemsID" +
                    "                                  GROUP BY sui.supply_itemsID" +
                    "								) AS supso ON si.supply_itemsID = supso.supply_itemsID" +
                    "                LEFT JOIN(" +
                    "                            SELECT supply_itemsID, SUM(stockin_quantity) AS `stockIn` FROM supply_details GROUP BY supply_itemsID" +
                    "                            )AS supsiA ON si.supply_itemsID = supsiA.supply_itemsID" +
                    "                LEFT JOIN(" +
                    "                        SELECT sui.supply_itemsID, SUM(IFNULL(dm.stockedOutArea,0)+IFNULL(fm.stockedOutArea, 0) + IFNULL(jo.stockedOutArea, 0)) AS `stockOut` " +
                    "						 FROM supply_items AS sui" +
                    "                        LEFT JOIN(SELECT supply_itemsID, SUM(totalQuantityStockedOut) AS `totalStockedOut`, SUM(measureAtoOGUnit* measureBtoOGUnit) AS `stockedOutArea`" +
                    "                                    FROM damaged_materials GROUP BY supply_itemsID) AS dm ON sui.supply_itemsID = dm.supply_itemsID" +
                    "                        LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG* sfm.measureBtoOG)*SUM(fs.stockinQuantity) as `stockedOutArea` /*Measurements*/" +
                    "									FROM frame_materials as sfm" +
                    "                                    LEFT JOIN frame_list as fl ON sfm.frameItemID = fl.frameItemID" +
                    "                                    LEFT JOIN frameStock_In as fs ON fl.frameItemID = fs.frameItemID" +
                    "                                    GROUP BY supply_itemsID) AS fm ON sui.supply_ItemsID = fm.supply_ItemsID" +
                    "                        LEFT JOIN(SELECT sjo.supply_itemsID, SUM(sjo.measureAtoOG* sjo.measureBtoOG)*SUM(job.jobOrderQuantity) as `stockedOutArea` /*Measurements*/" +
                    "									FROM jOrder_Details as sjo" +
                    "                                    LEFT JOIN jobOrder as job ON sjo.jOrd_Num = job.jOrd_Num" +
                    "                                    GROUP BY supply_itemsID) AS jo ON sui.supply_ItemsID = jo.supply_ItemsID" +
                    "                        GROUP BY sui.supply_itemsID" +
                    "				)AS supsoA ON si.supply_itemsID = supsoA.supply_itemsID " +
                    "                 WHERE si.supply_itemsID=@supply_itemsID  " +
                    "                   HAVING `Cost per Unit`>0 " +
                    "                   ORDER BY sc.categoryName, si.supplyName";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@supply_itemsID", this.supply_itemsId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSuppliesList = new DataTable();
                my_adapter.Fill(dtSuppliesList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void DefaultDatesInitializer()
        {
            DateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddHours(0).AddMinutes(0).AddSeconds(0);
            DateEnd = DateStart.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            startDatePicker.Value = DateStart;
            endDatePicker.Value = DateEnd;
        }
        private void controlsLimit()
        {
            typeOfMeasure = dtSuppliesList.Rows[0]["typeOfMeasure"].ToString();

            if(String.Equals(typeOfMeasure, "Length"))
                {
                txtBoxLength.Enabled = true;
                cboLengthUnit.Enabled = true;

                txtBoxAreaLength.Enabled = false;
                txtBoxAreaWidth.Enabled = false;
                cboAreaUnit.Enabled = false;

                txtBoxWeight.Enabled = false;
                cboWeightUnit.Enabled = false;

                txtBoxWhole.Enabled = false;
                cboWholeUnit.Enabled = false;

                txtBoxVolume.Enabled = false;
                cboVolumeUnit.Enabled = false;
            }
                else if (String.Equals(typeOfMeasure, "Area"))
            {
                txtBoxLength.Enabled = false;
                cboLengthUnit.Enabled = false;

                txtBoxAreaLength.Enabled = true;
                txtBoxAreaWidth.Enabled = true;
                cboAreaUnit.Enabled = true;

                txtBoxWeight.Enabled = false;
                cboWeightUnit.Enabled = false;

                txtBoxWhole.Enabled = false;
                cboWholeUnit.Enabled = false;

                txtBoxVolume.Enabled = false;
                cboVolumeUnit.Enabled = false;
            }
            else if (String.Equals(typeOfMeasure, "Weight"))
            {
                txtBoxLength.Enabled = false;
                cboLengthUnit.Enabled = false;

                txtBoxAreaLength.Enabled = false;
                txtBoxAreaWidth.Enabled = false;
                cboAreaUnit.Enabled = false;

                txtBoxWeight.Enabled = true;
                cboWeightUnit.Enabled = true;

                txtBoxWhole.Enabled = false;
                cboWholeUnit.Enabled = false;

                txtBoxVolume.Enabled = false;
                cboVolumeUnit.Enabled = false;
            }
            else if (String.Equals(typeOfMeasure, "Whole"))
            {
                txtBoxLength.Enabled = false;
                cboLengthUnit.Enabled = false;

                txtBoxAreaLength.Enabled = false;
                txtBoxAreaWidth.Enabled = false;
                cboAreaUnit.Enabled = false;

                txtBoxWeight.Enabled = false;
                cboWeightUnit.Enabled = false;

                txtBoxWhole.Enabled = true;
                cboWholeUnit.Enabled = false;

                txtBoxVolume.Enabled = false;
                cboVolumeUnit.Enabled = false;
            }
            else if (String.Equals(typeOfMeasure, "Volume"))
            {
                txtBoxLength.Enabled = false;
                cboLengthUnit.Enabled = false;

                txtBoxAreaLength.Enabled = false;
                txtBoxAreaWidth.Enabled = false;
                cboAreaUnit.Enabled = false;

                txtBoxWeight.Enabled = false;
                cboWeightUnit.Enabled = false;

                txtBoxWhole.Enabled = false;
                cboWholeUnit.Enabled = false;

                txtBoxVolume.Enabled = true;
                cboVolumeUnit.Enabled = true;
            }
            cboAreaUnit.SelectedIndex = 1;
            cboLengthUnit.SelectedIndex = 1;
            cboVolumeUnit.SelectedIndex = 0;
            cboWeightUnit.SelectedIndex = 0;
            cboWholeUnit.SelectedIndex = 0;
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
        private void trueCostCalculation()
        {
            typeOfMeasure = dtSuppliesList.Rows[0]["typeOfMeasure"].ToString();
            double unitPriceOG = Double.Parse(dtSuppliesList.Rows[0]["Cost per Unit"].ToString());
            double trueUnitPrice=0;
            double rawCost=0;//get the trueUnitPrice first.
            double quantityConverted=0;//theQuantityConverted
            double quantityLeft = this.quantityLeft;
            double quantityLeftinMeasurement = this.quantityLeftinMeasurement;
            String unitMeasure_OG = dtSuppliesList.Rows[0]["Base Unit Measure"].ToString();
            String unitMeasureUsed="";

            double measureAOG=Double.Parse(dtSuppliesList.Rows[0]["measureAOG"].ToString());
            double measureBOG=0;
            double measureAUsed=0;
            double measureBUsed=0;
            double areaOfUsed = 0;
            double area_OG = 0;

            //Initializing Variables
            if (String.Equals(typeOfMeasure, "Whole"))
            {
                if (String.IsNullOrEmpty(txtBoxWhole.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxWhole.Text);
                }                                
            }
            else if (String.Equals(typeOfMeasure, "Area"))
            {
                if (String.IsNullOrEmpty(txtBoxAreaLength.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxAreaLength.Text);

                }
                if (String.IsNullOrEmpty(txtBoxAreaWidth.Text))
                {
                    measureBUsed = 0;
                }
                else
                {
                    measureBUsed = Double.Parse(txtBoxAreaWidth.Text);
                }
                measureBOG = Double.Parse(dtSuppliesList.Rows[0]["measureBOG"].ToString());
                area_OG = measureAOG * measureBOG;
                trueUnitPrice = unitPriceOG / area_OG;
                unitMeasureUsed = cboAreaUnit.Text;
            }
            else if (String.Equals(typeOfMeasure, "Volume"))
            {
                if (String.IsNullOrEmpty(txtBoxVolume.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxVolume.Text);
                }
                trueUnitPrice = unitPriceOG / measureAOG;
                unitMeasureUsed = cboVolumeUnit.Text;
            }
            else if (String.Equals(typeOfMeasure, "Length"))
            {
                if (String.IsNullOrEmpty(txtBoxLength.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxLength.Text);
                }
                trueUnitPrice = unitPriceOG / measureAOG;
                unitMeasureUsed = cboLengthUnit.Text;
            }
            else if (String.Equals(typeOfMeasure, "Weight"))
            {
                if (String.IsNullOrEmpty(txtBoxWeight.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxWeight.Text);
                }
                trueUnitPrice = unitPriceOG / measureAOG;
                unitMeasureUsed = cboWeightUnit.Text;
            }

            //Calculation
            if (String.Equals(typeOfMeasure, "Whole"))
            {
                rawCost = measureAUsed * unitPriceOG;
                quantityConverted = measureAUsed;
            }
            else if (String.Equals(unitMeasureUsed, unitMeasure_OG))
            {
                if(String.Equals(typeOfMeasure, "Area")){
                    areaOfUsed = measureAUsed * measureBUsed;
                    
                    rawCost = areaOfUsed * trueUnitPrice;

                    quantityConverted = quantityLeft - ((1-(areaOfUsed/quantityLeftinMeasurement))*quantityLeft);
                }
                else{
                    trueUnitPrice = unitPriceOG /measureAOG;
                    rawCost = measureAUsed * trueUnitPrice;

                    quantityConverted = quantityLeft - ((1 - (measureAUsed / quantityLeftinMeasurement)) * quantityLeft);
                }
            }
            else
            {
                if (String.Equals(typeOfMeasure, "Area"))
                {
                    double measureAConvertedUse = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed);
                    double measureBConvertedUse = measureConverter(measureBUsed, unitMeasure_OG, unitMeasureUsed);

                    areaOfUsed = measureAConvertedUse * measureBConvertedUse; //Calculate the area of Use of the used up converted measurements

                    rawCost = areaOfUsed * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price

                    quantityConverted = quantityLeft - ((1 - (areaOfUsed / quantityLeftinMeasurement)) * quantityLeft);
                    //NOTE: To be used for inserting:
                    //double measureAUsedtoOGConvert = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed);
                    //double measureBUsedtoOGConvert = measureConverter(measureBUsed, unitMeasure_OG, unitMeasureUsed);
                }
                else
                {
                    //Get the already converted Measurements in frame_materials table.
                    //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                    double measureAConvertedUse;
                    if (String.Equals(typeOfMeasure, "Volume"))
                    {
                        measureAConvertedUse = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed, 0);
                    }
                    else
                    {
                        measureAConvertedUse = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed);                    }

                    quantityConverted = quantityLeft - ((1 - (measureAConvertedUse / quantityLeftinMeasurement)) * quantityLeft);
                    rawCost = measureAConvertedUse * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                }
            }

            txtCalculatedStockedQuantity.Text = quantityConverted.ToString();
            txtTotalDamageCost.Text = rawCost.ToString();
        }
        private void sendToDatabase()
        {
            double measureAUsed = 0;
            double measureBUsed = 0;
            double measureAtoOG = 0;
            double measureBtoOG = 0;
            String unitMeasureUsed = "";
            String unitMeasureOG = dtSuppliesList.Rows[0]["Base Unit Measure"].ToString();
            //Initializing Variables
            if (String.Equals(typeOfMeasure, "Whole"))
            {
                measureAUsed = Double.Parse(txtBoxWhole.Text);
                measureAtoOG = measureAUsed;
            }
            else if (String.Equals(typeOfMeasure, "Area"))
            {
                measureAUsed = Double.Parse(txtBoxAreaLength.Text);
                measureBUsed = Double.Parse(txtBoxAreaWidth.Text);             
                unitMeasureUsed = cboAreaUnit.Text;

                measureAtoOG = measureConverter(measureAUsed, unitMeasureOG, unitMeasureUsed);
                measureBtoOG = measureConverter(measureBUsed, unitMeasureOG, unitMeasureUsed);
            }
            else if (String.Equals(typeOfMeasure, "Volume"))
            {
                measureAUsed = Double.Parse(txtBoxVolume.Text);
                unitMeasureUsed = cboVolumeUnit.Text;

                measureAtoOG = measureConverter(measureAUsed, unitMeasureOG, unitMeasureUsed,0);

                //MessageBox.Show("measureAUsed: "+measureAUsed+" measureAtoOG: "+measureAtoOG);
            }
            else if (String.Equals(typeOfMeasure, "Length"))
            {
                measureAUsed = Double.Parse(txtBoxLength.Text);
                unitMeasureUsed = cboLengthUnit.Text;

                measureAtoOG = measureConverter(measureAUsed, unitMeasureOG, unitMeasureUsed);
            }
            else if (String.Equals(typeOfMeasure, "Weight"))
            {
                measureAUsed = Double.Parse(txtBoxWeight.Text);
                unitMeasureUsed = cboWeightUnit.Text;

                measureAtoOG = measureConverter(measureAUsed, unitMeasureOG, unitMeasureUsed);
            }
            //Sending to insert methods
            if (String.Equals(typeOfMeasure, "Area"))
            {
                insertAreaToDataBase(measureAUsed,measureBUsed,measureAtoOG,measureBtoOG,unitMeasureUsed);
            }
            else
            {
                insertToDataBase(measureAUsed,measureAtoOG,unitMeasureUsed);
            }
            MessageBox.Show("Supply has been Stocked Out.");
        }
        private void insertAreaToDataBase(double measureAUsed, double measureBused, double measureAtoOG, double measureBtoOG, String unitMeasureUsed)
        {
            try
            {
                String stringInsertToFrameStockIn =
                    "INSERT INTO damaged_materials (description,supply_itemsID,date_created," +
                    "measureADeducted,measureBDeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure," +
                    "measureAtoOGUnit,measureBtoOGUnit) " +
                    "VALUES(@description, @supply_itemsID, curdate()," +
                    "@measureAUsed, @measureBUsed, @totalQuantity, @totalCost, @unitMeasure, @measureAtoOG, @measureBtoOG) ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdInsertToFrameStockIn = new MySqlCommand(stringInsertToFrameStockIn, my_conn);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@description", this.txtDamageReason.Text);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@supply_itemsID", this.supply_itemsId);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@measureAUsed", measureAUsed);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@measureBUsed", measureBused);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@totalQuantity", Double.Parse(this.txtCalculatedStockedQuantity.Text));
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@totalCost", Double.Parse(this.txtTotalDamageCost.Text));
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@unitMeasure", unitMeasureUsed);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@measureAtoOG", measureAtoOG);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@measureBtoOG", measureBtoOG);
                my_conn.Open();
                cmdInsertToFrameStockIn.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            damage_materialsLoader();
            txtDamageReason.Text = "";
            txtBoxAreaLength.Text = "";
            txtBoxAreaWidth.Text = "";
            txtCalculatedStockedQuantity.Text = "";
            txtTotalDamageCost.Text = "";
        }
        private void insertToDataBase(double measureAUsed, double measureAtoOG, String unitMeasureUsed)
        {
            try
            {
                String stringInsertToFrameStockIn =
                    "INSERT INTO damaged_materials (description,supply_itemsID,date_created," +
                    "measureADeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure," +
                    "measureAtoOGUnit) " +
                    "VALUES(@description, @supply_itemsID, curdate()," +
                    "@measureAUsed, @totalQuantity, @totalCost, @unitMeasure, @measureAtoOG) ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdInsertToFrameStockIn = new MySqlCommand(stringInsertToFrameStockIn, my_conn);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@description", this.txtDamageReason.Text);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@supply_itemsID", this.supply_itemsId);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@measureAUsed", measureAUsed);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@totalQuantity", Double.Parse(this.txtCalculatedStockedQuantity.Text));
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@totalCost", Double.Parse(this.txtTotalDamageCost.Text));
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@unitMeasure", unitMeasureUsed);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@measureAtoOG", measureAtoOG);
                my_conn.Open();
                cmdInsertToFrameStockIn.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            damage_materialsLoader();
            txtDamageReason.Text = "";
            txtBoxLength.Text = "";
            txtBoxVolume.Text = "";
            txtBoxWeight.Text = "";
            txtBoxWhole.Text = "";
            txtCalculatedStockedQuantity.Text = "";
            txtTotalDamageCost.Text = "";
        }
        private bool quantityChecker()
        {
            double quantityLeftinMeasure = this.quantityLeftinMeasurement;
            double quantityCheck;

            String unitMeasure_OG = dtSuppliesList.Rows[0]["Base Unit Measure"].ToString();
            String unitMeasureUsed = "";

            double measureAOG = Double.Parse(dtSuppliesList.Rows[0]["measureAOG"].ToString());
            double measureBOG = 0;
            double measureAUsed = 0;
            double measureBUsed = 0;
            double areaOfUsed = 0;
            double area_OG = 0;
            double measureAConvertedUse=0;
            double measureBConvertedUse=0;
            //Initializing Variables
            if (String.Equals(typeOfMeasure, "Whole"))
            {
                if (String.IsNullOrEmpty(txtBoxWhole.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxWhole.Text);
                }
            }
            else if (String.Equals(typeOfMeasure, "Area"))
            {
                if (String.IsNullOrEmpty(txtBoxAreaLength.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxAreaLength.Text);

                }
                if (String.IsNullOrEmpty(txtBoxAreaWidth.Text))
                {
                    measureBUsed = 0;
                }
                else
                {
                    measureBUsed = Double.Parse(txtBoxAreaWidth.Text);
                }
                measureBOG = Double.Parse(dtSuppliesList.Rows[0]["measureBOG"].ToString());
                area_OG = measureAOG * measureBOG;

                unitMeasureUsed = cboAreaUnit.Text;
            }
            else if (String.Equals(typeOfMeasure, "Volume"))
            {
                if (String.IsNullOrEmpty(txtBoxVolume.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxVolume.Text);
                }

                unitMeasureUsed = cboVolumeUnit.Text;
            }
            else if (String.Equals(typeOfMeasure, "Length"))
            {
                if (String.IsNullOrEmpty(txtBoxLength.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxLength.Text);
                }

                unitMeasureUsed = cboLengthUnit.Text;
            }
            else if (String.Equals(typeOfMeasure, "Weight"))
            {
                if (String.IsNullOrEmpty(txtBoxWeight.Text))
                {
                    measureAUsed = 0;
                }
                else
                {
                    measureAUsed = Double.Parse(txtBoxWeight.Text);
                }
                unitMeasureUsed = cboWeightUnit.Text;
            }

            //Calculation for Quantity Checking
            if (String.Equals(typeOfMeasure, "Whole"))
            {
                quantityCheck = quantityLeftinMeasurement - measureAUsed;
            }
            else if (String.Equals(unitMeasureUsed, unitMeasure_OG))
            {
                if (String.Equals(typeOfMeasure, "Area"))
                {
                    areaOfUsed = measureAUsed * measureBUsed;
                    quantityCheck = quantityLeftinMeasurement - areaOfUsed;
                }
                else
                {
                    quantityCheck = quantityLeftinMeasurement - measureAUsed;
                }
            }
            else
            {
                if (String.Equals(typeOfMeasure, "Area"))
                {
                    measureAConvertedUse = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed);
                    measureBConvertedUse = measureConverter(measureBUsed, unitMeasure_OG, unitMeasureUsed);

                    areaOfUsed = measureAConvertedUse * measureBConvertedUse; //Calculate the area of Use of the used up converted measurements

                    quantityCheck = quantityLeftinMeasurement - areaOfUsed;
                    //NOTE: To be used for inserting:
                    //double measureAUsedtoOGConvert = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed);
                    //double measureBUsedtoOGConvert = measureConverter(measureBUsed, unitMeasure_OG, unitMeasureUsed);
                }
                else
                {
                    //Get the already converted Measurements in frame_materials table.
                    //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms

                    if (String.Equals(typeOfMeasure, "Volume"))
                    {
                        measureAConvertedUse = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed, 0);
                    }
                    else
                    {
                        measureAConvertedUse = measureConverter(measureAUsed, unitMeasure_OG, unitMeasureUsed);
                    }

                    quantityCheck = quantityLeftinMeasurement - measureAConvertedUse; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                }
            }

            //if (String.Equals(typeOfMeasure, "Area"))
            //{
            //    MessageBox.Show("Quantity Left in Measurements: "+quantityLeftinMeasure
            //        + "\n Subtracted Area: "+areaOfUsed
            //        + "\n measureAUsed: "+measureAUsed
            //        + "\n measureBUsed: "+measureBUsed
            //        + "\n measureAtoOG: "+ measureAConvertedUse
            //        + "\n measureBtoOG: " + measureBConvertedUse
            //        + "\n quantityCheck: " + quantityCheck);
            //}
            //else
            //{
            //    MessageBox.Show("Quantity Left in Measurements: " + quantityLeftinMeasure
            //       + "\n Subtracted Area: " + areaOfUsed
            //       + "\n measureAUsed: " + measureAUsed
            //       + "\n measureAtoOG: " + measureAConvertedUse
            //       + "\n quantityCheck: " + quantityCheck);
            //}
            if (quantityCheck < 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        //----------------Event Methods-----------------
        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled)
            {
                DateStart = startDatePicker.Value;
                damage_materialsLoader();
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled)
            {
                DateEnd = endDatePicker.Value;
                damage_materialsLoader();
            }
        }

        private void txtBoxLength_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxAreaLength_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxAreaWidth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxWhole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxVolume_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnStockOutItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDamageReason.Text))
            {
                MessageBox.Show("Please Enter a Description");
                return;
            }
            if (String.Equals(typeOfMeasure, "Area") && ((String.IsNullOrEmpty(txtBoxAreaLength.Text) || String.IsNullOrEmpty(txtBoxAreaWidth.Text))
            && ((Double.Parse(txtBoxAreaLength.Text) == 0 || Double.Parse(txtBoxAreaWidth.Text) == 0))))
            {
                MessageBox.Show("Please Enter the Values");
                return;
            }
            else
            {
                if (String.Equals(typeOfMeasure, "Length") && (String.IsNullOrEmpty(txtBoxLength.Text) || Double.Parse(txtBoxLength.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(typeOfMeasure, "Weight") && (String.IsNullOrEmpty(txtBoxWeight.Text) || Double.Parse(txtBoxWeight.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(typeOfMeasure, "Volume") && (String.IsNullOrEmpty(txtBoxVolume.Text) || Double.Parse(txtBoxVolume.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(typeOfMeasure, "Whole") && (String.IsNullOrEmpty(txtBoxWhole.Text) || Double.Parse(txtBoxWhole.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
            }
            bool quantityValidation = quantityChecker();
            if (quantityValidation == false)
            {
                MessageBox.Show("Insufficient Supplies. Cannot Stock Out more than Stocked In Materials");
                return;
            }
            sendToDatabase();
        }

        private void txtBoxValueChange(object sender, EventArgs e)
        {
            trueCostCalculation();
        }

        private void cboValueChanged(object sender, EventArgs e)
        {
            trueCostCalculation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
