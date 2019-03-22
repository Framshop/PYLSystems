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
    public partial class frmFrameStockInAdd : Form
    {
        
       
        
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        int frameItemID;
        int employeeID;
        DataTable dtframeStockInList;
        DataTable dtRawCost; //DataTable from DataBase
        DataTable dtRawCostMerger; //Merge to add Raw Cost Column per Item;

        DateTime DateStart;
        DateTime DateEnd;
        double rawCostInitial;
        double salesPriceInitial;

        DataTable dtQuantityChecker;
        List<String> insufficientSupplies;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmFrameStockInAdd()
        {
            InitializeComponent();
            this.frameItemID = 1;
            this.employeeID = 1;
        }
        public frmFrameStockInAdd(int frameItemID, int employeeID)
        {
            InitializeComponent();
            this.frameItemID=frameItemID;
            this.employeeID = employeeID;
            rawCostInitial = 0;
            salesPriceInitial = 0;
        }
        private void frmFrameStockInAdd_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            frameDetailsLoader();
            frmFrameStockInAdd_Loader();
            rawCostLoader();

            startDatePicker.Enabled = true;
            endDatePicker.Enabled = true;
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmFrameStockInAdd_Loader()
        {
            //MessageBox.Show(frameItemID + " " + DateStart.ToString() + " " + DateEnd.ToString());
            try
            {
                String stringStockInRecord =
                    "SELECT fs.inventoryID, fs.dateStockIn AS `Date Stocked In`, fs.stockinQuantity AS `Stock In Quantity`, " +
                    "fs.dateModified AS `Date Modified`, concat(emp.lastName, ', ', emp.firstName) as `Stocked In by`, " +
                    "fs.totalCostPrice AS `Cost of Stock In` " +
                    "FROM framestock_in AS fs " +
                    "LEFT JOIN employee AS emp ON fs.employeeID = emp.employeeID " +
                    "LEFT JOIN frame_list AS fl ON fs.frameItemID = fl.frameItemID " +
                    "WHERE fs.frameItemID = @frameItemId AND (fs.dateStockIn BETWEEN @DateStart AND @DateEnd); ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdStockInRecord = new MySqlCommand(stringStockInRecord, my_conn);
                cmdStockInRecord.Parameters.AddWithValue("@frameItemId", this.frameItemID);
                cmdStockInRecord.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd hh:mm:ss"));
                cmdStockInRecord.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd hh:mm:ss"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdStockInRecord);


                dtframeStockInList = new DataTable();
                my_adapter.Fill(dtframeStockInList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridFrameStockIn.DataSource = null;
            datagridFrameStockIn.DataSource = dtframeStockInList;
            datagridFrameStockIn.Columns["inventoryID"].Visible = false;
            datagridFrameStockIn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            //Hide edit Stock In for now
            btnEdit.Visible = false;
        }
        private void frameDetailsLoader()
        {
            DataTable dtFrameDet;
            dtFrameDet = new DataTable();
            //Load Frame detaisl from frame_list
            try
            {
                String stringSuppliesSelect =
                    "SELECT frameName, dimension, frameDescription, unitSalesPrice FROM frame_list WHERE frameItemID = @frameItemId; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", this.frameItemID);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                
                my_adapter.Fill(dtFrameDet);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            this.txtBoxFrameName.Text = dtFrameDet.Rows[0]["frameName"].ToString();
            this.txtBoxDimension.Text = dtFrameDet.Rows[0]["dimension"].ToString();
            this.txtBoxDescription.Text = dtFrameDet.Rows[0]["frameDescription"].ToString();
            this.salesPriceInitial = Double.Parse(dtFrameDet.Rows[0]["unitSalesPrice"].ToString());

            //Load EmployeeName
            DataTable dtEmployeeName;
            dtEmployeeName = new DataTable();
            //Load from frame_list
            try
            {
                String stringGetEmpName =
                    "SELECT concat(lastname,', ',firstname) AS empName FROM employee WHERE employeeID = @employeeID; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdGetEmpName = new MySqlCommand(stringGetEmpName, my_conn);
                cmdGetEmpName.Parameters.AddWithValue("@employeeID", this.employeeID);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdGetEmpName);

                my_adapter.Fill(dtEmployeeName);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            this.txtBoxEmpName.Text = dtEmployeeName.Rows[0]["empName"].ToString();
        }
        private void rawCostLoader()
        {
            //Load dataTable from frame_materials - frmFrameEdit style. Store raw cost in rawCostInitial;
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
                    "                    WHERE fm.frameItemId = @frameItemID AND fm.active = 0 " +
                    "                                        GROUP BY frame_materialsID; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", this.frameItemID);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtRawCost = new DataTable();
                my_adapter.Fill(dtRawCost);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            dtRawCostMerger = new DataTable();
            dtRawCostMerger.Columns.Add("frame_MaterialsID", typeof(int));
            dtRawCostMerger.Columns.Add("supply_itemsId", typeof(int));
            dtRawCostMerger.Columns.Add("Supply Name", typeof(String));
            dtRawCostMerger.Columns.Add("Category", typeof(String));
            dtRawCostMerger.Columns.Add("typeOfMeasure", typeof(String));
            dtRawCostMerger.Columns.Add("deductedA", typeof(double));
            dtRawCostMerger.Columns.Add("deductedB", typeof(double));
            dtRawCostMerger.Columns.Add("Usage", typeof(String));
            dtRawCostMerger.Columns.Add("Unit Measure", typeof(String));
            //Original Measures
            dtRawCostMerger.Columns.Add("OGUnitMeasure", typeof(String));
            dtRawCostMerger.Columns.Add("OGUnitPrice", typeof(double));
            dtRawCostMerger.Columns.Add("measureAOG", typeof(double));
            dtRawCostMerger.Columns.Add("measureBOG", typeof(double));
            dtRawCostMerger.Columns.Add("measureAtoOG", typeof(double));
            dtRawCostMerger.Columns.Add("measureBtoOG", typeof(double));


            //ADDED Custom Columns
            dtRawCostMerger.Columns.Add("Cost/Unit Measure", typeof(double));
            dtRawCostMerger.Columns.Add("Raw Cost", typeof(double));

            dtRawCostMerger.Merge(dtRawCost);

            if (dtRawCostMerger.Rows.Count > 0)
            {
                for (int i = 0; i < dtRawCostMerger.Rows.Count; i++)
                {
                    trueCostCalculationPutDataGrid(i);
                }
            }
        }
        internal void trueCostCalculationPutDataGrid(int dtTableIndex)
        {

            if (String.Equals(dtRawCostMerger.Rows[dtTableIndex]["typeOfMeasure"].ToString(), "Whole"))
            {
                double rawCost = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAtoOG"].ToString()) * Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString());

                dtRawCostMerger.Rows[dtTableIndex]["Cost/Unit Measure"] = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString());
                dtRawCostMerger.Rows[dtTableIndex]["Raw Cost"] = rawCost;

            }
            else if (String.Equals(dtRawCostMerger.Rows[dtTableIndex]["typeOfMeasure"].ToString(), "Area"))
            {
                double area_OG = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString()) * Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureBOG"].ToString());
                double trueUnitPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) / area_OG;

                double areaOfUsed = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAtoOG"].ToString()) * Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureBtoOG"].ToString());

                double rawCost = areaOfUsed * trueUnitPrice;

                dtRawCostMerger.Rows[dtTableIndex]["Cost/Unit Measure"] = trueUnitPrice;
                dtRawCostMerger.Rows[dtTableIndex]["Raw Cost"] = rawCost;
            }
            else
            {
                double trueUnitPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) / Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString());

                double rawCost = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAtoOG"].ToString()) * trueUnitPrice;

                dtRawCostMerger.Rows[dtTableIndex]["Cost/Unit Measure"] = trueUnitPrice;
                dtRawCostMerger.Rows[dtTableIndex]["Raw Cost"] = rawCost;
            }         
            rawCostSingleUnitCalc();
        }
        private void rawCostSingleUnitCalc()
        {
            double rawCostTotal = 0;
            for (int i = 0; i < dtRawCostMerger.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dtRawCostMerger.Rows[i]["Raw Cost"].ToString()))
                {
                    rawCostTotal += Double.Parse(dtRawCostMerger.Rows[i]["Raw Cost"].ToString());
                }

            }
            this.rawCostInitial = rawCostTotal;
        }
        private void rawSalesTimesQuantityCalc()
        {
            Double quantityInput=0;
            if (String.IsNullOrEmpty(txtBoxQuantity.Text))
            {
                quantityInput = 0;
            }
            else
            {
                quantityInput = Double.Parse(txtBoxQuantity.Text);
            }
            Double totalRawCost = this.rawCostInitial * quantityInput;
            Double totalSalesCost = this.salesPriceInitial * quantityInput;

            txtBoxCost.Text = totalRawCost.ToString();
            txtBoxSales.Text = totalSalesCost.ToString();
        }
        private void DefaultDatesInitializer()
        {

                DateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddHours(0).AddMinutes(0).AddSeconds(0);
                DateEnd = DateStart.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
                startDatePicker.Value = DateStart;
                endDatePicker.Value = DateEnd;
            

        }
        private void sendToDataBase() {
            try
            {
                String stringInsertToFrameStockIn = "INSERT INTO frameStock_in (employeeID,frameItemID,stockinQuantity,dateStockIn,totalCostPrice,totalSalesPrice) VALUES " +
                    "(@employeeID, @frameItemID, @stockinQuantity, NOW(), @totalCostPrice, @totalSalesPrice); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdInsertToFrameStockIn = new MySqlCommand(stringInsertToFrameStockIn, my_conn);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@employeeID", this.employeeID);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@frameItemID", this.frameItemID);
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@stockinQuantity", Int32.Parse(this.txtBoxQuantity.Text));

                cmdInsertToFrameStockIn.Parameters.AddWithValue("@totalCostPrice", Double.Parse(this.txtBoxCost.Text));
                cmdInsertToFrameStockIn.Parameters.AddWithValue("@totalSalesPrice", Double.Parse(this.txtBoxSales.Text));


                my_conn.Open();
                cmdInsertToFrameStockIn.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            MessageBox.Show("Frame Stocked In.");
            frmFrameStockInAdd_Loader();
            txtBoxQuantity.Text = "";
            txtBoxCost.Text = "";
            txtBoxSales.Text = "";
        }
        private void dtQuantityCheckerFiller(int supply_itemId)
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
                    "				)AS supsoA ON si.supply_itemsID = supsoA.supply_itemsID WHERE si.supply_itemsID=@supply_itemID;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@supply_itemID", supply_itemId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtQuantityChecker = new DataTable();
                my_adapter.Fill(dtQuantityChecker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private bool quantityChecker(int supply_itemId,int currRowIndex)
        {
            
            dtQuantityCheckerFiller(supply_itemId);
            double quantityLeftinMeasure = Double.Parse(dtQuantityChecker.Rows[0]["Quantity Left in Measurement"].ToString());
            double quantityCheck;
            double measureAUsedConverted;
            double measureBUsedConverted=0;

            double totalAreaUsed=0;

            String typeOfMeasure = dtRawCostMerger.Rows[currRowIndex]["typeOfMeasure"].ToString();

            double quantityUsed = Double.Parse(txtBoxQuantity.Text);
            //Use dtRawCostMerger for using this method

            if (String.Equals(typeOfMeasure, "Area"))
            {
                measureAUsedConverted = Double.Parse(dtRawCostMerger.Rows[currRowIndex]["measureAtoOG"].ToString());
                measureBUsedConverted = Double.Parse(dtRawCostMerger.Rows[currRowIndex]["measureBtoOG"].ToString());

              
                totalAreaUsed = measureAUsedConverted * measureBUsedConverted;

                quantityCheck = quantityLeftinMeasure - (totalAreaUsed*quantityUsed);
            }
            else
            {
                measureAUsedConverted = Double.Parse(dtRawCostMerger.Rows[currRowIndex]["measureAtoOG"].ToString());

                quantityCheck = quantityLeftinMeasure - (measureAUsedConverted * quantityUsed);
            }
            if (String.Equals(typeOfMeasure, "Area"))
            {
                MessageBox.Show("Quantity Left in Measure= " + quantityLeftinMeasure + "\n QuantityCheck= " + quantityCheck +
                "\n measureAUsed= " + measureAUsedConverted +
                "\n measureBUsed= "+measureBUsedConverted +
                "\n totalAreaUsed= "+totalAreaUsed);
            }
            else
            {
                MessageBox.Show("Quantity Left in Measure= " + quantityLeftinMeasure + "\n QuantityCheck= " + quantityCheck +
                "\n measureAUsed= " + measureAUsedConverted +
                "\n typeOfmeasure= "+ typeOfMeasure);
            }
            

            if (quantityCheck < 0)
            {
                insufficientSupplies.Add(dtRawCostMerger.Rows[currRowIndex]["Supply Name"].ToString());
                return false;
            }
            else
            {
                return true;
            }
        }
        //----------------Event Methods-----------------
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmFrameStockInUpdate UpdateStockIn = new frmFrameStockInUpdate();
            UpdateStockIn.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            int validationCount = 0;
            insufficientSupplies = new List<String>();
            if (String.IsNullOrEmpty(txtBoxQuantity.Text)||Double.Parse(txtBoxQuantity.Text)==0)
            {
                MessageBox.Show("Please enter a Quantity to Stock In");
                return;
            }

            for (int i=0; i<dtRawCostMerger.Rows.Count;i++)
            {
                bool quantityCheck = quantityChecker(Int32.Parse(dtRawCostMerger.Rows[i]["supply_itemsId"].ToString()),i);
                if (quantityCheck == false)
                {
                    validationCount++;
                }
            }
            if (validationCount > 0)
            {
                String insufficiencies = "\nPlease Stock In more Supplies of: ";
                for (int i=0; i<insufficientSupplies.Count;i++)
                {
                    insufficiencies += "\n *"+ insufficientSupplies[i];
                }
                MessageBox.Show("Insufficient Supplies. Cannot Stock In Frame." + insufficiencies);
                return;
            }

            DialogResult result = MessageBox.Show("Confirm Stock In?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sendToDataBase();
            }
            else
            {
                return;
            }

        }
        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled)
            {
                DateStart = startDatePicker.Value;
                frmFrameStockInAdd_Loader();
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled)
            {
                DateEnd = endDatePicker.Value;
                frmFrameStockInAdd_Loader();
            }
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            rawSalesTimesQuantityCalc();
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
