using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchoPA
{
    static class Program
    {
        

        [STAThread]
        static void Main()
        {
            Inventory.AllParts.Add(new Inhouse("Handlebar", 25.00m, 16, 4, 20, 035));
            Inventory.AllParts.Add(new Outsourced("Tire", 5.00m, 25, 1, 50, "Goodyear"));
            Inventory.AllParts.Add(new Outsourced("Tire", 50.00m, 30, 1, 100, "Michelin"));
            Inventory.AllParts.Add(new Inhouse("Deck", 15.00m, 14, 2, 23, 084));

            Inventory.Products.Add(new Product("Bike", 100.00m, 15, 1, 25));
            Inventory.Products.Add(new Product("Skateboard", 25.00m, 35, 1, 100));
            Inventory.Products.Add(new Product("Car", 1000.00m, 3, 1, 5));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
