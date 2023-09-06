using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    //class for Executor inherited from StarDestroyer class
    class ExecutorClass:StarDestroyer
    {
        //data member
        private string name;
        //overloaded constructor
        public ExecutorClass(int cost, int combatPower) : base(cost, combatPower)
        {
            name = "Executor";
        }
    }
}
