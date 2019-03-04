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
    public partial class frmCashAdvanceDet : Form
    {
        private int selectedCashAdvId;
        DataTable dtCashAdvdet;
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        public frmCashAdvanceDet()
        {
            InitializeComponent();
        }
        public frmCashAdvanceDet(int selectedCashAvId)
        {
            InitializeComponent();
            this.selectedCashAdvId = selectedCashAvId;
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmCashAdvanceDet_Load(object sender, EventArgs e)
        {
            lblPayrollDate.Text = "";
            lblDateReceived.Text = "";
            lblEmp.Text = "";
            lblTotalAmount.Text = "";
            lblReceiver.Text = "";
            lblEncoder.Text = "";
            textBoxCashAdvDesc.Text = "";
            dtCashAdvdet = new DataTable();
            try
            {
                String stringCashAdvdet = "SELECT ca.cashAdvanceId, concat(pr.payRollStartDate,' - ', pr.payRollEndDate) AS 'Payroll Date', ca.dateReceived AS 'Date Received', " +
                    "concat(emp.lastName, ', ', emp.firstName) AS 'Employee', ca.Amount, ca.nameOfReceiver AS 'Receiver', concat(empenc.lastName, ', ', empenc.firstName) AS 'Encoder', " +
                    "ca.cashAdvancedescription AS 'Description' " +
                    "FROM cashadvance AS ca " +
                    "LEFT JOIN employee AS empenc ON ca.employeeIDProvider = empenc.employeeID " +
                    "LEFT JOIN employee AS emp ON ca.employeeID = emp.employeeID " +
                    "LEFT JOIN payroll AS pr ON ca.payrollID = pr.payrollID " +
                    "WHERE ca.cashAdvanceID = @cashAdvanceID; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdCashAdvDet = new MySqlCommand(stringCashAdvdet, my_conn);
                cmdCashAdvDet.Parameters.AddWithValue("@cashAdvanceID", this.selectedCashAdvId);
                //cmdEmpList.Parameters.AddWithValue("@DateStart", DateStart);
                //cmdEmpList.Parameters.AddWithValue("@DateEnd", DateEnd);

                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdCashAdvDet);


                my_adapter.Fill(dtCashAdvdet);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            lblPayrollDate.Text = dtCashAdvdet.Rows[0]["Payroll Date"].ToString();
            lblDateReceived.Text = Convert.ToDateTime(dtCashAdvdet.Rows[0]["Date Received"]).ToString("yyyy-MM-dd");
            lblEmp.Text = dtCashAdvdet.Rows[0]["Employee"].ToString();
            lblTotalAmount.Text = dtCashAdvdet.Rows[0]["Amount"].ToString();
            lblReceiver.Text = dtCashAdvdet.Rows[0]["Receiver"].ToString();
            lblEncoder.Text = dtCashAdvdet.Rows[0]["Encoder"].ToString();
            textBoxCashAdvDesc.Text = dtCashAdvdet.Rows[0]["Description"].ToString();
        }
        //----------------Event Methods-----------------
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
