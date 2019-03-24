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
    public partial class frmFrameStockInUpdate : Form
    {
        int employeeID;
        int inventoryID;
        int quantityInputted;
        double rawCostInitial;
        double salesPriceInitial;
        String frameName;
        String frameDescription;
        String frameDimension;
        String empName;

        DataTable dtRawCostMerger;
        DataTable dtQuantityChecker;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        List<String> insufficientSupplies;
        //--------------Initial Load--------------
        //----for programming initializer

        public frmFrameStockInUpdate()
        {
            InitializeComponent();
        }
        public frmFrameStockInUpdate(int employeeID, int inventoryID, double rawCostInitial, int quantityInputted,
            String frameName, String frameDescription,String frameDimension, String empName,DataTable dtRawCostMerger,double salesPriceInitial)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.rawCostInitial = rawCostInitial;
            this.quantityInputted = quantityInputted;
            this.frameDescription = frameDescription;
            this.frameName = frameName;
            this.empName = empName;
            this.frameDimension = frameDimension;
            this.dtRawCostMerger = dtRawCostMerger;
            this.inventoryID = inventoryID;
            this.salesPriceInitial = salesPriceInitial;
        }
        private void frmFrameStockInUpdate_Load(object sender, EventArgs e)
        {
            frmDetailsLoader();
        }

        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmDetailsLoader()
        {
            txtBoxEmployeeName.Text = empName;
            txtBoxFrameName.Text = frameName;
            txtBoxDescription.Text = frameDescription;
            txtBoxDimension.Text = frameDimension;
            txtBoxQuantity.Text = quantityInputted.ToString();
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
                    "                                  LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG) * (SUM(fs.stockinQuantity)- @quantityInput) as `stockedOut` /*Measurements*/" +
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
                    "                        LEFT JOIN(SELECT sfm.supply_itemsID, SUM(sfm.measureAtoOG* sfm.measureBtoOG)*(SUM(fs.stockinQuantity)- @quantityInput ) as `stockedOutArea` /*Measurements*/" +
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
                cmdSuppliesSelect.Parameters.AddWithValue("@quantityInput", quantityInputted);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtQuantityChecker = new DataTable();
                my_adapter.Fill(dtQuantityChecker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private bool quantityChecker(int supply_itemId, int currRowIndex)
        {

            dtQuantityCheckerFiller(supply_itemId);
            double quantityLeftinMeasure = Double.Parse(dtQuantityChecker.Rows[0]["Quantity Left in Measurement"].ToString());
            double quantityCheck;
            double measureAUsedConverted;
            double measureBUsedConverted = 0;

            double totalAreaUsed = 0;

            String typeOfMeasure = dtRawCostMerger.Rows[currRowIndex]["typeOfMeasure"].ToString();

            double quantityUsed = Double.Parse(txtBoxQuantity.Text);
            //Use dtRawCostMerger for using this method

            if (String.Equals(typeOfMeasure, "Area"))
            {
                measureAUsedConverted = Double.Parse(dtRawCostMerger.Rows[currRowIndex]["measureAtoOG"].ToString());
                measureBUsedConverted = Double.Parse(dtRawCostMerger.Rows[currRowIndex]["measureBtoOG"].ToString());


                totalAreaUsed = measureAUsedConverted * measureBUsedConverted;

                quantityCheck = quantityLeftinMeasure - (totalAreaUsed * quantityUsed);
            }
            else
            {
                measureAUsedConverted = Double.Parse(dtRawCostMerger.Rows[currRowIndex]["measureAtoOG"].ToString());

                quantityCheck = quantityLeftinMeasure - (measureAUsedConverted * quantityUsed);
            }
            //if (String.Equals(typeOfMeasure, "Area"))
            //{
            //    MessageBox.Show("Quantity Left in Measure= " + quantityLeftinMeasure + "\n QuantityCheck= " + quantityCheck +
            //    "\n measureAUsed= " + measureAUsedConverted +
            //    "\n measureBUsed= " + measureBUsedConverted +
            //    "\n totalAreaUsed= " + totalAreaUsed);
            //}
            //else
            //{
            //    MessageBox.Show("Quantity Left in Measure= " + quantityLeftinMeasure + "\n QuantityCheck= " + quantityCheck +
            //    "\n measureAUsed= " + measureAUsedConverted +
            //    "\n typeOfmeasure= " + typeOfMeasure);
            //}
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
        private void rawSalesTimesQuantityCalc()
        {
            Double quantityInput = 0;
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
        private void sendToDataBase()
        {
            try
            {
                String stringUpdateStockIn = "UPDATE framestock_in " +
                    "SET " +
                    "stockinQuantity = @quantity, " +
                    "dateModified = NOW(), " +
                    "totalCostPrice = @totalCostPrice, " +
                    "totalSalesPrice = @totalSalesPrice " +
                    "WHERE inventoryID = @inventoryID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdUpdateStockIn = new MySqlCommand(stringUpdateStockIn, my_conn);
                cmdUpdateStockIn.Parameters.AddWithValue("@inventoryID", this.inventoryID);
                cmdUpdateStockIn.Parameters.AddWithValue("@quantity", Int32.Parse(txtBoxQuantity.Text));
                cmdUpdateStockIn.Parameters.AddWithValue("@totalCostPrice", Double.Parse(txtBoxCost.Text));
                cmdUpdateStockIn.Parameters.AddWithValue("@totalSalesPrice", Double.Parse(txtBoxSales.Text));
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdUpdateStockIn.ExecuteReader();
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

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            int validationCount = 0;
            insufficientSupplies = new List<String>();
            if (String.IsNullOrEmpty(txtBoxQuantity.Text) || Double.Parse(txtBoxQuantity.Text) == 0)
            {
                MessageBox.Show("Please enter a Quantity to Stock In");
                return;
            }

            for (int i = 0; i < dtRawCostMerger.Rows.Count; i++)
            {
                bool quantityCheck = quantityChecker(Int32.Parse(dtRawCostMerger.Rows[i]["supply_itemsId"].ToString()), i);
                if (quantityCheck == false)
                {
                    validationCount++;
                }
            }
            if (validationCount > 0)
            {
                String insufficiencies = "\nPlease Stock In more Supplies of: ";
                for (int i = 0; i < insufficientSupplies.Count; i++)
                {
                    insufficiencies += "\n *" + insufficientSupplies[i];
                }
                MessageBox.Show("Insufficient Supplies. Cannot Stock In Frame." + insufficiencies);
                return;
            }

            DialogResult result = MessageBox.Show("Confirm Stock In?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sendToDataBase();
                MessageBox.Show("Stock In Details Updated.");
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            rawSalesTimesQuantityCalc();
        }
    }
}
