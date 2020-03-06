using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree,INotifyPropertyChanged
    {


        private bool bread = true;
        /// <summary>
        /// if the pulled pork is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; PropertyNotify("Bread"); }
        }



        private bool pickle = true;
        /// <summary>
        /// if the Pulled Pork is served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; PropertyNotify("Pickle"); }
        }



        /// <summary>
        /// price of the Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Calories in the Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }



        /// <summary>
        /// Specia instructions for the preperation of the Pecos Pulled Pork
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
        /// <returns>returns Pecos Pork string</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
