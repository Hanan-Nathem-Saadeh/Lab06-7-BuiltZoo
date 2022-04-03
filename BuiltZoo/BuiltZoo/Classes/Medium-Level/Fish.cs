using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    public abstract class Fish : Animals // //Derived Class from Animals Class && parent for Shark and ClownFish classes
    {
        // virtual Property

        public virtual int NumberOfFins { get; set; } = 2;


        /// <summary>
        /// Abstract method will be override in the child's classes to represent the Fish Speed
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete Fish object's Speed
        /// </returns>
        /// 
        // abstract probirity
        public abstract decimal SwimSpeed { get; set; }

        //override Sleep method

        public override string Sleep()
        {
            return "Fish Class Say : All Fish Sleepping";
        }
        //override eat method
        public override void Eat()
        {
            Console.WriteLine("Fish Class Say : All Fish Eating");
        }
        

        /// <summary>
        /// Virtual method that returns a string representation of the concrete Fish Swimming.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete Fish object's Swimming
        /// </returns>
        public virtual string Swim()
        {
            return "Fish Class Say : This Fish can Swim";

        }

    }
}

