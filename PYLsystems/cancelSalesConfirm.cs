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
    public partial class cancelSalesConfirm : Form
    {
        private checkSales checkSalesPForm;
        public cancelSalesConfirm(checkSales ParentForm)
        {
            InitializeComponent();
            checkSalesPForm = ParentForm;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            checkSalesPForm.cancelSalesOrder();
            this.Close();
        }
    }
}
