using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace DinoDiner.MenuTest
{
    public class SodasaurusTest
    {
        // change the SodaFlavor
        [Fact]
        public void ShouldBeAbleToChangeTheFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(SodasaurusFlavor.Cola, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal(SodasaurusFlavor.Orange, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal(SodasaurusFlavor.Vanilla, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal(SodasaurusFlavor.Chocolate, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal(SodasaurusFlavor.RootBeer, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal(SodasaurusFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal(SodasaurusFlavor.Lime, soda.Flavor);
        }

        // The correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        // The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        // The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        // The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(Size.Small, soda.Size);
        }

        // correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        // correct price after setting small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        // correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        // correct price after setting medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        // correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        // correct price after setting large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }
        
        // HoldIce method holds the ice
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        // correct ingredients
        [Fact] 
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains("Water", soda.Ingredients);
            Assert.Contains("Natural Flavors", soda.Ingredients);
            Assert.Contains("Cane Sugar", soda.Ingredients);
        }

        [Fact]
        public void ShouldHaveHoldIceSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            string[] special = { "Hold Ice" };
            Assert.Equal(soda.Special, special);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Size")]
        [InlineData("Description")]
        public void ChangingSizeShouldNotifyOfPropertyChanged(string propertyName)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, propertyName, () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, propertyName, () =>
            {
                soda.Size = Size.Large;
            });
            Assert.PropertyChanged(soda, propertyName, () =>
            {
                soda.Size = Size.Small;
            });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Flavor")]
        public void ChangeFlavorShouldNotifyOfPropertyChanged(string propertyName)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, propertyName, () =>
            {
                soda.Flavor = SodasaurusFlavor.Chocolate;
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ice")]
        public void HoldIceShouldNotifyOfPropertyChanged(string propertyName)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, propertyName, () =>
            {
                soda.HoldIce();
            });
        }
    }
}
