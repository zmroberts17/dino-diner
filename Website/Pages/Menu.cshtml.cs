using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public bool c = false;
        public bool e = false;
        public bool s = false;
        public bool d = false;

        [BindProperty]
        public List<IMenuItem> items { get; set; } = new List<IMenuItem>();

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double? minimumPrice { get; set; }

        [BindProperty]
        public double? maximumPrice { get; set; }

        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        public Menu Menu { get; } = new Menu();

        public void OnGet()
        {
            menuCategory.Add("Combo");
            menuCategory.Add("Entree");
            menuCategory.Add("Side");
            menuCategory.Add("Drink");
            items = Menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            items = Menu.AvailableMenuItems;
            if (search != null)
            {
                c = false;
                e = false;
                s = false;
                d = false;
                items = Menu.Search(items, search);
            }

            if (menuCategory.Count > 0)
            {
                c = false;
                e = false;
                s = false;
                d = false;
                items = Menu.FilterByIMenuItem(items, menuCategory);
            }

            if (minimumPrice != null || maximumPrice != null)
            {
                if (minimumPrice == null)
                {
                    items = Menu.FilterByPrice(items, 0, maximumPrice);
                }
                else if (maximumPrice == null)
                {
                    items = Menu.FilterByPrice(items, minimumPrice, Int32.MaxValue);
                }
                else
                {
                    items = Menu.FilterByPrice(items, minimumPrice, maximumPrice);
                }
            }

            if (excludedIngredients.Count > 0)
            {
                items = Menu.FilterByIngredients(items, excludedIngredients);
            }
        }
    }
}