using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class frmSuppliesPrint : Form
    {
        DateTime DateStart;
        DateTime DateEnd;

        DataTable dtSuppliersList;
        DataTable dtStockInList;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        //--------------Initial Load--------------
        //----for programming initializer

        public frmSuppliesPrint()
        {
            InitializeComponent();
        }

        private void frmSuppliesPrint_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            startDatePicker.Enabled = true;
            endDatePicker.Enabled = true;
            suppliersListLoader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void suppliersListLoader()
        {
            try
            {//Show Only jOrd_Num and jobOrderDate
                String stringJobOrdersList =
                    "SELECT supplierID, supplierName AS `Supplier`, supplierDetails AS `Description`,contactDetails AS `Contact Details` FROM supplier where active=0;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdJobOrdersList = new MySqlCommand(stringJobOrdersList, my_conn);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdJobOrdersList);


                dtSuppliersList = new DataTable();
                my_adapter.Fill(dtSuppliersList);
                datagridSuppliersList.DataSource = dtSuppliersList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridSuppliersList.Columns["supplierID"].Visible = false;
        }
        private void generatorData(int supplierID)
        {
            try
            {//Show Only jOrd_Num and jobOrderDate
                String stringPrintSupplyItems =
                    "SELECT sui.supply_itemsID, sd.supplierID, sd.delivery_date AS `Date Delivered`, sui.supplyName AS `Item Name`,sui.supplyDescription AS `Description`,  " +
                    " sd.stockin_quantity AS `Stock In Quantity`, sd.priceRawTotal AS `Unit Purchase Price`, sd.pricePurchaseTotal AS `Total Paid` " +
                    "FROM supply_details AS sd " +
                    "LEFT JOIN supply_items AS sui ON sd.supply_itemsID = sui.supply_itemsID " +
                    "LEFT JOIN supplier AS sup ON sd.supplierID = sup.supplierID " +
                    "LEFT JOIN supplier_items AS supi ON sui.supply_itemsID = supi.supply_itemsID AND sup.supplierID = supi.supplierID " +
                    "WHERE sd.supplierID = @supplierID AND delivery_date BETWEEN @DateStart AND @DateEnd;" ;

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPrintSupplyItems = new MySqlCommand(stringPrintSupplyItems, my_conn);
                cmdPrintSupplyItems.Parameters.AddWithValue("@supplierID", supplierID);
                cmdPrintSupplyItems.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdPrintSupplyItems.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdPrintSupplyItems);


                dtStockInList = new DataTable();
                my_adapter.Fill(dtStockInList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //datagridSuppliersList.DataSource = null;
            //datagridSuppliersList.DataSource = dtStockInList;
        }
        private void generatePrint(String supplierName)
        {
            string pathDoc = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = pathDoc + @"\supplystockin.htm";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            string stringStockInGen = "<html><head><style>table {border-collapse: collapse;} table, th, td {  border: 1px solid black;} th, td { padding: 15px;}</style></head><body>";
            stringStockInGen += "<h3>"+ supplierName +"</h3><hr>";
            stringStockInGen += "<table><tr><th> Delivery Date </th><th> Item Name </th><th> Description </th><th> Stock in Quantity </th><th> Unit Price </th><th> Total Paid </th></tr>";
            if (dtStockInList.Rows.Count > 0)
            {
                double totalPaid=0;
                for (int i = 0; i < dtStockInList.Rows.Count; i++)
                {
                    stringStockInGen += "<tr>"
                        + "<td>" + dtStockInList.Rows[i]["Date Delivered"].ToString() + "</td>"
                        + "<td>" + dtStockInList.Rows[i]["Item Name"].ToString() + "</td>"
                        + "<td>" + dtStockInList.Rows[i]["Description"].ToString() + "</td>"
                        + "<td>" + dtStockInList.Rows[i]["Stock In Quantity"].ToString() + "</td>"
                        + "<td>" + dtStockInList.Rows[i]["Unit Purchase Price"].ToString() + "</td>"
                        + "<td>" + dtStockInList.Rows[i]["Total Paid"].ToString() + "</td></tr>";
                    totalPaid += Double.Parse(dtStockInList.Rows[i]["Total Paid"].ToString());
                    //int rowspanDeductCount = 0;
                    //int[] indiceOfDeduct;
                    //for (int k = 0; k < dtDeductions.Rows.Count; k++)
                    //{
                    //    if (Int32.Parse(dtPayroll.Rows[i]["payrollID"].ToString()) == Int32.Parse(dtDeductions.Rows[k]["payrollID"].ToString()))
                    //    {
                    //        rowspanDeductCount++;
                    //    }
                    //}
                    //indiceOfDeduct = new int[rowspanDeductCount];
                    //int counter = 0;
                    //for (int m = 0; m < dtDeductions.Rows.Count; m++)
                    //{
                    //    if (Int32.Parse(dtPayroll.Rows[i]["payrollID"].ToString()) == Int32.Parse(dtDeductions.Rows[m]["payrollID"].ToString()))
                    //    {
                    //        indiceOfDeduct[counter] = m;
                    //        counter++;
                    //        if (counter == indiceOfDeduct.Length)
                    //        {
                    //            break;
                    //        }
                    //    }
                    //}


                    ////+ "<td>"++"</td>"
                    //stringPayRollReportGen += "<tr>"
                    //    + "<td rowspan='" + rowspanDeductCount + "'>" + dtPayroll.Rows[i]["Employee Name"].ToString() + "</td>"
                    //    + "<td rowspan='" + rowspanDeductCount + "'>" + dtPayroll.Rows[i]["Hourly Rate"].ToString() + "</td>"
                    //    + "<td rowspan='" + rowspanDeductCount + "'>" + dtPayroll.Rows[i]["Total Work Hours"].ToString() + "</td>"
                    //    + "<td rowspan='" + rowspanDeductCount + "'>" + dtPayroll.Rows[i]["Gross Amount"].ToString() + "</td>";
                    //int DeductCounter = 0;
                    //stringPayRollReportGen += "<td>" + dtDeductions.Rows[indiceOfDeduct[DeductCounter]]["typeOfDeduction"].ToString() +
                    //    " - " + dtDeductions.Rows[indiceOfDeduct[DeductCounter]]["Amount"].ToString()
                    //    + "</td>";
                    //DeductCounter++;
                    //stringPayRollReportGen += "<td rowspan='" + rowspanDeductCount + "'>" + dtPayroll.Rows[i]["Net Amount"].ToString() + "</td></tr>";
                    //while (DeductCounter < indiceOfDeduct.Length)
                    //{
                    //    stringPayRollReportGen += "<tr><td>" + dtDeductions.Rows[indiceOfDeduct[DeductCounter]]["typeOfDeduction"].ToString() +
                    //    " - " + dtDeductions.Rows[indiceOfDeduct[DeductCounter]]["Amount"].ToString()
                    //    + "</td></tr>";
                    //    DeductCounter++;
                    //}
                }
                stringStockInGen+= "<tr>"
                        + "<td></td>"
                        + "<td></td>"
                        + "<td></td>"
                        + "<td></td>"
                        + "<td></td>"
                        + "<td><b>" + totalPaid + "</b></td></tr>";
            }
            stringStockInGen += " </table></body></html>";
            //string text = "<br><br><h1>A class</h1> <p>is the most powerful data type in C#.</p><p> Like a structure,</br> " +
            //           "a class defines the <strong>data</strong> and behavior of the data type. </p>";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\Users\Public\WriteText.txt", text);


            System.IO.File.WriteAllText(@filePath, stringStockInGen);
            string urifilePath = new Uri(@filePath).AbsoluteUri;

            //webBrowser1.Url = new Uri(Path.Combine("file://", filePath));
            wBSuppliesStockInReport.Url = new Uri(Path.Combine(urifilePath));
        }
        private void DefaultDatesInitializer()
        {

            DateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddHours(0).AddMinutes(0).AddSeconds(0);
            DateEnd = DateStart.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            startDatePicker.Value = DateStart;
            endDatePicker.Value = DateEnd;
        }
        //----------------Event Methods-----------------
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int currRowIndex = datagridSuppliersList.SelectedRows[0].Index;
            int selectedSupplierID = Int32.Parse(datagridSuppliersList.Rows[currRowIndex].Cells["supplierID"].Value.ToString());
            String selectedSupplierName = datagridSuppliersList.Rows[currRowIndex].Cells["Supplier"].Value.ToString();
            generatorData(selectedSupplierID);
            generatePrint(selectedSupplierName);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            wBSuppliesStockInReport.Print();
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled)
            {
                DateStart = startDatePicker.Value;
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled)
            {
                DateEnd = endDatePicker.Value;
            }
        }
    }
}
