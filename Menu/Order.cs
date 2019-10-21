/* Order.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Menu
{
    public class Order : IOrderItem, IObservable<IOrderItem>
    {
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

        /// <summary>
        /// Get and set methods for the Items variable
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
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

        /// <summary>
        /// This method adds an item to the order
        /// </summary>
        /// <param name="i">The Item to be added</param>
        public void AddItem(IOrderItem i)
        {
            Items.Add(i);
        }
    }
}
