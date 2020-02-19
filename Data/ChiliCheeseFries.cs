using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// side class representing Chili Cheese Fries
    /// </summary>
    public class ChiliCheeseFries: Side
    {
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
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
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
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }


        /// <summary>
        /// returns the string representation of the Side
        /// </summary>
        /// <returns>returns Chili Cheese Fries string</returns>
        public override string ToString()
        {
            string b = Size.ToString();
            return  b + " Chili Cheese Fries";
        }


























    }
}
