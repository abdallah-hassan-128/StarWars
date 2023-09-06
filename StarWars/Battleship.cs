using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for battle ship
    class Battleship
    {
        //data members
        private int cost;
        private int combatPower;

        //overloaded constructor
        public Battleship(int cost, int combatPower)
        {
            this.Cost = cost;
            this.CombatPower = combatPower;
        }

        //getter setters for data members
        public int Cost { get => cost; set => cost = value; }
        public int CombatPower { get => combatPower; set => combatPower = value; }
    }
}
