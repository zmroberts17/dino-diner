using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void ShouldHaveHoldBunSpecial()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldBun();
            string[] special = { "Hold Bun" };
            Assert.Equal(steak.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldPickleSpecial()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldPickle();
            string[] special = { "Hold Pickle" };
            Assert.Equal(steak.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldKetchupSpecial()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldKetchup();
            string[] special = { "Hold Ketchup" };
            Assert.Equal(steak.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldMustardSpecial()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldMustard();
            string[] special = { "Hold Mustard" };
            Assert.Equal(steak.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            steak.HoldBun();
            steak.HoldPickle();
            steak.HoldKetchup();
            steak.HoldMustard();
            string[] special = { "Hold Bun", "Hold Pickle", "Hold Ketchup", "Hold Mustard" };
            Assert.Equal(steak.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.Empty(steak.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Whole Wheat Bun")]
        public void HoldBunShouldNotifyOfPropertyChanged(string propertyName)
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, propertyName, () =>
            {
                steak.HoldBun();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Pickle")]
        public void HoldPickleShouldNotifyOfPropertyChanged(string propertyName)
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, propertyName, () =>
            {
                steak.HoldPickle();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ketchup")]
        public void HoldKetchupShouldNotifyOfPropertyChanged(string propertyName)
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, propertyName, () =>
            {
                steak.HoldKetchup();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Mustard")]
        public void HoldMustardShouldNotifyOfPropertyChanged(string propertyName)
        {
            SteakosaurusBurger steak = new SteakosaurusBurger();
            Assert.PropertyChanged(steak, propertyName, () =>
            {
                steak.HoldMustard();
            });
        }
    }
}
