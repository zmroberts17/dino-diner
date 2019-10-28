/*  Sodasaurus.cs
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
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// This is the size of the drink
        /// </summary>
        private Size size;

        /// <summary>
        /// This is the flavor of the Sodasaurus
        /// </summary>
        private SodasaurusFlavor flavor;

        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
                NotifyOfPropertyChanged("Description");
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
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
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
                size = value;
                switch (value)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
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
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// This method adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Ice");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return $"{size} {Flavor} Sodasaurus";
        }
    }
}
