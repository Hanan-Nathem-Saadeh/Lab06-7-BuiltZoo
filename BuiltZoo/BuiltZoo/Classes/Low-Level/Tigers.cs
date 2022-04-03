using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public class Tiger : Mammals // tiger class is a child class inherited from mammals and mammals from animals
    {
        //override Properties from parent classes

        public override string Name { get; set; } = "Tiger";
        public override decimal Age { get; set; } = 3;
        public override decimal Weight { get; set; } = 20;
        public override int NumOfLegs { get; set; } = 4;
        // override Sleep method
        public override string Sleep()
        {
            ////proove this function from Tiger class
            return "Tiger Class Say : All Tigers Sleepping";
        }
        // override Eat method

        public override void Eat()
        {
            //proove this function from Tiger class

            Console.WriteLine("Tiger Class Say : All Tigers Eating");
        }
        // override Sound method

        public override string Sound()
        {
            return "Tiger Class Say : All Tiger has a sound and it is like (roar)";
        }
        // override BreastFeeding method
        public override void BreastFeeding()
        {
            //proove this function from Tiger class

            Console.WriteLine("Tiger Class Say : Tiger animal do BreastFeeding");

        }
        // return that tiger is a carnivores
        public string Carnivores()
        {
            return "Tigers Class Say : Tiger is a Carnivores";

        }
    }
}