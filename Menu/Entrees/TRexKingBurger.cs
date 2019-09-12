/*  TRexKingBurger.cs
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
    public class TRexKingBurger
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
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
