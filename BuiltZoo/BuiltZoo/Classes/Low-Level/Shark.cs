using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public class Shark : Fish
    {
        //overide Properties from parent classes
        //Default values
        public override string Name { get; set; } = "Shark";
        public override decimal Age { get; set; } = 25;
        public override decimal Weight { get; set; } = 300;
        public override decimal SwimSpeed { get; set; } = 500;
        // override Sleep method
        public override string Sleep()
        {
            return "Shark Class Say : All Sharks Sleepping";
        }
        // override eat method

        public override void Eat()
        {

            Console.WriteLine("Shark Class Say : All Sharks Eating");
        }
        // override sound method

        public override string Sound()
        {
            return "Shark Class Say : All Shark has a sound and it is like (Grunts)";
        }
        /// <summary>
        /// abstract method that returns a string representation of the concrete Shark is a Predators.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete Shark object's Predators.
        /// </returns>
        public  string Predators()
        {
           return"Shark Class Say : Sharks are Predators";

        }

    }
}