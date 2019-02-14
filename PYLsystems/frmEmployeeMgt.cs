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


namespace Employee_Management
{
    public partial class frmEmployeeMgt : Form
    {
        public frmEmployeeMgt()
        {
            InitializeComponent();
        }

        private void btnEmpList_Click(object sender, EventArgs e)
        {
            frmEmployeeList emplist = new frmEmployeeList();
            emplist.ShowDialog();
        }

        private void frmEmployeeMgt_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmWorkDetails workdeteils = new frmWorkDetails();
            workdeteils.ShowDialog();
        }
    }
}
