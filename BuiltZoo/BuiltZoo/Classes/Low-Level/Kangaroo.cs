using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public class Kangaroo : Mammals
    {
        //override Properties from parent classes

        public override string Name { get; set; } = "Kangaroo";
        public override decimal Age { get; set; } = 2;
        public override decimal Weight { get; set; } =30;
        public override int NumOfLegs { get; set; } = 2;
        // override Sleep method
        public override string Sleep()
        {
            ////proove this function from Kangaroo class
            return "Kangaroo Class Say : All Kangaroo Sleepping";
        }
        // override Eat method

        public override void Eat()
        {
            //proove this function from Kangaroo class

            Console.WriteLine("Kangaroo Class Say : All Kangaroo Eating");
        }
        // override Sound method

        public override string Sound()
        {
            return "Kangaroo Class Say : All Kangaroo has a sound and it is like (chortle)";
        }
        // override BreastFeeding method

        public override void BreastFeeding()
        {
            //proove this function from Kangaroo class

            Console.WriteLine("Kangaroo Class Say : Kangaroo animal do BreastFeeding");

        }
        /// <summary>
        /// Virtual method that returns a string representation of the concrete Kangaroo is a Marsupials.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete Kangaroo object's is a Marsupials
        /// </returns>
        public string Marsupials()
        {
            return "Kangaroo Class Say : Kangaroo animal is a Marsupials";

        }
    }
}