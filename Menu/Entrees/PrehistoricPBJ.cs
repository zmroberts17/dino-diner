﻿/*  PrehistoricPBJ.cs
 *  Author: Nathan Bean
 *  Modified by: Zane Roberts
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
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
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Peanut Butter");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddPeanutButter()
        {
            this.peanutButter = true;
            NotifyOfPropertyChanged("Peanut Butter");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Jelly");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method adds the given item to the specific order.
        /// </summary>
        public void AddJelly()
        {
            this.jelly = true;
            NotifyOfPropertyChanged("Jelly");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
