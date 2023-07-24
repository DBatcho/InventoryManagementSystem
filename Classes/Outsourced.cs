using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchoPA
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }
        //
        //Constructor when adding new Outsourced
        //
        public Outsourced(string Name, decimal Price, int InStock, int Min, int Max, string CompanyName) : base(Name, Price, InStock, Min, Max)
        {
            this.CompanyName = CompanyName;
        }
        //
        //Constructor when modifying Outsourced
        //
        public Outsourced (int PartID, string Name, decimal Price, int InStock, int Min, int Max, string CompanyName) : base (PartID, Name, Price, InStock, Min, Max)
        {
            this.CompanyName = CompanyName;
        }
    }
}
