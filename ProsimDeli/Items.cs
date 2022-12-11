using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsimDeli
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public Item(int itemid, string itemname, double price)
        {
            ItemID = itemid;
            ItemName = itemname;
            Price = price;

        }
        public override string ToString()
        {
            return ItemID.ToString()+" " + ItemName.ToString()+" " + Price.ToString();
        }
    }
    public class SoftwareItem : Item
    {
        public string LicenceKey { get; set; }

        public int SizeInMB { get; set; }

        public SoftwareItem(int itemid,string itemname, double price,string licenceKey,int sizeInMB): base(itemid,itemname,price)
        {
            LicenceKey = licenceKey;
            SizeInMB = sizeInMB;
        }
        public override string ToString()
        {
            return ItemID.ToString()+" "+ItemName.ToString()+" "+Price.ToString()+" "+LicenceKey.ToString()+" "+SizeInMB.ToString();
        }
    }
    public class HardwareItem: Item
    {
        public double Weight { get; set; }
        public HardwareItem(int itemid, string itemname, double price , double weight) : base(itemid, itemname, price)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return ItemID.ToString() + " " + ItemName.ToString() + " " + Price.ToString() + " " + Weight.ToString();
        }
    }
    public class Computer : HardwareItem
    {
        public int NoOFCores { get; set; }
        public int AmounttOFRam { get; set; }
        public int HDDSize { get; set; }

        public Computer(int itemid, string itemname, double price, double  Weight,int cores,int ram,int hdd): base(itemid, itemname, price, Weight)
        {
            NoOFCores = cores;
            AmounttOFRam = ram;
            HDDSize = hdd;
        }
        public override string ToString()
        {
            return ItemID.ToString() +ItemName.ToString() + Price.ToString() + Weight.ToString() +NoOFCores.ToString() +AmounttOFRam.ToString() + HDDSize.ToString();
        }
    }
    public class Monitor : HardwareItem
    {
        public string resolution { get; set; }
        public string monType { get; set; }

        public Monitor(int itemid, string itemname, double price, double Weight, string res, string type): base(itemid, itemname, price, Weight)
        {
            resolution = res;
            monType = type;
        }
        public override string ToString()
        {
            return ItemID.ToString() + " " + ItemName.ToString() + " " + Price.ToString() + " " + Weight.ToString() + " " + resolution.ToString() + " " + monType.ToString();
        }
    }
}
