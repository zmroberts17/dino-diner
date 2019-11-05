/* Order.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : IOrderItem, IObservable<IOrderItem>, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for the Order class
        /// </summary>
        public Order()
        {

        }

        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
        }

        /// <summary>
        /// The method that is called when a property is changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that was changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// List of the items in the order
        /// </summary>
        private ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// This is the cost of the order without tax
        /// </summary>
        private double subtotalCost;

        /// <summary>
        /// This is the rate of sales tax
        /// </summary>
        private double salesTaxRate = .10;

        /// <summary>
        /// This is the total cost of the sales tax
        /// </summary>
        private double salesTaxCost;

        /// <summary>
        /// This is the sales tax cost plus the subtotal cost
        /// </summary>
        private double totalCost;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Get and set methods for the Items variable
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                return items;
            }
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnItemPropertyChanged;
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return removed;
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Get and set methods for the SubtotalCost variable
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    cost += items[i].Price;
                }
                subtotalCost = cost;
                if (cost < 0)
                {
                    subtotalCost = 0;
                }
                return subtotalCost;
            }
        }
        
        /// <summary>
        /// Get and set methods for the SalesTaxRate variable
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            protected set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// Get method for the SalesTaxCost variable
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Get method for the TotalCost variable
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }

        /// <summary>
        /// Get method for the Price
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Get method for the Description
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Get method for the Special
        /// </summary>
        public string[] Special { get; }

        /// <summary>
        /// Implemented because of the IObservable interface
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<IOrderItem> observer)
        {
            throw new NotImplementedException();
        }
    }
}
