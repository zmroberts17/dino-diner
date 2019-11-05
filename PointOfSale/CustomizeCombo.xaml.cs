/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">The combo after edits</param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            if (combo.Size == DinoDiner.Menu.Size.Small)
            {
                smallButton.IsChecked = true;
            }
            else if (combo.Size == DinoDiner.Menu.Size.Medium)
            {
                mediumButton.IsChecked = true;
            }
            else if (combo.Size == DinoDiner.Menu.Size.Large)
            {
                largeButton.IsChecked = true;
            }
        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectSide(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    NavigationService.Navigate(new SideSelection(combo));
                }
            }

        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectDrink(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    NavigationService.Navigate(new DrinkSelection(combo));
                }
            }
        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectEntree(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst bront) NavigationService.Navigate(new CustomizeBrontowurst());
                    else if (combo.Entree is DinoNuggets nuggets) NavigationService.Navigate(new CustomizeDinoNuggets());
                    else if (combo.Entree is PrehistoricPBJ pbj) NavigationService.Navigate(new CustomizePrehistoricPBJ());
                    else if (combo.Entree is SteakosaurusBurger burger) NavigationService.Navigate(new CustomizeSteakosaurus());
                    else if (combo.Entree is TRexKingBurger king) NavigationService.Navigate(new CustomizeTRexKingBurger());
                    else if (combo.Entree is VelociWrap wrap) NavigationService.Navigate(new CustomizeVelociWrap());
                }
            }
        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void DoneClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectSmall(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectMedium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }

        /// <summary>
        /// The actions after a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectLarge(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }
    }
}
