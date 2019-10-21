/*  Drink.cs
 *  Author: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Super class for the Drinks of the Menu
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public abstract Size Size { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The method that is called when a property is changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that was changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public abstract string[] Special { get; }

        public bool Ice = true;

        /// <summary>
        /// Sets the ice for all the drinks to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Ice");
            NotifyOfPropertyChanged("Special");
        }
    }
}
