using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// inherited abstract drink class
    /// </summary>
    public abstract class Drink
    {

        /// <summary>
        /// Gets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// gets weather theres ice or not
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// gets the price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the Calories
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets te special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }









    }
}
