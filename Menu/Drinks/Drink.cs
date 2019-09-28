/*  Drink.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Enum for the size of the drink
    /// </summary>
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// Super class for the Drinks of the Menu
    /// </summary>
    public abstract class Drink
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public abstract Size Size { get; set; }

        public bool Ice = true;

        /// <summary>
        /// Sets the ice for all the drinks to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
