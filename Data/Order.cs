using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  order class that holds the order of a customer
    /// </summary>
    public class Order: INotifyPropertyChanged
    {



        /// <summary>
        /// event for notifying if properties are changed 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// enemerable of iOrderItem interface's
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// double of subtotal before taxes of total order cost
        /// </summary>
        private double subtotal = 0;

        public double Subtotal { 
            
            get
            {
                return subtotal;
            } 
        }
        /// <summary>
        /// list of IOrderItem items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();


        private static uint LastOrderNumber = 0;

        public uint OrderNumber
        {
            get
            {
                LastOrderNumber++;
                return LastOrderNumber;
            }
        }



        /// <summary>
        /// method to add item to a specific order
        /// </summary>
        /// <param name="item">item to be added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        ///  method to remove item from specific order
        /// </summary>
        /// <param name="item"> item to be removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Prices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }


    }
}
