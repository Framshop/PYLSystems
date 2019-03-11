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
        DateTime? selectedTimeIn;
        DateTime? selectedTimeOut;
        private DataTable attendanceDT;
        int selectedEmpID;
        int employeeStatus;
        int employeeID;
        //--------------Initial Load--------------
        //----for programming initializer
        public e_attendance()
        {
            InitializeComponent();
            //DefaultDatesInitializer();
            this.selectedEmpID = 1; //To be removed once connected to employee management subsystem
            this.employeeStatus = 1; //To be removed once connected to employee management subsystem
            this.employeeID = 1;
        }
        public e_attendance(int employeeID, int employeeStatus, int selectedEmpID)
        {
            InitializeComponent();
            DefaultDatesInitializer();
            this.selectedEmpID = selectedEmpID; //To be removed once connected to employee management subsystem
            this.employeeStatus = employeeStatus; //To be removed once connected to employee management subsystem
            this.employeeID = employeeID;
        }
        private void e_attendance_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            attendanceSorter(DateStart, DateEnd);
            enableTimeInOutBtn();
            getEmployeeName();
            getTimeInOutTextBox();

        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void att_gridviewLoader()
        {
            //MessageBox.Show("");
            this.attendanceDT = new DataTable();
            this.attendanceDT.Columns.Add("Day");
            this.attendanceDT.Columns.Add("Date",typeof(DateTime));
            this.attendanceDT.Columns.Add("Time IN");
            this.attendanceDT.Columns.Add("Time OUT");
            this.attendanceDT.Columns.Add("Total Hours");
            this.attendanceGridView.DataSource = this.attendanceDT;
        }
        private void getEmployeeName() {
            String getEmployeeNameString = "SELECT concat(lastName,', ',firstName) AS empName FROM employee WHERE employeeID=@selectedEmpID;";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand getEmployeeName_command = new MySqlCommand(getEmployeeNameString, my_conn);
            getEmployeeName_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(getEmployeeName_command);

            DataTable empname_dt = new DataTable();
            my_adapter.Fill(empname_dt);

            empNameTextBox.Text = empname_dt.Rows[0][0].ToString();

        }
        private void getTimeInOutTextBox() {
            String attendanceViewString = "SELECT attIN.employeeID, DAYNAME(attIn.date), attIn.date, attIn.TimeIn,attOut.TimeOut, " +
             "concat(MOD(HOUR(TIMEDIFF(attIn.TimeIn, attOut.TimeOut)), 24), ' hours ', MINUTE(timediff(attIn.TimeIn, attOut.TimeOut)), ' min ') AS 'Total Hours' " +
             "FROM(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) as attIn " +
             "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) as attOut " +
             "on attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date " +
             "WHERE attIn.employeeID = @selectedEmpID AND attIn.date=CURDATE();";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceView_command = new MySqlCommand(attendanceViewString , my_conn);
            attendanceView_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(attendanceView_command);

            DataTable checkTimeOut = new DataTable();
            my_adapter.Fill(checkTimeOut);
            //MessageBox.Show(checkTimeOut.Rows.Count.ToString());
            if (checkTimeOut.Rows.Count >0) { 
                timeInTextBox.Text = checkTimeOut.Rows[0][3].ToString();
            }
            if (checkTimeOut.Rows.Count > 0 && checkTimeOut.Rows[0][4] != null) { 
                timeOutTextBox.Text = checkTimeOut.Rows[0][4].ToString();
            }
        }
        private void DefaultDatesInitializer()
        {
            String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday).ToString("yyyy-MM-dd");
            String DefaultEndDate = DateTime.Today.ToString("yyyy-MM-dd");
            DateStart = DefaultStartDate;
            DateEnd = DefaultEndDate;
            startDatePicker.Value = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday).AddHours(0).AddMinutes(0).AddSeconds(0);
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
                "concat(MOD(HOUR(TIMEDIFF(attIn.TimeIn, attOut.TimeOut)), 24), ' hours ') AS 'Total Hours' " +
                "FROM(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) as attIn " +
                "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) as attOut " +
                "on attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date " +
                "WHERE attIn.employeeID = @selectedEmpID AND attIn.date BETWEEN @atten_DateStart AND @atten_DateEnd " +
                "ORDER BY attIn.date; ";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceView_command = new MySqlCommand(attendanceViewString, my_conn);
            attendanceView_command.Parameters.AddWithValue("@atten_DateStart", DateStart);
            attendanceView_command.Parameters.AddWithValue("@atten_DateEnd", DateEnd);
            attendanceView_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
            MySqlDataAdapter my_adapter = new MySqlDataAdapter(attendanceView_command);

            DataTable attendanceSQLTable = new DataTable();
            my_adapter.Fill(attendanceSQLTable);
            this.attendanceGridView.DataSource = attendanceSQLTable;

            //DateTime example = (DateTime)attendanceSQLTable.Rows[1]["date"];
            //attendanceDT = new DataTable();
            //att_gridviewLoader();
            //MessageBox.Show(Convert.ToDateTime(DateStart).ToString()+" "+Convert.ToDateTime(DateEnd).ToString());

            foreach (DateTime day in EachDay(Convert.ToDateTime(DateStart), Convert.ToDateTime(DateEnd))) {
                attendanceDT.Rows.Add(day.DayOfWeek,day.Date);
            }

            int rowNumSQL = 0;
            for (int i = 0; i < attendanceDT.Rows.Count; i++) {
                /*if (rowNumSQL > attendanceSQLTable.Rows.Count-1) {
                    break;
                }*/
                //DateTime dateOfAtt=(DateTime)attendanceSQLTable.Rows[rowNumSQL]["date"];
                if (!(rowNumSQL > attendanceSQLTable.Rows.Count - 1) && (DateTime)attendanceDT.Rows[i][1] == Convert.ToDateTime(attendanceSQLTable.Rows[rowNumSQL]["date"]))
                {
                    if (String.IsNullOrEmpty(attendanceSQLTable.Rows[rowNumSQL]["TimeIn"].ToString()))
                    {
                        attendanceDT.Rows[i]["Time IN"] = "N/A";
                        attendanceDT.Rows[i]["Total Hours"] = "N/A";
                    }
                    else {
                        attendanceDT.Rows[i]["Time IN"] = attendanceSQLTable.Rows[rowNumSQL][3].ToString();
                    }
                    if (String.IsNullOrEmpty(attendanceSQLTable.Rows[rowNumSQL]["TimeOut"].ToString()))
                    {
                        attendanceDT.Rows[i]["Time OUT"] = "N/A";
                        attendanceDT.Rows[i]["Total Hours"] = "N/A";
                    }
                    else
                    {
                        attendanceDT.Rows[i]["Time OUT"] = attendanceSQLTable.Rows[rowNumSQL][4].ToString();
                        attendanceDT.Rows[i]["Total Hours"] = attendanceSQLTable.Rows[rowNumSQL][5].ToString();
                    }                    
                    
                    rowNumSQL++;
                }
                else {
                    attendanceDT.Rows[i]["Time IN"] = "N/A";
                    attendanceDT.Rows[i]["Time OUT"] = "N/A";
                    attendanceDT.Rows[i]["Total Hours"] = "N/A";
                }
                //if (attendanceSQLTable.Rows.Count > 0) { 
                //    if (String.IsNullOrEmpty(attendanceSQLTable.Rows[rowNumSQL]["TimeIn"].ToString()))
                //    {
                //        attendanceDT.Rows[i]["Time IN"] = "N/A";
                //        attendanceDT.Rows[i]["Total Hours"] = "N/A";
                //    }
                //    if (String.IsNullOrEmpty(attendanceSQLTable.Rows[rowNumSQL]["TimeOut"].ToString()))
                //    {
                //        attendanceDT.Rows[i]["Time IN"] = "N/A";
                //        attendanceDT.Rows[i]["Total Hours"] = "N/A";
                //    }
                //}
                //MessageBox.Show(rowNumSQL.ToString());
            }
            this.attendanceGridView.DataSource = this.attendanceDT;
            attendanceGridView.Columns["Date"].DefaultCellStyle.Format="yyyy-MM-dd";
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
              "WHERE attIn.employeeID = @selectedEmpID AND attIn.date=CURDATE();";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceView_command = new MySqlCommand(attendanceViewString, my_conn);
            attendanceView_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
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
            if (String.IsNullOrEmpty(checkTimeOut.Rows[0]["TimeIn"].ToString()))
            {
                timeInBtn.Enabled = true;
            }
            else if (String.IsNullOrEmpty(checkTimeOut.Rows[0]["TimeOut"].ToString())) {
                timeOutBtn.Enabled = true;
            }


        }
        private void insertTimeIn() {
            String attendanceTOString = "INSERT INTO attendance (employeeID,date,timeIn) values(@selectedEmpID,NOW(),NOW());";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceTO_command = new MySqlCommand(attendanceTOString, my_conn);
            attendanceTO_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
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
            getTimeInOutTextBox();
        }
        private void insertTimeOut() {
            String attendanceTOString = "INSERT INTO attendance (employeeID,date,timeOut) values(@selectedEmpID,NOW(),NOW());";
            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand attendanceTO_command = new MySqlCommand(attendanceTOString, my_conn);
            attendanceTO_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
            MySqlDataReader dataReader;
            my_conn.Open();
            dataReader = attendanceTO_command.ExecuteReader();
            while (dataReader.Read())
            {
            }
            my_conn.Close();
            timeOutBtn.Enabled = false;
            attendanceSorter(this.DateStart,this.DateEnd);
            getTimeInOutTextBox();
        }
        internal int getAttendanceIDs(String selectedDate, int timeInOrtimeOut) {
            int attendanceID = -1;
            
            //0=timeIn
            //1=timeOut
            if (timeInOrtimeOut == 0) {
                DataTable dtGetAttendanceID = new DataTable();
                selectedTimeIn = null;
                try
                {
                    String stringGetAttendanceID = "SELECT att.AttendanceID,att.employeeID,att.date,att.timeIN " +
                        "FROM attendance AS att " +
                        "WHERE att.employeeID = @employeeID AND att.date = @selectDate AND att.timeOUT IS NULL;";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdGetAttendanceID = new MySqlCommand(stringGetAttendanceID, my_conn);
                    cmdGetAttendanceID.Parameters.AddWithValue("@employeeID", selectedEmpID);
                    cmdGetAttendanceID.Parameters.AddWithValue("@selectDate", selectedDate);

                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdGetAttendanceID);
                    my_adapter.Fill(dtGetAttendanceID);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (dtGetAttendanceID.Rows.Count > 0) {
                    attendanceID = Int32.Parse(dtGetAttendanceID.Rows[0]["AttendanceID"].ToString());
                    if (!String.IsNullOrEmpty(dtGetAttendanceID.Rows[0]["timeIN"].ToString())) { 
                        selectedTimeIn = (DateTime)dtGetAttendanceID.Rows[0]["timeIN"];
                    }
                }
            }
            else if (timeInOrtimeOut == 1) {
                DataTable dtGetAttendanceID = new DataTable();
                selectedTimeOut = null;
                try
                {
                    String stringGetAttendanceID = "SELECT att.AttendanceID,att.employeeID,att.date,att.timeOUT " +
                        "FROM attendance as att " +
                        "WHERE att.employeeID = @employeeID AND att.date = @Date AND att.timeIN IS NULL;";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdGetAttendanceID = new MySqlCommand(stringGetAttendanceID, my_conn);
                    cmdGetAttendanceID.Parameters.AddWithValue("@employeeID", selectedEmpID);
                    cmdGetAttendanceID.Parameters.AddWithValue("@Date", selectedDate);


                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdGetAttendanceID);


                    my_adapter.Fill(dtGetAttendanceID);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (dtGetAttendanceID.Rows.Count > 0)
                {
                    if(dtGetAttendanceID.Rows.Count > 1)
                    { 
                        attendanceID = Int32.Parse(dtGetAttendanceID.Rows[1]["AttendanceID"].ToString());
                    }
                    else
                    {
                        attendanceID = Int32.Parse(dtGetAttendanceID.Rows[0]["AttendanceID"].ToString());
                    }
                    if (!String.IsNullOrEmpty(dtGetAttendanceID.Rows[0]["timeOUT"].ToString()))
                    {
                        selectedTimeOut = (DateTime)dtGetAttendanceID.Rows[0]["timeOUT"];
                    }
                }
            }
            if (String.IsNullOrEmpty(selectedDate)) {
                int currRowIndex = attendanceGridView.SelectedRows[0].Index;
            }
            return attendanceID;
        }
        private void updateAttendance(int attendanceID, int timeInOrtimeOut)
        {
            if (timeInOrtimeOut == 0)
            {
                String stringAttendanceUpdate = "UPDATE attendance AS att " +
                    "SET " +
                        "att.timeIn = NOW() " +
                        "WHERE att.attendanceID = @attendanceId;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdAttendanceUpdate = new MySqlCommand(stringAttendanceUpdate, my_conn);
                cmdAttendanceUpdate.Parameters.AddWithValue("@attendanceId", attendanceID);
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdAttendanceUpdate.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
                timeInBtn.Enabled = false;
                timeOutBtn.Enabled = true;
                attendanceSorter(this.DateStart, this.DateEnd);
                getTimeInOutTextBox();
            }
            else if (timeInOrtimeOut == 1)
            {
                String stringAttendanceUpdate = "UPDATE attendance AS att " +
                "SET " +
                   "att.timeOut = NOW() " +
                   "WHERE att.attendanceID = @attendanceId;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdAttendanceUpdateB = new MySqlCommand(stringAttendanceUpdate, my_conn);
                cmdAttendanceUpdateB.Parameters.AddWithValue("@attendanceId", attendanceID);
                MySqlDataReader dataReaderB;
                my_conn.Open();
                dataReaderB = cmdAttendanceUpdateB.ExecuteReader();
                while (dataReaderB.Read())
                {
                }
                my_conn.Close();
                timeOutBtn.Enabled = false;
                attendanceSorter(this.DateStart, this.DateEnd);
                getTimeInOutTextBox();
            }
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
            DateTime getDateFormat = DateTime.Today;
            int attendanceId_TimeIn = getAttendanceIDs(getDateFormat.ToString("yyyy-MM-dd"), 0);
            if(attendanceId_TimeIn == -1) { 
                insertTimeIn();
            }
            else if(attendanceId_TimeIn > 0)
            {
                updateAttendance(attendanceId_TimeIn,0);
            }
        }

        private void timeOutBtn_Click(object sender, EventArgs e)
        {
            DateTime getDateFormat = DateTime.Today;
            int attendanceId_TimeOut = getAttendanceIDs(getDateFormat.ToString("yyyy-MM-dd"), 1);
            if (attendanceId_TimeOut == -1)
            {
                insertTimeOut();
            }
            else if (attendanceId_TimeOut > 0)
            {
                updateAttendance(attendanceId_TimeOut,1);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int currRowIndex = attendanceGridView.SelectedRows[0].Index;
            DateTime getDateFormat = (DateTime)attendanceGridView.Rows[currRowIndex].Cells["Date"].Value;
            int attendanceId_TimeIn = getAttendanceIDs(getDateFormat.ToString("yyyy-MM-dd"),0);
            int attendanceId_TimeOut = getAttendanceIDs(getDateFormat.ToString("yyyy-MM-dd"), 1);
            //MessageBox.Show(getDateFormat.ToString("yyyy-MM-dd"));
            //MessageBox.Show(attendanceId_TimeIn +" "+ attendanceId_TimeOut);
            //MessageBox.Show(attendanceId_TimeIn + " " + attendanceGridView.Rows[currRowIndex].Cells["Date"].Value.ToString() + " " + selectedTimeIn + " " + selectedTimeOut);
            e_frmEditAttendance editAttendancefrm;
            if (attendanceId_TimeIn == -1 && attendanceId_TimeOut == -1)
            {
                editAttendancefrm = new e_frmEditAttendance(getDateFormat, 0, this.empNameTextBox.Text, selectedEmpID, this);
            }
            else
            {
                editAttendancefrm = new e_frmEditAttendance(getDateFormat, selectedTimeIn, selectedTimeOut, attendanceId_TimeIn, attendanceId_TimeOut, 1, this.empNameTextBox.Text, selectedEmpID, this);
            }
            editAttendancefrm.ShowDialog();
            attendanceSorter(this.DateStart, this.DateEnd);
            getTimeInOutTextBox();
            enableTimeInOutBtn();
        }
    }
}
