using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// jerked soda class
    /// </summary>
    public class JerkedSoda: Drink
    {

        /// <summary>
        /// soda flavor enum
        /// </summary>
        public SodaFlavor Flavor { get; set; }



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
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }


        /// <summary>
        /// method for getting the number of calories based on zise
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }


        /// <summary>
        /// Specia instructions for the preperation of the Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }



    }
}
