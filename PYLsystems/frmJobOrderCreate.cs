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
    public partial class frmJobOrderCreate : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        int employeeID;
        int employeeStatus;
        DataTable dtSuppliesUsedSaved;
        double rawCostInitial;
        //--------------Initial Load--------------
        //----for programming initializer
               
        public frmJobOrderCreate()
        {
            InitializeComponent();
            this.employeeID = 1;
            this.employeeStatus = 1;
        }
        public frmJobOrderCreate(int employeeID, int employeeStatus)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.employeeStatus = employeeStatus;
        }

        private void frmJobOrderCreate_Load(object sender, EventArgs e)
        {
            frmJobOrderLoader();
            receiptLoader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmJobOrderLoader()
        {
            dtSuppliesUsedSaved = new DataTable();
            dtSuppliesUsedSaved.Columns.Add("supply_itemsId", typeof(int));
            dtSuppliesUsedSaved.Columns.Add("Supply Name", typeof(String));
            dtSuppliesUsedSaved.Columns.Add("Category", typeof(String));
            dtSuppliesUsedSaved.Columns.Add("typeOfMeasure", typeof(String));
            dtSuppliesUsedSaved.Columns.Add("Cost/Base Unit Measure", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("Base Unit Measure", typeof(String));
            dtSuppliesUsedSaved.Columns.Add("deductedA", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("deductedB", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("Usage", typeof(String));
            dtSuppliesUsedSaved.Columns.Add("Unit Measure", typeof(String));
            //Original Measures
            dtSuppliesUsedSaved.Columns.Add("OGUnitMeasure", typeof(String));
            dtSuppliesUsedSaved.Columns.Add("OGUnitPrice", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("measureAOG", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("measureBOG", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("measureAtoOG", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("measureBtoOG", typeof(double));


            //ADDED Custom Columns
            
            dtSuppliesUsedSaved.Columns.Add("Cost/Selected Unit Measure", typeof(double));
            dtSuppliesUsedSaved.Columns.Add("Raw Cost", typeof(double));

            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;

            refreshDataGrid();
        }
        private void refreshDataGrid()
        {
            dataGridSuppliesUsed.DataSource = null;
            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;
            dataGridSuppliesUsed.Columns["Cost/Base Unit Measure"].DefaultCellStyle.Format = "P0.0000000";
            dataGridSuppliesUsed.Columns["Cost/Selected Unit Measure"].DefaultCellStyle.Format = "P0.0000000";
            dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            dataGridSuppliesUsed.Columns["OGUnitMeasure"].Visible = false;
            dataGridSuppliesUsed.Columns["OGUnitPrice"].Visible = false;
            dataGridSuppliesUsed.Columns["measureAOG"].Visible = false;
            dataGridSuppliesUsed.Columns["measureBOG"].Visible = false;
            dataGridSuppliesUsed.Columns["deductedA"].Visible = false;
            dataGridSuppliesUsed.Columns["deductedB"].Visible = false;
            dataGridSuppliesUsed.Columns["measureAtoOG"].Visible = false;
            dataGridSuppliesUsed.Columns["measureBtoOG"].Visible = false;
            dataGridSuppliesUsed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
        private void receiptLoader()
        {
            String stringJOrdReceipt = "SELECT max(jOrd_Num) FROM joborder;";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand cmdJoRdReceipt = new MySqlCommand(stringJOrdReceipt, my_conn);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdJoRdReceipt);

            DataTable receiptNumberPrev_dt = new DataTable();
            my_adapter.Fill(receiptNumberPrev_dt);
            if (receiptNumberPrev_dt.Rows.Count == 0)
            {
                int receiptNum = 1;
                this.txtBoxReceipt.Text = receiptNum.ToString("0000000");
            }
            else if (String.IsNullOrEmpty(receiptNumberPrev_dt.Rows[0][0].ToString()))
            {
                int receiptNum = 1;
                this.txtBoxReceipt.Text = receiptNum.ToString("0000000");
            }
            else
            {
                int receiptNum = Int32.Parse(receiptNumberPrev_dt.Rows[0][0].ToString())+1;

                this.txtBoxReceipt.Text = receiptNum.ToString("0000000");
                //frameAvailDefaultFilter = new DataView(frameAvail_dt);
                //frameAvailDefaultFilter.RowFilter = "sOrd_status = 0";

            }
            txtBoxDiscount.Text = "0.00";
        }
        internal void checkIfExistsBeforeCalc(forAddEditSupplies addEditSuppliesVals)
        {
            bool existsInDataGrid = false;
            for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
            {
                //Check if item exists whether it has frame_itemID or not dtSuppliesUsedSaved
                if (addEditSuppliesVals.supplyItemsId == Int32.Parse(dtSuppliesUsedSaved.Rows[i]["supply_itemsId"].ToString()))
                {
                    existsInDataGrid = true;
                }
            }
            if (existsInDataGrid)
            {
                MessageBox.Show("You've already added the item in the list. \n Please use Remove the Supply button and re-add it again for any changes.");
                return;
            }
            //If confirmed that it doesn't exist, pass to addToDataTable method to put Data in DataTable
            addtoDataTable(addEditSuppliesVals, -1);
        }
        private void addtoDataTable(forAddEditSupplies addEditSuppliesVals, int frameMaterialsId) //Populating the DataTable
        {

            String dimension = addEditSuppliesVals.measureAUsed + " x " + addEditSuppliesVals.measureBUsed;
            String measure = addEditSuppliesVals.measureAUsed.ToString();
            dtSuppliesUsedSaved.Rows.Add();
            int indexdtInsert = dtSuppliesUsedSaved.Rows.Count - 1;

            //frameMaterialsId ==-1 - frameMat doesn't exist. If greater than that, it exists
            if (frameMaterialsId > -1)
            {
                dtSuppliesUsedSaved.Rows[indexdtInsert]["frame_MaterialsID"] = frameMaterialsId;
            }
            dtSuppliesUsedSaved.Rows[indexdtInsert]["supply_itemsId"] = addEditSuppliesVals.supplyItemsId;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["Supply Name"] = addEditSuppliesVals.supplyName;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["Category"] = addEditSuppliesVals.category;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["typeOfMeasure"] = addEditSuppliesVals.typeOfMeasure;

            dtSuppliesUsedSaved.Rows[indexdtInsert]["Unit Measure"] = addEditSuppliesVals.unitMeasureUsed;

            dtSuppliesUsedSaved.Rows[indexdtInsert]["Base Unit Measure"] = "1 " + addEditSuppliesVals.unitMeasure_OG;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitMeasure"] = addEditSuppliesVals.unitMeasure_OG;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitPrice"] = addEditSuppliesVals.unitPriceOG;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAOG"] = addEditSuppliesVals.measureA_OG;


            dtSuppliesUsedSaved.Rows[indexdtInsert]["deductedA"] = addEditSuppliesVals.measureAUsed;



            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
            {
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = dimension;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAtoOG"] = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureBOG"] = addEditSuppliesVals.measureB_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["deductedB"] = addEditSuppliesVals.measureBUsed;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureBtoOG"] = measureConverter(addEditSuppliesVals.measureBUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Base Unit Measure"] = "1 " + addEditSuppliesVals.unitMeasure_OG + "²";
            }
            else if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Whole")) ////NOTE: MAJOR BUG UPDATE. PLEASE TELL BEN ABOUT THIS. 3/20/2019 8:35AM
            {
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = measure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAtoOG"] = addEditSuppliesVals.measureAUsed;
            }
            else if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Volume"))
            {
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = measure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAtoOG"] = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed, 0);
            }
            else
            {
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = measure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAtoOG"] = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
            }


            int dtSuppliesSavedLastIndex = dtSuppliesUsedSaved.Rows.Count - 1;

            trueCostCalculationPutDataGrid(addEditSuppliesVals, dtSuppliesSavedLastIndex);
        }
        //Delete Row from DataTable and DataGrid
        private void deleteRowFromDataGrid(int currRowIndex)
        {
            DataRow dataRowDeleted = dtSuppliesUsedSaved.Rows[currRowIndex];
            dtSuppliesUsedSaved.Rows.Remove(dataRowDeleted);
            refreshDataGrid();
            rawCostCalculation();
        }
        //Cost/Base Unit Measure(trueUnitPrice) AND RAW COST CALCULATOR, pass data and indexInDataTable
        internal void trueCostCalculationPutDataGrid(forAddEditSupplies addEditSuppliesVals, int dtSuppliesUsedSavedIndex)
        {

            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Whole"))
            {
                double rawCost = addEditSuppliesVals.measureAUsed * addEditSuppliesVals.unitPriceOG;

                dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Base Unit Measure"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                refreshDataGrid();

            }
            else if (String.Equals(addEditSuppliesVals.unitMeasureUsed, addEditSuppliesVals.unitMeasure_OG))
            {
                if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
                {
                    double area_OG = addEditSuppliesVals.measureA_OG * addEditSuppliesVals.measureB_OG;
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / area_OG;

                    double areaOfUsed = addEditSuppliesVals.measureAUsed * addEditSuppliesVals.measureBUsed;

                    double rawCost = areaOfUsed * trueUnitPrice;

                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Base Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();
                }
                else
                {
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / addEditSuppliesVals.measureA_OG;

                    double rawCost = addEditSuppliesVals.measureAUsed * trueUnitPrice;

                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Base Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();

                }
            }
            else
            {
                if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
                {

                    double area_OG = addEditSuppliesVals.measureA_OG * addEditSuppliesVals.measureB_OG; // Get area of original measures from purchase from Object

                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / area_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement


                    double measureAConvertedUse = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                    double measureBConvertedUse = measureConverter(addEditSuppliesVals.measureBUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);

                    double areaOfUsed = measureAConvertedUse * measureBConvertedUse; //Calculate the area of Use of the used up converted measurements

                    double rawCost = areaOfUsed * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price

                    double measureAOGConvert = measureConverter(addEditSuppliesVals.measureA_OG, addEditSuppliesVals.unitMeasureUsed, addEditSuppliesVals.unitMeasure_OG);
                    double measureBOGConvert = measureConverter(addEditSuppliesVals.measureB_OG, addEditSuppliesVals.unitMeasureUsed, addEditSuppliesVals.unitMeasure_OG);
                    double area_OGDisplay = measureAOGConvert * measureBOGConvert;
                    double displayPrice = addEditSuppliesVals.unitPriceOG / area_OGDisplay;

                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = displayPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Base Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();



                }
                else
                {
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / addEditSuppliesVals.measureA_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                    //Get the already converted Measurements in frame_materials table.
                    //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                    double measureAConvertedUse;
                    double displayPrice;
                    if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Volume"))
                    {
                        measureAConvertedUse = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed, 0);
                        displayPrice = addEditSuppliesVals.unitPriceOG / measureConverter(addEditSuppliesVals.measureA_OG, addEditSuppliesVals.unitMeasureUsed, addEditSuppliesVals.unitMeasure_OG, 0);

                    }
                    else
                    {
                        measureAConvertedUse = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                        displayPrice = addEditSuppliesVals.unitPriceOG / measureConverter(addEditSuppliesVals.measureA_OG, addEditSuppliesVals.unitMeasureUsed, addEditSuppliesVals.unitMeasure_OG);

                    }


                    double rawCost = measureAConvertedUse * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price

                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = displayPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Base Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();

                }

            }

            rawCostCalculation();
            rawSalesTimesQuantityCalc();
            this.txtBoxDiscount.Text = (0).ToString();
            this.txtBoxDiscountTotal.Text = "";
            this.txtBoxTotalPaid.Text = "";
            this.txtBoxChange.Text = "";
        }
        //Raw Cost Calculator Text Box
        private void rawCostCalculation()
        {
            double rawCostTotal = 0;
            for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[i]["Raw Cost"].ToString()))
                {
                    rawCostTotal += Double.Parse(dtSuppliesUsedSaved.Rows[i]["Raw Cost"].ToString());
                }

            }
            this.rawCostInitial=rawCostTotal;
            rawSalesTimesQuantityCalc();
        }
        private void rawSalesTimesQuantityCalc()
        {
            double quantityInput = 1;
            if (String.IsNullOrEmpty(txtBoxQuantity.Text))
            {
                quantityInput = 0;
            }
            else
            {
                quantityInput = Double.Parse(txtBoxQuantity.Text);
            }
            double totalRawCost = this.rawCostInitial * quantityInput;

            txtBoxRawCostTotal.Text = totalRawCost.ToString();
            
        }
        private void discountCalc()
        {
            double discountInput = 1;
            double priceInput = 0;
            if (String.IsNullOrEmpty(txtBoxDiscount.Text))
            {
                discountInput = 0;
            }
            else
            {
                discountInput = Double.Parse(txtBoxDiscount.Text);
            }
            if (String.IsNullOrEmpty(txtBoxJobPrice.Text))
            {
                priceInput = 0;
            }
            else
            {
                priceInput = Double.Parse(txtBoxJobPrice.Text);
            }
            double discountedTotal = priceInput - discountInput;
            txtBoxDiscountTotal.Text = discountedTotal.ToString();
            changeCalc();
        }
        private void changeCalc()
        {
            double totalPaid = 0;
            double discountInput = 0;
            if (String.IsNullOrEmpty(txtBoxTotalPaid.Text))
            {
                discountInput = 0;
            }
            else if (String.IsNullOrEmpty(txtBoxDiscount.Text)|| String.IsNullOrEmpty(txtBoxDiscountTotal.Text))
            {
                discountInput = Double.Parse(txtBoxTotalPaid.Text);
            }
            else
            {
                discountInput = Double.Parse(txtBoxDiscountTotal.Text);
            }
            if (String.IsNullOrEmpty(txtBoxTotalPaid.Text))
            {
                totalPaid = 0;
            }
            else
            {
                totalPaid = Double.Parse(txtBoxTotalPaid.Text);
            }
            double change = totalPaid - discountInput;
            txtBoxChange.Text = change.ToString();
        }
        //Converting Measure for Length, Area, Weight
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
        //Converting Measures for Volume
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
        //Used by frmFrameEditSuppliesUsed
        internal void editSuppliesSelected(forAddEditSupplies editSuppliesVal)
        {
            int currRowIndexDataGrid = dataGridSuppliesUsed.SelectedRows[0].Index;
            int currRowIndexDt = -1;
            if (dtSuppliesUsedSaved.Rows.Count > 0)
            {
                for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
                {
                    if (Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndexDataGrid].Cells["supply_itemsId"].Value.ToString()) == Int32.Parse(dtSuppliesUsedSaved.Rows[i]["supply_itemsId"].ToString()))
                    {
                        currRowIndexDt = i;

                    }
                }
            }
            if (currRowIndexDt > -1)
            {
                if (String.Equals(editSuppliesVal.typeOfMeasure, "Area"))
                {
                    String Dimension = editSuppliesVal.measureAUsed + " x " + editSuppliesVal.measureBUsed;
                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["Usage"] = Dimension;
                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["Unit Measure"] = editSuppliesVal.unitMeasureUsed;

                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["deductedA"] = editSuppliesVal.measureAUsed;
                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["deductedB"] = editSuppliesVal.measureBUsed;

                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["measureAtoOG"] = measureConverter(editSuppliesVal.measureAUsed, editSuppliesVal.unitMeasure_OG, editSuppliesVal.unitMeasureUsed);
                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["measureBtoOG"] = measureConverter(editSuppliesVal.measureBUsed, editSuppliesVal.unitMeasure_OG, editSuppliesVal.unitMeasureUsed);
                }
                else
                {
                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["Usage"] = editSuppliesVal.measureAUsed;
                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["Unit Measure"] = editSuppliesVal.unitMeasureUsed;

                    dtSuppliesUsedSaved.Rows[currRowIndexDt]["deductedA"] = editSuppliesVal.measureAUsed;

                    if (String.Equals(editSuppliesVal.typeOfMeasure, "Volume"))
                    {
                        dtSuppliesUsedSaved.Rows[currRowIndexDt]["measureAtoOG"] = measureConverter(editSuppliesVal.measureAUsed, editSuppliesVal.unitMeasure_OG, editSuppliesVal.unitMeasureUsed, 0);

                    }
                    else if (String.Equals(editSuppliesVal.typeOfMeasure, "Whole")) //////NOTE: MAJOR BUG UPDATE. PLEASE TELL BEN ABOUT THIS. 3/20/2019 8:35AM
                    {
                        dtSuppliesUsedSaved.Rows[currRowIndexDt]["measureAtoOG"] = editSuppliesVal.measureAUsed;
                    }
                    else
                    {
                        dtSuppliesUsedSaved.Rows[currRowIndexDt]["measureAtoOG"] = measureConverter(editSuppliesVal.measureAUsed, editSuppliesVal.unitMeasure_OG, editSuppliesVal.unitMeasureUsed);

                    }
                }
                trueCostCalculationPutDataGrid(editSuppliesVal, currRowIndexDt);
            }
            rawSalesTimesQuantityCalc();
        }
        private void sendToDatabase()
        {
            int jobOrderID = insertJobOrder();
            for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
            {
                insertJOrderdetails(i, jobOrderID);
            }
            MessageBox.Show("Job Order Created.");
            this.Close();
        }
        private int insertJobOrder()
        {
            int jobOrderID = -1;
            //INSERT PAYROLL
            try
            {
                String stringInsertJobOrder = "INSERT INTO joborder (jobOrderDate,employeeID,jobOrderDescription,active,discount,totalAmount,jobOrderQuantity,jobOrderPrice) " +
                    "VALUES(NOW(), @employeeID, @description, 0, @discount, @totalPaid, @quantity, @jobOrderPrice); " +
                    "SELECT LAST_INSERT_ID(); ";//This last line returns primary key of the last inserted item. Use wisely
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdJobOrderInsert = new MySqlCommand(stringInsertJobOrder, my_conn);
                cmdJobOrderInsert.Parameters.AddWithValue("@employeeID", this.employeeID);
                cmdJobOrderInsert.Parameters.AddWithValue("@description", txtBoxDescription.Text);
                cmdJobOrderInsert.Parameters.AddWithValue("@discount", Double.Parse(this.txtBoxDiscount.Text));
                cmdJobOrderInsert.Parameters.AddWithValue("@totalPaid", Double.Parse(txtBoxTotalPaid.Text));
                cmdJobOrderInsert.Parameters.AddWithValue("@quantity", Int32.Parse(txtBoxQuantity.Text));
                cmdJobOrderInsert.Parameters.AddWithValue("@jobOrderPrice", Double.Parse(txtBoxJobPrice.Text));
                my_conn.Open();
                jobOrderID = Convert.ToInt32(cmdJobOrderInsert.ExecuteScalar());
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return jobOrderID;
        }
        private void insertJOrderdetails(int indexOfdtSuppliesUsedSaved, int jobOrderID)
        {
            try
            {
                String stringInsertToFrame_Mat = "INSERT INTO jOrder_details (supply_itemsID,jOrd_Num,measureADeduction,measureBDeduction,unit_measure,dateDeducted,measureAtoOG,measureBtoOG,active) " +
                    "VALUES (@supply_itemsID, @jOrd_Num, @measureADeduction, @measureBDeduction, @unitmeasure, CURDATE(), @measureAtoOG, @measureBtoOG, 0); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdInsertToFrame_mat = new MySqlCommand(stringInsertToFrame_Mat, my_conn);
                cmdInsertToFrame_mat.Parameters.AddWithValue("@jOrd_Num", jobOrderID);
                cmdInsertToFrame_mat.Parameters.AddWithValue("@supply_itemsID", Int32.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["supply_itemsId"].ToString()));
                cmdInsertToFrame_mat.Parameters.AddWithValue("@measureADeduction", Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["deductedA"].ToString()));

                cmdInsertToFrame_mat.Parameters.AddWithValue("@unitMeasure", dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["Unit Measure"].ToString());

                double RoundedAtoOG = Math.Round(Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["measureAtoOG"].ToString()), 7);
                cmdInsertToFrame_mat.Parameters.AddWithValue("@measureAtoOG", RoundedAtoOG);


                if (!String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["deductedB"].ToString()))
                {
                    double RoundedBtoOG = Math.Round(Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["measureBtoOG"].ToString()), 7);

                    cmdInsertToFrame_mat.Parameters.AddWithValue("@measureBDeduction", Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["deductedB"].ToString()));
                    cmdInsertToFrame_mat.Parameters.AddWithValue("@measureBtoOG", RoundedBtoOG);
                }
                else
                {
                    cmdInsertToFrame_mat.Parameters.AddWithValue("@measureBDeduction", DBNull.Value);
                    cmdInsertToFrame_mat.Parameters.AddWithValue("@measureBtoOG", DBNull.Value);
                }


                my_conn.Open();
                cmdInsertToFrame_mat.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //----------------Event Methods-----------------
        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed addSupplies = new frmFrameAddSuppliesUsed(this);
            addSupplies.ShowDialog();
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            rawSalesTimesQuantityCalc();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currRowIndexDataGrid = dataGridSuppliesUsed.SelectedRows[0].Index;
            deleteRowFromDataGrid(currRowIndexDataGrid);
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            if (dataGridSuppliesUsed.Rows.Count == 0)
            {
                MessageBox.Show("There's nothing to edit.");
                return;
            }
            forAddEditSupplies addEditSuppliesval = new forAddEditSupplies();
            int currRowIndex = dataGridSuppliesUsed.SelectedRows[0].Index;
            //Get currRowIndex. NOTE: get currRowIndex of datagrid, loop through dtSuppliesUsedSaved and find the same supply_ItemId.Then replace
            //with edited values
            addEditSuppliesval.supplyItemsId = Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["supply_itemsId"].Value.ToString());
            addEditSuppliesval.unitMeasureUsed = dataGridSuppliesUsed.Rows[currRowIndex].Cells["Unit Measure"].Value.ToString();
            addEditSuppliesval.unitMeasure_OG = dataGridSuppliesUsed.Rows[currRowIndex].Cells["OGUnitMeasure"].Value.ToString();
            addEditSuppliesval.typeOfMeasure = dataGridSuppliesUsed.Rows[currRowIndex].Cells["typeOfMeasure"].Value.ToString();
            addEditSuppliesval.supplyName = dataGridSuppliesUsed.Rows[currRowIndex].Cells["Supply Name"].Value.ToString();
            addEditSuppliesval.category = dataGridSuppliesUsed.Rows[currRowIndex].Cells["Category"].Value.ToString();
            addEditSuppliesval.unitPriceOG = Double.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["OGUnitPrice"].Value.ToString());
            addEditSuppliesval.measureA_OG = Double.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["measureAOG"].Value.ToString());
            if (!String.IsNullOrEmpty(dataGridSuppliesUsed.Rows[currRowIndex].Cells["measureBOG"].Value.ToString()))
            {
                addEditSuppliesval.measureB_OG = Double.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["measureBOG"].Value.ToString());
            }
            frmFrameEditSuppliesUsed frmEditSupplies = new frmFrameEditSuppliesUsed(addEditSuppliesval, this);
            frmEditSupplies.ShowDialog();
        }

        private void txtBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            discountCalc();
        }

        private void txtBoxJobPrice_TextChanged(object sender, EventArgs e)
        {
            discountCalc();
        }

        private void txtBoxTotalPaid_TextChanged(object sender, EventArgs e)
        {
            changeCalc();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int validation=0;
            double jobPrice;
            double totalPaid;
            if (dtSuppliesUsedSaved.Rows.Count == 0)
            {
                MessageBox.Show("Please Add Supplies to be used for the Frame.");
                validation++;
            }
            if (String.IsNullOrEmpty(txtBoxDescription.Text))
            {
                MessageBox.Show("Please Input a Description for Job Order.");
                validation++;
            }
            if (String.IsNullOrEmpty(txtBoxJobPrice.Text))
            {
                MessageBox.Show("Please Input a Job Order Price.");
                validation++;
                jobPrice = 0;
            }
            else
            {
                jobPrice = Double.Parse(txtBoxJobPrice.Text);
            }
            if (String.IsNullOrEmpty(txtBoxTotalPaid.Text))
            {
                MessageBox.Show("Please Input a Payment.");
                validation++;
                totalPaid = 0;
            }
            else
            {
                totalPaid = Double.Parse(txtBoxTotalPaid.Text);
            }
            
            if ((totalPaid>=0||jobPrice>=0)&&(totalPaid < jobPrice))
            {
                MessageBox.Show("Please Input a proper payment amount");
                validation++;
            }
            if (String.IsNullOrEmpty(txtBoxDiscount.Text))
            {
                txtBoxDiscount.Text = "0";
            }

            if (validation > 0)
            {
                return;
            }
            sendToDatabase();
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxRawCostTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxJobPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxTotalPaid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
