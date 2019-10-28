/* Name: SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// This is the previous page
        /// </summary>
        private Page previousPage;

        /// <summary>
        /// Constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
            DataContext = null;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">Previous page</param>
        public SideSelection(Page page)
        {
            InitializeComponent();
            DataContext = null;
            previousPage = page;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="side">Current side</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            DataContext = side;
            OnCurrentChanged(side);
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectFryceritops(object sender, RoutedEventArgs e)
        {
            fryButton.Background = Brushes.LightGreen;
            SelectSide(new Fryceritops());

            macButton.Background = Brushes.Gold;
            triButton.Background = Brushes.Gold;
            sticksButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectMeteorMac(object sender, RoutedEventArgs e)
        {
            macButton.Background = Brushes.LightGreen;
            SelectSide(new MeteorMacAndCheese());

            fryButton.Background = Brushes.Gold;
            triButton.Background = Brushes.Gold;
            sticksButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectTriceritops(object sender, RoutedEventArgs e)
        {
            triButton.Background = Brushes.LightGreen;
            SelectSide(new Triceritots());

            fryButton.Background = Brushes.Gold;
            macButton.Background = Brushes.Gold;
            sticksButton.Background = Brushes.Gold;
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectMezzorella(object sender, RoutedEventArgs e)
        {
            sticksButton.Background = Brushes.LightGreen;
            SelectSide(new MezzorellaSticks());

            fryButton.Background = Brushes.Gold;
            triButton.Background = Brushes.Gold;
            macButton.Background = Brushes.Gold;
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
        /// Current side changed
        /// </summary>
        /// <param name="side">side selected</param>
        public void OnCurrentChanged(Side side)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side s)
                {
                    // Set radio to side.Size property
                    if (side.Size == DinoDiner.Menu.Size.Small) smallButton.IsChecked = true;
                    if (side.Size == DinoDiner.Menu.Size.Medium) mediumButton.IsChecked = true;
                    if (side.Size == DinoDiner.Menu.Size.Large) largeButton.IsChecked = true;

                    // Disable selection of side
                    fryButton.IsEnabled = false;
                    macButton.IsEnabled = false;
                    triButton.IsEnabled = false;
                    sticksButton.IsEnabled = false;
                }
                else
                {
                    fryButton.IsEnabled = true;
                    macButton.IsEnabled = true;
                    triButton.IsEnabled = true;
                    sticksButton.IsEnabled = true;
                }
            }
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Size button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = size;
                }
            }
        }

        /// <summary>
        /// Small button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickSmall(object sender, EventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Small);
            NavigationService.Navigate(previousPage);
        }

        /// <summary>
        /// Medium button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickMedium(object sender, EventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
            NavigationService.Navigate(previousPage);
        }

        /// <summary>
        /// Large button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickLarge(object sender, EventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Large);
            NavigationService.Navigate(previousPage);
        }
    }
}
