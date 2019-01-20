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
    public partial class addSalesConfirm : Form
    {
        addSales addSalesPform;
        public addSalesConfirm()
        {
            InitializeComponent();
        }
        public addSalesConfirm(addSales addSalesPform)
        {
            InitializeComponent();
            this.addSalesPform = addSalesPform;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            addSalesPform.insertToSalesOrder();
            this.Close();
        }
    }
}
