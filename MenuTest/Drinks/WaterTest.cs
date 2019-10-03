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
    }
}
