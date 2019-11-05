/*  DinoNuggets.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private uint nuggets = 6;

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public override List<string> Ingredients
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

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggets > 6)
                {
                    special.Add($"{nuggets - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59 * 6;
        }

        /// <summary>
        /// This method adds a chicken nugget to the order.
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.nuggets += 1;
            this.Calories += 59;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method removes a nugget from the order.
        /// </summary>
        public void RemoveNugget()
        {
            if (nuggets > 6)
            {
                this.Price -= .25;
                this.nuggets -= 1;
                this.Calories -= 59;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
