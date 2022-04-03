using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public  class Mammals : Animals //Derived Class From Animals Class and it is parent for Tiger and Kangaroo classes
, Iprey, Ipredator
    {
        public string Hunt()
        {
            return "It is searching for a food";
        }
        public string Flee()
        {

            return "It is runs away !! ";
        }
        public override string Name { get; set; }

        public override decimal Age { get; set; }
        public override decimal Weight { get; set; }
        public override string Sound()
        {
            return "Mammals has sound";
        }

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
        public virtual void BreastFeeding()
        {

        }

    }
}