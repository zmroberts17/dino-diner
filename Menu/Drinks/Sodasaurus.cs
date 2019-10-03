/*  Sodasaurus.cs
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
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// This is the size of the drink
        /// </summary>
        private Size size;

        public SodasaurusFlavor Flavor;

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
                switch (value)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        size = value;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        size = value;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        size = value;
                        break;

                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
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
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return $"{size} {Flavor} Sodasaurus";
        }
    }
}
