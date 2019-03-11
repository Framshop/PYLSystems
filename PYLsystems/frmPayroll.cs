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
        DataTable dtCashAdvChecker;
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
            dtPayrollDatagrid.Columns.Add("employeeID",typeof(int));
            dtPayrollDatagrid.Columns.Add("Employee Name", typeof(String));
            dtPayrollDatagrid.Columns.Add("Hourly Rate", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Total Hours", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Gross Amount", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Cash Advance", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("PhilHealth", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("SSS", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Net Amount", typeof(decimal));

            InsertEmpPayrollList = new List<payRollList>();
            UpdateEmpPayrollList = new List<payRollList>();
            tempSave = new List<tempSaveRollDet>();
            try
            {
                String stringPayrollCalc = "SELECT emp.employeeID, concat(emp.lastname, ', ',emp.firstname) AS 'Employee Name', emp.salaryRate AS 'Hourly Rate', " +
                    "SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) AS 'Total Hours', SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) * emp.salaryRate AS 'Gross Amount' " +
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            dtPayrollCalc.Merge(dtPayrollDatagrid);
            //MessageBox.Show(dtPayrollCalc.Columns[0].DataType.ToString() + " " + dtPayrollCalc.Columns[1].DataType.ToString()
            //    + " " + dtPayrollCalc.Columns[2].DataType.ToString() + " " + dtPayrollCalc.Columns[3].DataType.ToString()
            //    + " " + dtPayrollCalc.Columns[4].DataType.ToString());
            this.datagridPayrollCalc.DataSource = dtPayrollCalc;
            datagridPayrollCalc.Columns["employeeID"].Visible = false;

            btnEdit.Enabled = false;
            this.startDatePicker.Enabled = true;
            this.endDatePicker.Enabled = true;
            datagridPayrollCalc.Columns["Gross Amount"].DefaultCellStyle.Format = "0.00";
            if (datagridPayrollCalc.Rows.Count > 0)
            {
                //MessageBox.Show(dtPayrollCalc.Rows[0]["employeeID"].ToString());
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
            dtCashAdvChecker = new DataTable();
            try
            {
                String stringCashAdvChecker = "SELECT ca.cashadvanceID, ca.amount, ca.dateReceived, ca.employeeID, emp.lastName, ca.payrollID " +
                    "FROM cashadvance AS ca " +
                    "LEFT JOIN payroll AS pay ON ca.payrollID = pay.payrollID " +
                    "LEFT JOIN employee AS emp ON ca.employeeID = emp.employeeID " +
                    "WHERE pay.payRollStartDate = @DateStart AND pay.payRollEndDate = @DateEnd; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvChecker = new MySqlCommand(stringCashAdvChecker, my_conn);
                cmdCashAdvChecker.Parameters.AddWithValue("@DateStart", DateStart);
                cmdCashAdvChecker.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdCashAdvChecker);
                my_adapter.Fill(dtCashAdvChecker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int kCAcheck = 0;
            if (dtCashAdvChecker.Rows.Count > 0) { 
                for (int i=0;i < dtPayrollCalc.Rows.Count; i++)
                {
                    if (Int32.Parse(dtPayrollCalc.Rows[i]["employeeID"].ToString()) == Int32.Parse(dtCashAdvChecker.Rows[kCAcheck]["employeeID"].ToString()))
                    {
                        UpdateEmpPayrollList.Add(new payRollList(Int32.Parse(dtPayrollCalc.Rows[i]["employeeID"].ToString()), encoderID, DateStart, DateEnd,
                             Double.Parse(dtPayrollCalc.Rows[i]["Gross Amount"].ToString()),
                             Int32.Parse(dtCashAdvChecker.Rows[kCAcheck]["payrollID"].ToString())));
                        datagridPayrollCalc.Rows[i].Cells["Cash Advance"].Value = dtCashAdvChecker.Rows[kCAcheck]["amount"].ToString();
                        kCAcheck++;
                    
                    }
                    else { 
                        InsertEmpPayrollList.Add(new payRollList(Int32.Parse(dtPayrollCalc.Rows[i]["employeeID"].ToString()), encoderID, DateStart, DateEnd,
                             Double.Parse(dtPayrollCalc.Rows[i]["Gross Amount"].ToString())));
                    }
                }
            }
            //MessageBox.Show(dtCashAdvChecker.Rows.Count.ToString()+" " + UpdateEmpPayrollList.Count.ToString()+" "+InsertEmpPayrollList.Count.ToString());
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
        private void addPayroll() {
            if (InsertEmpPayrollList.Count > 0) {
                int[] tempSaveIndice = new int[InsertEmpPayrollList.Count];
                int k = 0;
                //MessageBox.Show(InsertEmpPayrollList.Count.ToString());
                for (int i = 0; i < tempSave.Count; i++)
                {
                    if (tempSave[i].employeeID == InsertEmpPayrollList[k].employeeID)
                    {
                        tempSaveIndice[k] = i;
                        k++;
                        if (k == tempSaveIndice.Length)
                        {
                            break;
                        }
                    }
                }
                StringBuilder stringAddPayroll = new StringBuilder("INSERT INTO payroll (employeeIDReceiver, employeeIDProvider, payRollStartDate,payRollEndDate,dateReceived,amountReceived,nameOfReceiver) VALUES ");
                using (MySqlConnection my_conn = new MySqlConnection(connString))
                {
                    List<string> payRollAdd = new List<string>();
                    for (int i = 0; i < tempSaveIndice.Length; i++)
                    {
                        payRollAdd.Add(string.Format("('{0}','{1}','{2}','{3}',NOW(),'{4}','{5}')",
                        MySqlHelper.EscapeString(tempSave[tempSaveIndice[i]].employeeID.ToString()),
                        MySqlHelper.EscapeString(encoderID.ToString()),
                        MySqlHelper.EscapeString(InsertEmpPayrollList[i].pDateStart.ToString()),
                        MySqlHelper.EscapeString(InsertEmpPayrollList[i].pDateEnd.ToString()),
                        MySqlHelper.EscapeString(tempSave[tempSaveIndice[i]].totalAmountReceived.ToString()),
                        MySqlHelper.EscapeString(tempSave[tempSaveIndice[i]].receiverName.ToString())
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
            }
            if (UpdateEmpPayrollList.Count > 0)
            {
                int[] tempSaveIndice = new int[UpdateEmpPayrollList.Count];
                int k = 0;
                for(int i = 0; i < tempSave.Count;i++)
                {
                    if (tempSave[i].employeeID == UpdateEmpPayrollList[k].employeeID) {
                        tempSaveIndice[k] = i;
                        k++;
                        if (k == tempSaveIndice.Length)
                        {
                            break;
                        }
                    }
                }
                for(int i = 0; i < tempSaveIndice.Length; i++)
                {
                    String payroll_UpdateString = "UPDATE payroll AS pay " +
                        "SET " +
                        "pay.dateReceived = NOW(), " +
                        "pay.amountReceived = @amount, " +
                        "pay.nameOfReceiver = @nameOfReceiver," +
                        "pay.employeeIDProvider = @encoderID " +
                        "WHERE employeeIDReceiver = @employeeID; ";
                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand payroll_Updatecommand = new MySqlCommand(payroll_UpdateString, my_conn);
                    payroll_Updatecommand.Parameters.AddWithValue("@amount", tempSave[tempSaveIndice[i]].totalAmountReceived);
                    payroll_Updatecommand.Parameters.AddWithValue("@nameOfReceiver", tempSave[tempSaveIndice[i]].receiverName);
                    payroll_Updatecommand.Parameters.AddWithValue("@encoderID", encoderID);
                    payroll_Updatecommand.Parameters.AddWithValue("@employeeID", tempSave[tempSaveIndice[i]].employeeID);
                    MySqlDataReader dataReader;
                    my_conn.Open();
                    dataReader = payroll_Updatecommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                    }
                    my_conn.Close();
                }
            }
            insertDeductionsTable();
            pFrmPayrollListcs.employeeListLoader();
        }
        private void insertDeductionsTable() {
            DataTable dtPayrollListID = new DataTable();
            
            try
            {
                String stringPayrollListID = "SELECT pay.payrollID, pay.employeeIDReceiver " +
                    "FROM payroll AS pay " +
                    "WHERE pay.payRollStartDate = @DateStart AND pay.payRollEndDate = @DateEnd; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPayrollListID = new MySqlCommand(stringPayrollListID, my_conn);
                cmdPayrollListID.Parameters.AddWithValue("@DateStart", DateStart);
                cmdPayrollListID.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdPayrollListID);
                my_adapter.Fill(dtPayrollListID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int[] tempSaveIndices = new int[dtPayrollListID.Rows.Count];
            int k = 0;
            for (int i = 0; i < tempSaveIndices.Length; i++) {
                for (int a = 0; a < tempSave.Count; a++) { 
                    if (Int32.Parse(dtPayrollListID.Rows[i]["employeeIDReceiver"].ToString()) == tempSave[a].employeeID) {
                        tempSaveIndices[k] = a;
                        k++;
                    }
                }
                if (k == tempSaveIndices.Length)
                {
                    break;
                }
            }

            if (dtPayrollListID.Rows.Count > 0) {
                StringBuilder stringAddPayroll = new StringBuilder("INSERT INTO deductions (payrollID,typeOfDeduction,amount) VALUES ");
                using (MySqlConnection my_conn = new MySqlConnection(connString))
                {
                    List<string> payRollAdd = new List<string>();
                    for (int i = 0; i < dtPayrollListID.Rows.Count; i++)
                    {
                        payRollAdd.Add(string.Format("('{0}','PhilHealth','{1}'),('{2}','SSS','{3}')",
                        MySqlHelper.EscapeString(dtPayrollListID.Rows[i]["payrollID"].ToString()),
                        MySqlHelper.EscapeString(tempSave[tempSaveIndices[i]].philHealth.ToString()),
                        MySqlHelper.EscapeString(dtPayrollListID.Rows[i]["payrollID"].ToString()),
                        MySqlHelper.EscapeString(tempSave[tempSaveIndices[i]].sss.ToString())
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
            }
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
        private bool insertPhilHealthSSSValidation() {
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
            String concat = "Please add SSS and Philhealth values to the following Employees: \n";
            if (!validForms)
            {
                for (int i = 0; i < nameListInvalid.Length; i++)
                {
                    if (!String.IsNullOrEmpty(nameListInvalid[i]))
                    {
                        concat += "> " + nameListInvalid[i] + "\n";
                    }
                }
                MessageBox.Show(concat);
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
                tempSave[indexTempSaveList].philHealth = Double.Parse(txtBoxPhilhealth.Text.ToString()) ;
                tempSave[indexTempSaveList].sss = Double.Parse(txtBoxSSS.Text.ToString());
                tempSave[indexTempSaveList].receiverName = txtBoxReceiver.Text.ToString();
                tempSave[indexTempSaveList].totalAmountReceived = Double.Parse(txtBoxAmount.Text.ToString());
                datagridPayrollCalc.Rows[indexTempSaveList].Cells["PhilHealth"].Value = Double.Parse(txtBoxPhilhealth.Text.ToString());
                datagridPayrollCalc.Rows[indexTempSaveList].Cells["SSS"].Value = Double.Parse(txtBoxSSS.Text.ToString());
                datagridPayrollCalc.Rows[indexTempSaveList].Cells["Net Amount"].Value = Double.Parse(txtBoxAmount.Text.ToString());
                txtBoxSSS.ReadOnly = true;
                txtBoxPhilhealth.ReadOnly = true;
                txtBoxReceiver.ReadOnly = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                MessageBox.Show("Saved!");
            }
        }
        private void totalAmountSolver() {
            double valPhilHealth;
            double valSss;
            double valcashAdv; //temporary value
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
            if (String.IsNullOrEmpty(txtBoxCashAdv.Text.ToString()))
            {
                valcashAdv = 0;
            }
            else
            {
                valcashAdv = Double.Parse(txtBoxCashAdv.Text.ToString());
            }
            if (indexInsertPayrollList >= 0) {
                tempTotalAmount = InsertEmpPayrollList[indexInsertPayrollList].grossTotal;
                totalAmount = tempTotalAmount - (valPhilHealth + valSss);
            }
            else if (indexUpdatePayrollList >= 0) {
                tempTotalAmount = UpdateEmpPayrollList[indexUpdatePayrollList].grossTotal;
                totalAmount = tempTotalAmount - (valPhilHealth + valSss + valcashAdv);
            }
            txtBoxAmount.Text = totalAmount.ToString();
            //MessageBox.Show(txtBoxCashAdv.Text.ToString());

        }
        private bool validateDates()
        {
            int invalidForms = 0;
            DateTime Start = startDatePicker.Value.Date.Add(new TimeSpan(0, 0, 0));
            DateTime End = endDatePicker.Value.Date.Add(new TimeSpan(23,59,59));
            int totalDays = (int)Math.Round((End - Start).TotalDays);
            //MessageBox.Show(totalDays.ToString());
            if (totalDays < 6 || totalDays > 6) {
                MessageBox.Show("Payroll should be 6 days");
                invalidForms++;
            }
            if (Start.DayOfWeek != DayOfWeek.Monday || End.DayOfWeek != DayOfWeek.Saturday)
            {
                MessageBox.Show("Payroll Start date should be on a Monday and Payroll End date should be on a Saturday");
                invalidForms++;
            }
            DataTable checkIfAmountsExist = new DataTable();
            try
            {
                String stringCheckExistPayroll = "SELECT pay.payrollID,pay.employeeIDReceiver,pay.employeeIDProvider,pay.payRollStartDate," +
                    "pay.payRollEndDate,pay.dateReceived,pay.amountReceived " +
                    "FROM payroll as pay " +
                    "WHERE pay.payRollStartDate = @DateStart AND pay.payRollEndDate = @DateEnd; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCheckExistPayroll = new MySqlCommand(stringCheckExistPayroll, my_conn);
                cmdCheckExistPayroll.Parameters.AddWithValue("@DateStart", DateStart);
                cmdCheckExistPayroll.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdCheckExistPayroll);
                my_adapter.Fill(checkIfAmountsExist);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int nullAccs = 0;
            int notnullAccs = 0;
            if(checkIfAmountsExist.Rows.Count > 0) { 
                for (int i = 0; i<checkIfAmountsExist.Rows.Count;i++) {
                    if (!String.IsNullOrEmpty(checkIfAmountsExist.Rows[i]["amountReceived"].ToString()))
                    {
                        notnullAccs++;
                    
                    }
                    else {
                        nullAccs++;
                    }
                }
            }
            if (notnullAccs > 0)
            {
                invalidForms++;
                MessageBox.Show("Payroll already exists. Please select different payroll dates.");
            }

            if (datagridPayrollCalc.Rows.Count == 0)
            {
                MessageBox.Show("No employees to add payroll to.");
                invalidForms++;
            }
            //Number of invalidforms to be satisfied
            if (invalidForms > 0) {
                return false;
            }
            else {
                return true;
            }
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

            bool PhilHealthSSSValidate = insertPhilHealthSSSValidation();
            bool dateValidate = validateDates();

            if (!PhilHealthSSSValidate)
            {
                return;
            }
            if (!dateValidate)
            {
                return;
            }

            if (PhilHealthSSSValidate && dateValidate)
            {
                addPayroll();
                MessageBox.Show("Payroll Added.");
                this.Close();
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
                this.txtBoxAmount.Text = tempSave[currRowIndex].totalAmountReceived.ToString("0.00");
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                int selectedEmpID = Int32.Parse(datagridPayrollCalc.Rows[currRowIndex].Cells["employeeID"].Value.ToString());
                Double valCashAdv = 0;
                for (int i = 0; i < dtCashAdvChecker.Rows.Count; i++)
                {
                    if (Int32.Parse(dtCashAdvChecker.Rows[i]["employeeID"].ToString()) == selectedEmpID)
                    {
                        valCashAdv = Double.Parse(dtCashAdvChecker.Rows[i]["amount"].ToString());
                        txtBoxCashAdv.Text = valCashAdv.ToString();
                        return;
                    }
                    else
                    {
                        txtBoxCashAdv.Text = null;
                    }
                }

            }
            else {
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                this.txtBoxPhilhealth.ReadOnly = false;
                this.txtBoxSSS.ReadOnly = false;
                this.txtBoxReceiver.ReadOnly = false;
                this.txtBoxPhilhealth.Text = null;
                this.txtBoxSSS.Text = null;
                this.txtBoxReceiver.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Employee Name"].Value.ToString();
                //totalAmountSolver();
                int selectedEmpID = Int32.Parse(datagridPayrollCalc.Rows[currRowIndex].Cells["employeeID"].Value.ToString());
                Double valCashAdv = 0;
                for (int i = 0; i < dtCashAdvChecker.Rows.Count; i++)
                {
                    if (Int32.Parse(dtCashAdvChecker.Rows[i]["employeeID"].ToString()) == selectedEmpID)
                    {
                        valCashAdv = Double.Parse(dtCashAdvChecker.Rows[i]["amount"].ToString());
                        txtBoxCashAdv.Text = valCashAdv.ToString();
                        totalAmountSolver();
                        return;
                    }
                    else
                    {
                        txtBoxCashAdv.Text = null;
                    }
                }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtBoxPhilhealth.ReadOnly = false;
            txtBoxSSS.ReadOnly = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
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
        internal int payrollID { get; set; }
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
        public payRollList(int employeeID, int encoderID, String pDateStart, String pDateEnd, double grossTotal, int payrollID)
        {
            this.employeeID = employeeID;
            this.encoderID = encoderID;
            this.pDateStart = pDateStart;
            this.pDateEnd = pDateEnd;
            //this.dateReceived = dateReceived;
            this.grossTotal = grossTotal;
            this.payrollID = payrollID;

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
