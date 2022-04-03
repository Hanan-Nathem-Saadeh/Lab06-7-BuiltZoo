using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public class ClownFish : Fish
    {
        public override string Name { get; set; } = "ClownFish";
        public override decimal Age { get; set; } = 2;
        public override decimal Weight { get; set; } = 6;
        public override decimal SwimSpeed { get; set; } =100;

        public string Color
        {
            get { return Color = "Orange and white"; }
            set { }
        }


        public override string Sleep()
        {
            return "ClownFish Class Say : All ClownFish Sleepping";
        }
        public override void Eat()
        {

            Console.WriteLine("ClownFish Class Say : All ClownFish Eating");
        }
        public override string Sound()
        {
            return "ClownFish Class Say : All ClownFish has a sound and it is like (Grunts)";
        }
        public void Striped()
        {
            Console.WriteLine("ClownFish Class Say : ClownFish are Striped");

        }
    }
}