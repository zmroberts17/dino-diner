/* Name: FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method allows the user to select a flavor for the Sodasaurus
        /// </summary>
        /// <param name="flavor">This is the flavor selected</param>
        public void SelectFlavor(SodasaurusFlavor flavor)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                {
                    soda.Flavor = flavor;
                }
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Drink is Sodasaurus s)
                    {
                        s.Flavor = flavor;
                    }
                }
            }
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void CherryClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
            NavigationService.GoBack();
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void ChocolateClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
            NavigationService.GoBack();
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void ColaClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
            NavigationService.GoBack();
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void LimeClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
            NavigationService.GoBack();
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void OrangeClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
            NavigationService.GoBack();
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void RootBeerClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
            NavigationService.GoBack();
        }

        /// <summary>
        /// Actions when a flavor button is clicked
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void VanillaClick(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Vanilla);
            NavigationService.GoBack();
        }
    }
}
