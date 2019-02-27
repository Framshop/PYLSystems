using System;
using System.Windows.Forms;

namespace PYLsystems
{
    public partial class Home : Form
    {
        internal int employeeId;
        internal int employeeStatus;
        public Home()
        {
            InitializeComponent();
            /*------temporary. to be erased when combine employee management------*/
            //this.employeeId = 1;
            //this.employeeStatus = 1;
        }
        public Home(int employeeId, int employeeStatus) {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeStatus = employeeStatus;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            /*For employee Status check from Login. 1-admin programmer-Business Owner, 2-Admin staff, 3-Cashier, 4-Framers.
             Lock Neccessary buttons based on employee Status
              */
            LoginForm frmLogin = new LoginForm(this);
            frmLogin.ShowDialog();
            frmInventoryHomePage inventoryHomePage = new frmInventoryHomePage();
            MessageBox.Show(employeeId.ToString()+" "+employeeStatus.ToString());
            if (employeeStatus == 1) {
                salesOrderBtn.Enabled = true;
                salesOrderBtn.Visible = true;
                jOrderBtn.Enabled = true;
                jOrderBtn.Visible = true;
                inventoryBtn.Enabled = true;
                inventoryBtn.Visible = true;
                empManBtn.Enabled = true;
                empManBtn.Visible = true;
            }
            if (employeeStatus == 2)
            {
                salesOrderBtn.Enabled = true;
                salesOrderBtn.Visible = true;
                jOrderBtn.Visible = true;
                inventoryBtn.Enabled = true;
                inventoryBtn.Visible = true;
                empManBtn.Enabled = true;
                empManBtn.Visible = true;
            }
            if (employeeStatus == 3)
            {
                inventoryBtn.Enabled = false;
                inventoryBtn.Text = "Not Applicable";
                empManBtn.Enabled = false;
                empManBtn.Text = "Not Applicable";
            }
            if (employeeStatus == 4)
            {
                jOrderBtn.Enabled = false;
                jOrderBtn.Text = "Not Applicable";
                inventoryHomePage.btnSupplier.Enabled = false;
                inventoryHomePage.btnSupplier.Text = "Not Applicable";
                inventoryHomePage.btnSupplyStockIn.Enabled = false;
                inventoryHomePage.btnSupplyStockIn.Text = "Not Applicable";
                inventoryHomePage.btnCustomerAccount.Enabled = false;
                inventoryHomePage.btnCustomerAccount.Text = "Not Applicable";
            }
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
