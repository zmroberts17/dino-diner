/*  Brontowurst.cs
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
    public class Brontowurst : Entre
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Brautwurst = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool WholeWheatBun = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Peppers = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool Onions = true;

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public override List<string> Ingredients {
            get
            {
                List<string> ingredients = new List<string>();
                if (Brautwurst) ingredients.Add("Brautwurst");
                if (WholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
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
        public void HoldPeppers()
        {
            this.Peppers = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }
    }
}
