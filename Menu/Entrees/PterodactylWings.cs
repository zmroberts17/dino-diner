/*  PterodactylWings.cs
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
    public class PterodactylWings
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Chicken = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool WingSauce = true;

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
                if (Chicken) ingredients.Add("Chicken");
                if (WingSauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
