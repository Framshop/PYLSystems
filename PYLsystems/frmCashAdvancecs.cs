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
        frmPayrollListcs pFrmPayrollListcs;
        DateTime DateStart;
        DateTime DateEnd;
        //--------------Initial Load--------------
        //----for programming initializer
        public frmCashAdvancecs()
        {
            InitializeComponent();
        }
        public frmCashAdvancecs(int employeeId, frmPayrollListcs pFrmPayrollListcs)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.pFrmPayrollListcs = pFrmPayrollListcs;
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
            DateStart = DateTime.Today.AddDays(((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 7) % 7);
            DateEnd = DateStart.AddDays(((int)DayOfWeek.Saturday - (int)DateStart.DayOfWeek + 7) % 7);
            startDatePicker.Value = DateStart.AddHours(0).AddMinutes(0).AddSeconds(0);
            endDatePicker.Value = DateEnd.AddHours(23).AddMinutes(59).AddSeconds(59);
            datePickerCashAdv.Value = DateTime.Today.AddDays(((int)DayOfWeek.Wednesday - (int)DateTime.Today.DayOfWeek + 7) % 7);
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
                comboBoxEmp.DisplayMember = dtComboBoxEmpNames.Columns["Employee Name"].ToString();
                comboBoxEmp.ValueMember = "employeeID";
                comboBoxEmp.DataSource = dtComboBoxEmpNames;
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
            DataTable checkIfAmountsExist = new DataTable();
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
                my_adapter.Fill(checkIfAmountsExist);
                MessageBox.Show(checkIfAmountsExist.Rows.Count+ " "+ comboBoxEmp.SelectedValue.ToString()+ " "+DateStart.ToString("yyyy-MM-dd")+" "+DateEnd.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int nullAccs = 0;
            int notnullAccs = 0;
            if (checkIfAmountsExist.Rows.Count > 0)
            {
                notnullAccs++;
            }
            else
            {
                nullAccs++;
            }
            if (notnullAccs > 0)
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
        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCashAdv_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxEmp.SelectedValue+"");
            bool validDates = validateDates();
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
