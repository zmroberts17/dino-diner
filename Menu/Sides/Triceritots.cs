/*  Triceritots.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains information for this specific menu item
    /// </summary>
    public class Triceritots : Side, IMenuItem
    {
        /// <summary>
        /// This is the size of the side
        /// </summary>
        private Size size;

        /// <summary>
        /// This gets and sets the size while changing the Price and Calories in accordance
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Triceritots()
        {
            Calories = 352;
            Price = 0.99;
        }

        /// <summary>
        /// Get method for Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return $"{size} Triceritots";
        }
    }
}
