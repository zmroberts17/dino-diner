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
        /// This is the previous page
        /// </summary>
        private Page previousPage;

        /// <summary>
        /// Constructor
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
            DataContext = null;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">Previous page</param>
        public EntreeSelection(Page page)
        {
            InitializeComponent();
            DataContext = null;
            previousPage = page;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="entree">Current entree</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            DataContext = entree;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectBrontowurst(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());
            brontowurstButton.Background = Brushes.LightGreen;

            nuggetsButton.Background = Brushes.Gold;
            pbjButton.Background = Brushes.Gold;
            wingsButton.Background = Brushes.Gold;
            steakButton.Background = Brushes.Gold;
            trexButton.Background = Brushes.Gold;
            wrapButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());
            nuggetsButton.Background = Brushes.LightGreen;

            brontowurstButton.Background = Brushes.Gold;
            pbjButton.Background = Brushes.Gold;
            wingsButton.Background = Brushes.Gold;
            steakButton.Background = Brushes.Gold;
            trexButton.Background = Brushes.Gold;
            wrapButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PrehistoricPBJ());
            pbjButton.Background = Brushes.LightGreen;

            nuggetsButton.Background = Brushes.Gold;
            brontowurstButton.Background = Brushes.Gold;
            wingsButton.Background = Brushes.Gold;
            steakButton.Background = Brushes.Gold;
            trexButton.Background = Brushes.Gold;
            wrapButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectPterodactylWings(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PterodactylWings());
            wingsButton.Background = Brushes.LightGreen;

            nuggetsButton.Background = Brushes.Gold;
            pbjButton.Background = Brushes.Gold;
            brontowurstButton.Background = Brushes.Gold;
            steakButton.Background = Brushes.Gold;
            trexButton.Background = Brushes.Gold;
            wrapButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            SelectEntree(new SteakosaurusBurger());
            steakButton.Background = Brushes.LightGreen;

            nuggetsButton.Background = Brushes.Gold;
            pbjButton.Background = Brushes.Gold;
            wingsButton.Background = Brushes.Gold;
            brontowurstButton.Background = Brushes.Gold;
            trexButton.Background = Brushes.Gold;
            wrapButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());
            trexButton.Background = Brushes.LightGreen;

            nuggetsButton.Background = Brushes.Gold;
            pbjButton.Background = Brushes.Gold;
            wingsButton.Background = Brushes.Gold;
            steakButton.Background = Brushes.Gold;
            brontowurstButton.Background = Brushes.Gold;
            wrapButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Entree button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());
            wrapButton.Background = Brushes.LightGreen;

            nuggetsButton.Background = Brushes.Gold;
            pbjButton.Background = Brushes.Gold;
            wingsButton.Background = Brushes.Gold;
            steakButton.Background = Brushes.Gold;
            trexButton.Background = Brushes.Gold;
            brontowurstButton.Background = Brushes.Gold;
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
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                NavigationService.Navigate(new MenuCategorySelection());
            }
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
    }
}
