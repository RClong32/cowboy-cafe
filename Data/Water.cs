using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// water drink class
    /// </summary>
    public class Water: Drink
    {
        /// <summary>
        ///   gets weathers theres lemon or not
        /// </summary>
        public bool Lemon = false;


        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Small:
                        return 0.12;
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
                            return 0;
                        case Size.Medium:
                            return 0;
                        case Size.Small:
                            return 0;
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
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }







    }
}
