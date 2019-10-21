using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DinoDiner.MenuTest
{
    public class CretaceousComboTest
    {
        [Fact]
        public void ShouldHaveDefaultEmptySpecials()
        {
            Brontowurst b = new Brontowurst();
            Triceritots tot = new Triceritots();
            JurassicJava java = new JurassicJava();
            CretaceousCombo combo = new CretaceousCombo(b);
            combo.Side = tot;
            combo.Drink = java;
            string[] special = { "Small Triceritots", "Small Jurassic Java" };
            Assert.Equal(combo.Special, special);
        }

        [Fact]
        public void ShouldHaveCorrectEntreeSpecial()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            CretaceousCombo combo = new CretaceousCombo(b);
            string[] special = { "Hold Bun", "Small Fryceritops", "Small Cola Sodasaurus" };
            Assert.Equal(combo.Special, special);
        }

        [Fact]
        public void ShouldHaveCorrectSideSpecial()
        {
            Triceritots tot = new Triceritots();
            Brontowurst b = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(b);
            combo.Side = tot;
            string[] special = { "Small Triceritots", "Small Cola Sodasaurus" };
            Assert.Equal(combo.Special, special);
        }

        [Fact]
        public void ShouldHaveCorrectDrinkSpecial()
        {
            Brontowurst b = new Brontowurst();
            JurassicJava java = new JurassicJava();
            CretaceousCombo combo = new CretaceousCombo(b);
            java.AddIce();
            combo.Drink = java;
            string[] special = { "Small Fryceritops", "Small Jurassic Java", "Add Ice" };
            Assert.Equal(combo.Special, special);
        }

        [Fact]
        public void ShouldHaveCorrectAllSpecials()
        {
            Brontowurst b = new Brontowurst();
            Triceritots tot = new Triceritots();
            JurassicJava java = new JurassicJava();
            b.HoldBun();
            java.AddIce();
            CretaceousCombo combo = new CretaceousCombo(b);
            combo.Side = tot;
            combo.Drink = java;
            string[] special = { "Hold Bun", "Small Triceritots", "Small Jurassic Java", "Add Ice" };
            Assert.Equal(combo.Special, special);
        }
    }
}
