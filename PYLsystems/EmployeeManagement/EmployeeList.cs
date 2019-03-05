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
        public delegate void AddEmployeeInstanceEventHandler(EmployeeList source, EventArgs args);
        public event AddEmployeeInstanceEventHandler AddEmpInstance;

        addEmployeeInstance newEmployee;
        MainForm parentForm;

        public EmployeeList(MainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.Dock = DockStyle.Fill;
            newEmployee = new addEmployeeInstance(this);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.parentForm.empManControl_Load(this);
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            if (AddEmpInstance == null)
            {
                AddEmpInstance += newEmployee.openAddEmployeeForm;
                AddEmpInstance(this, EventArgs.Empty);
            }
            else
            {
                AddEmpInstance(this, EventArgs.Empty);
            }
        }
    }
}
