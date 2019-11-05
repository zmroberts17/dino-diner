/*  VelociWrap.cs
 *  Author: Zane Roberts
 */using System;

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool FlourTortilla = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool ChickenBreast = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool RomaineLettuce = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool CaesarDressing = true;

        /// <summary>
        /// This variable is an ingredient for this menu item and can be removed upon request.
        /// </summary>
        private bool ParmesanCheese = true;

        /// <summary>
        /// List of ingredients within the menu item
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (FlourTortilla) ingredients.Add("Flour Tortilla");
                if (ChickenBreast) ingredients.Add("Chicken Breast");
                if (RomaineLettuce) ingredients.Add("Romaine Lettuce");
                if (CaesarDressing) ingredients.Add("Ceasar Dressing");
                if (ParmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Get method for specials
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!CaesarDressing) special.Add("Hold Dressing");
                if (!RomaineLettuce) special.Add("Hold Lettuce");
                if (!ParmesanCheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldDressing()
        {
            this.CaesarDressing = false;
            NotifyOfPropertyChanged("Dressing");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The method adds cheese to the specific order.
        /// </summary>
        public void AddDressing()
        {
            this.CaesarDressing = true;
            NotifyOfPropertyChanged("Dressing");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldLettuce()
        {
            this.RomaineLettuce = false;
            NotifyOfPropertyChanged("Lettuce");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The method adds cheese to the specific order.
        /// </summary>
        public void AddLettuce()
        {
            this.RomaineLettuce = true;
            NotifyOfPropertyChanged("Lettuce");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldCheese()
        {
            this.ParmesanCheese = false;
            NotifyOfPropertyChanged("Cheese");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// The method adds cheese to the specific order.
        /// </summary>
        public void AddCheese()
        {
            this.ParmesanCheese = true;
            NotifyOfPropertyChanged("Cheese");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
