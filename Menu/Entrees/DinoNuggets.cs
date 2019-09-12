/*  DinoNuggets.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private uint nuggets = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// This method adds a chicken nugget to the order.
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.nuggets += 1;
            this.Calories += 59;
        }
    }
}
