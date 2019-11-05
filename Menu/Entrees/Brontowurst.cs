/*  Brontowurst.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class Brontowurst : Entree
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
        /// Get method for specials
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!WholeWheatBun) special.Add("Hold Bun");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onions) special.Add("Hold Onion");
                return special.ToArray();
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
            NotifyOfPropertyChanged("Whole Wheat Bun");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddBun()
        {
            this.WholeWheatBun = true;
            NotifyOfPropertyChanged("Whole Wheat Bun");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
            NotifyOfPropertyChanged("Peppers");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddPeppers()
        {
            this.Peppers = true;
            NotifyOfPropertyChanged("Peppers");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
            NotifyOfPropertyChanged("Onion");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddOnion()
        {
            this.Onions = true;
            NotifyOfPropertyChanged("Onion");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
