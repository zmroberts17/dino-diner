/* CretaceousCombo.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Gets and sets the toy
        /// </summary>
        public string Toy { get; private set; }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Size of the combo
        /// </summary>
        private Size size;

        public Size Size
        {
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified information
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Toy = "...";
        }

        /// <summary>
        /// This method returns the string that refers to the menu item.
        /// </summary>
        /// <returns>The string that refers to the menu item</returns>
        public override string ToString()
        {
            return $"{Entree.ToString()} Combo";
        }
    }
}
