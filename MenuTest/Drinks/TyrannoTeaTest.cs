using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class TyrannoteaTest
    {
        // The correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        // The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        // The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(Size.Small, tea.Size);
        }

        // The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        // correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        // correct price after setting small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        // correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        // correct price after setting medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        // correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        // correct price after setting large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        // Hold Ice works
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        // AddLemon works
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        // Sweet Property changes calories
        [Fact]
        public void SweetPropertyShouldChangeCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        // Removing Sweet Property decreases Calories
        [Fact]
        public void RemovingSweetPropertyShouldDecreaseCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweet();
            tea.RemoveSweet();
            Assert.Equal<uint>(8, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        // correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains("Water", tea.Ingredients);
            Assert.Contains("Tea", tea.Ingredients);
            Assert.Equal(2, tea.Ingredients.Count);
            tea.AddLemon();
            Assert.Contains("Lemon", tea.Ingredients);
            tea.AddSweet();
            Assert.Contains("Cane Sugar", tea.Ingredients);
        }

        [Fact]
        public void ShouldHaveAddLemonSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            string[] special = { "Add Lemon" };
            Assert.Equal(tea.Special, special);
        }

        [Fact]
        public void ShouldHaveHoldIceSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            string[] special = { "Hold Ice" };
            Assert.Equal(tea.Special, special);
        }

        [Fact]
        public void ShouldHaveAllSpecials()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.HoldIce();
            string[] special = { "Add Lemon", "Hold Ice" };
            Assert.Equal(tea.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Size")]
        [InlineData("Description")]
        public void ChangingSizeShouldNotifyOfPropertyChanged(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Size = Size.Large;
            });
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.Size = Size.Small;
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Lemon")]
        public void AddLemonShouldNotifyOfPropertyChanged(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.AddLemon();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Lemon")]
        public void RemoveLemonShouldNotifyOfPropertyChanged(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.RemoveLemon();
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ice")]
        public void HoldIceShouldNotifyOfPropertyChanged(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.HoldIce();
            });
        }

        [Theory]
        [InlineData("Sweet")]
        [InlineData("Calories")]
        [InlineData("Special")]
        [InlineData("Description")]
        public void AddSweetShouldNotifyOfPropertyChanged(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.AddSweet();
            });
        }

        [Theory]
        [InlineData("Sweet")]
        [InlineData("Calories")]
        [InlineData("Special")]
        [InlineData("Description")]
        public void RemoveSweetShouldNotifyOfPropertyChanged(string propertyName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propertyName, () =>
            {
                tea.RemoveSweet();
            });
        }
    }
}
