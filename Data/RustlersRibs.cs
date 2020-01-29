using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{   /// <summary>
///  A class representing the Rustlers Ribs entree
/// </summary>
    public class RustlersRibs
    {

        /// <summary>
        /// the price of the Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// the calories within the Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special Instructions for the preparation Rustler's Ribs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
            
        }








    }
}
