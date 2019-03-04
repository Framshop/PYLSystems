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
    public partial class frmPayroll : Form
    {
        private int employeeId;
        frmPayrollListcs pFrmPayrollListcs;
        public frmPayroll()
        {
            InitializeComponent();
        }
        public frmPayroll(int employeeId, frmPayrollListcs pFrmPayrollListcs)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.pFrmPayrollListcs = pFrmPayrollListcs;
        }
    }
}
