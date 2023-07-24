using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchoPA
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }
        //
        // constructor when adding new Inhouse
        //
        public Inhouse(string Name, decimal Price, int InStock, int Min, int Max, int MachineID) : base(Name, Price, InStock, Min, Max)
        {
            this.MachineID = MachineID;
        }
        //
        // constructor when modifying Inhouse
        //
        public Inhouse(int PartID, string Name, decimal Price, int InStock, int Min, int Max, int MachineID) : base(PartID, Name, Price, InStock, Min, Max)
        {
            this.MachineID = MachineID;
        }
    }
}
