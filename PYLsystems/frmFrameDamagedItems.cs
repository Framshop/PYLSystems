using MySql.Data.MySqlClient;
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
    public partial class frmFrameDamagedItems : Form
    {
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";

        int frameItemID;
        int quantityLeft;
        String frameName;
        String frameDimension;
        double salesPrice;
        DataTable dtDamagedFrames;
        DateTime DateStart;
        DateTime DateEnd;
        //--------------Initial Load--------------
        //----for programming initializer

        public frmFrameDamagedItems()
        {
            InitializeComponent();
        }
        public frmFrameDamagedItems(int frameItemID, int quantityLeft, String frameName,String frameDimension, double salesPrice)
        {
            InitializeComponent();
            this.frameItemID = frameItemID;
            this.quantityLeft = quantityLeft;
            this.frameName = frameName;
            this.frameDimension = frameDimension;
            this.salesPrice = salesPrice;
        }
        private void frmFrameDamagedItems_Load(object sender, EventArgs e)
        {
            DefaultDatesInitializer();
            frmDetailsLoader();
            frmFrameDamagedItems_Loader();
            startDatePicker.Enabled = true;
            endDatePicker.Enabled = true;
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void DefaultDatesInitializer()
        {
            DateStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddHours(0).AddMinutes(0).AddSeconds(0);
            DateEnd = DateStart.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            startDatePicker.Value = DateStart;
            endDatePicker.Value = DateEnd;
        }
        private void frmDetailsLoader()
        {
            txtBoxFrameName.Text = frameName;
            txtBoxDimension.Text = frameDimension;
            estimateQuantityLeft();
            damageCostCalculate();
        }
        private void frmFrameDamagedItems_Loader()
        {
            try
            {
                String stringDamageFrameRecord =
                    "SELECT damagedItemsID, frameItemID, dateCreated AS `Date Stocked Out`,Quantity,totalCostStockedOut AS `Damage Cost` " +
                    "FROM damaged_items " +
                    "WHERE frameItemID = @frameItemId AND (dateCreated BETWEEN @DateStart AND @DateEnd); ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdDmgFrameRecord = new MySqlCommand(stringDamageFrameRecord, my_conn);
                cmdDmgFrameRecord.Parameters.AddWithValue("@frameItemId", this.frameItemID);
                cmdDmgFrameRecord.Parameters.AddWithValue("@DateStart", DateStart.ToString("yyyy-MM-dd hh:mm:ss"));
                cmdDmgFrameRecord.Parameters.AddWithValue("@DateEnd", DateEnd.ToString("yyyy-MM-dd hh:mm:ss"));
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdDmgFrameRecord);


                dtDamagedFrames = new DataTable();
                my_adapter.Fill(dtDamagedFrames);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridFrameStockOut.DataSource = null;
            datagridFrameStockOut.DataSource = dtDamagedFrames;
            datagridFrameStockOut.Columns["frameItemID"].Visible = false;
            datagridFrameStockOut.Columns["damagedItemsID"].Visible = false;
            datagridFrameStockOut.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
        private void damageCostCalculate()
        {
            int quantityInput = 0;
            double damageCost = 0;
            if (String.IsNullOrEmpty(txtBoxQuantity.Text))
            {
                quantityInput = 0;
            }
            else
            {
                quantityInput = Int32.Parse(txtBoxQuantity.Text);
            }
            damageCost = salesPrice * quantityInput;

            txtTotalDamageCost.Text = damageCost.ToString();
        }
        private void estimateQuantityLeft()
        {
            int quantityInput = 0;
            int estimateLeft = 0;
            if (String.IsNullOrEmpty(txtBoxQuantity.Text))
            {
                quantityInput = 0;
            }
            else
            {
                quantityInput = Int32.Parse(txtBoxQuantity.Text);
            }
            estimateLeft = this.quantityLeft - quantityInput;
            txtBoxQuantityLeft.Text = estimateLeft.ToString();
        }
        private void sendToDataBase()
        {
            try
            {
                String stringInsertIntoDamageFrames = "INSERT INTO damaged_items (frameItemID,damageReason,quantity, dateCreated, totalCostStockedOut) " +
                    "VALUES(@frameItemID, @description, @quantity, curdate(), @cost); ";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdInsertIntoDamageFrames = new MySqlCommand(stringInsertIntoDamageFrames, my_conn);
                cmdInsertIntoDamageFrames.Parameters.AddWithValue("@frameItemID", this.frameItemID);
                cmdInsertIntoDamageFrames.Parameters.AddWithValue("@description", this.txtBoxDescription.Text);
                cmdInsertIntoDamageFrames.Parameters.AddWithValue("@quantity", Int32.Parse(this.txtBoxQuantity.Text));
                cmdInsertIntoDamageFrames.Parameters.AddWithValue("@cost", Double.Parse(this.txtTotalDamageCost.Text));


                my_conn.Open();
                cmdInsertIntoDamageFrames.ExecuteNonQuery();
                my_conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            MessageBox.Show("Frame Stocked Out.");
            frmFrameDamagedItems_Loader();
            txtBoxQuantity.Text = "0";
            txtTotalDamageCost.Text = "";
            txtBoxDescription.Text = "";
            quantityLeft = Int32.Parse(txtBoxQuantityLeft.Text);
            damageCostCalculate();
        }
        //----------------Event Methods-----------------
        private void btnStockOutItem_Click(object sender, EventArgs e)
        {
            int validation=0;
            if (String.IsNullOrEmpty(txtBoxQuantity.Text)||Int32.Parse(txtBoxQuantity.Text)==0)
            {
                MessageBox.Show("Please Enter a Value.");
                validation++;
            }
            if (Int32.Parse(txtBoxQuantityLeft.Text)<0)
            {
                MessageBox.Show("Cannot Stock Out more than the number of frames left.");
                validation++;
            }
            if (String.IsNullOrEmpty(txtBoxDescription.Text))
            {
                MessageBox.Show("Please enter a desciption");
                validation++;
            }
            if (validation > 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Confirm Stock Out?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sendToDataBase();
            }
            else
            {
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            damageCostCalculate();
            estimateQuantityLeft();
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDatePicker.Enabled)
            {
                DateStart = startDatePicker.Value;
                frmFrameDamagedItems_Loader();
            }
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (endDatePicker.Enabled)
            {
                DateEnd = endDatePicker.Value;
                frmFrameDamagedItems_Loader();
            }
        }

    }
}
