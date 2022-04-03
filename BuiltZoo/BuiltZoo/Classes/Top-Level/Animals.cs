using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{
    //abstract class
    public abstract class Animals  //Parent Class
    {
        //Every Animals will have the following properties
        // 3 abstract Properties

        /// <summary>
        /// What's the name of this animal?
        /// </summary>
        public abstract string Name {get ;set;}
        /// <summary>
        /// What's the Age of this animal?
        /// </summary>
        public abstract decimal Age {get;set;}
        /// <summary>
        /// What's the Weight of this animal?
        /// </summary>
        public abstract decimal Weight { get;set;}

        /// <summary>
        /// Virtual method that returns a string representation of the concrete animal's sleep.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's sleeping
        /// </returns>
        public virtual string Sleep()
        {
            ////proove this function from Animal class
           return "Animal Class Say : All animals Sleepping";
        }

        /// <summary>
        /// Virtual method that returns a string representation of the concrete animal's eating.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's eating
        /// </returns>
        public virtual void Eat()
        {
            //proove this function from Animal class

            Console.WriteLine("Animal Class Say : All animals Eating");
        }
     
        /// <summary>
        /// Abstract method will be override in the child's classes to represent the animal sound.
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete animal object's sound
        /// </returns>
        public abstract string Sound();
    }
}