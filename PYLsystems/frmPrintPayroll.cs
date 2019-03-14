using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class frmPrintPayroll : Form
    {
        private int encoderID;
        frmPayrollListcs pFrmPayrollListcs;
        DataTable dtPayroll;
        DataTable dtDeductions;
        //DataTable dtCombine;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        DateTime DateStart;
        DateTime DateEnd;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmPrintPayroll()
        {
            InitializeComponent();
        }

        private void frmPrintPayroll_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();

        }
        //-------------Process and Calculation Methods--------------
        //First time load
        //private void printTableInitialize()
        //{
        //    dtCombine = new DataTable();
        //    dtCombine.Columns.Add("payrollID", typeof(int));
        //    dtCombine.Columns.Add("Employee Name", typeof(String));
        //    dtCombine.Columns.Add("Hourly Rate", typeof(decimal));
        //    dtCombine.Columns.Add("Total Work Hours", typeof(decimal));
        //    dtCombine.Columns.Add("Gross Amount", typeof(decimal));
        //    dtCombine.Columns.Add("Deductions", typeof(decimal));
        //    dtCombine.Columns.Add("Net Amount", typeof(decimal));
        //}
        private void generatePayrollReport()
        {
            // TODO: This line of code loads data into the 'mydbDataSet.item' table. You can move, or remove it, as needed.
            string pathDoc = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);            
            string filePath = pathDoc+ @"\test.htm";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            string stringPayRollReportGen = "<html><head><style>table {border-collapse: collapse;} table, th, td {  border: 1px solid black;}</style></head><body>";
            stringPayRollReportGen += "<table><tr><th> Employee Name </th><th> Hourly Rate </th><th> Total Work Hours </th><th> Gross Amount </th><th> Deductions </th><th> Net Amount </th></tr>";
            if (dtPayroll.Rows.Count > 0)
            {               
                for (int i = 0; i < dtPayroll.Rows.Count; i++)
                {
                    int rowspanDeductCount = 0;
                    for (int k = 0; k<dtDeductions.Rows.Count;k++)
                    {
                        if (Int32.Parse(dtPayroll.Rows[i]["payrollID"].ToString()) == Int32.Parse(dtDeductions.Rows[k]["payrollID"].ToString()))
                        {
                            rowspanDeductCount++;
                        }
                    }
                    //+ "<td>"++"</td>"
                    stringPayRollReportGen += "<tr>" + "<td rowspan='"+rowspanDeductCount+"'>"+ dtPayroll.Rows[i]["Employee Name"].ToString() +"</td>" 
                        + "<td>"+ dtPayroll.Rows[i]["Hourly Rate"].ToString() + "</td>" + "<td>"+ dtPayroll.Rows[i]["Total Work Hours"].ToString() + "</td>"
                        + "<td>" + dtPayroll.Rows[i]["Gross Amount"].ToString() + "</td>"
                        + "</tr>";
                }
            }
            stringPayRollReportGen += " </table></body></html>";
            //string text = "<br><br><h1>A class</h1> <p>is the most powerful data type in C#.</p><p> Like a structure,</br> " +
            //           "a class defines the <strong>data</strong> and behavior of the data type. </p>";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\Users\Public\WriteText.txt", text);
            

            System.IO.File.WriteAllText(@filePath, stringPayRollReportGen);
            string urifilePath = new Uri(@filePath).AbsoluteUri;

            //webBrowser1.Url = new Uri(Path.Combine("file://", filePath));
            wBPayrollReport.Url = new Uri(Path.Combine(urifilePath));
        }
        private void DefaultDatesInitializer()
        {
            if (DateTime.Today.DayOfWeek < DayOfWeek.Saturday)
            {
                DateStart = DateTime.Today.AddDays(-((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 6) % 6);
                DateEnd = DateStart.AddDays(((int)DayOfWeek.Saturday - (int)DateStart.DayOfWeek + 7) % 7);
                startDatePicker.Value = DateStart.AddHours(0).AddMinutes(0).AddSeconds(0);
                endDatePicker.Value = DateEnd.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            else if(DateTime.Today.DayOfWeek == DayOfWeek.Saturday || DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                DayOfWeek day = DateTime.Now.DayOfWeek;
                int days = day - DayOfWeek.Monday;
                DateTime start = DateTime.Now.AddDays(-days);
                DateTime end = start.AddDays(5);

                DateStart = start;
                DateEnd = end;
                startDatePicker.Value = start;
                endDatePicker.Value = end;
            }
            
            //MessageBox.Show(endDatePicker.Value.ToString());
        }
        private void getTables()
        {
            getfromPayroll();
            getDeductions();
        }
        private void getfromPayroll()
        {
            dtPayroll = new DataTable();

            try
            {
                String stringPayrollCalc = "SELECT pay.payrollID, concat(emp.lastname,', ',emp.firstname) AS `Employee Name`, emp.salaryRate as `Hourly Rate`, " +
                    "SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) AS `Total Work Hours`, " +
                    "SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) * emp.salaryRate AS `Gross Amount`, " +
                    "pay.amountReceived AS `Net Amount` " +
                    "FROM employee AS emp " +
                    "LEFT JOIN payroll AS pay ON emp.employeeID = pay.employeeIDReceiver " +
                    "LEFT JOIN(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) AS attIn ON emp.employeeID = attIn.employeeID " +
                    "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) AS attOut ON(attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date) " +
                    "WHERE pay.payRollStartDate = @DateStart AND pay.payRollEndDate = @DateEnd " +
                    "AND attIn.date BETWEEN @DateStart AND @DateEnd " +
                    "GROUP BY `Employee Name` " +
                    "ORDER BY `Employee Name`; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPayrollCalc = new MySqlCommand(stringPayrollCalc, my_conn);
                cmdPayrollCalc.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdPayrollCalc.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdPayrollCalc);


                my_adapter.Fill(dtPayroll);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void getDeductions()
        {
            dtDeductions = new DataTable();
            if (dtPayroll.Rows.Count > 0) { 
                for(int i=0;i<dtPayroll.Rows.Count; i++)
                {
                    try
                    {
                        String stringCashAdvList = "SELECT  ca.cashAdvanceID AS 'origintableID', ca.payrollID, 'Cash Advance' as typeOfDeduction, ca.Amount, concat(empenc.lastname,', ',empenc.firstname) AS 'Encoded by'  " +
                            "FROM cashAdvance AS ca " +
                            "LEFT JOIN employee AS empenc ON ca.employeeIDProvider = empenc.employeeID " +
                            "WHERE ca.payrollID = @payrollID AND ca.active=1 " +
                            "UNION ALL " +
                            "SELECT de.deductionsID AS 'origintableID', de.payrollID, de.typeOfDeduction, de.Amount, concat(empenc.lastname, ', ', empenc.firstname) AS 'Encoded by' " +
                            "FROM deductions AS de " +
                            "LEFT JOIN payroll AS pay ON de.payrollID = pay.payrollID " +
                            "LEFT JOIN employee AS empenc ON pay.employeeIDProvider = empenc.employeeID " +
                            "WHERE de.payrollID = @payrollID; ";

                        MySqlConnection my_conn = new MySqlConnection(connString);
                        MySqlCommand cmdCashAdvList = new MySqlCommand(stringCashAdvList, my_conn);
                        cmdCashAdvList.Parameters.AddWithValue("@payrollID", Int32.Parse(dtPayroll.Rows[i]["payrollID"].ToString()));
                        //cmdEmpList.Parameters.AddWithValue("@DateStart", DateStart);
                        //cmdEmpList.Parameters.AddWithValue("@DateEnd", DateEnd);

                        MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdCashAdvList);


                        my_adapter.Fill(dtDeductions);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }

        }

        //----------------Event Methods-----------------
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getTables();
            generatePayrollReport();
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
