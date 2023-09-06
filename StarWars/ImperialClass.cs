using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for Imperial Object
    class ImperialClass:StarDestroyer
    {
        //private data members
        private string name;
        //overloaded constructor
        public ImperialClass(int cost, int combatPower) : base(cost, combatPower)
        {
            name = "Fighter";
        }
    }
}
