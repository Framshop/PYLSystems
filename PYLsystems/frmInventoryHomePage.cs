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
    public partial class frmInventoryHomePage : Form
    {
        int employeeId;
        int employeeStatus;
        public frmInventoryHomePage()
        {
            InitializeComponent();
        }

        private void btnFrameList_Click(object sender, EventArgs e)
        {
            frmFrameList formFrameList = new frmFrameList();
            formFrameList.ShowDialog();
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            frmSuppliesHomePage formSuppliesNav = new frmSuppliesHomePage();
            formSuppliesNav.ShowDialog();
        }

        private void btnJobOrders_Click(object sender, EventArgs e)
        {
            frmJobOrderTransaction formJobOrder = new frmJobOrderTransaction();
            formJobOrder.ShowDialog();
        }
    }
}
