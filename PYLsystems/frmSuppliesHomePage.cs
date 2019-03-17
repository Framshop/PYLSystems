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
    public partial class frmSuppliesHomePage : Form
    {
        int employeeId;
        int employeeStatus;
        public frmSuppliesHomePage()
        {
            InitializeComponent();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSupplier formSuppliersList = new frmSupplier();
            formSuppliersList.ShowDialog();
        }

        private void btnSupplyCateg_Click(object sender, EventArgs e)
        {
            frmAddSupplyCategory formSupplyCategory = new frmAddSupplyCategory();
            formSupplyCategory.ShowDialog();
        }

        private void btnSupplyItemsList_Click(object sender, EventArgs e)
        {
            frmSupplyItems formSupplyItemsList = new frmSupplyItems();
            formSupplyItemsList.ShowDialog();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            frmSupplyDamage frmSupplyDmg = new frmSupplyDamage();
            frmSupplyDmg.ShowDialog();
        }
    }
}
