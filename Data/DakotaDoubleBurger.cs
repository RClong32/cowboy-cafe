using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Dakota Double Burger entree
    /// </summary>
   public class DakotaDoubleBurger: Entree, INotifyPropertyChanged
    {

        private bool bun = true;
        /// <summary>
        /// if the double burger is served on a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; PropertyNotify("Bun"); }
        }


        private bool ketchup = true;
        /// <summary>
        /// if the double burger is served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; PropertyNotify("Ketchup"); }
        }


        private bool mustard = true;
        /// <summary>
        /// if the double burger is served with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; PropertyNotify("Mustard"); }
        }


        private bool pickle = true;
        /// <summary>
        /// if the double burger is served with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; PropertyNotify("Pickle"); }
        }


        private bool cheese = true;
        /// <summary>
        /// if the double burger is served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; PropertyNotify("Cheese"); }
        }



        private bool tomato = true;
        /// <summary>
        /// if the double burger is served with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; PropertyNotify("Tomato"); }
        }


        private bool lettuce = true;
        /// <summary>
        /// if the double burger is served with Lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; PropertyNotify("Lettuce"); }
        }


        private bool mayo = true;
        /// <summary>
        /// if the double burger is served with Mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; PropertyNotify("Mayo"); }
        }

        /// <summary>
        /// price of ordering the dakota double burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// calories in the dakota double burger entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// special instructions for the preperation of a Dakota double burger entree
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
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                return instructions;
            }
        }


        /// <summary>
        /// returns the string representation of the entree
        /// </summary>
        /// <returns>returns Dakota Burger string</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }






















    }
}
