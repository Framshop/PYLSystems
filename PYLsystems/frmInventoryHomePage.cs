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
        public frmInventoryHomePage()
        {
            InitializeComponent();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier Supplier = new frmSupplier();
            Supplier.ShowDialog();
        }

        private void btnSupplyItems_Click(object sender, EventArgs e)
        {
            frmSupplyItems SupplyItems = new frmSupplyItems();
            SupplyItems.ShowDialog();
        }

        private void btnFrameList_Click(object sender, EventArgs e)
        {
            frmFrameList FrameList = new frmFrameList();
            FrameList.ShowDialog();
        }

        private void btnFrameDetails_Click(object sender, EventArgs e)
        {
            frmFrameDetails FrameDetails = new frmFrameDetails();
            FrameDetails.ShowDialog();
        }

        private void btnSupplyStockIn_Click(object sender, EventArgs e)
        {
            frmSupplyStockIn SupplyStockIn = new frmSupplyStockIn();
            SupplyStockIn.ShowDialog();
        }

        private void btnFrameStockInSupplyStockOut_Click(object sender, EventArgs e)
        {
            frmFrameStockInSupplyStockOut FrameStockInSupplyStockOut = new frmFrameStockInSupplyStockOut();
            FrameStockInSupplyStockOut.ShowDialog();
        }

        private void btnJobOrderDetails_Click(object sender, EventArgs e)
        {
            frmJobOrderDetails JobOrderDetails = new frmJobOrderDetails();
            JobOrderDetails.ShowDialog();
        }

        private void btnJobOrderTransaction_Click(object sender, EventArgs e)
        {
            frmJobOrderTransaction jobOrderTransaction = new frmJobOrderTransaction();
            jobOrderTransaction.ShowDialog();
        }

        private void btnCustomerAccount_Click(object sender, EventArgs e)
        {
            frmCustomerAccount CustomerAccount = new frmCustomerAccount();
            CustomerAccount.ShowDialog();
        }

        private void btnDamageItems_Click(object sender, EventArgs e)
        {
            frmDamageItems DamageItems = new frmDamageItems();
            DamageItems.ShowDialog();
        }

        private void btnSupplyFrames_Click(object sender, EventArgs e)
        {
            frmRemainingSupplyFrames remainingSupplyFrames = new frmRemainingSupplyFrames();
            remainingSupplyFrames.ShowDialog();
        }
    }
}
