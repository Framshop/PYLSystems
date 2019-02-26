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
    public partial class Home : Form
    {
        int employeeId;
        int employeeStatus;
        public Home()
        {
            InitializeComponent();
            /*------temporary. to be erased when combine employee management------*/
            this.employeeId = 1;
            this.employeeStatus = 1;
        }
        public Home(int employeeId, int employeeStatus) {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeStatus = employeeStatus;
        }

        private void Home_Load(object sender, EventArgs e)
        {
           /*For employee Status check from Login. 1-admin programmer, 2-Business Owner, 3-Admin staff, 4-Cashier, 5-Framers.
            Lock Neccessary buttons based on employee Status
             */
        }
        private void salesOrderBtn_Click(object sender, EventArgs e)
        {
            checkSales checkSDlg = new checkSales(this.employeeId,this.employeeStatus);
            checkSDlg.ShowDialog();
        }

        private void jOrderBtn_Click(object sender, EventArgs e)
        {
            frmJobOrderTransaction jOrderDlg = new frmJobOrderTransaction();
            jOrderDlg.ShowDialog();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            frmInventoryHomePage inventDlg = new frmInventoryHomePage();
            inventDlg.ShowDialog();
        }

        private void empManBtn_Click(object sender, EventArgs e)
        {
            frmEmployeeList empMgt = new frmEmployeeList();
            empMgt.ShowDialog();
        }
    }
}
