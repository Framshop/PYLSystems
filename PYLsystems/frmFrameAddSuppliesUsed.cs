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
    public partial class frmFrameAddSuppliesUsed : Form
    {
        private int employeeId;
        private int employeeStatus;
        private int frameItemId;
        private int jobOrderID;
        frmFrameEdit pFrmFrameEdit;
        frmFrameCreate pFrmFrameCreate;
        frmJobOrderCreate pFrmJobOrderCreate;
        frmJobOrderEdit pFrmJobOrderEdit;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        DataTable dtSuppliesList;
        DataTable dtSuppliesListView;
        //--------------Initial Load--------------
        //----for programming initializer
        //NOTE!!!! GET DATA FROM dtSuppliesList TO PASS THROUGH PARENT FORM
        public frmFrameAddSuppliesUsed(frmFrameEdit pFrmFrameEdit, int frameItemId)
        {
            InitializeComponent();
            this.pFrmFrameEdit = pFrmFrameEdit;
            this.frameItemId = frameItemId;
        }
        public frmFrameAddSuppliesUsed(frmFrameCreate pFrmFrameCreate)
        {
            InitializeComponent();
            this.pFrmFrameCreate = pFrmFrameCreate;
            this.frameItemId = -1;
        }
        public frmFrameAddSuppliesUsed(frmJobOrderCreate pFrmJobOrderCreate)
        {
            InitializeComponent();
            this.pFrmJobOrderCreate = pFrmJobOrderCreate;
            this.jobOrderID = -1;
        }
        public frmFrameAddSuppliesUsed(frmJobOrderEdit pFrmJobOrderEdit,int jobOrderID)
        {
            InitializeComponent();
            this.pFrmJobOrderEdit = pFrmJobOrderEdit;
            this.jobOrderID = jobOrderID;
        }
        private void frmFrameAddSuppliesUsed_Load(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed_Loader();
            
            selectedItemLoader();
           
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmFrameAddSuppliesUsed_Loader()
        {
            //FOR VIEWING PURPOSES
            try
            {
                String stringSuppliesList =
                    "SELECT sui.supply_ItemsId, sui.supplyName AS `Supply Name`, sui.supplyDescription AS `Description`, " +
                    "suc.categoryName AS `Category`, if(suc.typeOfMeasure='Area',concat(sui.measureA,' x ',sui.measureB),sui.measureA) AS `Base Measurements`, " +
                    "sui.unitMeasure AS `Base Unit Measure`,  sui.unitPurchasePrice AS `Cost per Unit`, suc.typeOfMeasure, " +
                    "sui.MeasureA AS `measureAOG`,sui.MeasureB AS `measureBOG` " +
                    "FROM supply_Items AS sui " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID ORDER BY suc.categoryName, sui.supplyName; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSuppliesListView = new DataTable();
                my_adapter.Fill(dtSuppliesListView);
                datagridSuppliesList.DataSource = dtSuppliesListView;
                datagridSuppliesList.Columns["supply_ItemsId"].Visible = false;
                datagridSuppliesList.Columns["typeOfMeasure"].Visible = false;
                datagridSuppliesList.Columns["measureAOG"].Visible = false;
                datagridSuppliesList.Columns["measureBOG"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridSuppliesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
            //String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)
            cboAreaUnit.SelectedIndex = 1;
            cboLengthUnit.SelectedIndex = 1;
            cboVolumeUnit.SelectedIndex = 0;
            cboWeightUnit.SelectedIndex = 0;
            cboWholeUnit.SelectedIndex = 0;


        }
        private void selectedItemLoader()
        {
            try
            {

                int currRowIndex = datagridSuppliesList.SelectedRows[0].Index;
                txtBoxCategory.Text = datagridSuppliesList.Rows[currRowIndex].Cells["Category"].Value.ToString();
                txtBoxSupplyName.Text = datagridSuppliesList.Rows[currRowIndex].Cells["Supply Name"].Value.ToString();
                txtBoxTypeOfM.Text = datagridSuppliesList.Rows[currRowIndex].Cells["typeOfMeasure"].Value.ToString();
                txtBoxLength.Text = "";
                txtBoxAreaLength.Text = "";
                txtBoxAreaWidth.Text = "";
                txtBoxVolume.Text = "";
                txtBoxWhole.Text = "";
                txtBoxWeight.Text = "";
                if (String.Equals(txtBoxTypeOfM.Text, "Length"))
                {
                    txtBoxLength.Enabled = true;
                    cboLengthUnit.Enabled = true;

                    txtBoxAreaLength.Enabled = false;
                    txtBoxAreaWidth.Enabled = false;
                    cboAreaUnit.Enabled = false;

                    txtBoxWeight.Enabled = false;
                    cboWeightUnit.Enabled = false;

                    txtBoxWhole.Enabled = false;
                    cboWholeUnit.Enabled = false;

                    txtBoxVolume.Enabled = false;
                    cboVolumeUnit.Enabled = false;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Area"))
                {
                    txtBoxLength.Enabled = false;
                    cboLengthUnit.Enabled = false;

                    txtBoxAreaLength.Enabled = true;
                    txtBoxAreaWidth.Enabled = true;
                    cboAreaUnit.Enabled = true;

                    txtBoxWeight.Enabled = false;
                    cboWeightUnit.Enabled = false;

                    txtBoxWhole.Enabled = false;
                    cboWholeUnit.Enabled = false;

                    txtBoxVolume.Enabled = false;
                    cboVolumeUnit.Enabled = false;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Weight"))
                {
                    txtBoxLength.Enabled = false;
                    cboLengthUnit.Enabled = false;

                    txtBoxAreaLength.Enabled = false;
                    txtBoxAreaWidth.Enabled = false;
                    cboAreaUnit.Enabled = false;

                    txtBoxWeight.Enabled = true;
                    cboWeightUnit.Enabled = true;

                    txtBoxWhole.Enabled = false;
                    cboWholeUnit.Enabled = false;

                    txtBoxVolume.Enabled = false;
                    cboVolumeUnit.Enabled = false;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Whole"))
                {
                    txtBoxLength.Enabled = false;
                    cboLengthUnit.Enabled = false;

                    txtBoxAreaLength.Enabled = false;
                    txtBoxAreaWidth.Enabled = false;
                    cboAreaUnit.Enabled = false;

                    txtBoxWeight.Enabled = false;
                    cboWeightUnit.Enabled = false;

                    txtBoxWhole.Enabled = true;
                    cboWholeUnit.Enabled = false;

                    txtBoxVolume.Enabled = false;
                    cboVolumeUnit.Enabled = false;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Volume"))
                {
                    txtBoxLength.Enabled = false;
                    cboLengthUnit.Enabled = false;

                    txtBoxAreaLength.Enabled = false;
                    txtBoxAreaWidth.Enabled = false;
                    cboAreaUnit.Enabled = false;

                    txtBoxWeight.Enabled = false;
                    cboWeightUnit.Enabled = false;

                    txtBoxWhole.Enabled = false;
                    cboWholeUnit.Enabled = false;

                    txtBoxVolume.Enabled = true;
                    cboVolumeUnit.Enabled = true;
                }
            }
            catch { }
        }
        private void sendToParentForm()
        {
            //supply_ItemsId, Supply Name, Description, Category, Base Measurements, Base Unit Measure, Cost per Unit, typeOfMeasure, measureAOG, measureBOG
            int currRowIndex = datagridSuppliesList.SelectedRows[0].Index;
            int frameItemId =-1;
            int jobOrderID = -1;
            int supplyItemsId = Int32.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["supply_ItemsId"].Value.ToString());

            double measureAUsed=-1;
            double measureBUsed=-1;
            String unitMeasureUsed = datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString();
            String unitMeasure_OG = datagridSuppliesList.Rows[currRowIndex].Cells["Base Unit Measure"].Value.ToString();
            String typeOfMeasure = txtBoxTypeOfM.Text;
            String supplyName = txtBoxSupplyName.Text;
            double unitPriceOG = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["Cost per Unit"].Value.ToString());
            double measureA_OG = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["measureAOG"].Value.ToString());
            double measureB_OG = -1;

            
            String category = txtBoxCategory.Text;

            if (this.frameItemId>-1)
            {
                frameItemId = this.frameItemId;
            }
            if (this.jobOrderID > -1)
            {
                jobOrderID = this.jobOrderID;
            }
            if (String.Equals(typeOfMeasure, "Area"))
            {
                measureAUsed = Double.Parse(txtBoxAreaLength.Text);
                measureBUsed = Double.Parse(txtBoxAreaWidth.Text);
                measureB_OG = Double.Parse(datagridSuppliesList.Rows[currRowIndex].Cells["measureBOG"].Value.ToString());
                unitMeasureUsed = cboAreaUnit.Text;
            }
            else
            {
                if (String.Equals(typeOfMeasure, "Length"))
                {
                    measureAUsed = Double.Parse(txtBoxLength.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboLengthUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Weight"))
                {
                    measureAUsed = Double.Parse(txtBoxWeight.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboWeightUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Volume"))
                {
                    measureAUsed = Double.Parse(txtBoxVolume.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboVolumeUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Whole"))
                {
                    measureAUsed = Double.Parse(txtBoxWhole.Text);
                    measureBUsed = -1;
                    unitMeasureUsed = cboWholeUnit.Text;
                }
            }

            //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
            //String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)

            forAddEditSupplies addEditSuppliesVals = new forAddEditSupplies(frameItemId,supplyItemsId,measureAUsed,measureBUsed,unitMeasureUsed,unitMeasure_OG,
                typeOfMeasure,supplyName,unitPriceOG,measureA_OG,measureB_OG,category);
            if (pFrmJobOrderEdit != null || pFrmJobOrderCreate != null)
            {
                addEditSuppliesVals = new forAddEditSupplies(jobOrderID, supplyItemsId, measureAUsed, measureBUsed, unitMeasureUsed, unitMeasure_OG,
                typeOfMeasure, supplyName, unitPriceOG, measureA_OG, measureB_OG, category);
            }

            if (pFrmFrameCreate != null)
            {
                pFrmFrameCreate.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            else if (pFrmFrameEdit!=null)
            {
                pFrmFrameEdit.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            else if (pFrmJobOrderCreate != null)
            {
                pFrmJobOrderCreate.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            else if (pFrmJobOrderEdit != null)
            {
                pFrmJobOrderEdit.checkIfExistsBeforeCalc(addEditSuppliesVals);
            }
            this.Close();
        }
        //----------------Event Methods-----------------

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datagridSuppliesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItemLoader();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String stringSuppliesList =
                    "SELECT sui.supply_ItemsId, sui.supplyName AS `Supply Name`, sui.supplyDescription AS `Description`, " +
                    "suc.categoryName AS `Category`, if(suc.typeOfMeasure='Area',concat(sui.measureA,' x ',sui.measureB),sui.measureA) AS `Base Measurements`, " +
                    "sui.unitMeasure AS `Base Unit Measure`,  sui.unitPurchasePrice AS `Cost per Unit`, suc.typeOfMeasure, " +
                    "sui.MeasureA AS `measureAOG`,sui.MeasureB AS `measureBOG` " +
                    "FROM supply_Items AS sui " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE sui.supplyName LIKE @txtSearch OR suc.categoryName LIKE @txtSearch " +
                    "ORDER BY suc.categoryName, sui.supplyName;";
                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                cmdSuppliesSelect.Parameters.AddWithValue("@txtSearch", "%"+txtSearch.Text+"%");
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSuppliesListView = new DataTable();
                my_adapter.Fill(dtSuppliesListView);
                datagridSuppliesList.DataSource = dtSuppliesListView;
                datagridSuppliesList.Columns["supply_ItemsId"].Visible = false;
                datagridSuppliesList.Columns["typeOfMeasure"].Visible = false;
                datagridSuppliesList.Columns["measureAOG"].Visible = false;
                datagridSuppliesList.Columns["measureBOG"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            datagridSuppliesList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (String.Equals(txtBoxTypeOfM.Text, "Area")&&(String.IsNullOrEmpty(txtBoxAreaLength.Text)|| String.IsNullOrEmpty(txtBoxAreaWidth.Text)))
            {
                MessageBox.Show("Please Enter the Values");
                return;
            }
            else
            {
                if (String.Equals(txtBoxTypeOfM.Text, "Length") && String.IsNullOrEmpty(txtBoxLength.Text))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Weight") && String.IsNullOrEmpty(txtBoxWeight.Text))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Volume") && String.IsNullOrEmpty(txtBoxVolume.Text))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
                else if (String.Equals(txtBoxTypeOfM.Text, "Whole") && String.IsNullOrEmpty(txtBoxWhole.Text))
                {
                    MessageBox.Show("Please Enter a Value");
                    return;
                }
            }
            sendToParentForm();
            
        }

        private void txtBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxAreaLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxAreaWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxWhole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtBoxVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
