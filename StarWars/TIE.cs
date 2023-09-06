using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for TIE object
    class TIE:Fighter
    {
        //private data members
        private string tieName;
        private string tieType;
        //overloaded constructor
        public TIE(string serialNumber, string name, string tieName, string tieType):base(serialNumber,name)
        {
            this.TieName = tieName;
            this.TieType = tieType;
        }
        //getters and setters
        public string TieName { get => tieName; set => tieName = value; }
        public string TieType { get => tieType; set => tieType = value; }
    }
}
