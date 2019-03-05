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
    public partial class addUserForm : Form
    {
        addEmployeeInstance parentInstance;
        public addUserForm(addEmployeeInstance parent)
        {
            InitializeComponent();
            this.parentInstance = parent;

        }
    }
}
