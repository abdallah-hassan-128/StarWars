using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for fighter member
    class Fighter
    {
        //data members
        private string serialNumber;
        private string name;
        //overloaded constructor
        public Fighter(string serialNumber, string name)
        {
            this.SerialNumber = serialNumber;
            this.Name = name;
        }
        //getters and setters
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Name { get => name; set => name = value; }
    }
}
