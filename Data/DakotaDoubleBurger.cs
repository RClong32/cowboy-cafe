using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Dakota Double Burger entree
    /// </summary>
   public class DakotaDoubleBurger
    {

        private bool bun = true;
        /// <summary>
        /// if the double burger is served on a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }


        private bool ketchup = true;
        /// <summary>
        /// if the double burger is served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }


        private bool mustard = true;
        /// <summary>
        /// if the double burger is served with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }


        private bool pickle = true;
        /// <summary>
        /// if the double burger is served with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }


        private bool cheese = true;
        /// <summary>
        /// if the double burger is served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }



        private bool tomato = true;
        /// <summary>
        /// if the double burger is served with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }


        private bool lettuce = true;
        /// <summary>
        /// if the double burger is served with Lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }


        private bool mayo = true;
        /// <summary>
        /// if the double burger is served with Mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// price of ordering the dakota double burger
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// calories in the dakota double burger entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// special instructions for the preperation of a Dakota double burger entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                return instructions;
            }
        }

























    }
}
