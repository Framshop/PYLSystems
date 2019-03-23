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
    public partial class frmCashAdvancecs : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";

        private int employeeId;
        private int selectedEmpId;
        frmPayrollListcs pFrmPayrollListcs;
        DateTime DateStart;
        DateTime DateEnd;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmCashAdvancecs()
        {
            InitializeComponent();
        }
        public frmCashAdvancecs(int employeeId, frmPayrollListcs pFrmPayrollListcs,int selectedEmpId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.pFrmPayrollListcs = pFrmPayrollListcs;
            this.selectedEmpId = selectedEmpId;
        }
        private void frmCashAdvancecs_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            namesInitializer();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void DefaultDatesInitializer()
        {
            //DateTime saturdayDate;
            //if (DateTime.Today.DayOfWeek != DayOfWeek.Saturday)
            //{
            //    saturdayDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 1);
            //}
            //else
            //{
            //    saturdayDate = DateTime.Today;
            //}
            //String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd");
            //String DefaultEndDate = saturdayDate.ToString("yyyy-MM-dd");
            if (DateTime.Today.DayOfWeek > DayOfWeek.Wednesday)
            {
                DateStart = DateTime.Today.AddDays(((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 7) % 7);
                DateEnd = DateStart.AddDays(((int)DayOfWeek.Saturday - (int)DateStart.DayOfWeek + 7) % 7);
                startDatePicker.Value = DateStart.AddHours(0).AddMinutes(0).AddSeconds(0);
                endDatePicker.Value = DateEnd.AddHours(23).AddMinutes(59).AddSeconds(59);
                datePickerCashAdv.Value = DateStart.AddDays(((int)DayOfWeek.Wednesday - (int)DateStart.DayOfWeek + 7) % 7);
            }
            else
            {
                DayOfWeek day = DateTime.Now.DayOfWeek;
                int days = day - DayOfWeek.Monday;
                DateTime start = DateTime.Now.AddDays(-days);
                DateTime end = start.AddDays(5);

                //String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd");
                DateStart = start;
                DateEnd = end;
                startDatePicker.Value = start;
                endDatePicker.Value = end;
            }
            //MessageBox.Show(endDatePicker.Value.ToString());

        }
        private void namesInitializer() {
            DataTable dtComboBoxEmpNames = new DataTable();
            DataTable dtEncoderName = new DataTable();
            try
            {
                String stringComboBoxEmpNames = "SELECT emp.employeeID, concat(emp.lastname,', ',emp.firstname) AS 'Employee Name' " +
                    "FROM employee AS emp WHERE emp.active=0 ORDER BY 'Employee Name'";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdComboBoxEmpNames = new MySqlCommand(stringComboBoxEmpNames, my_conn);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdComboBoxEmpNames);
                my_adapter.Fill(dtComboBoxEmpNames);
                int comboBoxIndex=0;
                if (dtComboBoxEmpNames.Rows.Count > 0) {
                    for (int i = 0; i < dtComboBoxEmpNames.Rows.Count; i++)
                    {
                        if (Int32.Parse(dtComboBoxEmpNames.Rows[i]["employeeId"].ToString()) == selectedEmpId)
                        {
                            comboBoxIndex = i;
                        }
                }
                }
                comboBoxEmp.DisplayMember = dtComboBoxEmpNames.Columns["Employee Name"].ToString();
                comboBoxEmp.ValueMember = "employeeID";
                comboBoxEmp.DataSource = dtComboBoxEmpNames;
                comboBoxEmp.SelectedIndex = comboBoxIndex;
                txtBoxReceivedBy.Text = comboBoxEmp.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                
                String stringGetEncoderID = "SELECT emp.employeeID, concat(emp.lastname,', ',emp.firstname) AS 'Employee Name' " +
                    "FROM employee AS emp WHERE emp.employeeID=@encoderId";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdGetEncoderID = new MySqlCommand(stringGetEncoderID, my_conn);
                cmdGetEncoderID.Parameters.AddWithValue("@encoderId", employeeId);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdGetEncoderID);
                my_adapter.Fill(dtEncoderName);
                //encoderName = dtencoderName.Rows[0]["Employee Name"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (dtEncoderName.Rows.Count > 0)
            {
                txtBoxEncodedBy.Text = dtEncoderName.Rows[0]["Employee Name"].ToString();
            }
            
        }
        private bool validateDates()
        {
            int invalidForms = 0;
            DateTime Start = startDatePicker.Value.Date.Add(new TimeSpan(0, 0, 0));
            DateTime End = endDatePicker.Value.Date.Add(new TimeSpan(23, 59, 59));
            int totalDays = (int)Math.Round((End - Start).TotalDays);
            //MessageBox.Show(totalDays.ToString());
            //Check if dates are valid
            if (totalDays < 6 || totalDays > 6)
            {
                MessageBox.Show("Payroll should be 6 days");
                invalidForms++;
            }
            if (Start.DayOfWeek != DayOfWeek.Monday || End.DayOfWeek != DayOfWeek.Saturday)
            {
                MessageBox.Show("Payroll Start date should be on a Monday and Payroll End date should be on a Saturday");
                invalidForms++;
            }
            if (!(datePickerCashAdv.Value >= DateStart && datePickerCashAdv.Value<=DateEnd))
            {
                MessageBox.Show("Cash Advance Date should be in between chosen Payroll Dates");
                invalidForms++;
            }
            //Check if Cash Advance already exists in those dates
            DataTable checkIfCAexists = new DataTable();
            try
            {
                String stringCashAdvChecker = "SELECT ca.cashadvanceID, ca.employeeID " +
                   "FROM cashadvance AS ca " +
                   "WHERE ca.active=1 AND ca.employeeID=@employeeId AND ca.dateReceived BETWEEN @DateStart AND @DateEnd;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvChecker = new MySqlCommand(stringCashAdvChecker, my_conn);
                cmdCashAdvChecker.Parameters.AddWithValue("@employeeId", comboBoxEmp.SelectedValue.ToString());
                cmdCashAdvChecker.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdCashAdvChecker.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdCashAdvChecker);
                my_adapter.Fill(checkIfCAexists);
                //MessageBox.Show(checkIfCAexists.Rows.Count+ " "+ comboBoxEmp.SelectedValue.ToString()+ " "+DateStart.ToString("yyyy-MM-dd")+" "+DateEnd.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int nullCAs = 0;
            int notNullCAs = 0;
            if (checkIfCAexists.Rows.Count > 0)
            {
                notNullCAs++;
            }
            else
            {
                nullCAs++;
            }
            if (notNullCAs > 0)
            {
                invalidForms++;
                MessageBox.Show("Cash Advance already exists. Please select different payroll dates.");
            }


            //Number of invalidforms to be satisfied
            if (invalidForms > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void addCashAdv()
        {
            //bool duplicatePayroll = checkDuplicatePayroll();
            int payrollIDDuplicate = checkDuplicatePayroll();
            int payrollID = -1;
            if (payrollIDDuplicate > -1) {
                insertCashAdv(payrollIDDuplicate);
            }
            else if (payrollIDDuplicate == -1)
            {
                payrollID = insertPayroll();
                insertCashAdv(payrollID);
            }          
            //MessageBox.Show("Payroll ID" + payrollID +" "+ payrollIDDuplicate);
            
        }
        private int checkDuplicatePayroll() {
            int payrollID = -1;
            DataTable dtPayrollID = new DataTable();
            try
            {
                String stringGetPayrollID = "SELECT payrollID FROM payroll " +
                    "WHERE employeeIDReceiver = @employeeID AND payRollStartDate = @DateStart AND payRollEndDate = @DateEnd;";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdGetPayrollID = new MySqlCommand(stringGetPayrollID, my_conn);
                cmdGetPayrollID.Parameters.AddWithValue("@employeeID", comboBoxEmp.SelectedValue);
                cmdGetPayrollID.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdGetPayrollID.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdGetPayrollID);
                my_adapter.Fill(dtPayrollID);
                //MessageBox.Show(dtPayrollID.Rows.Count + " " + comboBoxEmp.SelectedValue + " " + DateStart.ToString("yyyy-MM-dd") + " " + DateEnd.ToString("yyyy-MM-dd"));
                if (dtPayrollID.Rows.Count > 0)
                {
                    payrollID = Int32.Parse(dtPayrollID.Rows[0]["payrollID"].ToString());
                }

                //MessageBox.Show(checkIfCAexists.Rows.Count+ " "+ comboBoxEmp.SelectedValue.ToString()+ " "+DateStart.ToString("yyyy-MM-dd")+" "+DateEnd.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return payrollID;
        }
        private int insertPayroll() {
            int payrollID = -1;
            //INSERT PAYROLL
            try
            {
                String stringPayrollInsert = "INSERT INTO payroll (employeeIDReceiver,employeeIDProvider,payRollStartDate,payRollEndDate) " +
                    "VALUES (@employeeID,@encoderID,@DateStart,@DateEnd); " +
                    "SELECT LAST_INSERT_ID();";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdPayrollInsert = new MySqlCommand(stringPayrollInsert, my_conn);
                cmdPayrollInsert.Parameters.AddWithValue("@employeeID", comboBoxEmp.SelectedValue);
                cmdPayrollInsert.Parameters.AddWithValue("@encoderID", employeeId);
                cmdPayrollInsert.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
                cmdPayrollInsert.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
                my_conn.Open();
                payrollID = Convert.ToInt32(cmdPayrollInsert.ExecuteScalar());
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //GET PAYROLL ID
            //DataTable dtPayrollID = new DataTable();
            //try
            //{
            //    String stringGetPayrollID = "SELECT payrollID FROM payroll " +
            //        "WHERE employeeIDReceiver = @employeeID AND payRollStartDate = @DateStart AND payRollEndDate = @DateEnd;";

            //    MySqlConnection my_conn = new MySqlConnection(connString);
            //    MySqlCommand cmdGetPayrollID = new MySqlCommand(stringGetPayrollID, my_conn);
            //    cmdGetPayrollID.Parameters.AddWithValue("@employeeId", comboBoxEmp.SelectedValue);
            //    cmdGetPayrollID.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd"));
            //    cmdGetPayrollID.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd"));
            //    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdGetPayrollID);
            //    my_adapter.Fill(dtPayrollID);
            //    MessageBox.Show(dtPayrollID.Rows.Count+"");
            //    if (dtPayrollID.Rows.Count>0)
            //    {
            //        payrollID = Int32.Parse(dtPayrollID.Rows[0]["payrollID"].ToString());
            //    }
                
            //    //MessageBox.Show(checkIfCAexists.Rows.Count+ " "+ comboBoxEmp.SelectedValue.ToString()+ " "+DateStart.ToString("yyyy-MM-dd")+" "+DateEnd.ToString("yyyy-MM-dd"));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            return payrollID;
        }
        private void insertCashAdv(int payrollID)
        {
            //MessageBox.Show(payrollID+"");
            try
            {
                String stringCashAdvInsert = "INSERT INTO cashadvance (amount,dateReceived,active,employeeID,payrollID,employeeIDProvider,nameOfReceiver,cashAdvancedescription) " +
                    "VALUES (@amount, @dateReceived, 1, @employeeID, @payrollID, @encoderID, @nameOfReceiver, @cashAdvancedescription); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvInsert = new MySqlCommand(stringCashAdvInsert, my_conn);
                cmdCashAdvInsert.Parameters.AddWithValue("@amount", Double.Parse(txtBoxCAAmount.Text));
                cmdCashAdvInsert.Parameters.AddWithValue("@dateReceived", datePickerCashAdv.Value.ToString("yyyy-MM-dd"));
                cmdCashAdvInsert.Parameters.AddWithValue("@employeeID", comboBoxEmp.SelectedValue);
                cmdCashAdvInsert.Parameters.AddWithValue("@payrollID", payrollID);
                cmdCashAdvInsert.Parameters.AddWithValue("@encoderID", employeeId);
                cmdCashAdvInsert.Parameters.AddWithValue("@nameOfReceiver", txtBoxReceivedBy.Text);
                cmdCashAdvInsert.Parameters.AddWithValue("@cashAdvancedescription", txtBoxCAdesc.Text);
                my_conn.Open();
                cmdCashAdvInsert.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private bool validateCashAdvAmount()
        {
            if (String.IsNullOrEmpty(txtBoxCAAmount.Text))
            {
                MessageBox.Show("Please enter a valid amount.");
                return false;
            }
            else if(Double.Parse(txtBoxCAAmount.Text)==0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return false;
            }
            else if (Double.Parse(txtBoxCAAmount.Text) > 500)
            {
                MessageBox.Show("Please enter a valid amount. \n Cash Advance cannot exceed more than P500.");
                return false;
            }
            else
            {
                return true;
            }
        }
        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCashAdv_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxEmp.SelectedValue+"");
            bool validDates = validateDates();
            bool validCashAdvAmount = validateCashAdvAmount();
            if (!validDates) {
                return;
            }
            if (!validCashAdvAmount)
            {
                return;
            }
            else
            {
                addCashAdv();
                MessageBox.Show("Cash Advance added.");
                this.Close();
            }
        }

        private void comboBoxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxReceivedBy.Text = comboBoxEmp.Text;
        }

        private void txtBoxCAAmount_KeyPress(object sender, KeyPressEventArgs e)
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
