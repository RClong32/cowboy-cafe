using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// a base class representing a entree
    /// </summary>
    public abstract class Entree: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// gets the Calories in each entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets te special instructions for each entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


        public event PropertyChangedEventHandler PropertyChanged;


        protected void PropertyNotify(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }












    }
}
