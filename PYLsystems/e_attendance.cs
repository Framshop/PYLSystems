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
    public partial class e_attendance : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        String DateStart;
        String DateEnd;
        private DataTable attendanceDT;
        int employeeID;
        int employeeStatus;
        //--------------Initial Load--------------
        //----for programming initializer
        public e_attendance()
        {
            InitializeComponent();
            //DefaultDatesInitializer();
            this.employeeID = 1; //To be removed once connected to employee management subsystem
            this.employeeStatus = 1; //To be removed once connected to employee management subsystem
        }
        public e_attendance(int employeeID, int employeeStatus)
        {
            InitializeComponent();
            DefaultDatesInitializer();
            this.employeeID = employeeID; //To be removed once connected to employee management subsystem
            this.employeeStatus = employeeStatus; //To be removed once connected to employee management subsystem
        }
        private void e_attendance_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            attendanceSorter(DateStart, DateEnd);
            enableTimeInOutBtn();
            getEmployeeName();

        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void att_gridviewLoader()
        {
            //MessageBox.Show("");
            this.attendanceDT = new DataTable();
            this.attendanceDT.Columns.Add("Day");
            this.attendanceDT.Columns.Add("Date");
            this.attendanceDT.Columns.Add("Time IN");
            this.attendanceDT.Columns.Add("Time OUT");
            this.attendanceDT.Columns.Add("Total Hours");
            this.attendanceGridView.DataSource = this.attendanceDT;
        }
        private void getEmployeeName() {
            String getEmployeeNameString = "SELECT concat(lastName,', ',firstName) AS empName FROM employee WHERE employeeID=@employeeID;";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand getEmployeeName_command = new MySqlCommand(getEmployeeNameString, my_conn);
            getEmployeeName_command.Parameters.AddWithValue("@employeeID", this.employeeID);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(getEmployeeName_command);

            DataTable empname_dt = new DataTable();
            my_adapter.Fill(empname_dt);

            empNameTextBox.Text = empname_dt.Rows[0][0].ToString();


        }
        private void DefaultDatesInitializer()
        {
            String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd");
            String DefaultEndDate = DateTime.Today.ToString("yyyy-MM-dd");
            DateStart = DefaultStartDate;
            DateEnd = DefaultEndDate;
            startDatePicker.Value = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).AddHours(0).AddMinutes(0).AddSeconds(0);
            endDatePicker.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            dateNowTextBox.Text = DateTime.Today.ToString("yyyy-MM-dd");
            //MessageBox.Show(endDatePicker.Value.ToString());

        }
        //Attendance sorter
        private void attendanceSorter(String DateStart, String DateEnd) {          
            this.attendanceGridView.DataSource = null;
            this.attendanceGridView.Rows.Clear();
            if(attendanceDT!=null)
                this.attendanceDT.Clear();
            String attendanceViewString = "SELECT attIN.employeeID, DAYNAME(attIn.date), attIn.date, attIn.TimeIn,attOut.TimeOut, " +
                "concat(MOD(HOUR(TIMEDIFF(attIn.TimeIn, attOut.TimeOut)), 24), ' hours ', MINUTE(timediff(attIn.TimeIn, attOut.TimeOut)), ' min ') AS 'Total Hours' " +
                "FROM(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) as attIn " +
                "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) as attOut " +
                "on attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date " +
                "WHERE attIn.employeeID = @employeeID AND attIn.date BETWEEN @atten_DateStart AND @atten_DateEnd; ";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceView_command = new MySqlCommand(attendanceViewString, my_conn);
            attendanceView_command.Parameters.AddWithValue("@atten_DateStart", DateStart);
            attendanceView_command.Parameters.AddWithValue("@atten_DateEnd", DateEnd);
            attendanceView_command.Parameters.AddWithValue("@employeeID", this.employeeID);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(attendanceView_command);

            DataTable attendanceSQLTable = new DataTable();
            my_adapter.Fill(attendanceSQLTable);
            this.attendanceGridView.DataSource = attendanceSQLTable;

            //DateTime example = (DateTime)attendanceSQLTable.Rows[1]["date"];
            //attendanceDT = new DataTable();
            //att_gridviewLoader();
            //MessageBox.Show(Convert.ToDateTime(DateStart).ToString()+" "+Convert.ToDateTime(DateEnd).ToString());

            foreach (DateTime day in EachDay(Convert.ToDateTime(DateStart), Convert.ToDateTime(DateEnd))) {
                attendanceDT.Rows.Add(day.DayOfWeek,day.Date.ToString("yyyy-MM-dd"));
            }

            int rowNumSQL = 0;
            for (int i = 0; i < attendanceDT.Rows.Count; i++) {
                /*if (rowNumSQL > attendanceSQLTable.Rows.Count-1) {
                    break;
                }*/
                //DateTime dateOfAtt=(DateTime)attendanceSQLTable.Rows[rowNumSQL]["date"];
                if (!(rowNumSQL > attendanceSQLTable.Rows.Count - 1) && attendanceDT.Rows[i][1].ToString() == Convert.ToDateTime(attendanceSQLTable.Rows[rowNumSQL]["date"]).ToString("yyyy-MM-dd"))
                {
                    attendanceDT.Rows[i]["Time IN"] = attendanceSQLTable.Rows[rowNumSQL][3].ToString();
                    attendanceDT.Rows[i]["Time OUT"] = attendanceSQLTable.Rows[rowNumSQL][4].ToString();
                    attendanceDT.Rows[i]["Total Hours"] = attendanceSQLTable.Rows[rowNumSQL][5].ToString();
                    rowNumSQL++;
                }
                else {
                    attendanceDT.Rows[i]["Time IN"] = "N/A";
                    attendanceDT.Rows[i]["Time OUT"] = "N/A";
                    attendanceDT.Rows[i]["Total Hours"] = "N/A";
                }
                //MessageBox.Show(rowNumSQL.ToString());
            }
            this.attendanceGridView.DataSource = this.attendanceDT;
        }
        private String getDateTimePicker(int startOrEnd)
        {
            String Datetime = "";
            if (startOrEnd == 0)
            {
                Datetime = startDatePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            }
            else if (startOrEnd == 1)
            {
                Datetime = endDatePicker.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            }
            return Datetime;
        }
        private void enableTimeInOutBtn() {
            String attendanceViewString = "SELECT attIN.employeeID, DAYNAME(attIn.date), attIn.date, attIn.TimeIn,attOut.TimeOut, " +
              "concat(MOD(HOUR(TIMEDIFF(attIn.TimeIn, attOut.TimeOut)), 24), ' hours ', MINUTE(timediff(attIn.TimeIn, attOut.TimeOut)), ' min ') AS 'Total Hours' " +
              "FROM(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) as attIn " +
              "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) as attOut " +
              "on attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date " +
              "WHERE attIn.employeeID = @employeeID AND attIn.date=CURDATE();";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceView_command = new MySqlCommand(attendanceViewString, my_conn);
            attendanceView_command.Parameters.AddWithValue("@employeeID", this.employeeID);
            my_conn.Open();
            MySqlDataReader readCheckRows = attendanceView_command.ExecuteReader();
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(attendanceView_command);

            DataTable checkTimeOut = new DataTable();
            bool checkRowsExist = readCheckRows.Read();
            my_conn.Close();
            my_adapter.Fill(checkTimeOut);
            if (!checkRowsExist)
            {
                timeInBtn.Enabled = true;              
            }           
            else if (checkTimeOut.Rows[0][4].ToString() == "") {
                timeOutBtn.Enabled = true;
            }
        }
        private void insertTimeIn() {
            String attendanceTOString = "INSERT INTO attendance (employeeID,date,timeIn) values(@employeeID,NOW(),NOW());";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceTO_command = new MySqlCommand(attendanceTOString, my_conn);
            attendanceTO_command.Parameters.AddWithValue("@employeeID", this.employeeID);
            MySqlDataReader dataReader;
            my_conn.Open();
            dataReader = attendanceTO_command.ExecuteReader();
            while (dataReader.Read())
            {
            }
            my_conn.Close();
            timeInBtn.Enabled = false;
            timeOutBtn.Enabled = true;
            attendanceSorter(this.DateStart, this.DateEnd);
        }
        private void insertTimeOut() {
            String attendanceTOString = "INSERT INTO attendance (employeeID,date,timeOut) values(@employeeID,NOW(),NOW());";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceTO_command = new MySqlCommand(attendanceTOString, my_conn);
            attendanceTO_command.Parameters.AddWithValue("@employeeID", this.employeeID);
            MySqlDataReader dataReader;
            my_conn.Open();
            dataReader = attendanceTO_command.ExecuteReader();
            while (dataReader.Read())
            {
            }
            my_conn.Close();
            timeOutBtn.Enabled = false;
            attendanceSorter(this.DateStart,this.DateEnd);
        }
        //----------------Special [foreach] statements------------
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

  
        //----------------Event Methods-----------------
        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (attendanceDT == null)
                att_gridviewLoader();
            this.DateStart = getDateTimePicker(0);
            attendanceSorter(this.DateStart,this.DateEnd);
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (attendanceDT == null)
                att_gridviewLoader();
            this.DateEnd = getDateTimePicker(1);
            attendanceSorter(this.DateStart, this.DateEnd);
        }

        private void timeInBtn_Click(object sender, EventArgs e)
        {
            insertTimeIn();
        }

        private void timeOutBtn_Click(object sender, EventArgs e)
        {
            insertTimeOut();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
