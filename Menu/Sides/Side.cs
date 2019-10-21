/*  Side.cs
 *  Author: Nathan Bean
 *  Modified by: Zane Roberts
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        public string Description
        {
            get { return this.ToString(); }
        }

        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The method that is called when a property is changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that was changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
