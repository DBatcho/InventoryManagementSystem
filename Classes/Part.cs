using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchoPA
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public static int PartIDcount = 1;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        //
        //Used when adding a new part
        //
        public Part(string Name, decimal Price, int InStock, int Min, int Max)
        {
            PartID = PartIDcount++;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }
        //
        //Used when Modifying a part
        //
        public Part(int PartID, string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.PartID = PartID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }
    }
}
