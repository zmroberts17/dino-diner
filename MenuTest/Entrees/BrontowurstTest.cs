using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void ShouldHaveHoldBunSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            string[] special = { "Hold Bun" };
            Assert.Equal(b.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldPeppersSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            string[] special = { "Hold Peppers" };
            Assert.Equal(b.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldOnionSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            string[] special = { "Hold Onion" };
            Assert.Equal(b.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldPeppers();
            b.HoldOnion();
            string[] special = { "Hold Bun", "Hold Peppers", "Hold Onion" };
            Assert.Equal(b.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Whole Wheat Bun")]
        public void HoldBunShouldNotifyOfPropertyChanged(string propertyName)
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, propertyName, () =>
            {
                b.HoldBun();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Peppers")]
        public void HoldPeppersShouldNotifyOfPropertyChanged(string propertyName)
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, propertyName, () =>
            {
                b.HoldPeppers();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Onion")]
        public void HoldOnionShouldNotifyOfPropertyChanged(string propertyName)
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, propertyName, () =>
            {
                b.HoldOnion();
            });
        }
    }
}
