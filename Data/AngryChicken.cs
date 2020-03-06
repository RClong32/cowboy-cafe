using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{

    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree, INotifyPropertyChanged
    {

        
        private bool bread = true;
        /// <summary>
        /// if the chicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; PropertyNotify("Bread"); }
        }

        
        private bool pickle = true;
        /// <summary>
        /// if the Chicken is served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; PropertyNotify("Pickle"); }
        }

        /// <summary>
        /// price of the angry chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Calories in the angry chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Specia instructions for the preperation of the Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// returns the string representation of the entree
        /// </summary>
        /// <returns>returns Angry chicken string</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }












    }
}
