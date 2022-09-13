using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    //main Invetory Item class
    public class InvItem
    {
        //get and set methods for the properties / encapsulation
        public int ItemNo { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        //default Invetory Item consturtor
        public InvItem()
        {
        }

        //constructor with parameters
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        //method to print text to the form
        //Nathan Burns
        public virtual string GetDisplayText(string sep) => $"{ItemNo}{sep}{sep}{sep}{sep}{Description}{sep}{"("}{Price:C}{")"}";
    }
}
