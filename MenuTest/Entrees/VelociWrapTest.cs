using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void ShouldHaveHoldDressingSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldDressing();
            string[] special = { "Hold Dressing" };
            Assert.Equal(wrap.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldLettuceSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldLettuce();
            string[] special = { "Hold Lettuce" };
            Assert.Equal(wrap.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldCheeseSpecial()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldCheese();
            string[] special = { "Hold Cheese" };
            Assert.Equal(wrap.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            VelociWrap wrap = new VelociWrap();
            wrap.HoldDressing();
            wrap.HoldLettuce();
            wrap.HoldCheese();
            string[] special = { "Hold Dressing", "Hold Lettuce", "Hold Cheese" };
            Assert.Equal(wrap.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            VelociWrap wrap = new VelociWrap();
            Assert.Empty(wrap.Special);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Dressing")]
        public void HoldDressingShouldNotifyOfPropertyChanged(string propertyName)
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, propertyName, () =>
            {
                wrap.HoldDressing();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Lettuce")]
        public void HoldLettuceShouldNotifyOfPropertyChanged(string propertyName)
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, propertyName, () =>
            {
                wrap.HoldLettuce();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Cheese")]
        public void HoldCheeseShouldNotifyOfPropertyChanged(string propertyName)
        {
            VelociWrap wrap = new VelociWrap();
            Assert.PropertyChanged(wrap, propertyName, () =>
            {
                wrap.HoldCheese();
            });
        }
    }
}
