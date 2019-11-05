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
        /// Constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="combo">The current combo</param>
        public SideSelection(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
            if (combo.Side.Size == DinoDiner.Menu.Size.Small)
            {
                smallButton.IsChecked = true;
            }
            else if (combo.Side.Size == DinoDiner.Menu.Size.Medium)
            {
                mediumButton.IsChecked = true;
            }
            else if (combo.Side.Size == DinoDiner.Menu.Size.Large)
            {
                largeButton.IsChecked = true;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="side">Current side</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            if (side.Size == DinoDiner.Menu.Size.Small)
            {
                smallButton.IsChecked = true;
            }
            else if (side.Size == DinoDiner.Menu.Size.Medium)
            {
                mediumButton.IsChecked = true;
            }
            else if (side.Size == DinoDiner.Menu.Size.Large)
            {
                largeButton.IsChecked = true;
            }
        }

        private CretaceousCombo combo = null;

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectMeteorMac(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectTriceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// Side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectMezzorella(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());
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
                if (combo != null)
                {
                    combo.Side = side;
                }
                else
                {
                    order.Add(side);
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
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
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else if (combo != null)
                {
                    combo.Side.Size = size;
                    NavigationService.GoBack();
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
        }

        /// <summary>
        /// Medium button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickMedium(object sender, EventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Large button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickLarge(object sender, EventArgs args)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }
    }
}
