using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// side class representing Corn Dodgers
    /// </summary>
    public class CornDodgers: Side
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
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
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
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// returns the string representation of the Side
        /// </summary>
        /// <returns>returns Corn Dodgers string</returns>
        public override string ToString()
        {
            string b = Size.ToString();
            return b + " Corn Dodgers";
        }



        public override List<string> SpecialInstructions { get; }

















    }
}
