using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class frmPayroll : Form
    {
        private int encoderID;
        frmPayrollListcs pFrmPayrollListcs;
        DataTable dtPayrollCalc;
        DataTable dtPayrollDatagrid;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        private String DateStart;
        internal List<payRollList> InsertEmpPayrollList;
        internal List<payRollList> UpdateEmpPayrollList;
        internal List<tempSaveRollDet> tempSave;
        private String DateEnd;
        private String[] nameListInvalid;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmPayroll()
        {
            InitializeComponent();
            this.encoderID = 1;
            DefaultDatesInitializer();
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
        private void frmPayroll_Loader() {
            //int selectedEmpId;
            this.datagridPayrollCalc.DataSource = null;
            this.datagridPayrollCalc.Rows.Clear();
            dtPayrollCalc = new DataTable();
            dtPayrollDatagrid = new DataTable();
            dtPayrollDatagrid.Columns.Add("employeeID");
            dtPayrollDatagrid.Columns.Add("Employee Name");
            dtPayrollDatagrid.Columns.Add("Hourly Rate");
            dtPayrollDatagrid.Columns.Add("Gross Amount");
            dtPayrollDatagrid.Columns.Add("Cash Advance");
            dtPayrollDatagrid.Columns.Add("PhilHealth");
            dtPayrollDatagrid.Columns.Add("SSS");
            dtPayrollDatagrid.Columns.Add("Net Amount");

            InsertEmpPayrollList = new List<payRollList>();
            UpdateEmpPayrollList = new List<payRollList>();
            tempSave = new List<tempSaveRollDet>();
            try
            {
                String stringPayrollCalc = "SELECT emp.employeeID, concat(emp.lastname, ', ',emp.firstname) AS 'Employee Name', emp.salaryRate AS 'Hourly Rate', " +
                    "SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) 'AS Total Hours', SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) * emp.salaryRate AS 'Gross Amount' " +
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
            datagridPayrollCalc.Columns["Gross Amount"].DefaultCellStyle.Format = "0.00";
            if (datagridPayrollCalc.Rows.Count > 0) {
                datagridPayrollCalc.Rows[0].Selected = true;
                int currRowIndex = datagridPayrollCalc.SelectedRows[0].Index;
                this.txtBoxEmployeeName.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Employee Name"].Value.ToString();
                this.txtBoxAmount.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Gross Amount"].Value.ToString();
                this.txtBoxReceiver.Text = txtBoxEmployeeName.Text;
            }
            
            insertIntoPayrollList();
            insertIntotempSave();
        }
        private void insertIntoPayrollList() {
            //MessageBox.Show(Double.Parse(dtPayrollCalc.Rows[1]["Gross Amount"].ToString()).ToString());
            //String concat="";
            for (int i=0;i < dtPayrollCalc.Rows.Count; i++)
            {
                InsertEmpPayrollList.Add(new payRollList(Int32.Parse(dtPayrollCalc.Rows[i]["employeeID"].ToString()), encoderID, DateStart, DateEnd,
                    Double.Parse(dtPayrollCalc.Rows[i]["Gross Amount"].ToString())));
            }
        }
        private void insertIntotempSave()
        {
            //MessageBox.Show(Double.Parse(dtPayrollCalc.Rows[1]["Gross Amount"].ToString()).ToString());
            //String concat="";
            for (int i = 0; i < dtPayrollCalc.Rows.Count; i++)
            {
                tempSave.Add(new tempSaveRollDet(Int32.Parse(dtPayrollCalc.Rows[i]["employeeID"].ToString()), dtPayrollCalc.Rows[i]["Employee Name"].ToString(), -1, -1, "", Double.Parse(dtPayrollCalc.Rows[i]["Gross Amount"].ToString())));
            }
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
                    MySqlHelper.EscapeString(tempSave[i].totalAmountReceived.ToString())
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
            DateTime saturdayDate;
            if (DateTime.Today.DayOfWeek != DayOfWeek.Saturday) {
                saturdayDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 1);
            }
            else
            {
                saturdayDate = DateTime.Today;
            }
            String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd");
            String DefaultEndDate = saturdayDate.ToString("yyyy-MM-dd");
            DateStart = DefaultStartDate;
            DateEnd = DefaultEndDate;
            startDatePicker.Value = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).AddHours(0).AddMinutes(0).AddSeconds(0);
            endDatePicker.Value = saturdayDate.AddHours(23).AddMinutes(59).AddSeconds(59);
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
        private bool insertValidation() {
            bool validForms = false;
            nameListInvalid = new String[tempSave.Count];
            int numListInvalid = 0;
            for (int i=0;i<tempSave.Count;i++) {
                if (tempSave[i].philHealth < 0 || tempSave[i].sss < 0) {
                    nameListInvalid[i] = tempSave[i].employeeName;
                    numListInvalid++;
                }
            }
            if (numListInvalid > 0)
            {
                validForms = false;
            }
            else {
                validForms = true;
            }
            return validForms;
        }
        private void saveTempSave() {
            int dataGridSelectedIndex = datagridPayrollCalc.SelectedRows[0].Index;
            int employeeId = Int32.Parse(datagridPayrollCalc.Rows[dataGridSelectedIndex].Cells["employeeID"].Value.ToString());
            int indexTempSaveList=-1;
            if (txtBoxPhilhealth.Text == null || txtBoxPhilhealth.Text == "" ||
                txtBoxSSS.Text == null || txtBoxSSS.Text == "") {
                MessageBox.Show("Please type in PhilHealth and SSS values");
                return;
            }
            for (int i = 0; i < tempSave.Count; i++) {
                if (tempSave[i].employeeID == employeeId) {
                    indexTempSaveList = i;
                }
            }           
            if (indexTempSaveList >= 0) {
                tempSave[indexTempSaveList].philHealth = Double.Parse(txtBoxPhilhealth.Text.ToString());
                tempSave[indexTempSaveList].sss = Double.Parse(txtBoxSSS.Text.ToString());
                tempSave[indexTempSaveList].receiverName = txtBoxReceiver.Text.ToString();
                txtBoxSSS.ReadOnly = true;
                txtBoxPhilhealth.ReadOnly = true;
                txtBoxReceiver.ReadOnly = true;
                MessageBox.Show("Saved!");
            }
        }
        private void totalAmountSolver() {
            double valPhilHealth;
            double valSss;
            double valcashAdv=0; //temporary value
            double tempTotalAmount;
            double totalAmount = 0;
            int dataGridSelectedIndex = datagridPayrollCalc.SelectedRows[0].Index;
            int employeeId = Int32.Parse(datagridPayrollCalc.Rows[dataGridSelectedIndex].Cells["employeeID"].Value.ToString());
            int indexInsertPayrollList = -1;
            int indexUpdatePayrollList = -1;
            for (int i = 0; i < InsertEmpPayrollList.Count; i++)
            {
                if (InsertEmpPayrollList[i].employeeID == employeeId)
                {
                    indexInsertPayrollList = i;
                }
            }
            for (int i = 0;i < UpdateEmpPayrollList.Count; i++)
            {
                if (UpdateEmpPayrollList[i].employeeID == employeeId)
                {
                    indexUpdatePayrollList = i;
                }
            }
            if (String.IsNullOrEmpty(txtBoxPhilhealth.Text.ToString()))
            {
                valPhilHealth = 0;
            }
            else {
                valPhilHealth = Double.Parse(txtBoxPhilhealth.Text.ToString());
            }
            if (String.IsNullOrEmpty(txtBoxSSS.Text.ToString()))
            {
                valSss = 0;
            }
            else {
                valSss = Double.Parse(txtBoxSSS.Text.ToString());
            }
            if (indexInsertPayrollList >= 0) {
                tempTotalAmount = InsertEmpPayrollList[indexInsertPayrollList].grossTotal;
                totalAmount = tempTotalAmount - (valPhilHealth + valSss);
            }
            else if (indexUpdatePayrollList >= 0) {
                tempTotalAmount = UpdateEmpPayrollList[indexInsertPayrollList].grossTotal;
                totalAmount = tempTotalAmount - (valPhilHealth + valSss + valcashAdv);
            }
            txtBoxAmount.Text = totalAmount.ToString();

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
            bool insertValidate = insertValidation();
            MessageBox.Show(insertValidate.ToString());
            String concat = "Please add SSS and Philhealth values to the following Employees: \n";
            if (!insertValidate) {
                for(int i=0; i < nameListInvalid.Length; i++) {
                    if(!String.IsNullOrEmpty(nameListInvalid[i])) { 
                         concat += "> "+ nameListInvalid[i] + "\n";
                    }
                }
                MessageBox.Show(concat);
            }
        }

        private void datagridPayrollCalc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = datagridPayrollCalc.SelectedRows[0].Index;
            this.txtBoxEmployeeName.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Employee Name"].Value.ToString();
            this.txtBoxAmount.Text = tempSave[currRowIndex].totalAmountReceived.ToString("0.00");
            if (tempSave[currRowIndex].philHealth >= 0 && tempSave[currRowIndex].sss >= 0)
            {
                this.txtBoxPhilhealth.ReadOnly = true;
                this.txtBoxSSS.ReadOnly = true;
                this.txtBoxReceiver.ReadOnly = true;
                this.txtBoxPhilhealth.Text = tempSave[currRowIndex].philHealth.ToString();
                this.txtBoxSSS.Text = tempSave[currRowIndex].sss.ToString();
                this.txtBoxReceiver.Text = tempSave[currRowIndex].receiverName.ToString();
            }
            else {
                this.txtBoxPhilhealth.ReadOnly = false;
                this.txtBoxSSS.ReadOnly = false;
                this.txtBoxReceiver.ReadOnly = false;
                this.txtBoxPhilhealth.Text = null;
                this.txtBoxSSS.Text = null;
                this.txtBoxReceiver.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Employee Name"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveTempSave();
        }

        private void txtBoxPhilhealth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxSSS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxPhilhealth_TextChanged(object sender, EventArgs e)
        {
            totalAmountSolver();
        }

        private void txtBoxSSS_TextChanged(object sender, EventArgs e)
        {
            totalAmountSolver();
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
        internal double grossTotal { get; set; }
        // public frame_ItemsforList() {
        //}
        public payRollList(int employeeID, int encoderID, String pDateStart, String pDateEnd, double grossTotal)
        {
            this.employeeID = employeeID;
            this.encoderID = encoderID;
            this.pDateStart = pDateStart;
            this.pDateEnd = pDateEnd;
            //this.dateReceived = dateReceived;
            this.grossTotal = grossTotal;

        }

    }
    class tempSaveRollDet
    {
        internal int employeeID { get; set; }
        internal String employeeName { get; set; }
        internal double philHealth { get; set; }
        internal double sss { get; set; }
        internal String receiverName { get; set; }
        internal double totalAmountReceived { get; set; }
        // public frame_ItemsforList() {
        //}
        public tempSaveRollDet(int employeeID, String employeeName, double philHealth, double sss, String receiverName, double totalAmountReceived)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.philHealth = philHealth;
            this.sss = sss;
            this.receiverName = receiverName;
            this.totalAmountReceived = totalAmountReceived;
        }

    }
}
