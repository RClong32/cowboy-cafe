using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// cowboy coffe class
    /// </summary>
    public class CowboyCoffee: Drink
    {
        /// <summary>
        /// weather to add cream or not
        /// </summary>
        public bool RoomForCream = false;

        /// <summary>
        /// ice set to false
        /// </summary>
        public override bool Ice = false;


        /// <summary>
        ///method for getting the price based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return .60;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }


        /// <summary>
        /// method for getting the number of calories based on sise
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }


        /// <summary>
        /// Specia instructions for the preperation of the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }


    }
}
