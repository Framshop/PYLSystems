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
using UnitsNet;

namespace PYLsystems
{
    public partial class frmFrameEdit : Form
    {
        //TO DO: 3/18/2019 - 4:00PM test out lists and datatable
        private int frameItemId;
        private String frameName;
        private String frameDimension;
        private String frameDescription;
        String connString = "Server=localhost;Database=frameshopdb;Uid=root;Pwd=root";

        DataTable dtSelectSupplies; //Selected from Database
        DataTable dtSelectSuppliesFiltered; //removed Original UnitMeasure and PURCHASE UnitPrice. Use this for merging
        DataTable dtSuppliesUsed; //Merged DataTable

        DataTable dtSelectSuppliesSaved;
        DataTable dtSuppliesUsedSaved;

        List<int> RemovedFrame_MatItemId;//for Supplies with existing frame_MaterialsId. Set to inactive
        //List<int> UpdateToActiveFrame_Mat;//for Supplies found in database with existing frame_MaterialsId. Set to active. GetDataTableIndexes to update
        List<suppliesSavedForUpdates> updateSuppliesConvertedtoOG; //for Edit Supply with existing frame_MaterialsId. Get DataTable Indexes to update 

        //--------------Initial Load--------------
        //----for programming initializer

        public frmFrameEdit()
        {
            InitializeComponent();
            this.frameItemId = 1;
            this.frameName = "BLACK2L00001A8 8X10WM";
            this.frameDimension = "8x10";
            this.frameDescription = "BLACK2L00001A8 8X10\" With Matting";
        }
        public frmFrameEdit(int frameItemId, String frameName, String frameDimension, String frameDescription)
        {
            InitializeComponent();
            this.frameItemId = frameItemId;
            this.frameName = frameName;
            this.frameDimension = frameDimension;
            this.frameDescription = frameDescription;
        }
        private void frmFrameEdit_Load(object sender, EventArgs e)
        {
            frmFrameEdit_Loader();
        }

