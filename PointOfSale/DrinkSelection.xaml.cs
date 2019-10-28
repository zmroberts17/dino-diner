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
        /// This is the previous page
        /// </summary>
        private Page previousPage;

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
        /// <param name="page">Previous page</param>
        public DrinkSelection(Page page)
        {
            InitializeComponent();
            previousPage = page;
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
                Page page = this;
                NavigationService.Navigate(new FlavorSelection(page));
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
            }
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SodasaurusButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!sodasaurusButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.LightGreen;
                tyrannoteaButton.Background = Brushes.Gold;
                jurassicJavaButton.Background = Brushes.Gold;
                waterButton.Background = Brushes.Gold;

                topButton.Content = "Flavor";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "";
                middleButton.Background = Brushes.Gray;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }

            SelectDrink(new Sodasaurus());
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TyrannoteaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!tyrannoteaButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.Gold;
                tyrannoteaButton.Background = Brushes.LightGreen;
                jurassicJavaButton.Background = Brushes.Gold;
                waterButton.Background = Brushes.Gold;

                topButton.Content = "Sweet";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }

            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void JurassicJavaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!jurassicJavaButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.Gold;
                tyrannoteaButton.Background = Brushes.Gold;
                jurassicJavaButton.Background = Brushes.LightGreen;
                waterButton.Background = Brushes.Gold;

                topButton.Content = "Decaf";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Room \n for Cream";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.LightGreen;
            }

            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!waterButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.Gold;
                tyrannoteaButton.Background = Brushes.Gold;
                jurassicJavaButton.Background = Brushes.Gold;
                waterButton.Background = Brushes.LightGreen;

                topButton.Content = "";
                topButton.Background = Brushes.Gray;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }

            SelectDrink(new Water());
        }

        /// <summary>
        /// Done button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(previousPage);
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
                order.Items.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
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
