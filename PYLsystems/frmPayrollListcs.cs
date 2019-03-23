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
    public partial class frmPayrollListcs : Form
    {
        private int employeeId;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        private String DateStart;
        private String DateEnd;
        DataTable dtEmpList;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmPayrollListcs()
        {
            InitializeComponent();
            this.employeeId = 1;
        }
        public frmPayrollListcs(int employeeId) {
            InitializeComponent();
            this.employeeId = employeeId;

        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmPayrollListcs_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            employeeListLoader();
        }
        internal void employeeListLoader() {
            int selectedEmpId;
            this.datagridEmpList.DataSource = null;
            this.datagridEmpList.Rows.Clear();
            dtEmpList = new DataTable();
            try {
                String stringEmpList = "SELECT employeeID, concat(LastName,', ',firstName) AS 'Employee Name' FROM employee;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdEmpList = new MySqlCommand(stringEmpList, my_conn);
                //salesOrdList_command.Parameters.AddWithValue("@DateStart", DateStart);
                //salesOrdList_command.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdEmpList);

                
                my_adapter.Fill(dtEmpList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (dtEmpList.Rows.Count > 0 ) { 
                this.datagridEmpList.DataSource = dtEmpList;
                datagridEmpList.Columns["employeeID"].Visible = false;
                datagridEmpList.Rows[0].Selected = true;
                int currRowIndex = datagridEmpList.SelectedRows[0].Index;
                selectedEmpId = Int32.Parse(datagridEmpList.Rows[currRowIndex].Cells["employeeID"].Value.ToString());
                payrollDetLoader(selectedEmpId);
            }
            this.startDatePicker.Enabled = true;
            this.endDatePicker.Enabled = true;
        }
        private void payrollDetLoader(int selectedEmpId) {
            this.datagridPayrollDet.DataSource = null;
            this.datagridPayrollDet.Rows.Clear();
            DataTable dtPayrollList = new DataTable();
            try
            {
                String stringPayrollList = "SELECT pr.payrollID,pr.payRollStartDate AS 'Payroll Start Date', pr.payRollEndDate AS 'Payroll End Date', pr.dateReceived AS 'Date Received', " +
                    "pr.amountReceived AS 'Amount Received', pr.nameOfReceiver AS 'Received By', concat(empenc.lastname, ', ', empenc.firstname) AS 'Encoded by' " +
                    "FROM payroll AS pr LEFT JOIN employee AS empenc ON pr.employeeIDProvider = empenc.employeeID " +
                    "WHERE pr.employeeIDReceiver = @employeeID AND pr.payRollStartDate BETWEEN @DateStart AND @DateEnd; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPayrollList = new MySqlCommand(stringPayrollList, my_conn);
                cmdPayrollList.Parameters.AddWithValue("@employeeID", selectedEmpId);
                cmdPayrollList.Parameters.AddWithValue("@DateStart", DateStart);
                cmdPayrollList.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdPayrollList);


                my_adapter.Fill(dtPayrollList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (dtPayrollList.Rows.Count > 0)
            {
                this.datagridPayrollDet.DataSource = dtPayrollList;
                datagridPayrollDet.Columns["payrollID"].Visible = false;
                datagridPayrollDet.Rows[0].Selected = true;
                int currRowIndex = datagridPayrollDet.SelectedRows[0].Index;
                int selectedpayrollId = Int32.Parse(datagridPayrollDet.Rows[currRowIndex].Cells["payrollID"].Value.ToString());
                cashAdvLoader(selectedpayrollId);
                //MessageBox.Show(DateStart+" "+DateEnd);
            }
            else
            {
                //cashAdvLoader();
                this.datagridCashAdv.DataSource = null;
                this.datagridCashAdv.Rows.Clear();
            }
            voidCashAdvButtonEnabler();
        }
        private void cashAdvLoader(int selectedpayrollId) {
            this.datagridCashAdv.DataSource = null;
            this.datagridCashAdv.Rows.Clear();
            DataTable dtCashAdvList = new DataTable();
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
                cmdCashAdvList.Parameters.AddWithValue("@payrollID", selectedpayrollId);
                //cmdEmpList.Parameters.AddWithValue("@DateStart", DateStart);
                //cmdEmpList.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdCashAdvList);

                
                my_adapter.Fill(dtCashAdvList);
                this.datagridCashAdv.DataSource = dtCashAdvList;
                datagridCashAdv.Columns["payrollID"].Visible = false;
                datagridCashAdv.Columns["origintableID"].Visible = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            voidCashAdvButtonEnabler();
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
        private void voidCashAdvButtonEnabler()
        {
            if (datagridCashAdv.Rows.Count > 0)
            {
                int currRowIndex = datagridCashAdv.SelectedRows[0].Index;
                if (String.Equals("Cash Advance", datagridCashAdv.Rows[currRowIndex].Cells["typeOfDeduction"].Value.ToString()))
                {
                    btnVoidCashAdv.Enabled = true;
                    
                }
                else
                {
                    btnVoidCashAdv.Enabled = false;
                }
            }
            else
            {
                btnVoidCashAdv.Enabled = false;
            }
            
        }
        private void voidCashdv()
        {
            int currRowIndex = datagridCashAdv.SelectedRows[0].Index;
            int selectedCashAdvID = Int32.Parse(datagridCashAdv.Rows[currRowIndex].Cells["originTableID"].Value.ToString());
            try
            {
                String stringCashAdvUpdStat = "UPDATE cashadvance AS ca " +
               "SET " +
               "ca.active = 0 " +
               "WHERE ca.cashadvanceID = @cashadvanceID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvUpdStat = new MySqlCommand(stringCashAdvUpdStat, my_conn);
                cmdCashAdvUpdStat.Parameters.AddWithValue("@cashadvanceID", selectedCashAdvID);

                MySqlDataReader dataReader;
                my_conn.Open();
                dataReader = cmdCashAdvUpdStat.ExecuteReader();
                while (dataReader.Read())
                {
                }
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int currRowIndexB = datagridPayrollDet.SelectedRows[0].Index;
            //MessageBox.Show(datagridPayrollDet.Rows[currRowIndex].Cells["payrollID"].ToString());
            int selectedPayrollID = Int32.Parse(datagridPayrollDet.Rows[currRowIndexB].Cells["payrollID"].Value.ToString());
            cashAdvLoader(selectedPayrollID);
        }
        //----------------Event Methods-----------------
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCashAdv_Click(object sender, EventArgs e)
        {
            int currRowIndex = datagridEmpList.SelectedRows[0].Index;
            int selectedEmpId = Int32.Parse(datagridEmpList.Rows[currRowIndex].Cells["employeeID"].Value.ToString());
            frmCashAdvancecs cashAdvForm = new frmCashAdvancecs(this.employeeId,this,selectedEmpId);
            cashAdvForm.ShowDialog();
            employeeListLoader();
        }

        private void btnCreatePayroll_Click(object sender, EventArgs e)
        {
            frmPayroll createPayrollForm = new frmPayroll(this.employeeId,this);
            createPayrollForm.ShowDialog();
        }

        private void datagridEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = datagridEmpList.SelectedRows[0].Index;
            int selectedEmpId = Int32.Parse(dtEmpList.Rows[currRowIndex][0].ToString());
            payrollDetLoader(selectedEmpId);
        }

        private void datagridPayrollDet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = datagridPayrollDet.SelectedRows[0].Index;
            //MessageBox.Show(datagridPayrollDet.Rows[currRowIndex].Cells["payrollID"].ToString());
            int selectedPayrollID = Int32.Parse(datagridPayrollDet.Rows[currRowIndex].Cells["payrollID"].Value.ToString());
            cashAdvLoader(selectedPayrollID);
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled)
            {
                DateStart = getDateTimePicker(0);
                int currRowIndex = datagridEmpList.SelectedRows[0].Index;
                int selectedEmpId = Int32.Parse(dtEmpList.Rows[currRowIndex][0].ToString());
                payrollDetLoader(selectedEmpId);
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled)
            {
                DateEnd = getDateTimePicker(1);
                int currRowIndex = datagridEmpList.SelectedRows[0].Index;
                int selectedEmpId = Int32.Parse(dtEmpList.Rows[currRowIndex][0].ToString());
                payrollDetLoader(selectedEmpId);
            }
        }

        private void datagridCashAdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = datagridCashAdv.SelectedRows[0].Index;

            if (String.Equals("Cash Advance",datagridCashAdv.Rows[currRowIndex].Cells["typeOfDeduction"].Value.ToString())) {               
                //MessageBox.Show(datagridPayrollDet.Rows[currRowIndex].Cells["payrollID"].ToString());
                int selectedCashAdvID = Int32.Parse(datagridCashAdv.Rows[currRowIndex].Cells["originTableID"].Value.ToString());
                frmCashAdvanceDet cashAdvForm = new frmCashAdvanceDet(selectedCashAdvID);
                cashAdvForm.ShowDialog();
                
            }
            
        }

        private void datagridCashAdv_CellClick_ch(object sender, DataGridViewCellEventArgs e)
        {
            voidCashAdvButtonEnabler();
        }

        private void btnVoidCashAdv_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to void Cash Advance?",
                                     "Void Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                voidCashdv();
            }
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {        
            if(datagridPayrollDet.SelectedRows.Count == 1) { 
                int selectedEmpId = Int32.Parse(datagridEmpList.Rows[datagridEmpList.SelectedRows[0].Index].Cells["employeeID"].Value.ToString());
                int selectedPayrollID = Int32.Parse(datagridPayrollDet.Rows[datagridPayrollDet.SelectedRows[0].Index].Cells["payrollID"].Value.ToString());
                String selectedEmpName = datagridEmpList.Rows[datagridEmpList.SelectedRows[0].Index].Cells["Employee Name"].Value.ToString();
                DateTime PDateStart = Convert.ToDateTime(datagridPayrollDet.Rows[datagridPayrollDet.SelectedRows[0].Index].Cells["Payroll Start Date"].Value);
                DateTime PDateEnd = Convert.ToDateTime(datagridPayrollDet.Rows[datagridPayrollDet.SelectedRows[0].Index].Cells["Payroll End Date"].Value);
                double cashAdvanceValue = 0;
                double philHealth = 0;
                double sss = 0;
                int philHealthID = -1;
                int sssID = -1;
                for (int i = 0; i < datagridCashAdv.Rows.Count; i++)
                {
                    if (String.Equals("Cash Advance", datagridCashAdv.Rows[i].Cells["typeOfDeduction"].Value.ToString()))
                    {
                        cashAdvanceValue = Double.Parse(datagridCashAdv.Rows[i].Cells["Amount"].Value.ToString());
                    }
                    if (String.Equals("PhilHealth", datagridCashAdv.Rows[i].Cells["typeOfDeduction"].Value.ToString()))
                    {
                        philHealth = Double.Parse(datagridCashAdv.Rows[i].Cells["Amount"].Value.ToString());
                        philHealthID = Int32.Parse(datagridCashAdv.Rows[i].Cells["origintableID"].Value.ToString());
                    }
                    if (String.Equals("SSS", datagridCashAdv.Rows[i].Cells["typeOfDeduction"].Value.ToString()))
                    {
                        sss = Double.Parse(datagridCashAdv.Rows[i].Cells["Amount"].Value.ToString());
                        sssID = Int32.Parse(datagridCashAdv.Rows[i].Cells["origintableID"].Value.ToString());
                    }
                }             
                frmPayrollEditPay frmPayEdit = new frmPayrollEditPay(employeeId,selectedEmpId,selectedPayrollID,selectedEmpName,
                    PDateStart,PDateEnd,this,cashAdvanceValue,philHealth,sss,philHealthID,sssID);
                frmPayEdit.ShowDialog();
                int currRowIndex = datagridEmpList.SelectedRows[0].Index;
                payrollDetLoader(selectedEmpId);
            }
            else
            {
                MessageBox.Show("Please select a Payroll.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            frmPrintPayroll printForm = new frmPrintPayroll();
            printForm.ShowDialog();
        }
    }
}
