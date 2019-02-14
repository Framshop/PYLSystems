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
    public partial class e_attendance : Form
    {
        String DateStart;
        String DateEnd;
        private DataTable attendanceTable;
       // private List<>
        public e_attendance()
        {
            InitializeComponent();
            DefaultDatesInitializer();
        }
        private void e_attendance_Load(object sender, EventArgs e)
        {
            att_gridviewLoader();
            attendanceSorter(startDatePicker.Value, endDatePicker.Value);
        }
        private void DefaultDatesInitializer()
        {
            String DefaultStartDate = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).ToString("yyyy-MM-dd") + " 00:00:00";
            String DefaultEndDate = DateTime.Today.ToString("yyyy-MM-dd") + " 23:59:59";
            DateStart = DefaultStartDate;
            DateEnd = DefaultEndDate;
            startDatePicker.Value = DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek - 6).AddHours(0).AddMinutes(0).AddSeconds(0);
            endDatePicker.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            dateNowTextBox.Text = DateTime.Today.ToString("yyyy-MM-dd");
            //MessageBox.Show(endDatePicker.Value.ToString());

        }
        private void att_gridviewLoader() {
            attendanceTable = new DataTable();
            attendanceTable.Columns.Add("Day");
            attendanceTable.Columns.Add("Date");
            attendanceTable.Columns.Add("Time IN");
            attendanceTable.Columns.Add("Time OUT");
            attendanceGridView.DataSource = attendanceTable;
        }
        private void attendanceSorter(DateTime DateStart, DateTime DateEnd) {
            foreach (DateTime day in EachDay(DateStart, DateEnd)) {
                attendanceTable.Rows.Add(day.DayOfWeek,day.Date);
            }
        }
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

    }
}
