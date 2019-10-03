/* IMenuItem.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface that contains Price, Calories, and Ingredients
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Variable that will be used in MenuItems
        /// </summary>
        double Price
        {
            get;
        }

        /// <summary>
        /// Variable that will be used in MenuItems
        /// </summary>
        uint Calories
        {
            get;
        }

        /// <summary>
        /// Variable that will be used in MenuItems
        /// </summary>
        List<string> Ingredients
        {
            get;
        }
    }
}
