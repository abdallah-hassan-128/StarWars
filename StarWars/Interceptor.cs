using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for Interceptor object, inherited from TIE
    class Interceptor:TIE
    {
        //private data members
        private string name;
        //overloaded constructor
        public Interceptor(string serialNumber, string name, string tieName, string tieType):base(serialNumber,name,tieName,tieType)
        {
            name = "Interceptor";
        }
    }
}
