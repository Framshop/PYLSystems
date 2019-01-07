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
    public partial class addSales : Form
    {
        private int sample;
        checkSales checkSalesPForm;
        DataTable addSalesDT;
        public addSales()
        {
            InitializeComponent();
        }
        public addSales(checkSales ParentForm)
        {
            InitializeComponent();
            checkSalesPForm = ParentForm;
        }

        private void addSales_Load(object sender, EventArgs e)
        {
            addSalesDT = new DataTable();
            addSalesDT.Columns.Add("Item");
            addSalesDT.Columns.Add("Dimension");
            addSalesDT.Columns.Add("Quantity");
            addSalesDT.Columns.Add("Unit Price");

            addSalesGrid.DataSource = addSalesDT;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
