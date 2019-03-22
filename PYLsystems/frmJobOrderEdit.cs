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
    public partial class frmJobOrderEdit : Form
    {
        
       
       
        int employeeID;
        int employeeStatus;
        int jobOrderID;
        double rawCostInitial;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";

        DataTable dtSelectSuppliesFiltered; //removed Original UnitMeasure and PURCHASE UnitPrice. Use this for merging
        DataTable dtSuppliesUsed; //Merged DataTable

        DataTable dtSuppliesUsedSaved;

        List<int> RemovedFrame_MatItemId;//for Supplies with existing jOrd_Num. Set to inactive

        //--------------Initial Load--------------
        //----for programming initializer
        public frmJobOrderEdit()
        {
            InitializeComponent();
            this.employeeID = 1;
            this.employeeStatus = 1;
            this.jobOrderID = 2;
        }
        public frmJobOrderEdit(int employeeID, int employeeStatus, int jobOrderID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.employeeStatus = employeeStatus;
            this.jobOrderID = jobOrderID;
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmJobOrderEdit_Load(object sender, EventArgs e)
        {
            suppliesUsed_Loader();
            frmJobOrderDescription_Loader();
        }
        private void frmJobOrderDescription_Loader()
        {
            DataTable dtJobOrderDesc = new DataTable(); ;
            try
            {//Show Only jOrd_Num and jobOrderDate
                String stringJobOrdersList =
                    "SELECT job.jOrd_Num, job.jobOrderdescription AS `Order Description`,  " +
                    "job.jobOrderDate AS `Job Order Date`, concat(emp.lastname, ', ', emp.firstname) AS `Employee Name`, job.jobOrderQuantity AS `Quantity`, " +
                    "job.discount AS `Discount`, job.totalAmount AS `Total Paid`,job.jobOrderPrice " +
                    "FROM jobOrder AS job LEFT JOIN employee AS emp ON job.employeeID = emp.employeeID " +
                    "WHERE job.jOrd_Num=@jobOrderID; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdJobOrdersList = new MySqlCommand(stringJobOrdersList, my_conn);

                cmdJobOrdersList.Parameters.AddWithValue("@jobOrderID", this.jobOrderID);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdJobOrdersList);

                my_adapter.Fill(dtJobOrderDesc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            this.txtBoxReceipt.Text = Int32.Parse(dtJobOrderDesc.Rows[0]["jOrd_Num"].ToString()).ToString("000000000");
            this.txtBoxDescription.Text = dtJobOrderDesc.Rows[0]["Order Description"].ToString();
            this.txtBoxQuantity.Text = dtJobOrderDesc.Rows[0]["Quantity"].ToString();
            this.txtBoxJobPrice.Text = dtJobOrderDesc.Rows[0]["jobOrderPrice"].ToString();
            this.txtBoxDiscount.Text = dtJobOrderDesc.Rows[0]["Discount"].ToString();
            this.txtBoxTotalPaid.Text = dtJobOrderDesc.Rows[0]["Total Paid"].ToString();
            discountCalc();
        }
        private void suppliesUsed_Loader()
        {
            RemovedFrame_MatItemId = new List<int>();

            this.dataGridSuppliesUsed.DataSource = null;
            this.dataGridSuppliesUsed.Rows.Clear();
            dtSuppliesUsed = new DataTable();
            dtSuppliesUsed.Columns.Add("jOrder_detailsID", typeof(int));
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

            selectSuppliesLoader(this.jobOrderID);
            dtSuppliesUsed.Merge(dtSelectSuppliesFiltered);

            dtSuppliesUsedSaved = dtSuppliesUsed.Copy();

            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;


            if (dtSuppliesUsedSaved.Rows.Count > 0)
            {
                MessageBox.Show(dtSuppliesUsedSaved.Rows.Count+"");
                for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
                {
                    if (!String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[i]["jOrder_detailsID"].ToString())){
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
        private void selectSuppliesLoader(int selectedJobOrderID)
        {
            try
            {
                String stringSuppliesSelect =
                    "SELECT jod.jOrder_detailsID, job.jOrd_Num, sui.supply_itemsId, sui.supplyName AS `Supply Name`, sc.categoryName AS `Category`," +
                    "sc.typeOfMeasure, jod.measureAdeduction AS `deductedA`, jod.measureBdeduction AS `deductedB`," +
                    "if (sc.categoryName = 'Area',concat(jod.measureAdeduction, ' x ', jod.measureBdeduction),jod.measureAdeduction) AS `Usage`," +
                    "jod.unit_measure AS `Unit Measure`, sui.unitMeasure AS `OGUnitMeasure`, IFNULL(sud.priceRawTotal,0) AS `OGUnitPrice`," +
                    "IFNULL(MAX(sud.delivery_date),'None') AS `Latest_Stock_In`," +
                    "sui.measureA AS `measureAOG`, sui.measureB AS `measureBOG`, jod.measureAtoOG, jod.measureBtoOG " +
                    "FROM jOrder_details AS jod " +
                    "LEFT JOIN jobOrder AS job ON jod.jOrd_Num = job.jOrd_Num " +
                    "LEFT JOIN supply_items AS sui ON jod.supply_itemsID = sui.supply_itemsID " +
                    "LEFT JOIN supply_category AS sc ON sui.supply_categoryID = sc.supply_categoryID " +
                    "LEFT JOIN supply_details AS sud ON sui.supply_itemsId=sud.supply_itemsID " +
                    "WHERE jod.jOrd_Num = @jOrd_Num AND jod.active = 0 "+
                    "GROUP BY jod.jOrder_detailsID;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@jOrd_Num", this.jobOrderID);
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
        private void refreshDataGrid()
        {
            dataGridSuppliesUsed.DataSource = null;
            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;
            dataGridSuppliesUsed.Columns["Cost/Unit Measure"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            dataGridSuppliesUsed.Columns["jOrder_detailsID"].Visible = false;
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
        internal void checkIfExistsBeforeCalc(forAddEditSupplies addEditSuppliesVals) //for adding supply
        {
            DataTable dtcheckIfFrame_MatExists = new DataTable();
            //Check using jobOrderID and supply_ItemsId if it iexist in database
            try
            {
                String stringSuppliesSelect =
                    "SELECT jod.jOrder_detailsID, jod.jOrd_Num, jod.supply_itemsID, jod.measureADeduction,jod.measureBDeduction," +
                    "                    jod.unit_Measure, jod.active, jod.measureAtoOG, jod.measureBtoOG" +
                    "                    FROM jOrder_details AS jod" +
                    "                    WHERE jod.jOrd_Num = @jOrd_Num AND jod.supply_itemsID = @supplyItemsId; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@jOrd_Num", this.jobOrderID);
                cmdSuppliesSelect.Parameters.AddWithValue("@supplyItemsId", addEditSuppliesVals.supplyItemsId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);


                my_adapter.Fill(dtcheckIfFrame_MatExists);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            bool existsInDataGrid = false;

            //If material added exists in frame_materials table and dtSuppliesUsedSaved
            if (dtcheckIfFrame_MatExists.Rows.Count > 0)
            {
                for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
                {
                    if (!String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[i]["jOrder_detailsID"].ToString()))
                    {
                        //check if it's in the datatable;
                        if (Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["jOrder_detailsID"].ToString()) == Int32.Parse(dtSuppliesUsedSaved.Rows[i]["jOrder_detailsID"].ToString()))
                        {
                            existsInDataGrid = true;
                        }
                    }
                }
                if (existsInDataGrid)
                {
                    MessageBox.Show("You've already added the item in the list. \n Please use Edit Supply for any changes.");
                    return;
                }
                else if (!existsInDataGrid)
                {
                    //if it's not in existsInDataGrid, and was removed earlier remove the item in removedList if it exists
                    int removedListindex = -1;
                    for (int i = 0; i < RemovedFrame_MatItemId.Count; i++)
                    {
                        if (RemovedFrame_MatItemId[i] == Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["jOrder_detailsID"].ToString()))
                        {
                            removedListindex = i;
                        }
                    }
                    if (removedListindex > -1)
                    {
                        RemovedFrame_MatItemId.RemoveAt(removedListindex);
                    }
                    //send jOrder_detailsID to in DataTable
                    addtoDataTable(addEditSuppliesVals, Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["jOrder_detailsID"].ToString()));
                }

            }
            //Else If not update
            else
            {
                //
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
                    MessageBox.Show("You've already added the item in the list. \n Please use Edit Supply for any changes.");
                    return;
                }
                addtoDataTable(addEditSuppliesVals, -1);
            }

        }
        private void addtoDataTable(forAddEditSupplies addEditSuppliesVals, int frameMaterialsId) //Insert List is the DataGrid NOTE: FOR INSERTING converted units, call measureConverter again
        {

            String dimension = addEditSuppliesVals.measureAUsed + " x " + addEditSuppliesVals.measureBUsed;
            String measure = addEditSuppliesVals.measureAUsed.ToString();
            dtSuppliesUsedSaved.Rows.Add();
            int indexdtInsert = dtSuppliesUsedSaved.Rows.Count - 1;

            //frameMaterialsId ==-1 - frameMat doesn't exist. If greater than that, it exists
            if (frameMaterialsId > -1)
            {
                dtSuppliesUsedSaved.Rows[indexdtInsert]["jOrder_detailsID"] = frameMaterialsId;
            }
            dtSuppliesUsedSaved.Rows[indexdtInsert]["supply_itemsId"] = addEditSuppliesVals.supplyItemsId;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["Supply Name"] = addEditSuppliesVals.supplyName;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["Category"] = addEditSuppliesVals.category;
            dtSuppliesUsedSaved.Rows[indexdtInsert]["typeOfMeasure"] = addEditSuppliesVals.typeOfMeasure;

            dtSuppliesUsedSaved.Rows[indexdtInsert]["Unit Measure"] = addEditSuppliesVals.unitMeasureUsed;

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
        internal void editSuppliesSelected(forAddEditSupplies editSuppliesVal)
        {
            int currRowIndexDataGrid = dataGridSuppliesUsed.SelectedRows[0].Index;
            int currRowIndexDt = -1;
            for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
            {
                if (Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndexDataGrid].Cells["supply_itemsId"].Value.ToString()) == Int32.Parse(dtSuppliesUsedSaved.Rows[i]["supply_itemsId"].ToString()))
                {
                    currRowIndexDt = i;
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

        //COSTS CALCULATION. FOR SELECTED UNIT PRICE AND RAW COST
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
            this.rawCostInitial = rawCostTotal;
            rawSalesTimesQuantityCalc();
        }
        //Calculation Cost only. Then put to datagrid
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
            rawCostCalculation();
            rawSalesTimesQuantityCalc();
            this.txtBoxDiscount.Text = (0).ToString();
            this.txtBoxDiscountTotal.Text = "";
            this.txtBoxTotalPaid.Text = "";
            this.txtBoxChange.Text = "";
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
            else if (String.IsNullOrEmpty(txtBoxDiscount.Text) || String.IsNullOrEmpty(txtBoxDiscountTotal.Text))
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
        private void deleteRowFromDataGrid(int currRowIndex)
        {
            bool checkIfInDatabase = false;
            int jOrder_detailsID = -1;
            //Check if deleted item is in database or from the datatable retrieved from the database
            if (!String.IsNullOrEmpty(dataGridSuppliesUsed.Rows[currRowIndex].Cells["jOrder_detailsID"].Value.ToString()))
            {
                jOrder_detailsID = Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["jOrder_detailsID"].Value.ToString());
                DataTable checkIfRemovedWasActive = new DataTable();
                try
                {
                    String stringSuppliesSelect =
                        "SELECT jod.jOrder_detailsID " +
                        "                        FROM jOrder_details AS jod" +
                        "                        WHERE jod.jOrder_detailsID = @jOrder_detailsID AND jod.active = 0; ";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                    cmdSuppliesSelect.Parameters.AddWithValue("@jOrder_detailsID", jOrder_detailsID);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);


                    my_adapter.Fill(checkIfRemovedWasActive);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (checkIfRemovedWasActive.Rows.Count > 0)
                {
                    checkIfInDatabase = true;
                }
            }
            if (checkIfInDatabase)
            {
                if (jOrder_detailsID > -1)
                {
                    RemovedFrame_MatItemId.Add(jOrder_detailsID);
                    DataRow dataRowDeleted = dtSuppliesUsedSaved.Rows[currRowIndex];
                    dtSuppliesUsedSaved.Rows.Remove(dataRowDeleted);
                    refreshDataGrid();

                    //dataGridSuppliesUsed.Rows.RemoveAt(this.dataGridSuppliesUsed.SelectedRows[0].Index);
                }
            }
            else
            {///LAST STOP HERE
                DataRow dataRowDeleted = dtSuppliesUsedSaved.Rows[currRowIndex];
                dtSuppliesUsedSaved.Rows.Remove(dataRowDeleted);
                refreshDataGrid();

                //dataGridSuppliesUsed.Rows.RemoveAt(this.dataGridSuppliesUsed.SelectedRows[0].Index);
            }
            rawCostCalculation();
            
        }
        private void sendToDatabase()
        {
            if (dtSuppliesUsedSaved.Rows.Count > 0)
            {
                for (int i = 0; i < dtSuppliesUsedSaved.Rows.Count; i++)
                {
                    if (String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[i]["jOrder_detailsID"].ToString()))
                    {
                        insertToDatabase(i);
                    }
                    else
                    {
                        updateToDatabase(Int32.Parse(dtSuppliesUsedSaved.Rows[i]["jOrder_detailsID"].ToString()), i);
                    }
                }
            }
            //Set to InActive
            if (RemovedFrame_MatItemId.Count > 0)
            {
                for (int i = 0; i < RemovedFrame_MatItemId.Count; i++)
                {
                    try
                    {
                        String stringUpdateJOD = "UPDATE jorder_details as jod " +
                            "                SET" +
                            "                jod.active = 1" +
                            "                WHERE jod.jOrder_detailsID = @jOrder_detailsID; ";
                        MySqlConnection my_conn = new MySqlConnection(connString);
                        MySqlCommand cmdUpdateJOD = new MySqlCommand(stringUpdateJOD, my_conn);
                        cmdUpdateJOD.Parameters.AddWithValue("@jOrder_detailsID", RemovedFrame_MatItemId[i]);

                        MySqlDataReader dataReader;
                        my_conn.Open();
                        dataReader = cmdUpdateJOD.ExecuteReader();
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
            }
            //Update Costs and Payments
            try
            {
                String stringUpdateJobOrder = "UPDATE joborder  " +
                    "        SET" +
                    "            totalAmount = @totalAmountPaid," +
                    "            discount = @discount," +
                    "            jobOrderQuantity = @jobOrderQuantity," +
                    "            jobOrderPrice = @jobOrderPrice," +
                    "            jobOrderdescription = @description" +
                    "        WHERE jOrd_Num = @jobOrderID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdUpdateJobOrder = new MySqlCommand(stringUpdateJobOrder, my_conn);
                cmdUpdateJobOrder.Parameters.AddWithValue("@jobOrderID", this.jobOrderID);
                cmdUpdateJobOrder.Parameters.AddWithValue("@totalAmountPaid", Double.Parse(txtBoxTotalPaid.Text.ToString()));
                cmdUpdateJobOrder.Parameters.AddWithValue("@discount", Double.Parse(txtBoxDiscount.Text.ToString()));
                cmdUpdateJobOrder.Parameters.AddWithValue("@jobOrderQuantity", Double.Parse(txtBoxQuantity.Text.ToString()));
                cmdUpdateJobOrder.Parameters.AddWithValue("@jobOrderPrice", Double.Parse(txtBoxJobPrice.Text.ToString()));
                cmdUpdateJobOrder.Parameters.AddWithValue("@description", txtBoxDescription.Text);

                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdUpdateJobOrder.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



            MessageBox.Show("Job Order Details Updated.");
            this.Close();
        }
        private void insertToDatabase(int indexOfdtSuppliesUsedSaved)
        {
            try
            {
                String stringInsertToFrame_Mat = "INSERT INTO jOrder_details(supply_itemsID, jOrd_Num, measureADeduction, measureBDeduction, unit_measure, dateDeducted, measureAtoOG, measureBtoOG, active) " +
                    "VALUES (@supply_itemsID, @jOrd_Num, @measureADeduction, @measureBDeduction, @unitmeasure, CURDATE(), @measureAtoOG, @measureBtoOG, 0); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdInsertToFrame_mat = new MySqlCommand(stringInsertToFrame_Mat, my_conn);
                cmdInsertToFrame_mat.Parameters.AddWithValue("@jOrd_Num", this.jobOrderID);
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
        private void updateToDatabase(int joOrderDetailsID, int indexOfdtSuppliesUsedSaved)
        {
            try
            {
                String stringUpdateFrame_mat = "UPDATE jorder_details as jod  " +
                    "                    SET" +
                    "                    jod.measureADeduction = @measureADeduction,  " +
                    "                    jod.measureBDeduction = @measureBDeduction,  " +
                    "                    jod.unit_Measure = @unitMeasureSelected,  " +
                    "                    jod.active = 0, " +
                    "                    jod.measureAtoOG = @measureAtoOG,  " +
                    "                    jod.measureBtoOG = @measureBtoOG" +
                    "                    WHERE jorder_detailsID = @jorder_detailsID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdUpdateFrame_mat = new MySqlCommand(stringUpdateFrame_mat, my_conn);
                cmdUpdateFrame_mat.Parameters.AddWithValue("@unitMeasureSelected", dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["Unit Measure"].ToString());
                cmdUpdateFrame_mat.Parameters.AddWithValue("@jorder_detailsID", joOrderDetailsID);
                double RoundedAtoOG = Math.Round(Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["measureAtoOG"].ToString()), 7);
                cmdUpdateFrame_mat.Parameters.AddWithValue("@measureAtoOG", RoundedAtoOG);
                cmdUpdateFrame_mat.Parameters.AddWithValue("@measureADeduction", Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["deductedA"].ToString()));

                if (!String.IsNullOrEmpty(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["deductedB"].ToString()))
                {
                    double RoundedBtoOG = Math.Round(Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["measureBtoOG"].ToString()), 7);
                    cmdUpdateFrame_mat.Parameters.AddWithValue("@measureBDeduction", Double.Parse(dtSuppliesUsedSaved.Rows[indexOfdtSuppliesUsedSaved]["deductedB"].ToString()));
                    cmdUpdateFrame_mat.Parameters.AddWithValue("@measureBtoOG", RoundedBtoOG);
                }
                else
                {
                    cmdUpdateFrame_mat.Parameters.AddWithValue("@measureBDeduction", DBNull.Value);
                    cmdUpdateFrame_mat.Parameters.AddWithValue("@measureBtoOG", DBNull.Value);
                }

                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdUpdateFrame_mat.ExecuteReader();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed frmAddSupplies = new frmFrameAddSuppliesUsed(this, this.jobOrderID);
            frmAddSupplies.ShowDialog();
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currRowIndex = dataGridSuppliesUsed.SelectedRows[0].Index;
            deleteRowFromDataGrid(currRowIndex);
        }

        private void btnEditJO_Click(object sender, EventArgs e)
        {
            int validation = 0;
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
            }
            if (String.IsNullOrEmpty(txtBoxTotalPaid.Text))
            {
                MessageBox.Show("Please Input a Payment.");
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

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            rawSalesTimesQuantityCalc();
        }

        private void txtBoxJobPrice_TextChanged(object sender, EventArgs e)
        {
            discountCalc();
        }

        private void txtBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            discountCalc();
        }

        private void txtBoxTotalPaid_TextChanged(object sender, EventArgs e)
        {
            changeCalc();
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
    }
}
