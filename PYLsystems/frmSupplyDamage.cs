using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UnitsNet;

namespace PYLsystems
{
    public partial class frmSupplyDamage : Form
    {
        MySqlConnection myConn = new MySqlConnection("Server=localhost;Database=frameshopdb;Uid=root;Pwd=root");
        public class Global
        {
            public static string supply_purchase_price;
            public static string supply_category_typeOfMeasure;
            public static string supply_itemsID;
            public static string measureAOG;
            public static string measureBOG;
            public static string quantity_left;
            public static bool trueFalseConverter = true;

        }
        public frmSupplyDamage()
        {
            InitializeComponent();
        }

        private void lblDamageReason_Click(object sender, EventArgs e)
        {

        }

        private void cboLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }
        public void RefreshStockOutRecord()
        {
            string myQuery = "SELECT d_m.damaged_materialsID,s_i.supplyName as 'Supply Name',s_c.categoryName as 'Supply Category',d_m.unitMeasure 'Measurement',d_m.totalQuantityStockedOut 'Quantity Stocked Out',d_m.date_created as 'Date Stocked Out',IFNULL(d_m.date_modified,'N / A') as 'Date Modified',s_i.unitPurchasePrice * totalQuantityStockedOut as 'Cost of Stock Out' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_i.supply_itemsID = " + Global.supply_itemsID;
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgvStockOut.DataSource = myDt;
            dgvStockOut.Columns["damaged_materialsID"].Visible = false;
  
        }
        private void costingCalculate()
        {
           
            //unit category of measure for original get in textbox hidden get from supply items
            String unitOfMeasure_Used = "";
            //unit measure for original get in textbox
            String unitOfMeasure_OG = txtUnitMeasure.Text;
            //unit purchase price of supply item
            double unitPriceOG = Double.Parse(Global.supply_purchase_price);

            if (Global.supply_category_typeOfMeasure == "Whole")
            {
                unitOfMeasure_Used = cboWhole.Text;
                //unit measure for original get in textbox
                unitOfMeasure_OG = txtUnitMeasure.Text;
                //unit purchase price of supply item
                unitPriceOG = Double.Parse(Global.supply_purchase_price);
            }
             else if (Global.supply_category_typeOfMeasure == "Weight")
            {
   
                unitOfMeasure_Used = cboWeight.Text;
                //unit measure for original get in textbox
                unitOfMeasure_OG = txtUnitMeasure.Text;
                //unit purchase price of supply item
                unitPriceOG = Double.Parse(Global.supply_purchase_price);
            }
            else if (Global.supply_category_typeOfMeasure == "Volume")
            {

                unitOfMeasure_Used = cboVolume.Text;
                //unit measure for original get in textbox
                unitOfMeasure_OG = txtUnitMeasure.Text;
                //unit purchase price of supply item
                unitPriceOG = Double.Parse(Global.supply_purchase_price);
            }
            else if (Global.supply_category_typeOfMeasure == "Area")
            {
          
                unitOfMeasure_Used = cboArea.Text;
                //unit measure for original get in textbox
                unitOfMeasure_OG = txtUnitMeasure.Text;
                //unit purchase price of supply item
                unitPriceOG = Double.Parse(Global.supply_purchase_price);
            }
            else if (Global.supply_category_typeOfMeasure == "Length")
            {
  
                unitOfMeasure_Used = cboLength.Text;
                //unit measure for original get in textbox
                unitOfMeasure_OG = txtUnitMeasure.Text;
                //unit purchase price of supply item
                unitPriceOG = Double.Parse(Global.supply_purchase_price);
            }
            //WHOLE
            if (String.Equals(Global.supply_category_typeOfMeasure, "Whole"))
            {
                if (txtWhole.Text == "")
                {
                    txtWhole.Text = "0";
                }
       
                    double measureA = Double.Parse(txtWhole.Text);
                    double rawCost = measureA * unitPriceOG;

                    txtTotalDamageCost.Text = rawCost.ToString();

                    txtCalculatedStockedQuantity.Text = txtWhole.Text;    
            }

            else if (String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
            {
                // AREA
                if (String.Equals(Global.supply_category_typeOfMeasure, "Area"))
                {
                   
                    if (txtArea1.Text == "" || txtArea2.Text == "")
                    {
                        txtArea1.Text = "0";
                        txtArea2.Text = "0";
                    }
                
                        double measureA_OG = Double.Parse(Global.measureAOG);
                        double measureB_OG = Double.Parse(Global.measureBOG);
                        double area_OG = measureA_OG * measureB_OG;
                        double trueUnitPrice = unitPriceOG / area_OG;
                        double measureAUsed = Double.Parse(txtArea1.Text);
                        double measureBUsed = Double.Parse(txtArea2.Text);
                        double areaOfUsed = Double.Parse(txtArea1.Text) * Double.Parse(txtArea2.Text);
                        double rawCost = areaOfUsed * trueUnitPrice;

                    measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboArea.Text);
                    measureBUsed = measureConverter(measureBUsed, txtUnitMeasure.Text, cboArea.Text);
                    txtTotalDamageCost.Text = rawCost.ToString();
                    double qLeft = double.Parse(Global.quantity_left);
                    double qLeftInMeasure = area_OG * double.Parse(Global.quantity_left);
                    txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (areaOfUsed / qLeftInMeasure)) * qLeft)).ToString();
                }
                else
                {
                    
                    // LENGTH WEIGHT VOLUME
                    double measureA_OG = Double.Parse(Global.measureAOG);
                    double trueUnitPrice = unitPriceOG / measureA_OG;
                    double rawCostPasser = 0;
                    if (String.Equals(Global.supply_category_typeOfMeasure,"Volume") && String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {
                        if (txtVolume.Text == "")
                        {
                            txtVolume.Text = "0";
                        }
                    
                            double measureAUsed = double.Parse(txtVolume.Text);
                            measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboVolume.Text, 1);
                            double rawCost = measureAUsed * trueUnitPrice;
                            rawCostPasser = rawCost;
                            txtTotalDamageCost.Text = rawCostPasser.ToString();
                        double qLeft = double.Parse(Global.quantity_left);
                        double qLeftInMeasure = double.Parse(Global.measureAOG) * double.Parse(Global.quantity_left);
                        txtCalculatedStockedQuantity.Text = (qLeft-((1-(measureAUsed/qLeftInMeasure))*qLeft)).ToString();

                    }
                     else if (String.Equals(Global.supply_category_typeOfMeasure, "Length") && String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {
                        if (txtLength.Text == "")
                        {
                            txtLength.Text = "0";
                        }
                  
                            double measureAUsed = double.Parse(txtLength.Text);
                            measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboLength.Text);
                            double rawCost = measureAUsed * trueUnitPrice;
                            rawCostPasser = rawCost;
                            txtTotalDamageCost.Text = rawCostPasser.ToString();
                        double qLeft = double.Parse(Global.quantity_left);
                        double qLeftInMeasure = double.Parse(Global.measureAOG) * double.Parse(Global.quantity_left);
                        txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (measureAUsed / qLeftInMeasure)) * qLeft)).ToString();

                    }
                    else if (String.Equals(Global.supply_category_typeOfMeasure, "Weight") && String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {
                        if (txtWeight.Text == "")
                        {
                            txtWeight.Text = "0";
                        }
                        
                            double measureAUsed = double.Parse(txtWeight.Text);
                            measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboWeight.Text);
                            double rawCost = measureAUsed * trueUnitPrice;
                            rawCostPasser = rawCost;
                            txtTotalDamageCost.Text = rawCostPasser.ToString();
                        double qLeft = double.Parse(Global.quantity_left);
                        double qLeftInMeasure = double.Parse(Global.measureAOG) * double.Parse(Global.quantity_left);
                        txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (measureAUsed / qLeftInMeasure)) * qLeft)).ToString();
                    }


                }
            }
            else
            {

                //AREA CONVERTION
                if (String.Equals(Global.supply_category_typeOfMeasure, "Area"))
                {
                    if (txtArea1.Text == "" || txtArea2.Text == "")
                    {
                        txtArea1.Text = "0";
                        txtArea2.Text = "0";
                    }

                    double measureA_OG;
                    double trueUnitPrice;
                    measureA_OG = Double.Parse(Global.measureAOG); //Get purchase measures from Supply_Item table
                    double measureB_OG = Double.Parse(Global.measureBOG);
                    double area_OG = measureA_OG * measureB_OG; // Get area of original measures from purchase on Supply_Item table
                    trueUnitPrice = unitPriceOG / area_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement
                    double measureAConverted = Double.Parse(txtArea1.Text);
                    double measureBConverted = Double.Parse(txtArea2.Text);
                  //Calculate the area of Use of the used up converted measurements

                 //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                  
                    measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboArea.Text);
                    measureBConverted = measureConverter(measureBConverted, txtUnitMeasure.Text, cboArea.Text);
                    double areaOfUsed = measureAConverted * measureBConverted;
                    double rawCost = areaOfUsed * trueUnitPrice;
                    double area_of_OG = area_OG * double.Parse(Global.quantity_left);
                   
                    txtTotalDamageCost.Text = rawCost.ToString();
                    double calcout = double.Parse(Global.quantity_left) + ((1 - (areaOfUsed / (area_of_OG))) * double.Parse(Global.quantity_left));
                    double qLeft = double.Parse(Global.quantity_left);
                    double qLeftInMeasure = area_OG * double.Parse(Global.quantity_left);
                    txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (areaOfUsed / qLeftInMeasure)) * qLeft)).ToString();
                    
       
                }
                else
                {
                 
                    double measureA_OG;
                    double trueUnitPrice;
                    //LENGTH WEIGHT VOLUME CONVERTION
                    measureA_OG = Double.Parse(Global.measureAOG); 
                    trueUnitPrice = unitPriceOG / measureA_OG;
                    try
                    {
                        
                        if (String.Equals(Global.supply_category_typeOfMeasure, "Volume"))
                        {
                            double measureAConverted = Double.Parse(txtVolume.Text);
                            measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboVolume.Text, 1);
                            double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            txtTotalDamageCost.Text = rawCost.ToString();

                            double qLeft = double.Parse(Global.quantity_left);
                            double qLeftInMeasure = double.Parse(Global.measureAOG) * double.Parse(Global.quantity_left);
                            txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (measureAConverted / qLeftInMeasure)) * qLeft)).ToString();

                            // txtCalculatedStockedQuantity.Text = (double.Parse(Global.quantity_left) - ((1 - (measureAUsed / measureA_OG))) * double.Parse(Global.quantity_left))).ToString();
                        }
                        if (String.Equals(Global.supply_category_typeOfMeasure, "Weight"))
                        {
                            double measureAConverted = Double.Parse(txtWeight.Text);
                            measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboWeight.Text);
                            double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            txtTotalDamageCost.Text = rawCost.ToString();
                            double qLeft = double.Parse(Global.quantity_left);
                            double qLeftInMeasure = double.Parse(Global.measureAOG) * double.Parse(Global.quantity_left);
                            txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (measureAConverted / qLeftInMeasure)) * qLeft)).ToString();

                        }
                        if (String.Equals(Global.supply_category_typeOfMeasure, "Length"))
                        {
                            
                            double measureAConverted = Double.Parse(txtLength.Text);
                            measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboLength.Text);


                            double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            txtTotalDamageCost.Text = rawCost.ToString();
                            double qLeft = double.Parse(Global.quantity_left);
                            double qLeftInMeasure = double.Parse(Global.measureAOG) * double.Parse(Global.quantity_left);
                            txtCalculatedStockedQuantity.Text = (qLeft - ((1 - (measureAConverted / qLeftInMeasure)) * qLeft)).ToString();

                        }
                    }
                    catch { }
                }
            }
        }

        private double measureConverter(double measure_forCvt, String unitOfMeasure_OG, String unitOfMeasure_Used)
        {
           
            double measureConverted = 0;
            Length measureLength = Length.FromMeters(1);
            Mass measureMass = Mass.FromGrams(1);

            //Initialize
            if (String.Equals(unitOfMeasure_Used, "feet"))
            {
                measureLength = Length.FromFeet(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "meters"))
            {
                measureLength = Length.FromMeters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "centimeters"))
            {
                measureLength = Length.FromCentimeters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "millimeters"))
            {
                measureLength = Length.FromMillimeters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "inches"))
            {
                measureLength = Length.FromInches(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "ounces"))
            {
                measureMass = Mass.FromOunces(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "gram/s"))
            {
                measureMass = Mass.FromGrams(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "kilogram/s"))
            {
                measureMass = Mass.FromKilograms(measure_forCvt);
            }

            //Convert
            if (String.Equals(unitOfMeasure_OG, "feet"))
            {
                measureConverted = measureLength.Feet;
            }
            else if (String.Equals(unitOfMeasure_OG, "meters"))
            {
                measureConverted = measureLength.Meters;
            }
            else if (String.Equals(unitOfMeasure_OG, "centimeters"))
            {
                measureConverted = measureLength.Centimeters;
            }
            else if (String.Equals(unitOfMeasure_OG, "millimeters"))
            {
                measureConverted = measureLength.Millimeters;
            }
            else if (String.Equals(unitOfMeasure_OG, "inches"))
            {
                measureConverted = measureLength.Inches; ;
            }
            else if (String.Equals(unitOfMeasure_OG, "ounces"))
            {
                measureConverted = measureMass.Ounces;
            }
            else if (String.Equals(unitOfMeasure_OG, "gram/s"))
            {
                measureConverted = measureMass.Grams;
            }
            else if (String.Equals(unitOfMeasure_OG, "kilogram/s"))
            {
                measureConverted = measureMass.Kilograms;
            }
            return measureConverted;
        }
        private double measureConverter(double measure_forCvt, String unitOfMeasure_OG, String unitOfMeasure_Used, int overload)
        {
            double measureConverted = 0;
            Volume measureVolume = Volume.FromLiters(1);

            if (String.Equals(unitOfMeasure_Used, "ounces"))
            {
                measureVolume = Volume.FromUsOunces(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "liters"))
            {
                measureVolume = Volume.FromLiters(measure_forCvt);
            }
            else if (String.Equals(unitOfMeasure_Used, "milliliters"))
            {
                measureVolume = Volume.FromMilliliters(measure_forCvt);
            }

            if (String.Equals(unitOfMeasure_OG, "ounces"))
            {
                measureConverted = measureVolume.UsOunces;
            }
            else if (String.Equals(unitOfMeasure_OG, "liters"))
            {
                measureConverted = measureVolume.Liters;
            }
            else if (String.Equals(unitOfMeasure_OG, "milliliters"))
            {
                measureConverted = measureVolume.Milliliters;
            }
            return measureConverted;
        }

        private void frmSupplyDamage_Load(object sender, EventArgs e)
        {
            RefreshStockOutRecord();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void txtArea1_TextChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void txtArea2_TextChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void txtWhole_TextChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void cboWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void cboVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            costingCalculate();
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            string myQuery = "SELECT d_m.damaged_materialsID,s_i.supplyName as 'Supply Name',s_c.categoryName as 'Supply Category',d_m.unitMeasure 'Measurement',d_m.totalQuantityStockedOut 'Quantity Stocked Out',d_m.date_created as 'Date Stocked Out',IFNULL(d_m.date_modified,'N / A') as 'Date Modified',s_i.unitPurchasePrice * totalQuantityStockedOut as 'Cost of Stock Out' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_i.supply_itemsID = " + Global.supply_itemsID + " AND date_created BETWEEN '" + startDatePicker.Value.ToString("yyyy-MM-dd") + "' AND '" + endDatePicker.Value.ToString("yyyy-MM-dd") + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgvStockOut.DataSource = myDt;
            dgvStockOut.Columns["damaged_materialsID"].Visible = false;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            string myQuery = "SELECT d_m.damaged_materialsID,s_i.supplyName as 'Supply Name',s_c.categoryName as 'Supply Category',d_m.unitMeasure 'Measurement',d_m.totalQuantityStockedOut 'Quantity Stocked Out',d_m.date_created as 'Date Stocked Out',IFNULL(d_m.date_modified,'N / A') as 'Date Modified',s_i.unitPurchasePrice * totalQuantityStockedOut as 'Cost of Stock Out' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_i.supply_itemsID = " + Global.supply_itemsID + " AND date_created BETWEEN '" + startDatePicker.Value.ToString("yyyy-MM-dd") + "' AND '" + endDatePicker.Value.ToString("yyyy-MM-dd") + "'";
            MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
            MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
            DataTable myDt = new DataTable();
            myAdp.Fill(myDt);
            dgvStockOut.DataSource = myDt;
             dgvStockOut.Columns["damaged_materialsID"].Visible = false;
        }
        public void enableStockOutItem()
        {
            int description = txtDamageReason.TextLength;
            if (description > 0 && float.Parse(txtCalculatedStockedQuantity.Text) > 0 && float.Parse(txtTotalDamageCost.Text) > 0)
            {
                btnStockOutItem.Enabled = true;
            }
            else
            {
                btnStockOutItem.Enabled = false;
            }
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArea2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtArea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWhole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnStockOutItem_Click(object sender, EventArgs e)
        {
            if (double.Parse(Global.quantity_left) >= double.Parse(txtCalculatedStockedQuantity.Text))
            {
                if (String.Equals(Global.supply_category_typeOfMeasure, "Area"))
                {
                    string myQuery = "INSERT INTO damaged_materials(description,supply_itemsID,measureADeducted,measureBDeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure,measureAtoOGUnit,measureBtoOGUnit,date_created) VALUES('" + txtDamageReason.Text + "'," + Global.supply_itemsID + "," + txtArea1.Text + "," + txtArea2.Text + "," + txtCalculatedStockedQuantity.Text + "," + txtTotalDamageCost.Text + ",'" + cboArea.Text + "'," + Global.measureAOG + "," + Global.measureBOG + ",NOW())";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    MessageBox.Show("Insert Successful!");
                    cboArea.SelectedIndex = -1;
                    txtArea1.Text = "0";
                    txtArea2.Text = "0";
                }
               else if (String.Equals(Global.supply_category_typeOfMeasure, "Volume"))
                {
                    string myQuery = "INSERT INTO damaged_materials(description,supply_itemsID,measureADeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure,measureAtoOGUni,date_created) VALUES('" + txtDamageReason.Text + "'," + Global.supply_itemsID + "," + txtVolume.Text +  "," + txtCalculatedStockedQuantity.Text + "," + txtTotalDamageCost.Text + ",'" + cboVolume.Text + "'," + Global.measureAOG + ",NOW())";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    MessageBox.Show("Insert Successful!");
                    cboVolume.SelectedIndex = -1;
                    txtVolume.Text = "0";
                }
               else if (String.Equals(Global.supply_category_typeOfMeasure, "Weight"))
                {
                    string myQuery = "INSERT INTO damaged_materials(description,supply_itemsID,measureADeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure,measureAtoOGUnit,date_created) VALUES('" + txtDamageReason.Text + "'," + Global.supply_itemsID + "," + txtWeight.Text + ","  + txtCalculatedStockedQuantity.Text + "," + txtTotalDamageCost.Text + ",'" + cboWeight.Text + "'," + Global.measureAOG + ",NOW())";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    MessageBox.Show("Insert Successful!");
                    cboWeight.SelectedIndex = -1;
                    txtWeight.Text = "0";
                }
               else if (String.Equals(Global.supply_category_typeOfMeasure, "Length"))
                {
                    string myQuery = "INSERT INTO damaged_materials(description,supply_itemsID,measureADeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure,measureAtoOGUnit,date_created) VALUES('" + txtDamageReason.Text + "'," + Global.supply_itemsID + "," + txtLength.Text + ","  + txtCalculatedStockedQuantity.Text + "," + txtTotalDamageCost.Text + ",'" + cboLength.Text + "'," + Global.measureAOG + ",NOW())";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    myAdp.Fill(myDt);
                    MessageBox.Show("Insert Successful!");
                    cboLength.SelectedIndex = -1;
                    txtLength.Text = "0";
                }
                else
                {
                    string myQuery = "INSERT INTO damaged_materials(description,supply_itemsID,measureADeducted,totalQuantityStockedOut,totalCostStockedOut,unitMeasure,measureAtoOGUnit,date_created) VALUES('" + txtDamageReason.Text + "'," + Global.supply_itemsID + "," + txtWhole.Text + ","  + txtCalculatedStockedQuantity.Text + "," + txtTotalDamageCost.Text + ",'" + cboWhole.Text + "'," + Global.measureAOG + ",NOW())";
                    MySqlCommand myComm = new MySqlCommand(myQuery, myConn);
                    MySqlDataAdapter myAdp = new MySqlDataAdapter(myComm);
                    DataTable myDt = new DataTable();
                    MessageBox.Show("Insert Successful!");
                    myAdp.Fill(myDt);
                    txtWhole.Text = "0";
                    cboWhole.SelectedIndex = -1;
                }

                myConn.Open();
                string myQuer = "SELECT s_i.supply_itemsID as 'Supply ID',s_c.supply_categoryID as 'Supply Category ID'," +
    "s_i.supplyName as 'Supply Name',s_c.categoryName as 'Category Name',s_c.typeOfMeasure as 'Type of Measure'," +
    "s_i.supplyDescription as 'Supply Description',s_i.measureA as 'Measurement A',IFNULL(s_i.measureB, 'Not Applicable') as " +
    "'Measurement B',case when s_i.measureB is not null then CONCAT(s_i.measureA,' x ',s_i.measureB) else s_i.measureA end" +
     " as 'Measurement',s_i.unitMeasure as 'Unit Measure',s_i.unitPurchasePrice as 'Purchase Price'," +
    " IF(active = 0, 'Active', 'Inactive') as 'Active',s_c.typeOfMeasure," +
     " IFNULL(IF(s_c.typeOfMeasure = 'Volume', (1 - ((IFNULL(d_m4.DamagedMaterials, 0) + IFNULL(f_m4.FrameMaterials, 0) + IFNULL(j_d4.JobOrderDetailsMaterials, 0)) / (s_d4.StockInVolume * s_i.measureA))) * (s_d4.StockInVolume), IF(s_c.typeOfMeasure = 'Weight', (1 - ((IFNULL(d_m3.DamagedMaterials, 0) + IFNULL(f_m3.FrameMaterials, 0) + IFNULL(j_d3.JobOrderDetailsMaterials, 0)) / (s_d2.StockInWeight * s_i.measureA))) * (s_d2.StockInWeight), IF(s_c.typeOfMeasure = 'Length', (1 - ((IFNULL(d_m.DamagedMaterials, 0) + IFNULL(f_m.FrameMaterials, 0) + IFNULL(j_d.JobOrderDetailsMaterials, 0)) / (s_d3.StockInLength * s_i.measureA))) * (s_d3.StockInLength), IF(s_c.typeOfMeasure = 'Area', (1 - ((IFNULL(d_m1.DamagedMaterials, 0) + IFNULL(f_m1.FrameMaterials, 0) + IFNULL(j_d1.JobOrderDetailsMaterials, 0)) / (s_d0.StockInArea * (s_i.measureA * s_i.measureB)))) * (s_d0.StockInArea), IF(s_c.typeOfMeasure = 'Whole', IFNULL(s_d1.StockInWhole, 0) - IFNULL(d_m2.DamagedMaterials, 0) + IFNULL(f_m2.FrameMaterials, 0) + IFNULL(j_d2.JobOrderDetailsMaterials, 0), 0))))), 0) as 'Quantity Left'," +
     "   IFNULL(IF(s_c.typeOfMeasure = 'Volume',(s_i.measureA * s_d4.StockInVolume) - IFNULL(d_m4.DamagedMaterials, 0)+ IFNULL(f_m4.FrameMaterials, 0) + IFNULL(j_d4.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Weight', (s_i.measureA * s_d2.StockInWeight) - IFNULL(d_m3.DamagedMaterials, 0)+ IFNULL(f_m3.FrameMaterials, 0) + IFNULL(j_d3.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Length',(s_i.measureA * s_d3.StockInLength) - IFNULL(d_m.DamagedMaterials, 0)+ IFNULL(f_m.FrameMaterials, 0) + IFNULL(j_d.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Area', ((s_i.measureA * s_i.measureB) * s_d0.StockInArea) - IFNULL(d_m1.DamagedMaterials, 0)+ IFNULL(f_m1.FrameMaterials, 0) + IFNULL(j_d1.JobOrderDetailsMaterials, 0), IF(s_c.typeOfMeasure = 'Whole',s_i.measureA * s_d1.StockInWhole -  IFNULL(d_m2.DamagedMaterials, 0)+ IFNULL(f_m2.FrameMaterials, 0) + IFNULL(j_d2.JobOrderDetailsMaterials, 0), 0))))), 0) as 'Quantity Left in Measurement' " +
     " FROM supply_items s_i" +
     " LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) " +
    " as d_m ON d_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) " +
    " as f_m ON f_m.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_i.supply_itemsID) " +
    " as j_d ON j_d.supply_itemsID = s_i.supply_itemsID" +

    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) " +
    " as d_m1 ON d_m1.supply_itemsID = s_i.supply_itemsID  LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) " +
    " as f_m1 ON f_m1.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_i.supply_itemsID) " +
    " as j_d1 ON j_d1.supply_itemsID = s_i.supply_itemsID" +


    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) " +
    " as d_m2 ON d_m2.supply_itemsID = s_i.supply_itemsID  LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) " +
    " as f_m2 ON f_m2.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_i.supply_itemsID) " +
    " as j_d2 ON j_d2.supply_itemsID = s_i.supply_itemsID" +

    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) " +
    " as d_m3 ON d_m3.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) " +
    " as f_m3 ON f_m3.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_i.supply_itemsID) " +
    " as j_d3 ON j_d3.supply_itemsID = s_i.supply_itemsID" +

    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(d_m.totalQuantityStockedOut,0)) as 'DamagedMaterials' FROM damaged_materials d_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = d_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_i.supply_itemsID) " +
    " as d_m4 ON d_m4.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(f_m.measureAtoOG,0)) as 'FrameMaterials' FROM frame_materials f_m LEFT JOIN supply_items s_i ON s_i.supply_itemsID = f_m.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_i.supply_itemsID) " +
    " as f_m4 ON f_m4.supply_itemsID = s_i.supply_itemsID LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(j_d.measureAtoOG,0)) as 'JobOrderDetailsMaterials' FROM jorder_details j_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = j_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume'GROUP BY s_i.supply_itemsID) " +
    " as j_d4 ON j_d4.supply_itemsID = s_i.supply_itemsID" +

    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInArea' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Area' GROUP BY s_d.supply_itemsID) s_d0 ON s_d0.supply_itemsID = s_i.supply_itemsID" +
    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInWhole' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Whole' GROUP BY s_d.supply_itemsID) s_d1 ON s_d1.supply_itemsID = s_i.supply_itemsID" +
    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as  'StockInWeight'FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Weight' GROUP BY s_d.supply_itemsID) s_d2 ON s_d2.supply_itemsID = s_i.supply_itemsID" +
    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInLength' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Length' GROUP BY s_d.supply_itemsID) s_d3 ON s_d3.supply_itemsID = s_i.supply_itemsID" +
    " LEFT JOIN(SELECT s_i.supply_itemsID, SUM(IFNULL(s_d.stockin_quantity,0)) as 'StockInVolume' FROM supply_details s_d LEFT JOIN supply_items s_i ON s_i.supply_itemsID = s_d.supply_itemsID LEFT JOIN supply_category s_c ON s_c.supply_categoryID = s_i.supply_categoryID WHERE s_c.typeOfMeasure = 'Volume' GROUP BY s_d.supply_itemsID) s_d4 ON s_d4.supply_itemsID = s_i.supply_itemsID  WHERE s_i.supply_itemsID = " + Global.supply_itemsID;
                MySqlCommand xmyCom = new MySqlCommand(myQuer, myConn);
                MySqlDataAdapter xmyAd = new MySqlDataAdapter(xmyCom);
                myConn.Close();
                myConn.Open();
                MySqlDataReader xmyReader;
                try
                {
                    xmyReader = xmyCom.ExecuteReader();
                    while (xmyReader.Read())
                    {
                        Global.quantity_left = xmyReader.GetString(13);
                    }
                    myConn.Close();

                }
                catch { }
                
                RefreshStockOutRecord();
                btnStockOutItem.Enabled = false;
                txtDamageReason.Text = "";
                txtTotalDamageCost.Text = "";
                txtCalculatedStockedQuantity.Text = "";
            }
            else
            {
                MessageBox.Show("The remaining stock in left in "  + txtItemName.Text + " is " + Global.quantity_left +  " less than the damage stock out which is  " + txtCalculatedStockedQuantity.Text + " ");

            }
        }

        private void txtDamageReason_TextChanged(object sender, EventArgs e)
        {
            enableStockOutItem();
        }

        private void txtCalculatedStockedQuantity_TextChanged(object sender, EventArgs e)
        {
            enableStockOutItem();
        }

        private void txtTotalDamageCost_TextChanged(object sender, EventArgs e)
        {
            enableStockOutItem();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
