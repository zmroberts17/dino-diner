/*  VelociWrap.cs
 *  Author: Zane Roberts
 */using System;

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class VelociWrap
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
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldDressing()
        {
            this.CaesarDressing = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldLettuce()
        {
            this.RomaineLettuce = false;
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldCheese()
        {
            this.ParmesanCheese = false;
        }
    }
}
