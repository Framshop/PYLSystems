using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems.EmployeeManagement
{
    public partial class addEmpForm : Form
    {
        addEmployeeInstance parentInstance;
        public addEmpForm(addEmployeeInstance parent)
        {           
            InitializeComponent();
            this.parentInstance = parent;
            this.birthDatePicker.Value = DateTime.Now;

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
