using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {


        private bool bread = true;
        /// <summary>
        /// if the pulled pork is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }



        private bool pickle = true;
        /// <summary>
        /// if the Pulled Pork is served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }



        /// <summary>
        /// price of the Pecos Pulled Pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Calories in the Pecos Pulled Pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }



        /// <summary>
        /// Specia instructions for the preperation of the Pecos Pulled Pork
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }




    }
}
