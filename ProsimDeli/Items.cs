using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsimDeli
{
    public class Item
    {
        //lastnosti
        //prop 2xtab
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Price { get; set; }

        //konstruktorji
        //ctor 2xtab
        public Item(int itemid, string itemname, string price)
        {
            ItemID = itemid;
            ItemName = itemname;
            Price = price;

        }

        //metode
        public override string ToString()
        {
            return ItemID.ToString()+"   " + ItemName.ToString()+"   " + Price.ToString();
        }
    }
}
