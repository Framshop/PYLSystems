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
        DataTable dtSuppliesUsedSaved;
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

            //Hide stockout dmg for now
            btnDamage.Visible = false;
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
        private void refreshDataGrid()
        {
            dataGridSuppliesUsed.DataSource = null;
            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;
            dataGridSuppliesUsed.Columns["Cost/Unit Measure"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["Cost/Selected Unit Measure"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            dataGridSuppliesUsed.Columns["frame_MaterialsID"].Visible = false;
            dataGridSuppliesUsed.Columns["OGUnitMeasure"].Visible = false;
            dataGridSuppliesUsed.Columns["OGUnitPrice"].Visible = false;
            dataGridSuppliesUsed.Columns["measureAOG"].Visible = false;
            dataGridSuppliesUsed.Columns["measureBOG"].Visible = false;
            dataGridSuppliesUsed.Columns["deductedA"].Visible = false;
            dataGridSuppliesUsed.Columns["deductedB"].Visible = false;
            dataGridSuppliesUsed.Columns["measureAtoOG"].Visible = false;
            dataGridSuppliesUsed.Columns["measureBtoOG"].Visible = false;
            dataGridSuppliesUsed.Columns["Latest_Stock_In"].Visible = false;
            dataGridSuppliesUsed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
        private void suppliesUsed_Loader()
        {
            this.dataGridSuppliesUsed.DataSource = null;
            this.dataGridSuppliesUsed.Rows.Clear();
            dtSuppliesUsed = new DataTable();
            dtSuppliesUsed.Columns.Add("frame_MaterialsID", typeof(int));
            dtSuppliesUsed.Columns.Add("supply_itemsId", typeof(int));
            dtSuppliesUsed.Columns.Add("Supply Name", typeof(String));
            dtSuppliesUsed.Columns.Add("Category", typeof(String));
            dtSuppliesUsed.Columns.Add("typeOfMeasure", typeof(String));
            dtSuppliesUsed.Columns.Add("deductedA", typeof(double));
            dtSuppliesUsed.Columns.Add("deductedB", typeof(double));
            dtSuppliesUsed.Columns.Add("Usage", typeof(String));
            dtSuppliesUsed.Columns.Add("Unit Measure", typeof(String));
            //Original Measures
            dtSuppliesUsed.Columns.Add("OGUnitMeasure", typeof(String));
            dtSuppliesUsed.Columns.Add("OGUnitPrice", typeof(double));
            dtSuppliesUsed.Columns.Add("measureAOG", typeof(double));
            dtSuppliesUsed.Columns.Add("measureBOG", typeof(double));
            dtSuppliesUsed.Columns.Add("measureAtoOG", typeof(double));
            dtSuppliesUsed.Columns.Add("measureBtoOG", typeof(double));


            //ADDED Custom Columns
            dtSuppliesUsed.Columns.Add("Cost/Unit Measure", typeof(double));
            dtSuppliesUsed.Columns.Add("Cost/Selected Unit Measure", typeof(double));
            dtSuppliesUsed.Columns.Add("Raw Cost", typeof(double));

            if (datagridFrameList.Rows.Count > 0)
            {
                int currRowIndex = datagridFrameList.SelectedRows[0].Index;
                int selectedFrameItemId = Int32.Parse(datagridFrameList.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());

                selectSuppliesLoader(selectedFrameItemId);
                dtSuppliesUsed.Merge(dtSelectSuppliesFiltered);

                dtSuppliesUsedSaved = dtSuppliesUsed.Copy();

                dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;


                if (dtSuppliesUsedSaved.Rows.Count > 0)
                {
                    for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
                    {
                        forAddEditSupplies calculateCost = new forAddEditSupplies();
                        calculateCost.typeOfMeasure = dtSuppliesUsedSaved.Rows[i]["typeOfMeasure"].ToString();
                        calculateCost.measureAUsed = Double.Parse(dtSuppliesUsedSaved.Rows[i]["deductedA"].ToString());
                        if (!String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[i]["deductedB"].ToString()))
                        {
                            calculateCost.measureBUsed = Double.Parse(dtSuppliesUsedSaved.Rows[i]["deductedB"].ToString());
                            calculateCost.measureB_OG = Double.Parse(dtSuppliesUsedSaved.Rows[i]["measureBOG"].ToString());
                        }
                        calculateCost.unitMeasureUsed = dtSuppliesUsedSaved.Rows[i]["Unit Measure"].ToString();
                        calculateCost.unitMeasure_OG = dtSuppliesUsedSaved.Rows[i]["OGUnitMeasure"].ToString();
                        calculateCost.measureA_OG = Double.Parse(dtSuppliesUsedSaved.Rows[i]["measureAOG"].ToString());
                        calculateCost.unitPriceOG = Double.Parse(dtSuppliesUsedSaved.Rows[i]["OGUnitPrice"].ToString());
                        trueCostCalculationPutDataGrid(calculateCost, i);
                        refreshDataGrid();
                    }
                }
            }
        }
        private void selectSuppliesLoader(int selectedFrameItemId)
        {
            try
            {
                String stringSuppliesSelect =
                    "SELECT fm.frame_MaterialsID,sui.supply_itemsId, sui.supplyName AS `Supply Name`, suc.categoryName AS `Category`, suc.typeOfMeasure,  " +
                    "                    if (suc.typeOfMeasure = 'Area',concat(fm.measureADeduction, ' x ', fm.measureBDeduction),fm.measureADeduction) AS `Usage`, " +
                    "                    fm.unitMeasure AS `Unit Measure`," +
                    "                    sui.unitMeasure AS `OGUnitMeasure`, IFNULL(sud.priceRawTotal, 0) AS `OGUnitPrice`, IFNULL(MAX(sud.delivery_date), 'None') AS `Latest_Stock_In`," +
                    "                    sui.measureA AS `measureAOG`, sui.measureB AS `measureBOG`, fm.measureAtoOG,  " +
                    "                    fm.measureBtoOG,fm.measureADeduction AS `deductedA`,  fm.measureBDeduction AS `deductedB`    " +
                    "                    FROM frame_materials AS fm" +
                    "                    LEFT JOIN supply_items AS sui ON sui.supply_itemsID = fm.supply_itemsID" +
                    "                    LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID" +
                    "                    LEFT JOIN supply_details AS sud ON sui.supply_itemsId = sud.supply_itemsID" +
                    "                    WHERE fm.frameItemId = @frameItemID AND fm.active = 0" +
                                        "                    GROUP BY frame_materialsID; ";

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
        internal void trueCostCalculationPutDataGrid(forAddEditSupplies addEditSuppliesVals, int dtSuppliesUsedSavedIndex)
        {

            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Whole"))
            {
                double rawCost = addEditSuppliesVals.measureAUsed * addEditSuppliesVals.unitPriceOG;

                dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Unit Measure"] = addEditSuppliesVals.unitPriceOG;
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
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();
                }
                else
                {
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / addEditSuppliesVals.measureA_OG;

                    double rawCost = addEditSuppliesVals.measureAUsed * trueUnitPrice;

                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Selected Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Unit Measure"] = trueUnitPrice;
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
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Unit Measure"] = trueUnitPrice;
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
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Cost/Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dtSuppliesUsedSavedIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();

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
        private void archiveFrame(int selectedFrameItemId)
        {
            try
            {
                String updateFrameListStat = "UPDATE frame_list " +
                    "SET active = '1' " +
                    "WHERE frameItemID = @frameItemID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdUpdateFrameListStat = new MySqlCommand(updateFrameListStat, my_conn);
                cmdUpdateFrameListStat.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);

                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdUpdateFrameListStat.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //----------------Event Methods-----------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String stringSuppliesList =
                    "SELECT FL.frameName AS Frame, FL.Dimension, FL.frameDescription, fl.UnitSalesPrice AS 'Unit Price', IFNULL(FS.Stockin - (IFNULL(SOD.Stockout,0)),0) AS 'Quantity Left', " +
                    "FL.frameItemID FROM frame_list AS FL " +
                    "LEFT JOIN(SELECT FS.frameItemID, SUM(FS.stockinQuantity) AS Stockin FROM framestock_in AS FS GROUP BY FS.frameItemID) " +
                    "AS FS ON FL.frameItemID = FS.frameItemID " +
                    "LEFT JOIN(SELECT SOD.frameItemID, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD LEFT JOIN salesOrder AS SO ON SOD.sOrd_Num=SO.sOrd_Num WHERE SO.sOrd_status>0 GROUP BY SOD.frameItemID) " +
                    "AS SOD ON FL.frameItemID = SOD.frameItemID " +
                    "WHERE FL.active = '0' " +
                    "AND FL.frameName LIKE @txtSearch " +
                    "ORDER BY FL.frameName;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                cmdSuppliesSelect.Parameters.AddWithValue("@txtSearch", "%" + txtSearch.Text + "%");
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtFrameList = new DataTable();
                my_adapter.Fill(dtFrameList);
                datagridFrameList.DataSource = dtFrameList;
                datagridFrameList.Columns["frameItemID"].Visible = false;
                datagridFrameList.Columns["Unit Price"].DefaultCellStyle.Format = "0.00";
                datagridFrameList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnCreateFrame_Click(object sender, EventArgs e)
        {
            frmFrameCreate formCreateAFrame = new frmFrameCreate();
            formCreateAFrame.ShowDialog();
            frameList_Loader();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int currRowIndex = datagridFrameList.SelectedRows[0].Index;
                int selectedFrameItemId = Int32.Parse(datagridFrameList.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());
                String frameName = datagridFrameList.Rows[currRowIndex].Cells["Frame"].Value.ToString();
                String frameDimension = datagridFrameList.Rows[currRowIndex].Cells["Dimension"].Value.ToString();
                String frameDescription = datagridFrameList.Rows[currRowIndex].Cells["frameDescription"].Value.ToString();
                double unitSalesPrice = Double.Parse(datagridFrameList.Rows[currRowIndex].Cells["Unit Price"].Value.ToString());
                frmFrameEdit formEditFrame = new frmFrameEdit(selectedFrameItemId, frameName, frameDimension, frameDescription, unitSalesPrice);
                formEditFrame.ShowDialog();

                suppliesUsed_Loader();
            }
            catch { }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            try
            {
                int currRowIndex = datagridFrameList.SelectedRows[0].Index;
                int selectedFrameItemId = Int32.Parse(datagridFrameList.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());
                frmFrameStockInAdd formFrameStockIn = new frmFrameStockInAdd(selectedFrameItemId, this.employeeId);
                formFrameStockIn.ShowDialog();
            }
            catch { }
            frameList_Loader();
            suppliesUsed_Loader();
        }

        private void btnArchiveList_Click(object sender, EventArgs e)
        {
            frmFrameArchivedList formFrameArchiveL = new frmFrameArchivedList();
            formFrameArchiveL.ShowDialog();
            frameList_Loader();
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

        private void btnArchiveFrame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to archive frame?","Confirm",MessageBoxButtons.YesNo);
            if(result== System.Windows.Forms.DialogResult.Yes)
            {
                int currRowIndex = datagridFrameList.SelectedRows[0].Index;
                int selectedFrameItemId = Int32.Parse(datagridFrameList.Rows[currRowIndex].Cells["frameItemID"].Value.ToString());
                archiveFrame(selectedFrameItemId);
                frameList_Loader();
            }
            else
            {
                return;
            }
            
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
