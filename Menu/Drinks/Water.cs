/*  Water.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is a drink on the Menu Item
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// This is the size of the drink
        /// </summary>
        private Size size;

        public bool Lemon;

        /// <summary>
        /// This is the get/set for the Size variable
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                Price = 0.10;
                Calories = 0;
                size = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Lemon = false;
        }

        /// <summary>
        /// This variable is a list of the ingredients of the drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// This method adds a lemon to the ingredients of the drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return $"{size} Water";
        }
    }
}
