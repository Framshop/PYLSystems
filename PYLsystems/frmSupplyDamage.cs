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

                }
                else
                {
                    double measureA = Double.Parse(txtWhole.Text);
                    double rawCost = measureA * unitPriceOG;

                    txtTotalDamageCost.Text = rawCost.ToString();
                    txtCalculatedStockedQuantity.Text = unitPriceOG.ToString();
                }
               
            }

            else if (String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
            {
                // AREA
                if (String.Equals(Global.supply_category_typeOfMeasure, "Area"))
                {
                    if (txtArea1.Text == "" || txtArea2.Text == "")
                    {

                    }
                    else
                    {
                        double measureA_OG = Double.Parse(Global.measureAOG);
                        double measureB_OG = Double.Parse(Global.measureBOG);
                        double area_OG = measureA_OG * measureB_OG;
                        double trueUnitPrice = unitPriceOG / area_OG;
                        double measureAUsed = Double.Parse(txtArea1.Text);
                        double measureBUsed = Double.Parse(txtArea2.Text);
                        double areaOfUsed = measureAUsed * measureBUsed;
                        double rawCost = areaOfUsed * trueUnitPrice;

                        txtTotalDamageCost.Text = rawCost.ToString();
                        txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                        measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboArea.Text);
                        measureBUsed = measureConverter(measureBUsed, txtUnitMeasure.Text, cboArea.Text);
                    }
               
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

                        }
                        else
                        {
                            double measureAUsed = double.Parse(txtVolume.Text);
                            measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboVolume.Text, 1);
                            double rawCost = measureAUsed * trueUnitPrice;
                            rawCostPasser = rawCost;
                            txtTotalDamageCost.Text = rawCostPasser.ToString();
                            txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                        }
                    }
                    else if (String.Equals(Global.supply_category_typeOfMeasure, "Length") && String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {
                        if (txtLength.Text == "")
                        {

                        }
                        else
                        {
                            double measureAUsed = double.Parse(txtLength.Text);
                            measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboLength.Text);
                            double rawCost = measureAUsed * trueUnitPrice;
                            rawCostPasser = rawCost;
                            txtTotalDamageCost.Text = rawCostPasser.ToString();
                            txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                        }
                      
                    }
                    else if (String.Equals(Global.supply_category_typeOfMeasure, "Weight") && String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {
                        if (txtWeight.Text == "")
                        {

                        }
                        else
                        {
                            double measureAUsed = double.Parse(txtWeight.Text);
                            measureAUsed = measureConverter(measureAUsed, txtUnitMeasure.Text, cboWeight.Text);
                            double rawCost = measureAUsed * trueUnitPrice;
                            rawCostPasser = rawCost;
                            txtTotalDamageCost.Text = rawCostPasser.ToString();
                            txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                        }
                    }

                    else
                    {
                        //AREA CONVERTION
                        if (String.Equals(Global.supply_category_typeOfMeasure, "Area"))
                        {
                            measureA_OG = Double.Parse(Global.measureAOG); //Get purchase measures from Supply_Item table
                            double measureB_OG = Double.Parse(Global.measureBOG);
                            double area_OG = measureA_OG * measureB_OG; // Get area of original measures from purchase on Supply_Item table
                            trueUnitPrice = unitPriceOG / area_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement
                            double measureAConverted = Double.Parse(txtArea1.Text);
                            double measureBConverted = Double.Parse(txtArea2.Text);
                            double areaOfUsed = measureAConverted * measureBConverted; //Calculate the area of Use of the used up converted measurements

                            double rawCost = areaOfUsed * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            txtTotalDamageCost.Text = rawCost.ToString();
                            txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                            measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboArea.Text);
                            measureBConverted = measureConverter(measureBConverted, txtUnitMeasure.Text, cboArea.Text);
                        }
                        else
                        {
                            //LENGTH WEIGHT VOLUME
                            measureA_OG = Double.Parse(Global.measureAOG); //Get purchase measures of A and B from Supply_Item table
                            trueUnitPrice = unitPriceOG / measureA_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                            //                //Get the already converted Measurements in frame_materials table.
                            //                //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                            if (Global.supply_category_typeOfMeasure == "Volume")
                            {
                                double measureAConverted = Double.Parse(txtVolume.Text);
                                measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboVolume.Text, 1);
                                double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                                txtTotalDamageCost.Text = rawCost.ToString();
                                txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                            }
                            else if (Global.supply_category_typeOfMeasure == "Weight")
                            {
                                double measureAConverted = Double.Parse(txtVolume.Text);
                                measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboWeight.Text);
                                double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                                txtTotalDamageCost.Text = rawCost.ToString();
                                txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                            }
                            else if (Global.supply_category_typeOfMeasure == "Length")
                            {
                                double measureAConverted = Double.Parse(txtVolume.Text);
                                measureAConverted = measureConverter(measureAConverted, txtUnitMeasure.Text, cboLength.Text);
                                double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                                txtTotalDamageCost.Text = rawCost.ToString();
                                txtCalculatedStockedQuantity.Text = trueUnitPrice.ToString();
                            }      
                        }
                    }
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
        private double measureConverter(double measure_forCvt, String unitOfMeasure_Used, String unitOfMeasure_OG, int overload)
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
    
        //     public static string supply_purchase_price;
        //public static string supply_category_typeOfMeasure;
        //public static string supply_itemsID;
        //public static string measureAOG;
        //public static string measureBOG;
        MessageBox.Show(Global.supply_purchase_price +  " " + Global.supply_category_typeOfMeasure + " " + Global.supply_itemsID + " " + Global.measureAOG + " " + Global.measureBOG);
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
    }
}
