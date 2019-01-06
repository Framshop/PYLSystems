using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems.EmployeeManagement
{
    public partial class EmployeeList : UserControl
    {
        MainForm parentForm;
        public EmployeeList(MainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.Dock = DockStyle.Fill;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.parentForm.empManControl_Load(this);
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            addEmployeeInstance newEmployee = new addEmployeeInstance(this);
            newEmployee.employeeListBoot();
        }
    }
}
