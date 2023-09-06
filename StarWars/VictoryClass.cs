using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for Victory object
    class VictoryClass:StarDestroyer
    {
        //private data member
        private string name;
        //overlaoded constructor
        public VictoryClass(int cost, int combatPower) : base(cost, combatPower)
        {
            name = "Victory";
        }
    }
}
