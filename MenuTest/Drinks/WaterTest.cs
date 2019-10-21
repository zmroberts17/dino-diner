using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class WaterTest
    {
        // The correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        // The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        // The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        // The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }

        // correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        // correct price after setting small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        // correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        // correct price after setting medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        // correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }
        // correct price after setting large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        // HoldIce holds ice
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        // AddLemon adds the lemon
        [Fact] 
        public void AddLemonShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        // correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            Assert.Contains("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
            water.AddLemon();
            Assert.Contains("Lemon", water.Ingredients);
        }

        [Fact]
        public void ShouldHaveAddLemonSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            string[] special = { "Add Lemon" };
            Assert.Equal(water.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldIceSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            string[] special = { "Hold Ice" };
            Assert.Equal(water.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            Water water = new Water();
            water.AddLemon();
            water.HoldIce();
            string[] special = { "Add Lemon", "Hold Ice" };
            Assert.Equal(water.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Description")]
        public void ChangingSizeShouldNotifyOfPropertyChanged(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = Size.Medium;
            });
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = Size.Large;
            });
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = Size.Small;
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Lemon")]
        public void AddLemonShouldNotifyOfPropertyChanged(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.AddLemon();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ice")]
        public void HoldIceShouldNotifyOfPropertyChanged(string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.HoldIce();
            });
        }
    }
}
