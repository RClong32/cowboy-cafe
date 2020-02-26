using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// IOroder interface for Order class
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        ///  interface retrieving the special instructions from entree side and drink classes
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        ///  interface retrieving the price from the entree drink and side classes
        /// </summary>
        double Price { get; }


    }
}
