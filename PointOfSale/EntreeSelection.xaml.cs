/* Name: EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="entree">Current entree</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectBrontowurst(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());

            NavigationService.Navigate(new CustomizeBrontowurst());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());

            NavigationService.Navigate(new CustomizeDinoNuggets());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PrehistoricPBJ());

            NavigationService.Navigate(new CustomizePrehistoricPBJ());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectPterodactylWings(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            SelectEntree(new SteakosaurusBurger());

            NavigationService.Navigate(new CustomizeSteakosaurus());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());

            NavigationService.Navigate(new CustomizeTRexKingBurger());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());

            NavigationService.Navigate(new CustomizeVelociWrap());
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Done button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
