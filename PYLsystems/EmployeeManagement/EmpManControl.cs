using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class EmpManControl : UserControl
    {
        MainForm parentForm;
        public EmpManControl(MainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.Dock = DockStyle.Fill;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.parentForm.homeControl_Load(this);
        }

        private void empListButtton_Click(object sender, EventArgs e)
        {
            this.parentForm.empListControl_Load(this);
        }
    }
}
