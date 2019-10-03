/*  PrehistoricPBJ.cs
 *  Author: Nathan Bean
 *  Modified by: Zane Roberts
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class contains information for this specific menu item.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
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
        }

        /// <summary>
        /// This method withholds the given item from the specific order.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
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
