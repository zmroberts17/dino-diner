/* Menu.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This menu is the center for all menu items
    /// </summary>
    public class Menu
    {
        private List<string> possibleIngredients { get; set; }

        public List<string> PossibleIngredients
        {
            get
            {
                List<string> possible = new List<string>();
                Menu menu = new Menu();
                foreach (IMenuItem item in menu.AvailableMenuItems)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        if (!possible.Contains(ingredient))
                        {
                            possible.Add(ingredient);
                        }
                    }
                }
                return possible;
            }
        }
        
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(AvailableCombos);
                items.AddRange(AvailableEntrees);
                items.AddRange(AvailableSides);
                items.AddRange(AvailableDrinks);
                return items;
            }
        }

        public List<IMenuItem> AvailableEntrees
        {
            get 
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                return items;
            }
        }

        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }

        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }

        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new CretaceousCombo(new Brontowurst()));
                items.Add(new CretaceousCombo(new DinoNuggets()));
                items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                items.Add(new CretaceousCombo(new PterodactylWings()));
                items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                items.Add(new CretaceousCombo(new TRexKingBurger()));
                items.Add(new CretaceousCombo(new VelociWrap()));
                return items;
            }
        }

        /// <summary>
        /// This method returns a list of all menu items
        /// </summary>
        /// <returns>This string is a list of all the menu items</returns>
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            JurassicJava j = new JurassicJava();
            sb.Append(j.ToString() + "\n");
            Sodasaurus s = new Sodasaurus();
            sb.Append(s.ToString() + "\n");
            Tyrannotea t = new Tyrannotea();
            sb.Append(t.ToString() + "\n");
            Water w = new Water();
            sb.Append(w.ToString() + "\n");
            Brontowurst b = new Brontowurst();
            sb.Append(b.ToString() + "\n");
            DinoNuggets d = new DinoNuggets();
            sb.Append(d.ToString() + "\n");
            PrehistoricPBJ p = new PrehistoricPBJ();
            sb.Append(p.ToString() + "\n");
            PterodactylWings pt = new PterodactylWings();
            sb.Append(pt.ToString() + "\n");
            SteakosaurusBurger st = new SteakosaurusBurger();
            sb.Append(st.ToString() + "\n");
            TRexKingBurger tk = new TRexKingBurger();
            sb.Append(tk.ToString() + "\n");
            VelociWrap v = new VelociWrap();
            sb.Append(v.ToString() + "\n");
            Fryceritops f = new Fryceritops();
            sb.Append(f.ToString() + "\n");
            MeteorMacAndCheese m = new MeteorMacAndCheese();
            sb.Append(m.ToString() + "\n");
            MezzorellaSticks mz = new MezzorellaSticks();
            sb.Append(mz.ToString() + "\n");
            Triceritots tr = new Triceritots();
            sb.Append(tr.ToString() + "\n");
            CretaceousCombo cc1 = new CretaceousCombo(new Brontowurst());
            sb.Append(cc1.ToString() + "\n");
            CretaceousCombo cc2 = new CretaceousCombo(new DinoNuggets());
            sb.Append(cc2.ToString() + "\n");
            CretaceousCombo cc3 = new CretaceousCombo(new PrehistoricPBJ());
            sb.Append(cc3.ToString() + "\n");
            CretaceousCombo cc4 = new CretaceousCombo(new PterodactylWings());
            sb.Append(cc4.ToString() + "\n");
            CretaceousCombo cc5 = new CretaceousCombo(new SteakosaurusBurger());
            sb.Append(cc5.ToString() + "\n");
            CretaceousCombo cc6 = new CretaceousCombo(new TRexKingBurger());
            sb.Append(cc6.ToString() + "\n");
            CretaceousCombo cc7 = new CretaceousCombo(new VelociWrap());
            sb.Append(cc7.ToString() + "\n");
            return sb.ToString();
        }

        public List<IMenuItem> FilterByIMenuItem(List<IMenuItem> items, List<string> checkedBoxes)
        {
            List<IMenuItem> qualified = new List<IMenuItem>();
            foreach (string checkBox in checkedBoxes)
            {
                if (checkBox.Equals("Combo"))
                {
                    foreach (IMenuItem item in items)
                    {
                        if (item is CretaceousCombo && !qualified.Contains(item))
                        {
                            qualified.Add(item);
                        }
                    }
                }
                else if (checkBox.Equals("Entree"))
                {
                    foreach (IMenuItem item in items)
                    {
                        if (item is Entree && !qualified.Contains(item))
                        {
                            qualified.Add(item);
                        }
                    }
                }
                else if (checkBox.Equals("Side"))
                {
                    foreach (IMenuItem item in items)
                    {
                        if (item is Side && !qualified.Contains(item))
                        {
                            qualified.Add(item);
                        }
                    }
                }
                else if (checkBox.Equals("Drink"))
                {
                    foreach (IMenuItem item in items)
                    {
                        if (item is Drink && !qualified.Contains(item))
                        {
                            qualified.Add(item);
                        }
                    }
                }
            }

            return qualified;
        }

        public List<IMenuItem> Search(List<IMenuItem> items, string search)
        {
            List<IMenuItem> qualified = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.ToString().ToLower().Contains(search.ToLower()))
                {
                    qualified.Add(item);
                }
            }
            return qualified;
        }

        public List<IMenuItem> FilterByPrice(List<IMenuItem> items, double? minPrice, double? maxPrice)
        {
            List<IMenuItem> qualified = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    qualified.Add(item);
                }
            }
            return qualified;
        }

        public List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> excludedIngredients)
        {
            List<IMenuItem> qualified = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                bool cleared = true;
                foreach (string itemIngredient in item.Ingredients)
                {
                    foreach (string excludedIngredient in excludedIngredients)
                    {
                        if (itemIngredient.Equals(excludedIngredient))
                        {
                            cleared = false;
                        }
                    }
                }
                if (cleared)
                {
                    qualified.Add(item);
                }
            }
            return qualified;
        }
    }
}
