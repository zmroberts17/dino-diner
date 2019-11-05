/* CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page"></param>
        public CustomizeBrontowurst()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The method called when the Hold Bun button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldBunButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bront)
                {
                    if (bront.Special.Contains("Hold Bun"))
                    {
                        bront.AddBun();
                    }
                    else
                    {
                        bront.HoldBun();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst b)
                    {
                        if (b.Special.Contains("Hold Bun"))
                        {
                            b.AddBun();
                        }
                        else
                        {
                            b.HoldBun();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The method called when the Hold Peppers button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldPeppersButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bront)
                {
                    if (bront.Special.Contains("Hold Peppers"))
                    {
                        bront.AddPeppers();
                    }
                    else
                    {
                        bront.HoldPeppers();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst b)
                    {
                        if (b.Special.Contains("Hold Peppers"))
                        {
                            b.AddPeppers();
                        }
                        else
                        {
                            b.HoldPeppers();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The method called when the Hold Onion button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldOnionButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bront)
                {
                    if (bront.Special.Contains("Hold Onion"))
                    {
                        bront.AddOnion();
                    }
                    else
                    {
                        bront.HoldOnion();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst b)
                    {
                        if (b.Special.Contains("Hold Onion"))
                        {
                            b.AddOnion();
                        }
                        else
                        {
                            b.HoldOnion();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The method called when the Done Button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
