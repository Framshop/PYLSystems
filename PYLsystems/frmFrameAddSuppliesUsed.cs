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
    public partial class frmFrameAddSuppliesUsed : Form
    {
        private int employeeId;
        private int employeeStatus;
        private int frameItemId;
        private int jobOrderID;
        frmFrameEdit pFrmFrameEdit;
        frmFrameCreate pFrmFrameCreate;
        frmJobOrderCreate pFrmJobOrderCreate;
        frmJobOrderEdit pFrmJobOrderEdit;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        DataTable dtSuppliesList;
        DataTable dtSuppliesListView;
        //--------------Initial Load--------------
        //----for programming initializer
        //NOTE!!!! GET DATA FROM dtSuppliesList TO PASS THROUGH PARENT FORM
        public frmFrameAddSuppliesUsed(frmFrameEdit pFrmFrameEdit, int frameItemId)
        {
            InitializeComponent();
            this.pFrmFrameEdit = pFrmFrameEdit;
            this.frameItemId = frameItemId;
        }
        public frmFrameAddSuppliesUsed(frmFrameCreate pFrmFrameCreate)
        {
            InitializeComponent();
            this.pFrmFrameCreate = pFrmFrameCreate;
            this.frameItemId = -1;
        }
        public frmFrameAddSuppliesUsed(frmJobOrderCreate pFrmJobOrderCreate)
        {
            InitializeComponent();
            this.pFrmJobOrderCreate = pFrmJobOrderCreate;
            this.jobOrderID = -1;
        }
        public frmFrameAddSuppliesUsed(frmJobOrderEdit pFrmJobOrderEdit,int jobOrderID)
        {
            InitializeComponent();
            this.pFrmJobOrderEdit = pFrmJobOrderEdit;
            this.jobOrderID = jobOrderID;
        }
        private void frmFrameAddSuppliesUsed_Load(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed_Loader();
            
            selectedItemLoader();
           
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmFrameAddSuppliesUsed_Loader()
        { //FOR VIEWING PURPOSES for create/edit frame
            if (pFrmFrameCreate != null || pFrmFrameEdit != null) { 
               
                try
                {
                    String stringSuppliesList =
                        "SELECT sui.supply_ItemsId, sui.supplyName AS `Supply Name`, sui.supplyDescription AS `Description`,  " +
                        "                    suc.categoryName AS `Category`, if (suc.typeOfMeasure = 'Area',concat(sui.measureA, ' x ', sui.measureB),sui.measureA) AS `Base Measurements`," +
                        "                         sui.unitMeasure AS `Base Unit Measure`, IFNULL(MAX(sud.delivery_date), 'None') AS `Latest_Stock_In`, IFNULL(sud.priceRawTotal, 0) AS `Cost per Unit`, suc.typeOfMeasure,  " +
                        "                    sui.MeasureA AS `measureAOG`,sui.MeasureB AS `measureBOG`  " +
                        "                    FROM supply_Items AS sui" +
                        "                    LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID" +
                        "                    LEFT JOIN supply_details AS sud ON sui.supply_itemsId = sud.supply_itemsID" +
                        "                    GROUP BY sui.supply_itemsId HAVING `Cost per Unit`>0" +
                        "                    ORDER BY suc.categoryName, sui.supplyName; ";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                    dtSuppliesListView = new DataTable();
                    my_adapter.Fill(dtSuppliesListView);
                    datagridSuppliesList.DataSource = dtSuppliesListView;
                    datagridSuppliesList.Columns["supply_ItemsId"].Visible = false;
                    datagridSuppliesList.Columns["typeOfMeasure"].Visible = false;
                    datagridSuppliesList.Columns["measureAOG"].Visible = false;
                    datagridSuppliesList.Columns["measureBOG"].Visible = false;
                    datagridSuppliesList.Columns["Latest_Stock_In"].Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                datagridSuppliesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
                //String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)
                cboAreaUnit.SelectedIndex = 1;
                cboLengthUnit.SelectedIndex = 1;
                cboVolumeUnit.SelectedIndex = 0;
                cboWeightUnit.SelectedIndex = 0;
                cboWholeUnit.SelectedIndex = 0;
            }
            else if(pFrmJobOrderCreate!=null || pFrmJobOrderEdit != null)
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
                        "                   HAVING `Cost per Unit`>0 " +
                        "                   ORDER BY sc.categoryName, si.supplyName";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                    dtSuppliesListView = new DataTable();
                    my_adapter.Fill(dtSuppliesListView);
                    datagridSuppliesList.DataSource = dtSuppliesListView;
                    datagridSuppliesList.Columns["supply_ItemsId"].Visible = false;
                    datagridSuppliesList.Columns["typeOfMeasure"].Visible = false;
                    datagridSuppliesList.Columns["measureAOG"].Visible = false;
                    datagridSuppliesList.Columns["measureBOG"].Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                datagridSuppliesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
                //String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)
                cboAreaUnit.SelectedIndex = 1;
                cboLengthUnit.SelectedIndex = 1;
                cboVolumeUnit.SelectedIndex = 0;
                cboWeightUnit.SelectedIndex = 0;
                cboWholeUnit.SelectedIndex = 0;
            }


        }
        private void selectedItemLoader()
        {
            try
            {

                int currRowIndex = datagridSuppliesList.SelectedRows[0].Index;
                txtBoxCategory.Text = datagridSuppliesList.Rows[currRowIndex].Cells["Category"].Value.ToString();
                txtBoxSupplyName.Text = datagridSuppliesList.Rows[currRowIndex].Cells["Supply Name"].Value.ToString();
                txtBoxTypeOfM.Text = datagridSuppliesList.Rows[currRowIndex].Cells["typeOfMeasure"].Value.ToString();
                txtBoxLength.Text = "";
                txtBoxAreaLength.Text = "";
                txtBoxAreaWidth.Text = "";
                txtBoxVolume.Text = "";
                txtBoxWhole.Text = "";
                txtBoxWeight.Text = "";
                if (String.Equals(txtBoxTypeOfM.Text, "Length"))
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
                else if (String.Equals(txtBoxTypeOfM.Text, "Area"))
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
                else if (String.Equals(txtBoxTypeOfM.Text, "Weight"))
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
                else if (String.Equals(txtBoxTypeOfM.Text, "Whole"))
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
                else if (String.Equals(txtBoxTypeOfM.Text, "Volume"))
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
            }
            catch { }
        }
        private void sendToParentForm()
        {
            //supply_ItemsId, Supply Name, Description, Category, Base Measurements, Base Unit Measure, Cost per Unit, typeOfMeasure, measureAOG, measureBOG
            int currRowIndex = datagridSuppliesList.SelectedRows[0].Index;
            int frameItemId =-1;
            int jobOrderID = -1;
            int supplyItemsId = Int32.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["supply_ItemsId"].Value.ToString());

            double measureAUsed=-1;
            double measureBUsed=-1;
            String unitMeasureUsed = datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString();
            String unitMeasure_OG = datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString();
            String typeOfMeasure = txtBoxTypeOfM.Text;
            String supplyName = txtBoxSupplyName.Text;
            double unitPriceOG = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["Cost per Unit"].Value.ToString());
            double measureA_OG = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["measureAOG"].Value.ToString());
            double measureB_OG = -1;

            
            String category = txtBoxCategory.Text;

            if (this.frameItemId>-1)
            {
                frameItemId = this.frameItemId;
            }
            if (this.jobOrderID > -1)
            {
                jobOrderID = this.jobOrderID;
            }
            if (String.Equals(typeOfMeasure, "Area"))
            {
                measureAUsed = Double.Parse(txtBoxAreaLength.Text);
                measureBUsed = Double.Parse(txtBoxAreaWidth.Text);
                measureB_OG = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["measureBOG"].Value.ToString());
                unitMeasureUsed = cboAreaUnit.Text;
            }
            else
            {
                if (String.Equals(typeOfMeasure, "Length"))
                {
                    measureAUsed = Double.Parse(txtBoxLength.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboLengthUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Weight"))
                {
                    measureAUsed = Double.Parse(txtBoxWeight.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboWeightUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Volume"))
                {
                    measureAUsed = Double.Parse(txtBoxVolume.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboVolumeUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Whole"))
                {
                    measureAUsed = Double.Parse(txtBoxWhole.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboWholeUnit.Text;
                }
            }

            //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
            //String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)

            forAddEditSupplies addEditSuppliesVals = new forAddEditSupplies(frameItemId,supplyItemsId,measureAUsed,measureBUsed,unitMeasureUsed,unitMeasure_OG,
                typeOfMeasure,supplyName,unitPriceOG,measureA_OG,measureB_OG,category);
            if (pFrmJobOrderEdit != null || pFrmJobOrderCreate != null)
            {
                addEditSuppliesVals = new forAddEditSupplies(jobOrderID, supplyItemsId, measureAUsed, measureBUsed, unitMeasureUsed, unitMeasure_OG,
                typeOfMeasure, supplyName, unitPriceOG, measureA_OG, measureB_OG, category);
            }

            if (pFrmFrameCreate != null)
            {
                pFrmFrameCreate.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            else if (pFrmFrameEdit!=null)
            {
                pFrmFrameEdit.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            else if (pFrmJobOrderCreate != null)
            {
                pFrmJobOrderCreate.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            else if (pFrmJobOrderEdit != null)
            {
                pFrmJobOrderEdit.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            this.Close();
        }
        private bool quantityChecker()
        {
            int currRowIndex = datagridSuppliesList.SelectedRows[0].Index;

            double quantityLeftinMeasure = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["Quantity Left in Measurement"].Value.ToString());
            double quantityCheck;
            double measureAUsedConverted;
            double measureBUsedConverted;

            double totalAreaUsed;

            if (String.Equals(txtBoxTypeOfM.Text, "Whole"))
            {
                measureAUsedConverted = Double.Parse((txtBoxWhole.Text));
                quantityCheck = quantityLeftinMeasure - measureAUsedConverted;                
            }
            else if (String.Equals(txtBoxTypeOfM.Text, "Area"))
            {
                if(String.Equals(cboAreaUnit.Text, datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString()))
                {
                    measureAUsedConverted = Double.Parse(txtBoxAreaLength.Text);
                    measureBUsedConverted = Double.Parse(txtBoxAreaWidth.Text);
                }
                else
                {
                    measureAUsedConverted = measureConverter(Double.Parse(txtBoxAreaLength.Text),
                        datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString(),cboAreaUnit.Text);
                    measureBUsedConverted = measureConverter(Double.Parse(txtBoxAreaWidth.Text),
                        datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString(), cboAreaUnit.Text);
                }
                totalAreaUsed = measureAUsedConverted * measureBUsedConverted;
                quantityCheck = quantityLeftinMeasure - totalAreaUsed;
            }
            else if (String.Equals(txtBoxTypeOfM.Text, "Volume"))
            {
                if (String.Equals(cboVolumeUnit.Text, datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString()))
                {
                    measureAUsedConverted = Double.Parse(txtBoxVolume.Text);
                }
                else
                {
                    measureAUsedConverted = measureConverter(Double.Parse(txtBoxVolume.Text),
                        datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString(), cboVolumeUnit.Text,0);
                }
                quantityCheck = quantityLeftinMeasure - measureAUsedConverted;
            }
            else
            {
                String unitMeasureUsed;
                double measureAUsed;
                if(String.Equals(txtBoxTypeOfM.Text, "Length"))
                {
                    unitMeasureUsed = cboLengthUnit.Text;
                    measureAUsed = Double.Parse(txtBoxLength.Text);
                }
                else
                {
                    unitMeasureUsed = cboWeightUnit.Text;
                    measureAUsed = Double.Parse(txtBoxWeight.Text);
                }
                if (String.Equals(unitMeasureUsed, datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString()))
                {
                    measureAUsedConverted = measureAUsed;
                }
                else
                {
                    measureAUsedConverted = measureConverter(measureAUsed,
                        datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString(), unitMeasureUsed);
                }
                quantityCheck = quantityLeftinMeasure - measureAUsedConverted;
            }
            if (quantityCheck < 0)
            {
                return false;
            }
            else
            {
                return true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridSuppliesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItemLoader();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (pFrmFrameCreate != null || pFrmFrameEdit != null)
            {
                try
                {
                    String stringSuppliesList =
                            "SELECT sui.supply_ItemsId, sui.supplyName AS `Supply Name`, sui.supplyDescription AS `Description`,  " +
                            "                    suc.categoryName AS `Category`, if (suc.typeOfMeasure = 'Area',concat(sui.measureA, ' x ', sui.measureB),sui.measureA) AS `Base Measurements`," +
                            "                         sui.unitMeasure AS `Base Unit Measure`, IFNULL(MAX(sud.delivery_date), 'None') AS `Latest_Stock_In`, IFNULL(sud.priceRawTotal, 0) AS `Cost per Unit`, suc.typeOfMeasure,  " +
                            "                    sui.MeasureA AS `measureAOG`,sui.MeasureB AS `measureBOG`  " +
                            "                    FROM supply_Items AS sui" +
                            "                    LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID" +
                            "                    LEFT JOIN supply_details AS sud ON sui.supply_itemsId = sud.supply_itemsID" +
                            "                    WHERE sui.supplyName LIKE @txtSearch OR suc.categoryName LIKE @txtSearch " +
                            "                    GROUP BY sui.supply_itemsId HAVING `Cost per Unit`>0" +
                            "                    ORDER BY suc.categoryName, sui.supplyName; ";
                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                    cmdSuppliesSelect.Parameters.AddWithValue("@txtSearch", "%" + txtSearch.Text + "%");
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                    dtSuppliesListView = new DataTable();
                    my_adapter.Fill(dtSuppliesListView);
                    datagridSuppliesList.DataSource = dtSuppliesListView;
                    datagridSuppliesList.Columns["supply_ItemsId"].Visible = false;
                    datagridSuppliesList.Columns["typeOfMeasure"].Visible = false;
                    datagridSuppliesList.Columns["measureAOG"].Visible = false;
                    datagridSuppliesList.Columns["measureBOG"].Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            }
            else if (pFrmJobOrderCreate != null || pFrmJobOrderEdit != null)
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
                        "                    WHERE sui.supplyName LIKE @txtSearch OR suc.categoryName LIKE @txtSearch " +
                        "                   HAVING `Cost per Unit`>0 " +
                        "                   ORDER BY sc.categoryName, si.supplyName";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                    cmdSuppliesSelect.Parameters.AddWithValue("@txtSearch", "%" + txtSearch.Text + "%");
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                    dtSuppliesListView = new DataTable();
                    my_adapter.Fill(dtSuppliesListView);
                    datagridSuppliesList.DataSource = dtSuppliesListView;
                    datagridSuppliesList.Columns["supply_ItemsId"].Visible = false;
                    datagridSuppliesList.Columns["typeOfMeasure"].Visible = false;
                    datagridSuppliesList.Columns["measureAOG"].Visible = false;
                    datagridSuppliesList.Columns["measureBOG"].Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            datagridSuppliesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtBoxTypeOfM.Text, "Area")&&( (String.IsNullOrEmpty(txtBoxAreaLength.Text)|| String.IsNullOrEmpty(txtBoxAreaWidth.Text))
                &&((Double.Parse(txtBoxAreaLength.Text) == 0 || Double.Parse(txtBoxAreaWidth.Text) == 0) ) ))
            {
                MessageBox.Show("Please Enter the Values");
                return;
            }
            else
            {
                if (String.Equals(txtBoxTypeOfM.Text, "Length") && (String.IsNullOrEmpty(txtBoxLength.Text)|| Double.Parse(txtBoxLength.Text)==0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Weight") && (String.IsNullOrEmpty(txtBoxWeight.Text) || Double.Parse(txtBoxWeight.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Volume") && (String.IsNullOrEmpty(txtBoxVolume.Text) || Double.Parse(txtBoxVolume.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Whole") && (String.IsNullOrEmpty(txtBoxWhole.Text) || Double.Parse(txtBoxWhole.Text) == 0))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
            }
            if (pFrmJobOrderCreate != null || pFrmJobOrderEdit != null)
            {
                bool quantityValidation = quantityChecker();
                if (quantityValidation == false)
                {
                    MessageBox.Show("Insufficient Supplies. Please use different measurements or Stock In Supplies.");
                    return;
                }
            }
            sendToParentForm();
            
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
    }
}
