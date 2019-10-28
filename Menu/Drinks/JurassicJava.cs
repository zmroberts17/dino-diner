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
    public class JurassicJava : Drink
    {
        /// <summary>
        /// This is the size of the drink
        /// </summary>
        private Size size;

        public bool RoomForCream;

        public bool Decaf;

        public bool Lemon;

        /// <summary>
        /// Get method for specials
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
                if (Lemon) special.Add("Add Lemon");
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
                        Price = 0.59;
                        Calories = 2;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
        public JurassicJava()
        {
            Ice = false;
            Price = 0.59;
            Calories = 2;
            RoomForCream = false;
            Decaf = false;
            Lemon = false;
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
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }

        /// <summary>
        /// This method leaves room for cream in the drink
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Room For Cream");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method removes the room for cream
        /// </summary>
        public void RemoveRoomForCream()
        {
            RoomForCream = false;
            NotifyOfPropertyChanged("Room For Cream");
            NotifyOfPropertyChanged("Special");
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
        /// This method adds a lemon to the drink
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method removes the lemon from the drink
        /// </summary>
        public void RemoveLemon()
        {
            Lemon = false;
            NotifyOfPropertyChanged("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method makes the drink decaf
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
            NotifyOfPropertyChanged("Decaf");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// This method makes the drink not decaf
        /// </summary>
        public void MakeNotDecaf()
        {
            Decaf = false;
            NotifyOfPropertyChanged("Decaf");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Description");
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
