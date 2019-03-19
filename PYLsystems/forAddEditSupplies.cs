using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYLsystems
{
    //ALL BASIC INFORMATION PASSED FROM ADD AND EDIT SUPPLIES  USED
    public class forAddEditSupplies
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
        public forAddEditSupplies()
        {

        }
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
