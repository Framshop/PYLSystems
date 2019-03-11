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
    public partial class e_frmEditAttendance : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        int attendanceID_timeIn;
        int attendanceID_timeOut;
        int selectedEmpID;
        DateTime selectedDate;
        DateTime? selectedTimeIn;
        DateTime? selectedTimeOut;
        String employeeName;

        int existingAttendance; //0-Doesn't exist, Use Insert 1-Exist||1-Exists, Use Update
        e_attendance pForm_e_Attendance;


        //--------------Initial Load--------------
        //----for programming initializer
        public e_frmEditAttendance()
        {
            InitializeComponent();
        }
        public e_frmEditAttendance(DateTime selectedDate, int existingAttendance, String employeeName, int selectedEmpID, e_attendance pForm_e_Attendance)
        {
            InitializeComponent();
            this.pForm_e_Attendance = pForm_e_Attendance;
            this.existingAttendance = existingAttendance;
            this.selectedDate = selectedDate;
            this.employeeName = employeeName;
            this.selectedEmpID = selectedEmpID;
        }
        public e_frmEditAttendance(DateTime selectedDate, DateTime? selectedTimeIn, DateTime? selectedTimeOut, int attendanceID_timeIn, int attendanceID_timeOut,
            int existingAttendance, String employeeName, int selectedEmpID, e_attendance pForm_e_Attendance)
        {
            InitializeComponent();
            this.pForm_e_Attendance = pForm_e_Attendance;
            this.selectedDate = selectedDate;
            this.attendanceID_timeIn = attendanceID_timeIn;
            this.attendanceID_timeOut = attendanceID_timeOut;
            this.existingAttendance = existingAttendance;
            this.selectedTimeIn = selectedTimeIn;
            this.selectedTimeOut = selectedTimeOut;
            this.employeeName = employeeName;
            this.selectedEmpID = selectedEmpID;
        }
        
        private void e_frmEditAttendance_Load(object sender, EventArgs e)
        {
            e_frmEditAttendance_Loader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void e_frmEditAttendance_Loader()
        {
            txtBoxEmpName.Text = employeeName;
            if (existingAttendance == 0 || (selectedTimeIn==null && selectedTimeOut==null))
            {
                DatePickerAtt.Value = selectedDate;
            }
            else if (existingAttendance == 1)
            {
                DatePickerAtt.Value = selectedDate;
                if (selectedTimeIn!=null)
                    startTimePicker.Value = Convert.ToDateTime(selectedTimeIn);
                if (selectedTimeOut!=null)
                    endTimePicker.Value = Convert.ToDateTime(selectedTimeOut);

                checkBEmpAbsent.Checked = false;
            }
        }
        //0-timeIn, 1-timeOut
        private void insertAttendance(int timeInOrtimeOut)
        {
            if (timeInOrtimeOut == 0)
            {
                String attendanceTOString = "INSERT INTO attendance (employeeID,date,timeIn) values(@selectedEmpID,@selectedDate,@timeIn);";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand attendanceTO_command = new MySqlCommand(attendanceTOString, my_conn);
                attendanceTO_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
                attendanceTO_command.Parameters.AddWithValue("@selectedDate", this.selectedDate.ToString("yyyy-MM-dd"));
                attendanceTO_command.Parameters.AddWithValue("@timeIn", this.selectedDate.ToString("yyyy-MM-dd")+" "+this.startTimePicker.Value.ToString("HH:mm:ss"));
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = attendanceTO_command.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
            else if (timeInOrtimeOut == 1)
            {
                String attendanceTOString = "INSERT INTO attendance (employeeID,date,timeOut) values(@selectedEmpID,@selectedDate,@timeOut);";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand attendanceTO_command = new MySqlCommand(attendanceTOString, my_conn);
                attendanceTO_command.Parameters.AddWithValue("@selectedEmpID", this.selectedEmpID);
                attendanceTO_command.Parameters.AddWithValue("@selectedDate", this.selectedDate.ToString("yyyy-MM-dd"));
                attendanceTO_command.Parameters.AddWithValue("@timeOut", this.selectedDate.ToString("yyyy-MM-dd") + " " + this.endTimePicker.Value.ToString("HH:mm:ss"));
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = attendanceTO_command.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
           
        }
        private void updateAttendance(int attendanceID, int timeInOrtimeOut)
        {
            if (timeInOrtimeOut == 0)
            {
                String stringAttendanceUpdate = "UPDATE attendance AS att " +
                    "SET " +
                        "att.timeIn = @timeIn " +
                        "WHERE att.attendanceID = @attendanceId;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdAttendanceUpdate = new MySqlCommand(stringAttendanceUpdate, my_conn);
                cmdAttendanceUpdate.Parameters.AddWithValue("@timeIn", this.selectedDate.ToString("yyyy-MM-dd") + " " + this.startTimePicker.Value.ToString("HH:mm:ss"));
                cmdAttendanceUpdate.Parameters.AddWithValue("@attendanceId", attendanceID_timeIn);
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdAttendanceUpdate.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
            else if (timeInOrtimeOut == 1)
            {
                String stringAttendanceUpdate = "UPDATE attendance AS att " +
                "SET " +
                   "att.timeOut = @timeOut " +
                   "WHERE att.attendanceID = @attendanceId;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdAttendanceUpdateB = new MySqlCommand(stringAttendanceUpdate, my_conn);
                cmdAttendanceUpdateB.Parameters.AddWithValue("@timeOut", this.selectedDate.ToString("yyyy-MM-dd") + " " + this.endTimePicker.Value.ToString("HH:mm:ss"));
                cmdAttendanceUpdateB.Parameters.AddWithValue("@attendanceId", attendanceID_timeOut);
                MySqlDataReader dataReaderB;
                my_conn.Open();
                dataReaderB = cmdAttendanceUpdateB.ExecuteReader();
                while (dataReaderB.Read())
                {
                }
                my_conn.Close();
            }
        }
        //Others
        
        private void absentSave()
        {
            if (existingAttendance == 0)
            {
                return;
            }
            else if (existingAttendance == 1)
            {
                String stringAttendanceUpdate = "UPDATE attendance AS att " +
                    "SET " +
                        "att.timeIn = null " +
                        "WHERE att.attendanceID = @attendanceId;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdAttendanceUpdate = new MySqlCommand(stringAttendanceUpdate, my_conn);
                cmdAttendanceUpdate.Parameters.AddWithValue("@attendanceId", attendanceID_timeIn);
                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdAttendanceUpdate.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();

                stringAttendanceUpdate = "UPDATE attendance AS att " +
                   "SET " +
                       "att.timeOut = null " +
                       "WHERE att.attendanceID = @attendanceId;";
                MySqlCommand cmdAttendanceUpdateB = new MySqlCommand(stringAttendanceUpdate, my_conn);
                cmdAttendanceUpdateB.Parameters.AddWithValue("@attendanceId", attendanceID_timeOut);
                MySqlDataReader dataReaderB;
                my_conn.Open();
                dataReaderB = cmdAttendanceUpdateB.ExecuteReader();
                while (dataReaderB.Read())
                {
                }
                my_conn.Close();

            }

        }
        private void editAttendanceSave() {
            if (attendanceID_timeIn > 0)
            {
                updateAttendance(attendanceID_timeIn,0);
            }
            else
            {
                insertAttendance(0);
            }
            if (attendanceID_timeOut > 0)
            {
                updateAttendance(attendanceID_timeOut,1);
            }
            else
            {
                insertAttendance(1);
            }
        }
        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBEmpAbsent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBEmpAbsent.Checked) {
                startTimePicker.Enabled = false;
                endTimePicker.Enabled = false;
                
            }
            else {
                startTimePicker.Enabled = true;
                endTimePicker.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkBEmpAbsent.Checked) {
                absentSave();
                this.Close();
            }
            else {
                editAttendanceSave();
                this.Close();
            }
        }

        private void DatePickerAtt_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DatePickerAtt.Value;
            this.attendanceID_timeIn = pForm_e_Attendance.getAttendanceIDs(selectedDate.ToString("yyyy-MM-dd"), 0);
            this.attendanceID_timeOut = pForm_e_Attendance.getAttendanceIDs(selectedDate.ToString("yyyy-MM-dd"), 1);
        }
    }
}
