using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuiltZoo
{

    public abstract class Birds : Animals //Derived Class From Animals && parent Class for Parrot class
    {
        // Encapsulation
        // 
        private bool HasLongNeck { get; set; }
        private string FeatherColor { get; set; }
      
       


        /// <summary>
        /// Abstract method will be override in the child's classes to represent the concrete Bird's Flying
        /// </summary>
        /// <returns>
        /// string: a representation of the concrete Birds object's fly
        /// </returns>
        public abstract void Fly();
        
    }
}