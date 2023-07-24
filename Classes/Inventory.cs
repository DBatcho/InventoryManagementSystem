using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchoPA
{
    static class Inventory
    {
        static public BindingList<Product> Products = new BindingList<Product>();
        static public BindingList<Part> AllParts = new BindingList<Part>();
        //
        // adds a product to the Prodcuts bindinglist
        //
        static public void addProduct(Product insert)
        {
            Products.Add(insert);
        }
        //
        // removes a Product from the Products bindinglist using the ProductID and returns if it was deleted or not
        //
        static public bool removeProduct (int ProductID)
        {
            for (var i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == ProductID)
                {
                    Products.Remove(Products[i]);
                    return true;
                }
            }
            return false;
        }
        //
        // finds a product using the ProductID and returns it
        //
        static public Product lookupProduct (int ProductID)
        {
            Product find = null;
            for(var i = 0; i < Inventory.Products.Count; i++)
            {
                if(Inventory.Products[i].ProductID == ProductID)
                {
                    find = Inventory.Products[i];
                }
            }
            return find;
        }
        //
        // Updates a existing product
        //
        static public void updateProduct (int ProductID, Product updated)
        {
            for (var i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == ProductID)
                {
                    Inventory.Products[i] = updated;
                }
            }
        }
        //
        // adds a part to the AllParts binding list
        //
        static public void addPart(Part insert) => AllParts.Add(insert);

        //
        // deletes a part from the AllParts binding list returning true or false
        //
        static public bool deletePart(Part remove)
        {
            for (var i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i] == remove)
                {
                    AllParts.Remove(remove);
                    return true;
                }
            }
            return false;
        }
        //
        // finds a part from the AllParts bindinglist using the PartID returning the found part
        //
        static public Part lookupPart(int PartID)
        {
            Part find = null;
            for (var i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID == PartID)
                {
                    find = Inventory.AllParts[i];
                }
            }
            if (find is Inhouse)
            {
                Inhouse found = (Inhouse)find;
                return found;
            }
            else if (find is Outsourced)
            {
                Outsourced found = (Outsourced)find;
                return found;
            }
            else
            {
                return find;
            }
        }
        //
        // updates an existing part
        //
        static public void updatePart (int PartID, Part updated)
        {
            for(var i = 0; i <Inventory.AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID == PartID)
                {
                    Inventory.AllParts[i] = updated;
                }
            }
        }
    }
}
