﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{   /// <summary>
///  A class representing the Rustlers Ribs entree
/// </summary>
    public class RustlersRibs: Entree
    {

        /// <summary>
        /// the price of the Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// the calories within the Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special Instructions for the preparation Rustler's Ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
            
        }

        /// <summary>
        /// returns the string representation of the entree
        /// </summary>
        /// <returns>returns Rustlers Ribs string</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }






    }
}
