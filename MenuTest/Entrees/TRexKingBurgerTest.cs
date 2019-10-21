using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void ShouldHaveHoldBunSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldBun();
            string[] special = { "Hold Bun" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldLettuceSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldLettuce();
            string[] special = { "Hold Lettuce" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldTomatoSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldTomato();
            string[] special = { "Hold Tomato" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldPickleSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldPickle();
            string[] special = { "Hold Pickle" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldOnionSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldOnion();
            string[] special = { "Hold Onion" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldKetchupSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldKetchup();
            string[] special = { "Hold Ketchup" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldMustardSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldMustard();
            string[] special = { "Hold Mustard" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldMayoSpecial()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldMayo();
            string[] special = { "Hold Mayo" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            TRexKingBurger king = new TRexKingBurger();
            king.HoldBun();
            king.HoldLettuce();
            king.HoldTomato();
            king.HoldPickle();
            king.HoldOnion();
            king.HoldKetchup();
            king.HoldMustard();
            king.HoldMayo();
            string[] special = { "Hold Bun", "Hold Lettuce", "Hold Tomato", "Hold Pickle", "Hold Onion", "Hold Ketchup", "Hold Mustard", "Hold Mayo" };
            Assert.Equal(king.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.Empty(king.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Whole Wheat Bun")]
        public void HoldBunShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldBun();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Lettuce")]
        public void HoldLettuceShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldLettuce();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Tomato")]
        public void HoldTomatoShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldTomato();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Onion")]
        public void HoldOnionShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldOnion();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Pickle")]
        public void HoldPickleShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldPickle();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ketchup")]
        public void HoldKetchupShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldKetchup();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Mustard")]
        public void HoldMustardShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldMustard();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Mayo")]
        public void HoldMayoShouldNotifyOfPropertyChanged(string propertyName)
        {
            TRexKingBurger king = new TRexKingBurger();
            Assert.PropertyChanged(king, propertyName, () =>
            {
                king.HoldMayo();
            });
        }
    }
}
