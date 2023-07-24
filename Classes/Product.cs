using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchoPA
{
    public class Product
    {
        public int ProductID { get; set; }
        public static int ProductIDcount = 1;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        protected BindingList<Part> AssociatedParts = new BindingList<Part>();
        //
        // used when declaring sample products in Program.cs
        //
        public Product(string Name, decimal Price, int InStock, int Min, int Max)
        {
            this.ProductID = ProductIDcount++;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
        }
        //
        //Used when modifying a Product
        //
        public Product(int ProductID, string Name, decimal Price, int InStock, int Min, int Max, BindingList<Part> associatedParts)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            for (var i = 0; i < associatedParts.Count; i++)
            {
                addAssociatedPart(associatedParts[i]);
            }
        }
        //
        // adds a part to the associated parts binding list
        //
        public void addAssociatedPart(Part insert) => AssociatedParts.Add(insert);
        //
        // removes a part from the associated parts binding list (not used because I save over the list every time)
        //
        public bool removeAssociatedPart (int PartID)
        {
            for (var i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == PartID)
                {
                    AssociatedParts.Remove(AssociatedParts[i]);
                    return true;
                }
            }
            return false;
        }
        //
        // finds a part in the Associated part binding list (not used)
        //
        public Part lookupAssociatedPart(int PartID)
        {
            Part find = null;
            for (var i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == PartID)
                {
                    find = AssociatedParts[i];
                }
            }
            return find;
        }
        //
        // returns the assoicated parts list from the products
        //
        public BindingList<Part> GetAssociatedParts()
        {
            return AssociatedParts;
        }
    }
}
