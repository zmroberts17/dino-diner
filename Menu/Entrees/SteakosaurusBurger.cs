/*  SteakosaurusBurger.cs
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
    public class SteakosaurusBurger : Entree, IMenuItem
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

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public override List<string> Ingredients
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
            Price = 5.15;
            Calories = 621;
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
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
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
        /// This method adds a bun to the specific order.
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
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Pickle");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds a bun to the specific order.
        /// </summary>
        public void AddPickle()
        {
            this.Pickle = true;
            NotifyOfPropertyChanged("Pickle");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ketchup");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds a bun to the specific order.
        /// </summary>
        public void AddKetchup()
        {
            this.Ketchup = true;
            NotifyOfPropertyChanged("Ketchup");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Mustard");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds a bun to the specific order.
        /// </summary>
        public void AddMustard()
        {
            this.Mustard = true;
            NotifyOfPropertyChanged("Mustard");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
