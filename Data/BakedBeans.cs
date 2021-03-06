﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    public class BakedBeans: Side, INotifyPropertyChanged
    {
        private Size size;

        public override Size Size
        {
            get { return size; }
            set { Size = value; PropertyNotify("Size"); }
        }
        /// <summary>
        ///method for getting the price based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
        /// <summary>
        /// method for getting the number of calories based on zise
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// returns the string representation of the Side
        /// </summary>
        /// <returns>returns Baked Beans string</returns>
        public override string ToString()
        {
            string b = Size.ToString();
            return b + " Baked Beans";
        }


        public override List<string> SpecialInstructions { get; }



    }
}
