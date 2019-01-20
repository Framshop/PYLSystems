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
    public partial class viewProductsSold : Form
    {
        String connString = "server=localhost;uid=root;pwd=root;database=frameshopdb;";
        DataTable viewProductsSold_dt;
        String DateStart;
        String DateEnd;
        //--------------Initial Load--------------
        public viewProductsSold()
        {
            InitializeComponent();
            DefaultDatesInitializer();

        }

        private void viewProductsSold_Load(object sender, EventArgs e)
        {
            
            viewProductsSold_Loader();
        }
        //-------------Process and Calculation Methods--------------
        private void viewProductsSold_Loader() {
            this.viewProductsSoldGrid.DataSource = null;
            this.viewProductsSoldGrid.Rows.Clear();
            String viewProductsSoldString = "SELECT FL.frameName AS Item, FL.dimension AS Dimension, " +
                "IFNULL(SOD.Stockout, 0) AS 'Quantity Sold', FL.frameItemID " +
                "FROM frame_list AS FL " +
                "LEFT JOIN(SELECT SOD.frameItemID, SO.sOrd_Date, SUM(SOD.sOrd_Quantity) AS Stockout FROM sOrder_details AS SOD LEFT JOIN salesOrder AS SO ON SOD.sOrd_Num = SO.sOrd_Num WHERE SO.sOrd_status > 0 GROUP BY SOD.frameItemID) AS SOD ON FL.frameItemID = SOD.frameItemID " +
                "WHERE SOD.sOrd_Date BETWEEN @sOrd_DateStart AND @sOrd_DateEnd " +
                "GROUP BY FL.frameItemID " +
                "ORDER BY FL.frameItemID; ";

            MySqlConnection my_conn = new MySqlConnection(connString);
            MySqlCommand viewProductsSold_command = new MySqlCommand(viewProductsSoldString, my_conn);

            viewProductsSold_command.Parameters.AddWithValue("@sOrd_DateStart", DateStart);
            viewProductsSold_command.Parameters.AddWithValue("@sOrd_DateEnd", DateEnd);

            MySqlDataAdapter my_adapter = new MySqlDataAdapter(viewProductsSold_command);

            viewProductsSold_dt = new DataTable();
            my_adapter.Fill(viewProductsSold_dt);
            viewProductsSoldGrid.DataSource = viewProductsSold_dt;
            viewProductsSoldGrid.Columns["frameItemID"].Visible = false;
            int SumTotalSold=0;
            for (int i = 0; i < viewProductsSoldGrid.RowCount; i++) {
                SumTotalSold += Int32.Parse(viewProductsSoldGrid.Rows[i].Cells["Quantity Sold"].Value.ToString());
            }
            totalSoldTextBox.Text = SumTotalSold.ToString();

        }
        private void DefaultDatesInitializer() {
            String DefaultStartDate =  DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd")+ " 00:00:00";
            String DefaultEndDate = DateTime.Today.ToString("yyyy-MM-dd")+ " 23:59:59";
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
            DateStart=getDateTimePicker(0);
            viewProductsSold_Loader();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateEnd = getDateTimePicker(1);
            viewProductsSold_Loader();
        }
    }
}
