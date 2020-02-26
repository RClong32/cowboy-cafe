using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  order class that holds the order of a customer
    /// </summary>
    public class Order: INotifyPropertyChanged, IOrderItem
    {

        List<string> SpecialInstructions;

        double Price;











        /// <summary>
        /// event for notifying if properties are changed 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// enemerable of iOrderItem interface's
        /// </summary>
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        /// <summary>
        /// double of subtotal before taxes of total order cost
        /// </summary>
        public double Subtotal => 0;


        /// <summary>
        /// list of IOrderItem items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();


        private uint LastOrderNumber;

        public uint OrderNumber
        {
            get
            {

            }
        }



        /// <summary>
        /// method to add item to a specific order
        /// </summary>
        /// <param name="item">item to be added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        /// <summary>
        ///  method to remove item from specific order
        /// </summary>
        /// <param name="item"> item to be removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
        }


    }
}
