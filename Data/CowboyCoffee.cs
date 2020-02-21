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
        ///   gets weathers theres cream or not
        /// </summary>
        private bool roomforcream = false;
        /// <summary>
        /// If the coffee has cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }

        /// <summary>
        ///   gets weathers theres decaf or not
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// If the coffee has cream
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        ///   gets weathers theres ice or not
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// If the coffee has Ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }


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
                    default:
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

        /// <summary>
        /// returns the string representation of the Drink
        /// </summary>
        /// <returns>returns Cowboy Coffee string</returns>
        public override string ToString()
        {
            
            string b = Size.ToString();
            if(Decaf == true)
            {
                return b + " Decaf Cowboy Coffee";
            }
            else
            {
                return b + " Cowboy Coffee";
            }
            
        }


    }
}
