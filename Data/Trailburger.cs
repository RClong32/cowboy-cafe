using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Trailburger entree
    /// </summary>
    public class TrailBurger: Entree
    {


        private bool bun = true;
        /// <summary>
        /// if the trailburger is served on a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }


        private bool ketchup = true;
        /// <summary>
        /// if the trailburger is served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }


        private bool mustard = true;
        /// <summary>
        /// if the trailburger is served with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }


        private bool pickle = true;
        /// <summary>
        /// if the trailburger is served with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle;}
            set { pickle = value; }
        }


        private bool cheese = true;
        /// <summary>
        /// if the trailburger is served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value;}
        }

        /// <summary>
        /// Price of ordering the trailburger entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// calories in the trailburger entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// special instructions for the preperation of the Trailburger entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }


    }
}
