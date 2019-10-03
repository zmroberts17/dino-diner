/*  JurassicJava.cs
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
    public class JurassicJava : Drink, IMenuItem
    {
        /// <summary>
        /// This is the size of the drink
        /// </summary>
        private Size size;

        public bool RoomForCream;

        public bool Decaf;

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
                        Price = 0.59;
                        Calories = 2;
                        size = value;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        size = value;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        size = value;
                        break;

                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public JurassicJava()
        {
            Ice = false;
            Price = 0.59;
            Calories = 2;
            RoomForCream = false;
            Decaf = false;
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
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// This method leaves room for cream in the drink
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// This method adds ice to the drink
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            if (Decaf)
                return ($"{size} Decaf Jurassic Java");
            else
                return $"{size} Jurassic Java";
        }
    }
}
