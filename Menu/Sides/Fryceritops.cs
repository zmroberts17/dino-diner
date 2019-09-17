/*  Fryceritops.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// This class contains information for this specific menu item
    /// </summary>
    public class Fryceritops : Side
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
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// This gets and sets the size while changing the Price and Calories in accordance
        /// </summary>
        public Fryceritops()
        {
            Calories = 222;
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
    }
}
