using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //Class for Bomber Inherited from class TIE
    class Bomber:TIE
    {
        //data member for bomber name
        private string name;
        //overloaded constructor
        public Bomber(string serialNumber, string name, string tieName, string tieType) : base(serialNumber, name, tieName, tieType)
        {
            name = "Bomber";
        }
    }
}
