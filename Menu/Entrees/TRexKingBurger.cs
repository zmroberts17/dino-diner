/*  TRexKingBurger.cs
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
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool wholeWheatBun = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private int steakburgerPatties = 3;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                for (int i = 0; i < steakburgerPatties; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }

        /// <summary>
        /// Get method for specials
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!wholeWheatBun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!pickle) special.Add("Hold Pickle");
                if (!onion) special.Add("Hold Onion");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
            NotifyOfPropertyChanged("Whole Wheat Bun");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddBun()
        {
            this.wholeWheatBun = true;
            NotifyOfPropertyChanged("Whole Wheat Bun");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Lettuce");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddLettuce()
        {
            this.lettuce = true;
            NotifyOfPropertyChanged("Lettuce");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("Tomato");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddTomato()
        {
            this.tomato = true;
            NotifyOfPropertyChanged("Tomato");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Onion");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddOnion()
        {
            this.onion = true;
            NotifyOfPropertyChanged("Onion");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Pickle");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddPickle()
        {
            this.pickle = true;
            NotifyOfPropertyChanged("Pickle");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Ketchup");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddKetchup()
        {
            this.ketchup = true;
            NotifyOfPropertyChanged("Ketchup");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Mustard");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddMustard()
        {
            this.mustard = true;
            NotifyOfPropertyChanged("Mustard");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChanged("Mayo");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddMayo()
        {
            this.mayo = true;
            NotifyOfPropertyChanged("Mayo");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
