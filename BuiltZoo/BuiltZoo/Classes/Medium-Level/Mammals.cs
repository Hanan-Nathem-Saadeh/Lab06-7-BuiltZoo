using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public abstract class Mammals : Animals //Derived Class From Animals Class and it is parent for Tiger and Kangaroo classes
    {
        // virtual propertity
        public virtual int NumOfLegs { get; set; } = 2;
        //override sleep method
        public override string Sleep()
        {
            return "Mammals Class Say : All Mammals Sleepping";
        }
        //override eat method
        public override void Eat()
        {
           Console.WriteLine("Mammals Class Say : All Mammals Eating");
        }

        /// <summary>
        /// Virtual method that returns a string representation of the concrete Mammals BreastFeeding.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete Mammal object's BreastFeeding
        /// </returns>
        public abstract void BreastFeeding();
        
    }
}