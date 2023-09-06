using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for star destroyer object
    class StarDestroyer:Battleship
    {
        //private data members
        private string name;
        //overloaded constructor
        public StarDestroyer(int cost, int combatPower) :base(cost, combatPower)
        {
            name = "Star Destroyer";
        }
    }
}
