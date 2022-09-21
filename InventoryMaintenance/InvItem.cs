using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem : IDisplayable
    {
        public InvItem() { } 

        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        //Nathan Burns
        public int ItemNo { get; set; }

        //Nathan Burns
        public string Description { get; set; }

        //Nathan Burns
        public decimal Price { get; set; }

        //Nathan Burns
        public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";

        //public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
    }
}
