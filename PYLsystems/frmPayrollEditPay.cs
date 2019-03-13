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

namespace PYLsystems
{
    public partial class frmPayrollEditPay : Form
    {
        private int encoderID;
        private int selectedEmpID;
        private int selectedPayrollID;
        private int philHealthID;
        private int sssID;
        private String selectedEmpName;
        private double cashAdvVal;
        private double philHealth;
        private double sss;
        DataTable dtPayrollCalc;
        DataTable dtPayrollDatagrid;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        DateTime DateStart;
        DateTime DateEnd;
        frmPayrollListcs pPayrollForm;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmPayrollEditPay()
        {
            InitializeComponent();
        }
        public frmPayrollEditPay(int encoderID, int selectedEmpID, int selectedPayrollID, String selectedEmpName,
            DateTime DateStart, DateTime DateEnd, frmPayrollListcs pPayrollForm, double cashAdvVal, double philHealth,double sss,
            int philHealthID, int sssID)
        {
            InitializeComponent();
            this.encoderID = encoderID;
            this.selectedEmpID = selectedEmpID;
            this.selectedPayrollID = selectedPayrollID;
            this.selectedEmpName = selectedEmpName;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.pPayrollForm = pPayrollForm;
            this.cashAdvVal = cashAdvVal;
            this.philHealth = philHealth;
            this.sss = sss;
            this.philHealthID = philHealthID;
            this.sssID = sssID;
        }
        private void frmPayrollEditPay_Load(object sender, EventArgs e)
        {
            frmPayroll_Loader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmPayroll_Loader()
        {
            //int selectedEmpId;
            this.datagridPayrollCalc.DataSource = null;
            this.datagridPayrollCalc.Rows.Clear();
            dtPayrollCalc = new DataTable();
            dtPayrollDatagrid = new DataTable();
            dtPayrollDatagrid.Columns.Add("employeeID", typeof(int));
            dtPayrollDatagrid.Columns.Add("Employee Name", typeof(String));
            dtPayrollDatagrid.Columns.Add("Hourly Rate", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Total Hours", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Gross Amount", typeof(decimal));
            dtPayrollDatagrid.Columns.Add("Cash Advance", typeof(decimal));

            try
            {
                String stringPayrollCalc = "SELECT emp.employeeID, concat(emp.lastname, ', ',emp.firstname) AS 'Employee Name', emp.salaryRate AS 'Hourly Rate', " +
                    "SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) AS `Total Hours`, SUM(FLOOR(TIMESTAMPDIFF(MINUTE, attIn.TimeIn, attOut.TimeOut) / 60)) * emp.salaryRate AS `Gross Amount` " +
                    "FROM(SELECT employeeID, date, timeIn from attendance GROUP BY employeeID, date) AS attIn " +
                    "LEFT JOIN(SELECT employeeID, date, timeOut from attendance WHERE timeOut IS NOT NULL GROUP BY employeeID, date) AS attOut ON(attIn.employeeID = attOut.employeeID AND attIn.date = attOut.date) " +
                    "LEFT JOIN(SELECT employeeID, lastname, firstname, salaryRate from employee) AS emp ON emp.employeeID = attIn.employeeID " +
                    "WHERE attIn.date BETWEEN @DateStart AND @DateEnd AND emp.employeeID=@employeeID GROUP BY emp.employeeID HAVING `Gross Amount` IS NOT NULL; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPayrollCalc = new MySqlCommand(stringPayrollCalc, my_conn);
                cmdPayrollCalc.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdPayrollCalc.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
                cmdPayrollCalc.Parameters.AddWithValue("@employeeID", selectedEmpID);

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

            datagridPayrollCalc.Columns["Gross Amount"].DefaultCellStyle.Format = "0.00";
            if (datagridPayrollCalc.Rows.Count > 0)
            {
                //MessageBox.Show(dtPayrollCalc.Rows[0]["employeeID"].ToString());
                datagridPayrollCalc.Rows[0].Selected = true;
                int currRowIndex = datagridPayrollCalc.SelectedRows[0].Index;
                this.txtBoxEmployeeName.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Employee Name"].Value.ToString();
                this.txtBoxAmount.Text = datagridPayrollCalc.Rows[currRowIndex].Cells["Gross Amount"].Value.ToString();
                this.txtBoxReceiver.Text = txtBoxEmployeeName.Text;
                this.txtBoxPayrollDates.Text = DateStart.ToString("yyyy/MM/dd") + " - " + DateEnd.ToString("yyyy/MM/dd");
                this.txtBoxCashAdv.Text = cashAdvVal.ToString();
                this.txtBoxPhilhealth.Text = philHealth.ToString();
                this.txtBoxSSS.Text = sss.ToString();
                datagridPayrollCalc.Rows[0].Cells["Cash Advance"].Value = cashAdvVal.ToString();
                bool validateCheck = dateChecker();
                if (!validateCheck)
                {
                    MessageBox.Show("You can only edit on or after the Payroll End Date.");
                    this.txtBoxEmployeeName.Text = selectedEmpName;
                    this.txtBoxPayrollDates.Text = DateStart.ToString("yyyy/MM/dd") + " - " + DateEnd.ToString("yyyy/MM/dd");
                    this.txtBoxCashAdv.Text = cashAdvVal.ToString();
                    this.txtBoxPhilhealth.ReadOnly = true;
                    this.txtBoxSSS.ReadOnly = true;
                    this.txtBoxReceiver.ReadOnly = true;
                    this.btnSave.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please make sure employee is not absent during the selected Payroll Dates. \nPlease edit Employee Attendance.");
                this.txtBoxEmployeeName.Text = selectedEmpName;
                this.txtBoxPayrollDates.Text = DateStart.ToString("yyyy/MM/dd") + " - " + DateEnd.ToString("yyyy/MM/dd");
                this.txtBoxCashAdv.Text = cashAdvVal.ToString();
                this.txtBoxPhilhealth.ReadOnly = true;
                this.txtBoxSSS.ReadOnly = true;
                this.txtBoxReceiver.ReadOnly = true;
                this.btnSave.Enabled = false;
            }
            totalAmountSolver();

            
        }
        private bool dateChecker()
        {
            if (DateTime.Now >= DateEnd)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void totalAmountSolver()
        {
            double valPhilHealth;
            double valSss;
            double valcashAdv; //temporary value
            double tempTotalAmount;
            double totalAmount = 0;
            int dataGridSelectedIndex = datagridPayrollCalc.SelectedRows[0].Index;

            if (String.IsNullOrEmpty(txtBoxPhilhealth.Text.ToString()))
            {
                valPhilHealth = 0;
            }
            else
            {
                valPhilHealth = Double.Parse(txtBoxPhilhealth.Text.ToString());
            }
            if (String.IsNullOrEmpty(txtBoxSSS.Text.ToString()))
            {
                valSss = 0;
            }
            else
            {
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

            tempTotalAmount = Double.Parse(datagridPayrollCalc.Rows[0].Cells["Gross Amount"].Value.ToString());
            totalAmount = tempTotalAmount - (valPhilHealth + valSss + valcashAdv);

            txtBoxAmount.Text = totalAmount.ToString();
            //MessageBox.Show(txtBoxCashAdv.Text.ToString());

        }
        private void updatePayroll()
        {
            try
            {
                String stringCashAdvUpdStat = "UPDATE payroll AS pay " +
               "SET " +
               "pay.amountReceived = @amount, " +
               "pay.nameOfreceiver = @nameOfReceiver " +
               "WHERE pay.payrollID = @payrollID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvUpdStat = new MySqlCommand(stringCashAdvUpdStat, my_conn);
                cmdCashAdvUpdStat.Parameters.AddWithValue("@amount", Double.Parse(txtBoxAmount.Text.ToString()));
                cmdCashAdvUpdStat.Parameters.AddWithValue("@nameOfReceiver", txtBoxReceiver.Text.ToString());
                cmdCashAdvUpdStat.Parameters.AddWithValue("@payrollID", selectedPayrollID);

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
            saveDeductions();
        }
        private void saveDeductions()
        {
            if (philHealthID > -1 && sssID > -1)
            {
                updateDeductions();
            }
            else if(philHealthID == -1 && sssID == -1)
            {
                insertDeductions();
            }
        }
        private void insertDeductions()
        {
            //Insert Philhealth
            try
            {
                String stringDeductionsInsert = "INSERT INTO deductions (payrollID,typeOfDeduction,amount) VALUES " +
                    "VALUES (@payrollID,'PhilHealth',@amount); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdDeductionsInsert = new MySqlCommand(stringDeductionsInsert, my_conn);
                cmdDeductionsInsert.Parameters.AddWithValue("@payrollID", selectedPayrollID);
                cmdDeductionsInsert.Parameters.AddWithValue("@amount", Double.Parse(txtBoxPhilhealth.Text.ToString()));
                my_conn.Open();
                cmdDeductionsInsert.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //Insert SSS
            try
            {
                String stringDeductionsInsert = "INSERT INTO deductions (payrollID,typeOfDeduction,amount) VALUES " +
                     "VALUES (@payrollID,'SSS',@amount); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdDeductionsInsert = new MySqlCommand(stringDeductionsInsert, my_conn);
                cmdDeductionsInsert.Parameters.AddWithValue("@payrollID", selectedPayrollID);
                cmdDeductionsInsert.Parameters.AddWithValue("@amount", Double.Parse(txtBoxSSS.Text.ToString()));
                my_conn.Open();
                cmdDeductionsInsert.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void updateDeductions()
        {
            //Update PhilHealth
            try
            {
                String stringCashAdvUpdStat = "UPDATE deductions AS de " +
               "SET " +
               "de.Amount = @amount " +
               "WHERE de.deductionsID = @deductionsID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvUpdStat = new MySqlCommand(stringCashAdvUpdStat, my_conn);
                cmdCashAdvUpdStat.Parameters.AddWithValue("@amount", Double.Parse(txtBoxPhilhealth.Text.ToString()));
                cmdCashAdvUpdStat.Parameters.AddWithValue("@deductionsID", philHealthID);

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
            //Update SSS
            try
            {
                String stringCashAdvUpdStat = "UPDATE deductions AS de " +
               "SET " +
               "de.Amount = @amount " +
               "WHERE de.deductionsID = @deductionsID; ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvUpdStat = new MySqlCommand(stringCashAdvUpdStat, my_conn);
                cmdCashAdvUpdStat.Parameters.AddWithValue("@amount", Double.Parse(txtBoxSSS.Text.ToString()));
                cmdCashAdvUpdStat.Parameters.AddWithValue("@deductionsID", sssID);

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
        }
        private bool validateAmounts()
        {
            if (String.IsNullOrEmpty(txtBoxPhilhealth.Text)|| String.IsNullOrEmpty(txtBoxPhilhealth.Text))
            {
                MessageBox.Show("Please Enter a value for PhilHealth and SSS");
                return false;
            }
            return true;
        }
        //----------------Event Methods-----------------
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPhilhealth_TextChanged(object sender, EventArgs e)
        {
            totalAmountSolver();
        }

        private void txtBoxSSS_TextChanged(object sender, EventArgs e)
        {
            totalAmountSolver();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validAmounts = validateAmounts();
            if (!validAmounts)
            {
                return;
            }
            else
            {
                updatePayroll();
                MessageBox.Show("Update Saved.");
                this.Close();
            }
        }
    }
}
