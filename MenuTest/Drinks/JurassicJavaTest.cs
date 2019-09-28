using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        // The correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        // The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        // The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        // The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(Size.Small, java.Size);
        }

        // correct default space for cream
        [Fact] 
        public void ShouldNotHaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        // correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        // correct price after setting small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        // correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        // correct price after setting medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        // correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        // correct price after setting large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        // LeaveRoomForCream works
        [Fact]
        public void LeaveRoomForCreamShouldLeaveRoom()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        // AddIce works
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains("Water", java.Ingredients);
            Assert.Contains("Coffee", java.Ingredients);
        }
    }
}
