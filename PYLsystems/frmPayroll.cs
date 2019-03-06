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
    public partial class frmPayroll : Form
    {
        private int encoderID;
        frmPayrollListcs pFrmPayrollListcs;
        DataTable dtPayrollCalc;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        private String DateStart;
        internal List<payRollList> InsertEmpPayrollList;
        internal List<payRollList> UpdateEmpPayrollList;
        private String DateEnd;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmPayroll()
        {
            InitializeComponent();
            this.encoderID = 1;
        }
        public frmPayroll(int encoderId, frmPayrollListcs pFrmPayrollListcs)
        {
            InitializeComponent();
            this.encoderID = encoderId;
            this.pFrmPayrollListcs = pFrmPayrollListcs;
            DefaultDatesInitializer();
        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {
            frmPayroll_Loader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        //Validate existence of cash advance. If cash advance exists, then exclude it from the insert list and add it to update list.
        //Get employee SSS Philhealth
        private void frmPayroll_Loader() {
            //int selectedEmpId;
            this.datagridPayrollCalc.DataSource = null;
            this.datagridPayrollCalc.Rows.Clear();
            dtPayrollCalc = new DataTable();
            InsertEmpPayrollList = new List<payRollList>();
            try
            {
                String stringPayrollCalc = "SELECT emp.employeeID, concat(emp.lastname, ', ',emp.firstname) AS 'Employee Name', emp.salaryRate AS 'Hourly Rate', " +
                    "SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) 'AS Total Hours', SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) * emp.salaryRate AS 'Amount' " +
                    "FROM(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) AS attIn " +
                    "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) AS attOut ON(attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date) " +
                    "LEFT JOIN(SELECT employeeID, lastname, firstname, salaryRate from employee) AS emp ON emp.employeeID = attIn.employeeID " +
                    "WHERE attIn.date BETWEEN @DateStart AND @DateEnd GROUP BY emp.employeeID; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPayrollCalc = new MySqlCommand(stringPayrollCalc, my_conn);
                cmdPayrollCalc.Parameters.AddWithValue("@DateStart", DateStart);
                cmdPayrollCalc.Parameters.AddWithValue("@DateEnd", DateEnd);


                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdPayrollCalc);


                my_adapter.Fill(dtPayrollCalc);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            this.datagridPayrollCalc.DataSource = dtPayrollCalc;
            datagridPayrollCalc.Columns["employeeID"].Visible = false;


            this.startDatePicker.Enabled = true;
            this.endDatePicker.Enabled = true;

            insertIntoPayrollList();
        }
        private void insertIntoPayrollList() {
            //MessageBox.Show(Double.Parse(dtPayrollCalc.Rows[1]["Amount"].ToString()).ToString());
            //String concat="";
            for (int i=0;i < dtPayrollCalc.Rows.Count; i++)
            {
                /*int employeeID, int encoderID, String pDateStart, String pDateEnd, double totalAmountReceived*/
                InsertEmpPayrollList.Add(new payRollList(Int32.Parse(dtPayrollCalc.Rows[i]["employeeID"].ToString()), encoderID, DateStart, DateEnd, Double.Parse(dtPayrollCalc.Rows[i]["Amount"].ToString())));
            }
           /* for (int i = 0; i < dtPayrollCalc.Rows.Count; i++) {
                   concat += empPayrollList[i].employeeID.ToString() + " " + empPayrollList[i].encoderID.ToString() + " " + empPayrollList[i].pDateStart.ToString() + " " +
                    empPayrollList[i].pDateEnd.ToString() + " " + empPayrollList[i].totalAmountReceived.ToString() + " " ;
            }*/
            //MessageBox.Show(concat);
        }
        private void insertPayroll() {
            StringBuilder stringAddPayroll = new StringBuilder("INSERT INTO payroll (employeeIDReceiver, employeeIDProvider, payRollStartDate,payRollEndDate,dateReceived,amountReceived) VALUES ");
            using (MySqlConnection my_conn = new MySqlConnection(connString))
            {
                List<string> payRollAdd = new List<string>();
                for (int i = 0; i < InsertEmpPayrollList.Count; i++)
                {
                    payRollAdd.Add(string.Format("('{0}','{1}','{2}','{3}',NOW(),'{4}')",
                    MySqlHelper.EscapeString(InsertEmpPayrollList[i].employeeID.ToString()),
                    MySqlHelper.EscapeString(InsertEmpPayrollList[i].encoderID.ToString()),
                    MySqlHelper.EscapeString(InsertEmpPayrollList[i].pDateStart.ToString()),
                    MySqlHelper.EscapeString(InsertEmpPayrollList[i].pDateEnd.ToString()),
                    MySqlHelper.EscapeString(InsertEmpPayrollList[i].totalAmountReceived.ToString())
                    ));
                }
                stringAddPayroll.Append(string.Join(",", payRollAdd));
                stringAddPayroll.Append(";");
                my_conn.Open();
                using (MySqlCommand cmdAddPayroll = new MySqlCommand(stringAddPayroll.ToString(), my_conn))
                {
                    cmdAddPayroll.CommandType = CommandType.Text;
                    cmdAddPayroll.ExecuteNonQuery();
                }
            }
            pFrmPayrollListcs.employeeListLoader();
        }
        private void DefaultDatesInitializer()
        {
            String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd");
            String DefaultEndDate = DateTime.Today.ToString("yyyy-MM-dd");
            DateStart = DefaultStartDate;
            DateEnd = DefaultEndDate;
            startDatePicker.Value = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).AddHours(0).AddMinutes(0).AddSeconds(0);
            endDatePicker.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            //MessageBox.Show(endDatePicker.Value.ToString());

        }
        private String getDateTimePicker(int startOrEnd)
        {
            String Datetime = "";
            if (startOrEnd == 0)
            {
                Datetime = startDatePicker.Value.ToString("yyyy-MM-dd");
            }
            else if (startOrEnd == 1)
            {
                Datetime = endDatePicker.Value.ToString("yyyy-MM-dd");
            }
            return Datetime;
        }

        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled)
            {
                DateStart = getDateTimePicker(0);
                frmPayroll_Loader();
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled)
            {
                DateEnd = getDateTimePicker(1);
                frmPayroll_Loader();
            }
        }

        private void btnAddPayroll_Click(object sender, EventArgs e)
        {
            insertPayroll();
        }
    }
    //------CLASS FOR LIST--------
    class payRollList
    {
        internal int employeeID { get; set; }
        internal int encoderID { get; set; }
        internal String pDateStart { get; set; }
        internal String pDateEnd { get; set; }
        //internal String dateReceived { get; set; }
        internal double totalAmountReceived { get; set; }
        // public frame_ItemsforList() {
        //}
        public payRollList(int employeeID, int encoderID, String pDateStart, String pDateEnd, double totalAmountReceived)
        {
            this.employeeID = employeeID;
            this.encoderID = encoderID;
            this.pDateStart = pDateStart;
            this.pDateEnd = pDateEnd;
            //this.dateReceived = dateReceived;
            this.totalAmountReceived = totalAmountReceived;
        }

    }
}
