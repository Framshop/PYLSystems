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
    public partial class frmFrameEditSuppliesUsed : Form
    {
        //--------------Initial Load--------------
        //----for programming initializer

        forAddEditSupplies addEditSuppliesVals;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";
        DataTable dtRemainingVals;
        frmFrameCreate pFrmFrameCreate;
        frmFrameEdit pFrmFrameEdit;
        frmJobOrderCreate pFrmJobOrderCreate;
        frmJobOrderEdit pFrmJobOrderEdit;
        int supplyItemsId;
        double measureAOG =0;
        double measureBOG=0;
        public frmFrameEditSuppliesUsed()
        {
            InitializeComponent();
        }
        public frmFrameEditSuppliesUsed(forAddEditSupplies addEditSuppliesVals, frmFrameEdit pfrmFrameEdit)
        {
            InitializeComponent();
            this.addEditSuppliesVals = addEditSuppliesVals;
            this.pFrmFrameEdit = pfrmFrameEdit;
            this.supplyItemsId = addEditSuppliesVals.supplyItemsId;
            this.measureAOG = addEditSuppliesVals.measureA_OG;
            this.measureBOG = addEditSuppliesVals.measureB_OG;
        }
        public frmFrameEditSuppliesUsed(forAddEditSupplies addEditSuppliesVals, frmFrameCreate pfrmFrameCreate)
        {
            InitializeComponent();
            this.addEditSuppliesVals = addEditSuppliesVals;
            this.pFrmFrameCreate = pfrmFrameCreate;
            this.supplyItemsId = addEditSuppliesVals.supplyItemsId;
            this.measureAOG = addEditSuppliesVals.measureA_OG;
            this.measureBOG = addEditSuppliesVals.measureB_OG;
        }
        public frmFrameEditSuppliesUsed(forAddEditSupplies addEditSuppliesVals, frmJobOrderCreate pFrmJobOrderCreate)
        {
            InitializeComponent();
            this.addEditSuppliesVals = addEditSuppliesVals;
            this.pFrmJobOrderCreate = pFrmJobOrderCreate;
            this.supplyItemsId = addEditSuppliesVals.supplyItemsId;
            this.measureAOG = addEditSuppliesVals.measureA_OG;
            this.measureBOG = addEditSuppliesVals.measureB_OG;
        }
        public frmFrameEditSuppliesUsed(forAddEditSupplies addEditSuppliesVals, frmJobOrderEdit pFrmJobOrderEdit)
        {
            InitializeComponent();
            this.addEditSuppliesVals = addEditSuppliesVals;
            this.pFrmJobOrderEdit = pFrmJobOrderEdit;
            this.supplyItemsId = addEditSuppliesVals.supplyItemsId;
            this.measureAOG = addEditSuppliesVals.measureA_OG;
            this.measureBOG = addEditSuppliesVals.measureB_OG;
        }
        private void frmFrameEditSuppliesUsed_Load(object sender, EventArgs e)
        {
            frmFrameEditSuppliesUsedLoader();
        }
        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmFrameEditSuppliesUsedLoader()
        {
            this.txtBoxCategory.Text = addEditSuppliesVals.category;
            this.txtBoxTypeOfM.Text = addEditSuppliesVals.typeOfMeasure;
            this.txtBoxSupplyName.Text = addEditSuppliesVals.supplyName;
            this.lblSupplyName.Text = addEditSuppliesVals.supplyName;
            this.lblSupplyCateg.Text = addEditSuppliesVals.category;
            this.lblSupplyCost.Text = addEditSuppliesVals.unitPriceOG.ToString();
            this.lblSupplyTypeOfM.Text = addEditSuppliesVals.typeOfMeasure;
            this.lblSupplyBaseUM.Text = addEditSuppliesVals.unitMeasure_OG;

            try
            {
                String stringSuppliesList =
                    "SELECT sui.supplyDescription " +                 
                    "FROM supply_Items AS sui " +
                    "WHERE sui.supply_itemsID = @supply_itemsID; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesList, my_conn);
                //cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                cmdSuppliesSelect.Parameters.AddWithValue("@supply_itemsID", addEditSuppliesVals.supplyItemsId);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtRemainingVals = new DataTable();
                my_adapter.Fill(dtRemainingVals);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //cboAreaUnit.SelectedIndex = 1;
            //cboLengthUnit.SelectedIndex = 1;
            //cboVolumeUnit.SelectedIndex = 0;
            //cboWeightUnit.SelectedIndex = 0;
            //cboWholeUnit.SelectedIndex = 0;
            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
            {
                lblSupplyBaseM.Text = addEditSuppliesVals.measureA_OG + " x " + addEditSuppliesVals.measureB_OG;
                cboAreaUnit.Text = addEditSuppliesVals.unitMeasureUsed;
                cboAreaUnit.Enabled = true;
                txtBoxAreaLength.Enabled = true;
                txtBoxAreaWidth.Enabled = true;
            }
            else
            {
                lblSupplyBaseM.Text = addEditSuppliesVals.measureA_OG.ToString();
            }
            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Length"))
            {
                cboLengthUnit.Text = addEditSuppliesVals.unitMeasureUsed;
                cboLengthUnit.Enabled = true;
                txtBoxLength.Enabled = true;
            }
            else if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Volume"))
            {
                cboVolumeUnit.Text = addEditSuppliesVals.unitMeasureUsed;
                cboVolumeUnit.Enabled = true;
                txtBoxVolume.Enabled = true;
            }
            else if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Weight"))
            {
                cboWeightUnit.Text = addEditSuppliesVals.unitMeasureUsed;
                cboWeightUnit.Enabled = true;
                txtBoxWeight.Enabled = true;
            }
            else if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Whole"))
            {
                cboWholeUnit.Text = addEditSuppliesVals.unitMeasureUsed;
                txtBoxWhole.Enabled = true;
            }
                lblSupplyDesc.Text = dtRemainingVals.Rows[0][0].ToString();
            //combobox defaults here.
        }
        private void updateSendDet()
        {
            forAddEditSupplies addEditSuppliesVals = new forAddEditSupplies();
            int supplyItemsId = this.supplyItemsId;

            addEditSuppliesVals.unitMeasure_OG = lblSupplyBaseUM.Text;
            String typeOfMeasure = lblSupplyTypeOfM.Text;
            addEditSuppliesVals.typeOfMeasure = lblSupplyTypeOfM.Text;
            addEditSuppliesVals.supplyName = lblSupplyName.Text;
            addEditSuppliesVals.unitPriceOG = Double.Parse(lblSupplyCost.Text);
            addEditSuppliesVals.measureA_OG = this.measureAOG;

            String category = txtBoxCategory.Text;


            if (String.Equals(typeOfMeasure, "Area"))
            {
                addEditSuppliesVals.measureAUsed = Double.Parse(txtBoxAreaLength.Text);
                addEditSuppliesVals.measureBUsed = Double.Parse(txtBoxAreaWidth.Text);
                addEditSuppliesVals.measureB_OG = this.measureBOG;
                addEditSuppliesVals.unitMeasureUsed = cboAreaUnit.Text;
            }
            else
            {
                if (String.Equals(typeOfMeasure, "Length"))
                {
                    addEditSuppliesVals.measureAUsed = Double.Parse(txtBoxLength.Text);
                    addEditSuppliesVals.measureBUsed = -1;
                    addEditSuppliesVals.unitMeasureUsed = cboLengthUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Weight"))
                {
                    addEditSuppliesVals.measureAUsed = Double.Parse(txtBoxWeight.Text);
                    addEditSuppliesVals.measureBUsed = -1;
                    addEditSuppliesVals.unitMeasureUsed = cboWeightUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Volume"))
                {
                    addEditSuppliesVals.measureAUsed = Double.Parse(txtBoxVolume.Text);
                    addEditSuppliesVals.measureBUsed = -1;
                    addEditSuppliesVals.unitMeasureUsed = cboVolumeUnit.Text;
                }
                else if (String.Equals(typeOfMeasure, "Whole"))
                {
                    addEditSuppliesVals.measureAUsed = Double.Parse(txtBoxWhole.Text);
                    addEditSuppliesVals.measureBUsed = -1;
                    addEditSuppliesVals.unitMeasureUsed = cboWholeUnit.Text;
                }
            }

            //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
            //String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)

            
            
            if (pFrmFrameCreate != null)
            {
                pFrmFrameCreate.editSuppliesSelected(addEditSuppliesVals);
            }
            else if (pFrmFrameEdit != null)
            {
                pFrmFrameEdit.editSuppliesSelected(addEditSuppliesVals);
            }
            else if (pFrmJobOrderCreate != null)
            {
                pFrmJobOrderCreate.editSuppliesSelected(addEditSuppliesVals);
            }
            else if (pFrmJobOrderEdit != null)
            {
                pFrmJobOrderEdit.editSuppliesSelected(addEditSuppliesVals);
            }
            this.Close();
        }
        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtBoxTypeOfM.Text, "Area") && (String.IsNullOrEmpty(txtBoxAreaLength.Text) || String.IsNullOrEmpty(txtBoxAreaWidth.Text)))
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
            updateSendDet();
            
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
