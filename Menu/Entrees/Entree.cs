using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Gets the ingredients
        /// </summary>
        public abstract List<string> Ingredients { get; }

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
