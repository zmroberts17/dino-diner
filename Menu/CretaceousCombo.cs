/* CretaceousCombo.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class serves as a menu item that serves for one entree, side, and drink.
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        /// <summary>
        /// Get method for the description
        /// </summary>
        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Entree.ToString());
                sb.Append(Environment.NewLine);
                sb.Append(Side.ToString());
                sb.Append(Environment.NewLine);
                sb.Append(Drink.ToString());
                return sb.ToString();
            }
        }

        /// <summary>
        /// Get method for the specials
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange((IEnumerable<string>)Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

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
                ingredients.AddRange((IEnumerable<string>)Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Size of the combo
        /// </summary>
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The method that is called when a property is changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that was changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
