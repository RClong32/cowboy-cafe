using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }


        public abstract List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void PropertyNotify(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }
    }

    
}
