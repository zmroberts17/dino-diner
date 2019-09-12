/*  SteakosaurusBurger.cs
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
    public class SteakosaurusBurger
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool WholeWheatBun = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool SteakburgerPattie = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Pickle = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Ketchup = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Mustard = true;

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
                if (WholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (SteakburgerPattie) ingredients.Add("Steakburger Pattie");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldBun()
        {
            this.WholeWheatBun = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }
    }
}
