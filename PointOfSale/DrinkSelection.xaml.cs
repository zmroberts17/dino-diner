/* Name: DrinkSelection.xaml.cs
 * Author: Zane Roberts
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {        
        /// <summary>
        /// Constructor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="combo">The current combo</param>
        public DrinkSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;

            if (combo.Drink.Size == DinoDiner.Menu.Size.Small)
            {
                smallButton.IsChecked = true;
            }
            else if (combo.Drink.Size == DinoDiner.Menu.Size.Medium)
            {
                mediumButton.IsChecked = true;
            }
            else if (combo.Drink.Size == DinoDiner.Menu.Size.Large)
            {
                largeButton.IsChecked = true;
            }

            if (combo.Drink is Sodasaurus soda)
            {
                topButton.Content = "Flavor";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "";
                middleButton.Background = Brushes.Gray;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
            else if (combo.Drink is JurassicJava java)
            {
                topButton.Content = "Decaf";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Room \n for Cream";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.LightGreen;
            }
            else if (combo.Drink is Tyrannotea tea)
            {
                topButton.Content = "Sweet";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
            else if (combo.Drink is Water water)
            {
                topButton.Content = "";
                topButton.Background = Brushes.Gray;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
        }

        /// <summary>
        /// The combo selected
        /// </summary>
        private CretaceousCombo combo = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">The page before this one</param>
        /// <param name="drink">The current drink selected</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            if (drink.Size == DinoDiner.Menu.Size.Small)
            {
                smallButton.IsChecked = true;
            }
            else if (drink.Size == DinoDiner.Menu.Size.Medium)
            {
                mediumButton.IsChecked = true;
            }
            else if (drink.Size == DinoDiner.Menu.Size.Large)
            {
                largeButton.IsChecked = true;
            }

            if (drink is Sodasaurus soda)
            {
                topButton.Content = "Flavor";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "";
                middleButton.Background = Brushes.Gray;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
            else if (drink is JurassicJava java)
            {
                topButton.Content = "Decaf";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Room \n for Cream";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.LightGreen;
            }
            else if (drink is Tyrannotea tea)
            {
                topButton.Content = "Sweet";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
            else if (drink is Water water)
            {
                topButton.Content = "";
                topButton.Background = Brushes.Gray;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
        }

        /// <summary>
        /// Top button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TopButtonClicked(object sender, RoutedEventArgs e)
        {
            if ((string)topButton.Content == "Flavor")
            {
                NavigationService.Navigate(new FlavorSelection());
            }
            else if ((string)topButton.Content == "Sweet")
            {
                if (topButton.Background == Brushes.Gold)
                {
                    topButton.Background = Brushes.LightGreen;
                    AddSweetClicked();
                }
                else
                {
                    topButton.Background = Brushes.Gold;
                    RemoveSweetClicked();
                }
            }
            else if ((string)topButton.Content == "Decaf")
            {
                if (topButton.Background == Brushes.Gold)
                {
                    topButton.Background = Brushes.LightGreen;
                    AddDecafClicked();
                }
                else
                {
                    topButton.Background = Brushes.Gold;
                    RemoveDecafClicked();
                }
            }
        }

        /// <summary>
        /// Middle button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MiddleButtonClicked(object sender, RoutedEventArgs e)
        {
            if ((string)middleButton.Content == "Add Lemon")
            {
                if (middleButton.Background == Brushes.Gold)
                {
                    middleButton.Background = Brushes.LightGreen;
                    AddLemonClicked();
                }
                else
                {
                    middleButton.Background = Brushes.Gold;
                    RemoveLemonClicked();
                }
            }
            else if ((string)middleButton.Content == "Add Room \n for Cream")
            {
                if (middleButton.Background == Brushes.Gold)
                {
                    middleButton.Background = Brushes.LightGreen;
                    LeaveRoomForCreamClicked();
                }
                else
                {
                    middleButton.Background = Brushes.Gold;
                    RemoveRoomForCreamClicked();
                }
            }

        }

        /// <summary>
        /// Bottom button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BottomButtonClicked(object sender, RoutedEventArgs e)
        {
            if (bottomButton.Background == Brushes.Gold)
            {
                bottomButton.Background = Brushes.LightGreen;
                RemoveIceClicked();
            }
            else
            {
                bottomButton.Background = Brushes.Gold;
                AddIceClicked();
            }
        }

        /// <summary>
        /// Decaf button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddDecafClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.MakeDecaf();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.MakeDecaf();
                    }
                }
            }
        }

        /// <summary>
        /// Decaf button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveDecafClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.MakeNotDecaf();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.MakeNotDecaf();
                    }
                }
            }
        }

        /// <summary>
        /// Sweet button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddSweetClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.AddSweet();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is Tyrannotea t)
                    {
                        t.AddSweet();
                    }
                }
            }
        }

        /// <summary>
        /// Sweet button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveSweetClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.RemoveSweet();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is Tyrannotea t)
                    {
                        t.RemoveSweet();
                    }
                }
            }
        }

        /// <summary>
        /// Lemon button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddLemonClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    water.AddLemon();
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.AddLemon();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.AddLemon();
                    }
                    else if (combo.Drink is Tyrannotea t)
                    {
                        t.AddLemon();
                    }
                    else if (combo.Drink is Water w)
                    {
                        w.AddLemon();
                    }
                }
            }
        }

        /// <summary>
        /// Lemon button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveLemonClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.RemoveLemon();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    water.RemoveLemon();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.RemoveLemon();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.RemoveLemon();
                    }
                    else if (combo.Drink is Tyrannotea t)
                    {
                        t.RemoveLemon();
                    }
                    else if (combo.Drink is Water w)
                    {
                        w.RemoveLemon();
                    }
                }
            }
        }

        /// <summary>
        /// Room for Cream button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LeaveRoomForCreamClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.LeaveRoomForCream();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.LeaveRoomForCream();
                    }
                }
            }
        }

        /// <summary>
        /// Room for Cream button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveRoomForCreamClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.RemoveRoomForCream();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.RemoveRoomForCream();
                    }
                }
            }
        }

        /// <summary>
        /// Ice button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddIceClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.AddIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.AddIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.AddIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    water.AddIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is JurassicJava j)
                    {
                        j.AddIce();
                    }
                    else if (combo.Drink is Tyrannotea t)
                    {
                        t.AddIce();
                    }
                    else if (combo.Drink is Sodasaurus s)
                    {
                        s.AddIce();
                    }
                    else if (combo.Drink is Water w)
                    {
                        w.AddIce();
                    }
                }
            }
        }

        /// <summary>
        /// Ice button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RemoveIceClicked()
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    java.HoldIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.HoldIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.HoldIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    water.HoldIce();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink.HoldIce();
                }
            }
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SodasaurusButtonClicked(object sender, RoutedEventArgs e)
        {
            topButton.Content = "Flavor";
            topButton.Background = Brushes.Gold;

            middleButton.Content = "";
            middleButton.Background = Brushes.Gray;

            bottomButton.Content = "Hold Ice";
            bottomButton.Background = Brushes.Gold;

            SelectDrink(new Sodasaurus());
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TyrannoteaButtonClicked(object sender, RoutedEventArgs e)
        {
            topButton.Content = "Sweet";
            topButton.Background = Brushes.Gold;

            middleButton.Content = "Add Lemon";
            middleButton.Background = Brushes.Gold;

            bottomButton.Content = "Hold Ice";
            bottomButton.Background = Brushes.Gold;

            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void JurassicJavaButtonClicked(object sender, RoutedEventArgs e)
        {
            topButton.Content = "Decaf";
            topButton.Background = Brushes.Gold;

            middleButton.Content = "Add Room \n for Cream";
            middleButton.Background = Brushes.Gold;

            bottomButton.Content = "Hold Ice";
            bottomButton.Background = Brushes.LightGreen;

            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WaterButtonClicked(object sender, RoutedEventArgs e)
        {
            topButton.Content = "";
            topButton.Background = Brushes.Gray;

            middleButton.Content = "Add Lemon";
            middleButton.Background = Brushes.Gold;

            bottomButton.Content = "Hold Ice";
            bottomButton.Background = Brushes.Gold;

            SelectDrink(new Water());
        }

        /// <summary>
        /// Done button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectDrink(Drink drink) 
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }
        }

        /// <summary>
        /// Size button clicked
        /// </summary>
        /// <param name="size"></param>
        public void SetSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = size;
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink.Size = size;
                }
            }
        }

        /// <summary>
        /// Small button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ClickSmall(object sender, RoutedEventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Medium button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ClickMedium(object sender, RoutedEventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Large button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ClickLarge(object sender, RoutedEventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }
    }
}
