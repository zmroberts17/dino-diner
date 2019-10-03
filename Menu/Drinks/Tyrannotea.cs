/*  Tyrannotea.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is a drink on the Menu Item
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// This is the size of the drink
        /// </summary>
        private Size size;

        public bool Sweet;

        public bool Lemon;

        /// <summary>
        /// Constructor
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            Sweet = false;
            Lemon = false;
        }

        /// <summary>
        /// This is the get/set for the Size variable
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        if (Sweet) Calories = 16;
                        else Calories = 8;
                        size = value;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet) Calories = 32;
                        else Calories = 16;
                        size = value;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet) Calories = 64;
                        else Calories = 32;
                        size = value;
                        break;
                }
            }
        }

        /// <summary>
        /// This variable is a list of the ingredients of the drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// This method adds cane sugar to the ingredients
        /// </summary>
        public void AddSweet()
        {
            Sweet = true;
            Calories *= 2;
        }

        /// <summary>
        /// This method adds lemon to the ingredients
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

        /// <summary>
        /// This method removes lemon from the ingredients
        /// </summary>
        public void RemoveLemon()
        {
            Sweet = false;
            Calories /= 2;
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            if (Sweet)
                return $"{size} Sweet Tyrannotea";
            else
                return $"{size} Tyrannotea";
        }
    }
}
