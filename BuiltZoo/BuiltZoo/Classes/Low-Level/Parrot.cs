using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public class Parrot : Birds
    {
        //override Properties from parent classes

      //Default Values
        public override string Name { get; set; } = "Parrot";
        public override decimal Age { get; set; } = 1;
        public override decimal Weight { get; set; } = 2;
        // override Sleep method

        public override string Sleep()
        {
            ////proove this function from Animal class
            return "Parrot Class Say : All Parrots Sleepping";
        }
        // override Eat method

        public override void Eat()
        {
            //proove this function from Kangaroo class

            Console.WriteLine("Parrot Class Say : All Parrots Eating");
        }
        // override Sound method

        public override string Sound()
        {
            return "Parrot Class Say : All Parrots has a sound and it is like (chatter)";
        }
        // override Fly method

        public override void Fly()
        {
            Console.WriteLine("Parrot Class Say : All Parrots can fly");
        }
        public string ImitateSpeech()
        {
          return "Parrot Class Say : Parrots ImitateSpeech";
        }
    }
}