        //-------------Process and Calculation Methods--------------
        //First time load
        private void frmFrameEdit_Loader()
        {
            this.txtBoxFrameName.Text = this.frameName;
            this.txtBoxDimension.Text = this.frameDimension;
            this.txtBoxDescription.Text = this.frameDescription;

            suppliesUsed_Loader();
            

        }
        private void suppliesUsed_Loader()
        {
            RemovedFrame_MatItemId = new List<int>();
            updateSuppliesConvertedtoOG = new List<suppliesSavedForUpdates>();

            this.dataGridSuppliesUsed.DataSource = null;
            this.dataGridSuppliesUsed.Rows.Clear();
            dtSuppliesUsed = new DataTable();
            dtSuppliesUsed.Columns.Add("frame_MaterialsID", typeof(int));
            dtSuppliesUsed.Columns.Add("supply_itemsId", typeof(int));
            dtSuppliesUsed.Columns.Add("Supply Name", typeof(String));
            dtSuppliesUsed.Columns.Add("Category", typeof(String));
            dtSuppliesUsed.Columns.Add("typeOfMeasure", typeof(String));
            dtSuppliesUsed.Columns.Add("Usage", typeof(String));
            dtSuppliesUsed.Columns.Add("Unit Measure", typeof(String));
            //Original Measures
            dtSuppliesUsed.Columns.Add("OGUnitMeasure", typeof(String));
            dtSuppliesUsed.Columns.Add("OGUnitPrice", typeof(double));
            dtSuppliesUsed.Columns.Add("measureAOG", typeof(double));
            dtSuppliesUsed.Columns.Add("measureBOG", typeof(double));

            //ADDED Custom Columns
            dtSuppliesUsed.Columns.Add("Cost/Unit Measure", typeof(double));
            dtSuppliesUsed.Columns.Add("Raw Cost", typeof(double));

            selectSuppliesLoader(this.frameItemId);
            dtSuppliesUsed.Merge(dtSelectSuppliesFiltered);

            dtSuppliesUsedSaved = dtSuppliesUsed.Copy();

            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;

            costingCalculate();
            //dataGridSuppliesUsed.Columns["Cost/Unit Measure"].DefaultCellStyle.Format = "P0.0000";
            //dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            //dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            //dataGridSuppliesUsed.Columns["frame_MaterialsID"].Visible = false;
            //dataGridSuppliesUsed.Columns["OGUnitMeasure"].Visible = false;
            //dataGridSuppliesUsed.Columns["OGUnitPrice"].Visible = false;
            //dataGridSuppliesUsed.Columns["measureAOG"].Visible = false;
            //dataGridSuppliesUsed.Columns["measureBOG"].Visible = false;
            //dataGridSuppliesUsed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);



            //FOR TESTING PURPOSES ONLY
            //public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
            //    String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)
            //{
            //    this.frameItemId = frameItemId;
            //    this.supplyItemsId = supplyItemsId;
            //    this.measureAUsed = measureAUsed;
            //    this.measureBUsed = measureBUsed;
            //    this.unitMeasureUsed = unitMeasureUsed;
            //    this.unitMeasure_OG = unitMeasure_OG;
            //    this.typeOfMeasure = typeOfMeasure;
            //    this.supplyName = supplyName;
            //    this.unitPriceOG = unitPriceOG;
            //    this.measureA_OG = measureA_OG;
            //    this.measureB_OG = measureB_OG;
            //    this.category = category;
            //}
            //forAddEditSupplies testing = new forAddEditSupplies(1, 7, 0.25, -1, "gram/s", "gram/s", "Weight", "D-Ring Hook 20mm", 200.0, 500, -1,"Hooks");
            //forAddEditSupplies testingv2 = new forAddEditSupplies(1, 8, 0.02, -1, "liters", "liters", "Volume", "Rugby All-Purpose Contact Cement", 200.0, 1, -1, "Adhesive Liquds");
            //checkIfExistsBeforeCalc(testing);
            //checkIfExistsBeforeCalc(testingv2);
            //MessageBox.Show(updateSuppliesConvertedtoOG.Count + "");
            //for (int i=0;i< updateSuppliesConvertedtoOG.Count;i++)
            //{
            //    MessageBox.Show("dt index: " + updateSuppliesConvertedtoOG[i].dataTableIndex + " " + updateSuppliesConvertedtoOG[i].frameMaterialsId + " " + updateSuppliesConvertedtoOG[i].typeOfMeasure);
            //}
            //MessageBox.Show(updateSuppliesConvertedtoOG[0].dataGridIndex + " " + updateSuppliesConvertedtoOG[0].frameMaterialsId
            //    + " " + updateSuppliesConvertedtoOG[0].typeOfMeasure + " " + updateSuppliesConvertedtoOG[0].measureAConvertedOG
            //    + " " + updateSuppliesConvertedtoOG[0].measureBConvertedOG);
        }
        private void selectSuppliesLoader(int selectedFrameItemId)
        {
            try
            {
                String stringSuppliesSelect =
                    "SELECT fm.frame_MaterialsID,sui.supply_itemsId, suc.typeOfMeasure, " +
                    "fm.measureADeduction, fm.measureBDeduction, " +
                    "fm.unitMeasure AS `Unit Measure`," +
                    "sui.unitMeasure AS `OGUnitMeasure`, sui.unitPurchasePrice AS `OGUnitPrice`," +
                    "sui.measureA, sui.measureB, fm.measureAtoOG as `ConvertedAtoOG`, fm.measureBtoOG `ConvertedBtoOG` " +
                    "FROM frame_materials AS fm " +
                    "LEFT JOIN supply_items AS sui ON sui.supply_itemsID = fm.supply_itemsID " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE fm.frameItemId = @frameItemID AND fm.active=0; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSelectSupplies = new DataTable();
                my_adapter.Fill(dtSelectSupplies);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                String stringSuppliesSelect =
                    "SELECT fm.frame_MaterialsID,sui.supply_itemsId, sui.supplyName AS `Supply Name`, suc.categoryName AS `Category`,suc.typeOfMeasure, " +
                    "if(suc.typeOfMeasure='area',concat(fm.measureADeduction,' x ',fm.measureBDeduction),fm.measureADeduction) AS `Usage`, " +
                    "fm.unitMeasure AS `Unit Measure`, " +
                    "sui.unitMeasure AS `OGUnitMeasure`, sui.unitPurchasePrice AS `OGUnitPrice`," +
                    "sui.measureA AS `measureAOG`, sui.measureB `measureBOG` " +
                    "FROM frame_materials AS fm " +
                    "LEFT JOIN supply_items AS sui ON sui.supply_itemsID = fm.supply_itemsID " +
                    "LEFT JOIN supply_category AS suc ON sui.supply_categoryID = suc.supply_categoryID " +
                    "WHERE fm.frameItemId = @frameItemID AND fm.active=0; ";

                MySqlConnection my_conn = new MySqlConnection(connString);
                MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                cmdSuppliesSelect.Parameters.AddWithValue("@frameItemID", selectedFrameItemId);
                //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                dtSelectSuppliesFiltered = new DataTable();
                my_adapter.Fill(dtSelectSuppliesFiltered);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            dtSelectSuppliesSaved = dtSelectSupplies.Copy();

            

        }
        private void refreshDataGrid()
        {
            dataGridSuppliesUsed.DataSource = null;
            dataGridSuppliesUsed.DataSource = dtSuppliesUsedSaved;
            //dataGridSuppliesUsed.Columns["Cost/Unit Measure"].DefaultCellStyle.Format = "P0.0000";
            //dataGridSuppliesUsed.Columns["Raw Cost"].DefaultCellStyle.Format = "P0.0000";
            //dataGridSuppliesUsed.Columns["supply_itemsId"].Visible = false;
            //dataGridSuppliesUsed.Columns["frame_MaterialsID"].Visible = false;
            //dataGridSuppliesUsed.Columns["OGUnitMeasure"].Visible = false;
            //dataGridSuppliesUsed.Columns["OGUnitPrice"].Visible = false;
            //dataGridSuppliesUsed.Columns["measureAOG"].Visible = false;
            //dataGridSuppliesUsed.Columns["measureBOG"].Visible = false;
            //dataGridSuppliesUsed.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
        internal void checkIfExistsBeforeCalc(forAddEditSupplies addEditSuppliesVals)
        {
            DataTable dtcheckIfFrame_MatExists = new DataTable();
            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
            {
                try
                {
                    String stringSuppliesSelect =
                        "SELECT fm.frame_materialsID, fm.frameItemID, fm.supply_itemsID, fm.measureADeduction,fm.measureBDeduction, " +
                        "fm.unitMeasure, fm.active, fm.measureAtoOG, fm.measureBtoOG " +
                        "FROM frame_materials AS fm " +
                        "WHERE fm.frameItemId = @frameItemId AND fm.supply_itemsID = @supplyItemsId; ";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                    cmdSuppliesSelect.Parameters.AddWithValue("@frameItemId", frameItemId);
                    cmdSuppliesSelect.Parameters.AddWithValue("@supplyItemsId", addEditSuppliesVals.supplyItemsId);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                    
                    my_adapter.Fill(dtcheckIfFrame_MatExists);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            }
            else
            {
                try
                {
                    String stringSuppliesSelect =
                        "SELECT fm.frame_materialsID, fm.frameItemID, fm.supply_itemsID, fm.measureADeduction, " +
                        "fm.unitMeasure,fm.active,fm.measureAtoOG " +
                        "FROM frame_materials AS fm " +
                        "WHERE fm.frameItemId = @frameItemId AND fm.supply_itemsID = @supplyItemsId; ";

                    MySqlConnection my_conn = new MySqlConnection(connString);
                    MySqlCommand cmdSuppliesSelect = new MySqlCommand(stringSuppliesSelect, my_conn);
                    cmdSuppliesSelect.Parameters.AddWithValue("@frameItemId", frameItemId);
                    cmdSuppliesSelect.Parameters.AddWithValue("@supplyItemsId", addEditSuppliesVals.supplyItemsId);
                    //cmdSuppliesSelect.Parameters.AddWithValue("@DateEnd", DateEnd);
                    MySqlDataAdapter my_adapter = new MySqlDataAdapter(cmdSuppliesSelect);

                    dtcheckIfFrame_MatExists = new DataTable();
                    my_adapter.Fill(dtcheckIfFrame_MatExists);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            //If material added exists in frame_materials table, Add to list of Updates active=0, inactive=1
            if (dtcheckIfFrame_MatExists.Rows.Count > 0)
            {
                bool existsInDataGrid=false;
                //MessageBox.Show(dtcheckIfFrame_MatExists.Rows.Count + " " + dataGridSuppliesUsed.Rows.Count);
                for (int i=0;i<dtSuppliesUsedSaved.Rows.Count;i++)
                {
                    if (Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["frame_materialsID"].ToString()) == Int32.Parse(dtSuppliesUsedSaved.Rows[i]["frame_materialsID"].ToString()))
                    {
                        existsInDataGrid = true;
                    }
                    if (addEditSuppliesVals.supplyItemsId == Int32.Parse(dtSuppliesUsedSaved.Rows[i]["frame_materialsID"].ToString()))
                    {
                        existsInDataGrid = true;
                    }
                }
                if (existsInDataGrid)
                {
                    MessageBox.Show("You've already added the item in the list. \n Please use Edit Supply for any changes.");
                    return;
                }
                else if (Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["active"].ToString()) == 1)
                {

                    //NOTE TO ADD: Add first to Datagrid values soon and put to updates List if there were any changes

                    addToUpdatedList(addEditSuppliesVals, Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["frame_materialsID"].ToString()));
                   
                }
                else if (Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["active"].ToString()) == 0)
                {
                    //NOTE TO ADD: Add first Find from removedList select to reinstate back to Datagrid and put to updates List if there were any changes
                    int removedListindex =-1;
                    for (int i=0;i < RemovedFrame_MatItemId.Count;i++)
                    {
                        if(RemovedFrame_MatItemId[i]== Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["frame_materialsID"].ToString()))
                        {
                            removedListindex = i;
                        }
                    }
                    if (removedListindex > -1)
                    {
                        RemovedFrame_MatItemId.RemoveAt(removedListindex);
                    }
                    addToUpdatedList(addEditSuppliesVals, Int32.Parse(dtcheckIfFrame_MatExists.Rows[0]["frame_materialsID"].ToString()));
                }
                
            }
            //Else If not update
            else
            {
                addToInsertList(addEditSuppliesVals);
            }

        }
        private void addToInsertList(forAddEditSupplies addEditSuppliesVals) //Insert List is the DataGrid NOTE: FOR INSERTING converted units, call measureConverter again
        {


            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
            {

                String dimension = addEditSuppliesVals.measureAUsed + " x " + addEditSuppliesVals.measureBUsed;

                dtSuppliesUsedSaved.Rows.Add();
                int indexdtInsert = dtSuppliesUsedSaved.Rows.Count - 1;

                dtSuppliesUsedSaved.Rows[indexdtInsert]["supply_itemsId"] = addEditSuppliesVals.supplyItemsId;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Supply Name"] = addEditSuppliesVals.supplyName;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Category"] = addEditSuppliesVals.category;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["typeOfMeasure"] = addEditSuppliesVals.typeOfMeasure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = dimension;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Unit Measure"] = addEditSuppliesVals.unitMeasureUsed;

                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitMeasure"] = addEditSuppliesVals.unitMeasure_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitPrice"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAOG"] = addEditSuppliesVals.measureA_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureBOG"] = addEditSuppliesVals.measureB_OG;

            }
            else
            {
                String measure = addEditSuppliesVals.measureAUsed.ToString();


                dtSuppliesUsedSaved.Rows.Add();
                int indexdtInsert = dtSuppliesUsedSaved.Rows.Count - 1;

                dtSuppliesUsedSaved.Rows[indexdtInsert]["supply_itemsId"] = addEditSuppliesVals.supplyItemsId;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Supply Name"] = addEditSuppliesVals.supplyName;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Category"] = addEditSuppliesVals.category;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["typeOfMeasure"] = addEditSuppliesVals.typeOfMeasure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = measure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Unit Measure"] = addEditSuppliesVals.unitMeasureUsed;

                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitMeasure"] = addEditSuppliesVals.unitMeasure_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitPrice"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAOG"] = addEditSuppliesVals.measureA_OG;
            }

            int dtSuppliesSavedLastIndex = dtSuppliesUsedSaved.Rows.Count - 1;

            trueCostCalculationPutDataGrid(addEditSuppliesVals, dtSuppliesSavedLastIndex);
        }
        private void addToUpdatedList(forAddEditSupplies addEditSuppliesVals, int frame_materialsID) //DataGrid+UpdateList
        {

            //dtSuppliesUsed.Columns.Add("frame_MaterialsID", typeof(int));
            //dtSuppliesUsed.Columns.Add("supply_itemsId", typeof(int));
            //dtSuppliesUsed.Columns.Add("Supply Name", typeof(String));
            //dtSuppliesUsed.Columns.Add("Category", typeof(String));
            //dtSuppliesUsed.Columns.Add("typeOfMeasure", typeof(String));
            //dtSuppliesUsed.Columns.Add("Usage", typeof(String));
            //dtSuppliesUsed.Columns.Add("Unit Measure", typeof(String));
            ////Original Measures
            //dtSuppliesUsed.Columns.Add("OGUnitMeasure", typeof(String));
            //dtSuppliesUsed.Columns.Add("OGUnitPrice", typeof(double));
            //dtSuppliesUsed.Columns.Add("measureAOG", typeof(double));
            //dtSuppliesUsed.Columns.Add("measureBOG", typeof(double));

            ////ADDED Custom Columns
            //dtSuppliesUsed.Columns.Add("Cost/Unit Measure", typeof(double));
            //dtSuppliesUsed.Columns.Add("Raw Cost", typeof(double));
            //MessageBox.Show(dataGridSuppliesUsed.Rows.Count + "");

            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
            {

                String dimension = addEditSuppliesVals.measureAUsed + " x " + addEditSuppliesVals.measureBUsed;

                dtSuppliesUsedSaved.Rows.Add();
                int indexdtInsert = dtSuppliesUsedSaved.Rows.Count-1;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["frame_materialsID"] = frame_materialsID;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["supply_itemsId"] = addEditSuppliesVals.supplyItemsId;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Supply Name"] = addEditSuppliesVals.supplyName;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Category"] = addEditSuppliesVals.category;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["typeOfMeasure"] = addEditSuppliesVals.typeOfMeasure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = dimension;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Unit Measure"] = addEditSuppliesVals.unitMeasureUsed;

                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitMeasure"] = addEditSuppliesVals.unitMeasure_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitPrice"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAOG"] = addEditSuppliesVals.measureA_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureBOG"] = addEditSuppliesVals.measureB_OG;

            }
            else
            {
                String measure = addEditSuppliesVals.measureAUsed.ToString();


                dtSuppliesUsedSaved.Rows.Add();
                int indexdtInsert = dtSuppliesUsedSaved.Rows.Count - 1;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["frame_materialsID"] = frame_materialsID;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["supply_itemsId"] = addEditSuppliesVals.supplyItemsId;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Supply Name"] = addEditSuppliesVals.supplyName;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Category"] = addEditSuppliesVals.category;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["typeOfMeasure"] = addEditSuppliesVals.typeOfMeasure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Usage"] = measure;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["Unit Measure"] = addEditSuppliesVals.unitMeasureUsed;

                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitMeasure"] = addEditSuppliesVals.unitMeasure_OG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["OGUnitPrice"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[indexdtInsert]["measureAOG"] = addEditSuppliesVals.measureA_OG;
            }


            refreshDataGrid();
            

            int dtSuppliesSavedLastIndex = dtSuppliesUsedSaved.Rows.Count - 1;

            trueCostCalculationPutDataGrid(addEditSuppliesVals, dtSuppliesSavedLastIndex);
            double measureAConverted;
            double measureBConverted;
            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
            {

                measureAConverted = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                measureBConverted = measureConverter(addEditSuppliesVals.measureBUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                updateSuppliesConvertedtoOG.Add(new suppliesSavedForUpdates(dtSuppliesSavedLastIndex, frame_materialsID,
                addEditSuppliesVals.typeOfMeasure, measureAConverted, measureBConverted));
            }
            else if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Volume"))
            {
                measureAConverted = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed, 0);

                updateSuppliesConvertedtoOG.Add(new suppliesSavedForUpdates(dtSuppliesSavedLastIndex, frame_materialsID,
                addEditSuppliesVals.typeOfMeasure, measureAConverted, -1));
            }
            else
            {
                measureAConverted = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);

                updateSuppliesConvertedtoOG.Add(new suppliesSavedForUpdates(dtSuppliesSavedLastIndex, frame_materialsID,
                addEditSuppliesVals.typeOfMeasure, measureAConverted, -1));
            }
        }
        //COSTS CALCULATION. FOR SELECTED UNIT PRICE AND RAW COST
        private void costingCalculate() //Retrieve from Database and calculate. One time use only
        {
            if (dtSelectSupplies.Rows.Count > 0)
            {
                for (int i = 0; i < dtSelectSupplies.Rows.Count; i++)
                {
                    String unitOfMeasure_Used = dtSelectSupplies.Rows[i]["Unit Measure"].ToString();
                    String unitOfMeasure_OG = dtSelectSupplies.Rows[i]["OGUnitMeasure"].ToString();
                    double unitPriceOG = Double.Parse(dtSelectSupplies.Rows[i]["OGUnitPrice"].ToString());


                    if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Whole"))
                    {
                        double measureA = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());

                        double rawCost = measureA * unitPriceOG;

                        dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = unitPriceOG;
                        dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;
                    }
                    else if (String.Equals(unitOfMeasure_Used, unitOfMeasure_OG))
                    {
                        if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Area"))
                        {
                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());
                            double measureB_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureB"].ToString());
                            double area_OG = measureA_OG * measureB_OG;
                            double trueUnitPrice = unitPriceOG / area_OG;
                            double measureAUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureADeduction"].ToString());
                            double measureBUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureBDeduction"].ToString());
                            double areaOfUsed = measureAUsed * measureBUsed;

                            double rawCost = areaOfUsed * trueUnitPrice;

                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;
                            measureAUsed = measureConverter(measureAUsed, "feet", "inches");

                        }
                        else
                        {
                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString());
                            double trueUnitPrice = unitPriceOG / measureA_OG;

                            double measureAUsed = Double.Parse(dtSelectSupplies.Rows[i]["measureADeduction"].ToString());

                            double rawCost = measureAUsed * trueUnitPrice;

                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;
                        }
                    }
                    else
                    {
                        //Jan 18, 2019 to change!!! From used to original measure conversion
                        if (String.Equals(dtSelectSupplies.Rows[i]["typeOfMeasure"].ToString(), "Area"))
                        {

                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString()); //Get purchase measures from Supply_Item table
                            double measureB_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureB"].ToString());

                            double area_OG = measureA_OG * measureB_OG; // Get area of original measures from purchase on Supply_Item table

                            double trueUnitPrice = unitPriceOG / area_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                            //Get the already converted Measurements in frame_materials table.
                            //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                            double measureAConverted = Double.Parse(dtSelectSupplies.Rows[i]["ConvertedAtoOG"].ToString());
                            double measureBConverted = Double.Parse(dtSelectSupplies.Rows[i]["ConvertedBtoOG"].ToString());

                            double areaOfUsed = measureAConverted * measureBConverted; //Calculate the area of Use of the used up converted measurements

                            double rawCost = areaOfUsed * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;


                        }
                        else
                        {


                            double measureA_OG = Double.Parse(dtSelectSupplies.Rows[i]["measureA"].ToString()); //Get purchase measures of A and B from Supply_Item table

                            double trueUnitPrice = unitPriceOG / measureA_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                            //Get the already converted Measurements in frame_materials table.
                            //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                            double measureAConverted = Double.Parse(dtSelectSupplies.Rows[i]["ConvertedAtoOG"].ToString());

                            double rawCost = measureAConverted * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                            dataGridSuppliesUsed.Rows[i].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                            dataGridSuppliesUsed.Rows[i].Cells["Raw Cost"].Value = rawCost;

                        }
                    }
                }
            }
        }
        //Calculation Cost only. Then put to datagrid
        internal void trueCostCalculationPutDataGrid(forAddEditSupplies addEditSuppliesVals,int dataGridIndex)
        {
            if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Whole"))
            {

                double rawCost = addEditSuppliesVals.measureAUsed * addEditSuppliesVals.unitPriceOG;

                dtSuppliesUsedSaved.Rows[dataGridIndex]["Cost/Unit Measure"] = addEditSuppliesVals.unitPriceOG;
                dtSuppliesUsedSaved.Rows[dataGridIndex]["Raw Cost"] = rawCost;
                refreshDataGrid();
                
            }
            else if (String.Equals(addEditSuppliesVals.unitMeasureUsed, addEditSuppliesVals.unitMeasure_OG))
            {
                if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
                {
                    
                    double area_OG = addEditSuppliesVals.measureA_OG * addEditSuppliesVals.measureB_OG;
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / area_OG;

                    double areaOfUsed = addEditSuppliesVals.measureAUsed * addEditSuppliesVals.measureBUsed;

                    double rawCost = areaOfUsed * trueUnitPrice;

                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Cost/Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();
                    
                    //dataGridSuppliesUsed.Rows[dataGridIndex].Cells["Cost/Unit Measure"].Value = trueUnitPrice;
                    //dataGridSuppliesUsed.Rows[dataGridIndex].Cells["Raw Cost"].Value = rawCost;
                }
                else
                {
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / addEditSuppliesVals. measureA_OG;

                    double rawCost = addEditSuppliesVals.measureAUsed * trueUnitPrice;

                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Cost/Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();
                    
                }
            }
            else
            {
                //Jan 18, 2019 to change!!! From used to original measure conversion
                if (String.Equals(addEditSuppliesVals.typeOfMeasure, "Area"))
                {

                    double area_OG = addEditSuppliesVals.measureA_OG * addEditSuppliesVals.measureB_OG; // Get area of original measures from purchase from Object

                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / area_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement


                    double measureAConvertedUse = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                    double measureBConvertedUse = measureConverter(addEditSuppliesVals.measureBUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);

                    double areaOfUsed = measureAConvertedUse * measureBConvertedUse; //Calculate the area of Use of the used up converted measurements

                    double rawCost = areaOfUsed * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price
                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Cost/Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();
                    


                }
                else
                {
                    double trueUnitPrice = addEditSuppliesVals.unitPriceOG / addEditSuppliesVals.measureA_OG; // Purchase Unit Price/area_OG to get the true Unit Price of "1" Unit of Measurement

                    //Get the already converted Measurements in frame_materials table.
                    //The already converted Measurements are calculated and inputted in the database in the FrameCreation and FrameEdited  forms
                    double measureAConvertedUse = measureConverter(addEditSuppliesVals.measureAUsed, addEditSuppliesVals.unitMeasure_OG, addEditSuppliesVals.unitMeasureUsed);
                   
                    double rawCost = measureAConvertedUse * trueUnitPrice; //Get the raw cost of the item based on 'Area Usage' multiplied by the true Unit Price

                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Cost/Unit Measure"] = trueUnitPrice;
                    dtSuppliesUsedSaved.Rows[dataGridIndex]["Raw Cost"] = rawCost;
                    refreshDataGrid();
                    

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
        //March 17,2019 - Before Adding a Row, check RemovedFrame_MatItemId first if it contains RemovedFrame_MatItemId being added.
        private void deleteRowFromDataGrid(int currRowIndex)
        {
            bool checkIfInDatabase=false;
            int frame_MaterialsID =-1;
            //Check if deleted item is in database or from the datatable retrieved from the database
            for(int i=0; i < dtSelectSupplies.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(dataGridSuppliesUsed.Rows[currRowIndex].Cells["frame_MaterialsID"].Value.ToString()))
                {
                    if (Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["frame_MaterialsID"].Value.ToString()) == Int32.Parse(dtSelectSupplies.Rows[i]["frame_MaterialsID"].ToString()))
                    {
                        checkIfInDatabase = true;
                        frame_MaterialsID = Int32.Parse(dtSelectSupplies.Rows[i]["frame_MaterialsID"].ToString());
                        //MessageBox.Show(this.dataGridSuppliesUsed.SelectedRows[0].Index+" "+checkIfInDatabase);
                    }
                }               
            }
            //If it exists, put to a list later for active
            if (checkIfInDatabase)
            {
                if (frame_MaterialsID > -1) { 
                    RemovedFrame_MatItemId.Add(frame_MaterialsID);
                    DataRow dataRowDeleted = dtSuppliesUsedSaved.Rows[currRowIndex];
                    dataRowDeleted.Delete();
                    refreshDataGrid();
                    
                    //dataGridSuppliesUsed.Rows.RemoveAt(this.dataGridSuppliesUsed.SelectedRows[0].Index);
                }
            }
            else
            {///LAST STOP HERE
                for (int i =0;i< updateSuppliesConvertedtoOG.Count;i++)
                {
                    if (!String.IsNullOrEmpty(dataGridSuppliesUsed.Rows[currRowIndex].Cells["frame_MaterialsID"].Value.ToString()))
                    {
                        //If it exists in update list. Assign to frame_materials Id and delete it from updates list.
                        if (Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["frame_MaterialsID"].Value.ToString()) == updateSuppliesConvertedtoOG[i].frameMaterialsId)
                        {
                            frame_MaterialsID = Int32.Parse(dataGridSuppliesUsed.Rows[currRowIndex].Cells["frame_MaterialsID"].Value.ToString());
                        }
                    }
                }
                DataRow dataRowDeleted = dtSuppliesUsedSaved.Rows[currRowIndex];
                dataRowDeleted.Delete();
                refreshDataGrid();
                
                //dataGridSuppliesUsed.Rows.RemoveAt(this.dataGridSuppliesUsed.SelectedRows[0].Index);
            }
            //
            int updateSuppliesConvertIndex = -1;
            if (updateSuppliesConvertedtoOG.Count > 0)
            {//find matching frame_materials id index
                for (int i=0; i <updateSuppliesConvertedtoOG.Count;i++) {
                    if (updateSuppliesConvertedtoOG[i].frameMaterialsId==frame_MaterialsID)
                    {
                        updateSuppliesConvertIndex = i;

                    }
                }
            }
            MessageBox.Show(updateSuppliesConvertIndex + "");
            if (updateSuppliesConvertIndex > -1)
            {
                //If deleted updated existing frame_materials is not the last row
                if (updateSuppliesConvertIndex + 1 != updateSuppliesConvertedtoOG.Count) { 
                    for(int i=updateSuppliesConvertIndex+1;i< updateSuppliesConvertedtoOG.Count; i++)
                    {
                        //shift datagridindex to match;
                        updateSuppliesConvertedtoOG[i].dataTableIndex--;
                    }
                }
                updateSuppliesConvertedtoOG.RemoveAt(updateSuppliesConvertIndex);
            }
            //MessageBox.Show(updateSuppliesConvertedtoOG.Count + "");
            //for (int i = 0; i < updateSuppliesConvertedtoOG.Count; i++)
            //{
            //    MessageBox.Show("dt index: "+updateSuppliesConvertedtoOG[i].dataTableIndex+" " +updateSuppliesConvertedtoOG[i].frameMaterialsId + " " + updateSuppliesConvertedtoOG[i].typeOfMeasure);
            //}
            //MessageBox.Show(frame_MaterialsID+" "+RemovedFrame_MatItemId[0]+"");
        }
        //----------------Event Methods-----------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            frmFrameAddSuppliesUsed frmAddSupplies = new frmFrameAddSuppliesUsed();
            frmAddSupplies.ShowDialog();
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            frmFrameEditSuppliesUsed frmEditSupplies = new frmFrameEditSuppliesUsed();
            frmEditSupplies.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currRowIndex = dataGridSuppliesUsed.SelectedRows[0].Index;
            deleteRowFromDataGrid(currRowIndex);
        }
    }
    class suppliesSavedForUpdates
    {
        //Saved Conversion
        internal int  dataTableIndex { get; set; }
        internal int frameMaterialsId { get; set; }
        internal String typeOfMeasure { get; set; }
        internal double measureAConvertedOG { get; set; }
        internal double measureBConvertedOG { get; set; }

        // public frame_ItemsforList() {
        //}
        public suppliesSavedForUpdates(int dataGridIndex, int frameMaterialsId, String typeOfMeasure, double measureAConvertedOG, double measureBConvertedOG)
        {
            this.dataTableIndex = dataGridIndex;
            this.frameMaterialsId = frameMaterialsId;
            this.typeOfMeasure = typeOfMeasure;
            this.measureAConvertedOG = measureAConvertedOG;
            this.measureBConvertedOG = measureBConvertedOG;
            //NOTE CHANGE updates int List of ACTIVE TO this class
        }
    }
    //ALL BASIC INFORMATION PASSED FROM ADD AND EDIT SUPPLIES  USED
    class forAddEditSupplies
    {
        internal int frameItemId { get; set; }
        internal int supplyItemsId { get; set; }
        internal double measureAUsed { get; set; }
        internal double measureBUsed { get; set; }
        internal String unitMeasureUsed { get; set; }
        internal String unitMeasure_OG { get; set; }
        internal String typeOfMeasure { get; set; }
        internal String supplyName { get; set; }
        internal String category { get; set; }
        internal double unitPriceOG { get; set; }
        internal double measureA_OG { get; set; }
        internal double measureB_OG { get; set; }

        // public frame_ItemsforList() {
        //}
        public forAddEditSupplies(int frameItemId, int supplyItemsId, double measureAUsed, double measureBUsed, String unitMeasureUsed, String unitMeasure_OG,
            String typeOfMeasure, String supplyName, double unitPriceOG, double measureA_OG, double measureB_OG, String category)
        {
            this.frameItemId = frameItemId;
            this.supplyItemsId = supplyItemsId;
            this.measureAUsed = measureAUsed;
            this.measureBUsed = measureBUsed;

            this.unitMeasureUsed = unitMeasureUsed;
            this.unitMeasure_OG = unitMeasure_OG;

            this.typeOfMeasure = typeOfMeasure;

            this.supplyName = supplyName;

            this.unitPriceOG = unitPriceOG;
            this.measureA_OG = measureA_OG;
            this.measureB_OG = measureB_OG;
            this.category = category;
        }
    }
}
