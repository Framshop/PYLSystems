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
    public partial class frmJobOrder : Form
    {
        //--------------Initial Load--------------
        //----for programming initializer
       
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        int employeeID;
        int employeeStatus;
        DataTable dtRawCost; //DataTable from DataBase and Supplies/JobOrderDetails
        DataTable dtRawCostMerger; //Merge to add Raw Cost Column per Item;

        DataTable dtJobOrderList;
        DateTime DateStart;
        DateTime DateEnd;

        double rawCostInitial;

        public frmJobOrder()
        {
            InitializeComponent();
            this.employeeID = 1;
            this.employeeStatus = 1;
        }
        public frmJobOrder(int employeeID, int employeeStatus)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.employeeStatus = employeeStatus;
        }
        private void frmJobOrder_Load(object sender, EventArgs e)
        {
            jobOrder_Loader();
        }


        //-------------Process and Calculation Methods--------------
        //First time load
        private void jobOrder_Loader()
        {
            DefaultDatesInitializer();
            jobOrder_ReceiptsLoader();
            if (datagridJOList.Rows.Count > 0)
            {           
                int currRowIndex = datagridJOList.SelectedRows[0].Index;
                int jobOrderID = Int32.Parse(datagridJOList.Rows[currRowIndex].Cells["Receipt Number"].Value.ToString());
                jobOrder_SuppliesUsedLoader(jobOrderID);
            }
        }
        private void jobOrder_ReceiptsLoader()
        {   //Hide Columns from Employee Name to the Last Column and jobOrderdescription. These fields will be inputted in the TextBoxes
            try
            {//Show Only jOrd_Num and jobOrderDate
                String stringJobOrdersList =
                    "SELECT job.jOrd_Num AS `Receipt Number`, job.jobOrderdescription AS `Order Description`,  " +
                    "job.jobOrderDate AS `Job Order Date`, concat(emp.lastname, ', ', emp.firstname) AS `Employee Name`, job.jobOrderQuantity AS `Quantity`, " +
                    "job.discount AS `Discount`, job.totalAmount AS `Total Paid`,job.jobOrderPrice " +
                    "FROM jobOrder AS job LEFT JOIN employee AS emp ON job.employeeID = emp.employeeID " +
                    "WHERE job.jobOrderDate BETWEEN @DateStart AND @DateEnd AND job.active=0; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdJobOrdersList = new MySqlCommand(stringJobOrdersList, my_conn);

                cmdJobOrdersList.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd hh:mm:ss"));
                cmdJobOrdersList.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd hh:mm:ss"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdJobOrdersList);


                dtJobOrderList = new DataTable();
                my_adapter.Fill(dtJobOrderList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridJOList.DataSource = dtJobOrderList;
            datagridJOList.Columns["Order Description"].Visible = false;
            datagridJOList.Columns["Employee Name"].Visible = false;
            datagridJOList.Columns["Quantity"].Visible = false;
            datagridJOList.Columns["Discount"].Visible = false;
            datagridJOList.Columns["Total Paid"].Visible = false;
            datagridJOList.Columns["jobOrderPrice"].Visible = false;
            datagridJOList.Columns["Receipt Number"].DefaultCellStyle.Format = "000000000";
            if (datagridJOList.Rows.Count > 0)
            {
                jobOrderOtherDetailsLoader();
            }
            
        }
        private void jobOrder_SuppliesUsedLoader(int jobOrderID)
        {
            try
            {
                String stringJOSuppliesList =
                    "SELECT jod.jOrder_detailsID, job.jOrd_Num, sui.supply_itemsId, sui.supplyName AS `Supply Name`, sc.categoryName AS `Category`," +
                    "sc.typeOfMeasure, jod.measureAdeduction AS `deductedA`, jod.measureBdeduction AS `deductedB`," +
                    "if(sc.typeOfMeasure = 'Area',concat('1 ',sui.unitMeasure,'²'),concat('1 ',sui.unitMeasure)) AS `Base Unit Measure`," +
                    "if (sc.categoryName = 'Area',concat(jod.measureAdeduction, ' x ', jod.measureBdeduction),jod.measureAdeduction) AS `Usage`," +
                    "jod.unit_measure AS `Unit Measure`, sui.unitMeasure AS `OGUnitMeasure`, IFNULL(sud.priceRawTotal,0) AS `OGUnitPrice`," +
                    "IFNULL(MAX(sud.delivery_date),'None') AS `Latest_Stock_In`," +
                    "sui.measureA AS `measureAOG`, sui.measureB AS `measureBOG`, jod.measureAtoOG, jod.measureBtoOG " +
                    "FROM jOrder_details AS jod " +
                    "LEFT JOIN jobOrder AS job ON jod.jOrd_Num = job.jOrd_Num " +
                    "LEFT JOIN supply_items AS sui ON jod.supply_itemsID = sui.supply_itemsID " +
                    "LEFT JOIN supply_category AS sc ON sui.supply_categoryID = sc.supply_categoryID " +
                    "LEFT JOIN supply_details AS sud ON sui.supply_itemsId=sud.supply_itemsID " +
                    "WHERE jod.jOrd_Num = @jOrd_Num AND jod.active = 0 " +
                    "GROUP BY jod.jOrder_detailsID;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdJOSuppliesList = new MySqlCommand(stringJOSuppliesList, my_conn);

                cmdJOSuppliesList.Parameters.AddWithValue("@jOrd_Num", jobOrderID);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdJOSuppliesList);


                dtRawCost = new DataTable();
                my_adapter.Fill(dtRawCost);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            dtRawCostMerger = new DataTable();
            dtRawCostMerger.Columns.Add("jOrder_detailsID", typeof(int));
            dtRawCostMerger.Columns.Add("jOrd_Num", typeof(int));
            dtRawCostMerger.Columns.Add("supply_itemsId", typeof(int));
            dtRawCostMerger.Columns.Add("Supply Name", typeof(String));
            dtRawCostMerger.Columns.Add("Category", typeof(String));
            dtRawCostMerger.Columns.Add("typeOfMeasure", typeof(String));
            dtRawCostMerger.Columns.Add("Cost/Base Unit Measure", typeof(double));
            dtRawCostMerger.Columns.Add("Base Unit Measure", typeof(String));
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

            dtRawCostMerger.Columns.Add("Cost/Selected Unit Measure", typeof(double));
            dtRawCostMerger.Columns.Add("Raw Cost", typeof(double));
            dtRawCostMerger.Merge(dtRawCost);
            

            if (dtRawCostMerger.Rows.Count > 0)
            {
                for (int i = 0; i < dtRawCostMerger.Rows.Count; i++)
                {
                    if (!String.IsNullOrEmpty(dtRawCostMerger.Rows[i]["jOrder_detailsID"].ToString()))
                    {
                        trueCostCalculationPutDataGrid(i);
                    }
                }
            }
            dataGridSuppliesUsed.DataSource = null;
            dataGridSuppliesUsed.DataSource = dtRawCostMerger;
            dataGridSuppliesUsed.Columns["Cost/Base Unit Measure"].DefaultCellStyle.Format = "P0.0000000";
            dataGridSuppliesUsed.Columns["Cost/Selected Unit Measure"].DefaultCellStyle.Format = "P0.0000000";
            dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            dataGridSuppliesUsed.Columns["jOrder_detailsID"].Visible = false;
            dataGridSuppliesUsed.Columns["jOrd_Num"].Visible = false;

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
        internal void jobOrderOtherDetailsLoader()
        {
            
            int currRowIndex = datagridJOList.SelectedRows[0].Index;
            txtBoxDescription.Text = datagridJOList.Rows[currRowIndex].Cells["Order Description"].Value.ToString();
            txtBoxEmployee.Text = datagridJOList.Rows[currRowIndex].Cells["Employee Name"].Value.ToString();
            txtBoxDate.Text = datagridJOList.Rows[currRowIndex].Cells["Job Order Date"].Value.ToString();
            txtBoxReceiptNum.Text = Int32.Parse((datagridJOList.Rows[currRowIndex].Cells["Receipt Number"].Value.ToString())).ToString("000000000");
            txtBoxQuantity.Text = datagridJOList.Rows[currRowIndex].Cells["Quantity"].Value.ToString();
            
            double discount = Double.Parse(datagridJOList.Rows[currRowIndex].Cells["Discount"].Value.ToString());
            double totalPaid = Double.Parse(datagridJOList.Rows[currRowIndex].Cells["Total Paid"].Value.ToString());
            double jobOrderPrice = Double.Parse(datagridJOList.Rows[currRowIndex].Cells["jobOrderPrice"].Value.ToString());
            txtBoxDiscount.Text = discount.ToString("0.00");
            txtBoxJOPrice.Text = jobOrderPrice.ToString("0.00");
            txtBoxDiscountTotal.Text = (jobOrderPrice - discount).ToString("0.00");
            txtBoxTotalAmount.Text = totalPaid.ToString("0.00");
            rawSalesTimesQuantityCalc();
        }
        internal void trueCostCalculationPutDataGrid(int dtTableIndex)
        {

            if (String.Equals(dtRawCostMerger.Rows[dtTableIndex]["typeOfMeasure"].ToString(), "Whole"))
            {
                double rawCost = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAtoOG"].ToString()) * Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString());

                dtRawCostMerger.Rows[dtTableIndex]["Cost/Base Unit Measure"] = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString());
                dtRawCostMerger.Rows[dtTableIndex]["Raw Cost"] = rawCost;
                dtRawCostMerger.Rows[dtTableIndex]["Cost/Selected Unit Measure"] = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString());

            }
            else if (String.Equals(dtRawCostMerger.Rows[dtTableIndex]["typeOfMeasure"].ToString(), "Area"))
            {
                double area_OG = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString()) * Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureBOG"].ToString());
                double trueUnitPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) / area_OG;

                double areaOfUsed = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAtoOG"].ToString()) * Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureBtoOG"].ToString());

                double rawCost = areaOfUsed * trueUnitPrice;
                double displayPrice;

                dtRawCostMerger.Rows[dtTableIndex]["Cost/Base Unit Measure"] = trueUnitPrice;
                dtRawCostMerger.Rows[dtTableIndex]["Raw Cost"] = rawCost;
                if(String.Equals(dtRawCostMerger.Rows[dtTableIndex]["OGUnitMeasure"].ToString(), dtRawCostMerger.Rows[dtTableIndex]["Unit Measure"].ToString()))
                {
                    displayPrice = trueUnitPrice;
                    dtRawCostMerger.Rows[dtTableIndex]["Cost/Selected Unit Measure"] = displayPrice;
                }
                else
                {
                    double measureAOGConvert = measureConverter(Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString()),
                        dtRawCostMerger.Rows[dtTableIndex]["Unit Measure"].ToString(), dtRawCostMerger.Rows[dtTableIndex]["OGUnitMeasure"].ToString());
                    double measureBOGConvert = measureConverter(Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureBOG"].ToString()),
                        dtRawCostMerger.Rows[dtTableIndex]["Unit Measure"].ToString(), dtRawCostMerger.Rows[dtTableIndex]["OGUnitMeasure"].ToString());
                    double area_OGDisplay = measureAOGConvert * measureBOGConvert;
                    displayPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) / area_OGDisplay;
                    dtRawCostMerger.Rows[dtTableIndex]["Cost/Selected Unit Measure"] = displayPrice;
                }
                
            }
            else
            {
                double trueUnitPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) / Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString());

                double rawCost = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAtoOG"].ToString()) * trueUnitPrice;

                double displayPrice;
                if (String.Equals(dtRawCostMerger.Rows[dtTableIndex]["typeOfMeasure"].ToString(), "Volume"))
                {
                    displayPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) /
                        measureConverter(Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString()),
                        dtRawCostMerger.Rows[dtTableIndex]["Unit Measure"].ToString(), dtRawCostMerger.Rows[dtTableIndex]["OGUnitMeasure"].ToString(),0);
                }
                else
                {
                    displayPrice = Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["OGUnitPrice"].ToString()) /
                        measureConverter(Double.Parse(dtRawCostMerger.Rows[dtTableIndex]["measureAOG"].ToString()),
                        dtRawCostMerger.Rows[dtTableIndex]["Unit Measure"].ToString(), dtRawCostMerger.Rows[dtTableIndex]["OGUnitMeasure"].ToString());
                }
                dtRawCostMerger.Rows[dtTableIndex]["Cost/Selected Unit Measure"] = displayPrice;
                dtRawCostMerger.Rows[dtTableIndex]["Cost/Base Unit Measure"] = trueUnitPrice;
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
        private void DefaultDatesInitializer()
        {

            DateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddHours(0).AddMinutes(0).AddSeconds(0);
            DateEnd = DateStart.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            startDatePicker.Value = DateStart;
            endDatePicker.Value = DateEnd;
        }
        private void rawSalesTimesQuantityCalc()
        {
            Double quantityInput = 1;
            if (String.IsNullOrEmpty(txtBoxQuantity.Text))
            {
                quantityInput = 0;
            }
            else
            {
                quantityInput = Double.Parse(txtBoxQuantity.Text);
            }
            Double totalRawCost = this.rawCostInitial * quantityInput;

            txtBoxRawCost.Text = totalRawCost.ToString();
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
        //----------------Event Methods-----------------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (datagridJOList.Rows.Count == 0)
            {
                MessageBox.Show("There's nothing to update.");
                return;
            }
            int currRowIndex = datagridJOList.SelectedRows[0].Index;
            int jobOrderID = Int32.Parse(datagridJOList.Rows[currRowIndex].Cells["Receipt Number"].Value.ToString());
            frmJobOrderEdit frmJOUpdate = new frmJobOrderEdit(this.employeeID,this.employeeStatus,jobOrderID);
            frmJOUpdate.ShowDialog();
            jobOrder_Loader();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmJobOrderCreate frmJOCreate = new frmJobOrderCreate(this.employeeID,this.employeeStatus);
            frmJOCreate.ShowDialog();
            jobOrder_Loader();
            jobOrder_Loader();
        }

        private void datagridJOList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = datagridJOList.SelectedRows[0].Index;
            int jobOrderID = Int32.Parse(datagridJOList.Rows[currRowIndex].Cells["Receipt Number"].Value.ToString());
            jobOrder_SuppliesUsedLoader(jobOrderID);
            jobOrderOtherDetailsLoader();
        }
    }
}
