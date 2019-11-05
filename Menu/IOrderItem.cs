/* IOrderItem.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Item within the Order.cs
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The Price of the item
        /// </summary>
        double Price
        {
            get;
        }

        /// <summary>
        /// The description of the item
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// The specials of the item
        /// </summary>
        string[] Special
        {
            get;
        }
    }
}
