using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
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

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void ShouldHaveLeaveRoomForCreamSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            string[] special = { "Leave Room For Cream" };
            Assert.Equal(java.Special, special);
        }

        [Fact]
        public void ShouldHaveIceSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            string[] special = { "Add Ice" };
            Assert.Equal(java.Special, special);
        }

        [Fact]
        public void ShouldHaveLemonSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddLemon();
            string[] special = { "Add Lemon" };
            Assert.Equal(java.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.AddLemon();
            java.AddIce();
            string[] special = { "Leave Room For Cream", "Add Ice", "Add Lemon" };
            Assert.Equal(java.Special, special);
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Size")]
        [InlineData("Description")]
        public void ChangingSizeShouldNotifyOfPropertyChanged(string propertyName)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, propertyName, () =>
            {
                java.Size = Size.Medium;
            });
            Assert.PropertyChanged(java, propertyName, () =>
            {
                java.Size = Size.Large;
            });
            Assert.PropertyChanged(java, propertyName, () =>
            {
                java.Size = Size.Small;
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Lemon")]
        public void AddLemonShouldNotifyOfPropertyChanged(string propertyName)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, propertyName, () =>
            {
                java.AddLemon();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Room For Cream")]
        public void LeaveRoomForCreamShouldNotifyOfPropertyChanged(string propertyName)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, propertyName, () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ice")]
        public void AddIceShouldNotifyOfPropertyChanged(string propertyName)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, propertyName, () =>
            {
                java.AddIce();
            });
        }
    }
}
