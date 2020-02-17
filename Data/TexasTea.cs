using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Texas Tea class
    /// </summary>
   public class TexasTea: Drink
    {

        /// <summary>
        /// weather to add cream or not
        /// </summary>
        public bool Lemon = false;



        /// <summary>
        /// weather to add cream or not
        /// </summary>
        public bool Sweet = true;



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
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
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
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                            throw new NotImplementedException("Unknown Size");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                            throw new NotImplementedException("Unknown Size");
                    }
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
