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
    public partial class viewTotalProfit : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        DataTable viewTotalProfit_dt;
        String DateStart;
        String DateEnd;
        int employeeStatus;
        //--------------Initial Load--------------
        public viewTotalProfit()
        {
            InitializeComponent();
            DefaultDatesInitializer();
            //this.employeeStatus = 2; //To be removed once connected to employee management subsystem
        }
        public viewTotalProfit(int employeeStatus)
        {
            InitializeComponent();
            DefaultDatesInitializer();
            this.employeeStatus = employeeStatus;
        }
        private void viewTotalProfit_Load(object sender, EventArgs e)
        {
            viewTotalProfit_Loader();
        }
        //-------------Process and Calculation Methods--------------
        private void viewTotalProfit_Loader() {
            viewTotalProfit_Days();
        }
        private void viewTotalProfit_Days() {
            
            this.viewTotalProfitGrid.DataSource = null;
            this.viewTotalProfitGrid.Rows.Clear();
            String viewTotalProfitString = "SELECT DATE(SO.sOrd_Date) AS 'Date', SUM(SOD.rawPrice-SO.discount) AS Profit FROM salesOrder AS SO " +
                "LEFT JOIN(SELECT SOD.sOrd_Num, SUM(SOD.sOrd_Quantity* SOD.sOrd_UnitPrice) AS rawPrice FROM sorder_details AS SOD GROUP BY SOD.sOrd_Num) AS SOD " +
                "ON SO.sOrd_Num = SOD.sOrd_Num " +
                "WHERE SO.sOrd_status > 0 AND So.sOrd_Date BETWEEN @sOrd_DateStart AND @sOrd_DateEnd " +
                "GROUP BY DATE(SO.sOrd_Date);";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand viewTotalProfit_command = new MySqlCommand(viewTotalProfitString, my_conn);

            viewTotalProfit_command.Parameters.AddWithValue("@sOrd_DateStart", DateStart);
            viewTotalProfit_command.Parameters.AddWithValue("@sOrd_DateEnd", DateEnd);

            MySqlDataAdapter my_adapter = new MySqlDataAdapter(viewTotalProfit_command);

            viewTotalProfit_dt = new DataTable();
            my_adapter.Fill(viewTotalProfit_dt);
            viewTotalProfitGrid.DataSource = viewTotalProfit_dt;
            int SumProfit = 0;
            for (int i = 0; i < viewTotalProfitGrid.RowCount; i++)
            {
                SumProfit+= Int32.Parse(viewTotalProfitGrid.Rows[i].Cells["Profit"].Value.ToString());
            }
            totalTextBox.Text = SumProfit.ToString();
        }
        private void viewTotalProfit_Months()
        {
            this.viewTotalProfitGrid.DataSource = null;
            this.viewTotalProfitGrid.Rows.Clear();
            //viewTotalProfit_dt= new DataTable;
            String viewTotalProfitString = "SELECT YEAR(SO.sOrd_Date) AS 'Year', MONTHNAME(SO.sORd_Date) AS 'Month', SUM(SOD.rawPrice-SO.discount) AS Profit FROM salesorder AS SO " +
                "LEFT JOIN(SELECT SOD.sOrd_Num, SUM(SOD.sOrd_Quantity* SOD.sOrd_UnitPrice) AS rawPrice FROM sorder_details AS SOD GROUP BY SOD.sOrd_Num) AS SOD " +
                "ON SO.sOrd_Num = SOD.sOrd_Num " +
                "WHERE SO.sOrd_status > 0 AND So.sOrd_Date BETWEEN @sOrd_DateStart AND @sOrd_DateEnd " +
                "GROUP BY YEAR(SO.sORD_DATE), MONTH(SO.sORd_Date) " +
                "ORDER BY YEAR(SO.sOrd_Date) ASC, MONTH(SO.sORD_DATE) ASC; ";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand viewTotalProfit_command = new MySqlCommand(viewTotalProfitString, my_conn);

            viewTotalProfit_command.Parameters.AddWithValue("@sOrd_DateStart", DateStart);
            viewTotalProfit_command.Parameters.AddWithValue("@sOrd_DateEnd", DateEnd);

            MySqlDataAdapter my_adapter = new MySqlDataAdapter(viewTotalProfit_command);

            viewTotalProfit_dt = new DataTable();
            my_adapter.Fill(viewTotalProfit_dt);
            viewTotalProfitGrid.DataSource = viewTotalProfit_dt;
            int SumProfit = 0;
            for (int i = 0; i < viewTotalProfitGrid.RowCount; i++)
            {
                SumProfit += Int32.Parse(viewTotalProfitGrid.Rows[i].Cells["Profit"].Value.ToString());
            }
            totalTextBox.Text = SumProfit.ToString();
        }
        private void DefaultDatesInitializer()
        {
            String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd") + " 00:00:00";
            String DefaultEndDate = DateTime.Today.ToString("yyyy-MM-dd") + " 23:59:59";
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
                Datetime = startDatePicker.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            }
            else if (startOrEnd == 1)
            {
                Datetime = endDatePicker.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            }
            return Datetime;
        }
        //----------------Event Methods-----------------
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (startCheck.Checked)
            {
                startDatePicker.Enabled = true;
            }
            else
            {
                startDatePicker.Enabled = false;
            }
        }

        private void endCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (endCheck.Checked)
            {
                endDatePicker.Enabled = true;
            }
            else
            {
                endDatePicker.Enabled = false;
            }
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            
            if ((endDatePicker.Value - startDatePicker.Value).TotalDays < 31)
            {
                if ((endDatePicker.Value - startDatePicker.Value).TotalDays > 7 && employeeStatus != 1)
                {
                    if (employeeStatus == 2)
                    {
                        MessageBox.Show("Cannot load list if insufficient access rights. You can only view the 7-day chart.");
                    }
                    else if (employeeStatus > 2)
                    {
                        MessageBox.Show("Cannot load list if insufficient access rights.");
                    }
                }
                else {
                    DateStart = getDateTimePicker(0);
                    viewTotalProfit_Days();
                }
            }
            else if ((endDatePicker.Value - startDatePicker.Value).TotalDays > 31)
            {
                if (employeeStatus == 1)
                {
                    DateStart = getDateTimePicker(0);
                    viewTotalProfit_Months();
                }
                else if (employeeStatus != 1)
                {
                    MessageBox.Show("Cannot load list if insufficient access rights.");
                }
                
            }
            else if (endDatePicker.Value < startDatePicker.Value) {
                MessageBox.Show("End date should be after Start Date");
            }
            
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if ((endDatePicker.Value - startDatePicker.Value).TotalDays < 31)
            {
                if ((endDatePicker.Value - startDatePicker.Value).TotalDays > 7 && employeeStatus != 1)
                {
                    if (employeeStatus == 2)
                    {
                        MessageBox.Show("Cannot load list if insufficient access rights. You can only view the 7-day chart.");
                    }
                    else if(employeeStatus > 2) {
                        MessageBox.Show("Cannot load list if insufficient access rights.");
                    }
                }
                else
                {
                    DateEnd = getDateTimePicker(1);
                    viewTotalProfit_Days();
                }
            }
            else if ((endDatePicker.Value - startDatePicker.Value).TotalDays > 31)
            {
                if (employeeStatus == 1)
                {
                    DateEnd = getDateTimePicker(1);
                    viewTotalProfit_Months();
                }
                else if (employeeStatus != 1)
                {
                    MessageBox.Show("Cannot load list if insufficient access rights.");
                }
            }
            else if (endDatePicker.Value < startDatePicker.Value)
            {
                MessageBox.Show("End date should be after Start Date");
            }
        }
    }
}
