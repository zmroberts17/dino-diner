using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectItemsInOrder()
        {
            Order order = new Order();
            Brontowurst b = new Brontowurst();
            order.Add(b);
            MezzorellaSticks sticks = new MezzorellaSticks();
            order.Add(sticks);
            JurassicJava java = new JurassicJava();
            order.Add(java);

            IOrderItem[] items = { b, sticks, java };
            
            for (int i = 0; i < order.Items.Count; i++)
            {
                Assert.Equal(order.Items[i].ToString(), items[i].ToString());
            }
        }

        [Fact]
        public void ShouldHaveCorrectSubtotalCost()
        {
            Order order = new Order();
            Brontowurst b = new Brontowurst();
            order.Add(b);
            MezzorellaSticks sticks = new MezzorellaSticks();
            order.Add(sticks);
            JurassicJava java = new JurassicJava();
            order.Add(java);

            double cost = 0;
            cost += b.Price;
            cost += sticks.Price;
            cost += java.Price;
            Assert.Equal(order.SubtotalCost, cost);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxRate()
        {
            Order order = new Order();
            Brontowurst b = new Brontowurst();
            order.Add(b);
            MezzorellaSticks sticks = new MezzorellaSticks();
            order.Add(sticks);
            JurassicJava java = new JurassicJava();
            order.Add(java);

            Assert.Equal(.10, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTaxCost()
        {
            Order order = new Order();
            Brontowurst b = new Brontowurst();
            order.Add(b);
            MezzorellaSticks sticks = new MezzorellaSticks();
            order.Add(sticks);
            JurassicJava java = new JurassicJava();
            order.Add(java);

            double cost = order.SubtotalCost;
            double stc = cost * order.SalesTaxRate;

            Assert.Equal(order.SalesTaxCost, stc);
        }

        [Fact]
        public void ShouldHaveCorrectTotal()
        {
            Order order = new Order();
            Brontowurst b = new Brontowurst();
            order.Add(b);
            MezzorellaSticks sticks = new MezzorellaSticks();
            order.Add(sticks);
            JurassicJava java = new JurassicJava();
            order.Add(java);

            double total = order.SalesTaxCost + order.SubtotalCost;

            Assert.Equal(order.TotalCost, total);
        }

        [Fact]
        public void SubtotalShouldNotBeNegative()
        {
            Order order = new Order();
            Brontowurst b = new Brontowurst();
            b.Price = -10.00;
            order.Add(b);

            Assert.Equal(0, order.SubtotalCost);
        }
    }
}
