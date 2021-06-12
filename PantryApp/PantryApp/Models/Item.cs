using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PantryApp.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string UnitType { get; set; }
        public string Category { get; set; }
        public string Barcode { get; set; }
        public int PantyQty { get; set; }
        public int ListQty { get; set; }

    }
}