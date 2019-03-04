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
    public partial class frmEmployeeMgt : Form
    {
        private int employeeId;
        public frmEmployeeMgt()
        {
            InitializeComponent();
        }
        public frmEmployeeMgt(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }

        private void btnEmpList_Click(object sender, EventArgs e)
        {
            frmEmployeeList emplist = new frmEmployeeList();
            emplist.ShowDialog();
        }

        private void frmEmployeeMgt_Load(object sender, EventArgs e)
        {

        }
        private void payrollBtn_Click(object sender, EventArgs e)
        {
            frmPayrollListcs payroll = new frmPayrollListcs(this.employeeId);
            payroll.ShowDialog();
        }
    }
}
