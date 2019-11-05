/* CustomizeSteakosaurus.xaml.cs
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
    /// Interaction logic for CustomizeSteakosaurus.xaml
    /// </summary>
    public partial class CustomizeSteakosaurus : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">The page before this one</param>
        public CustomizeSteakosaurus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldBunClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steak)
                {
                    if (steak.Special.Contains("Hold Bun"))
                    {
                        steak.AddBun();
                    }
                    else
                    {
                        steak.HoldBun();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is SteakosaurusBurger s)
                    {
                        if (s.Special.Contains("Hold Bun"))
                        {
                            s.AddBun();
                        }
                        else
                        {
                            s.HoldBun();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action clicking</param>
        public void HoldPickleClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steak)
                {
                    if (steak.Special.Contains("Hold Pickle"))
                    {
                        steak.AddPickle();
                    }
                    else
                    {
                        steak.HoldPickle();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is SteakosaurusBurger s)
                    {
                        if (s.Special.Contains("Hold Pickle"))
                        {
                            s.AddPickle();
                        }
                        else
                        {
                            s.HoldPickle();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldKetchupClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steak)
                {
                    if (steak.Special.Contains("Hold Ketchup"))
                    {
                        steak.AddKetchup();
                    }
                    else
                    {
                        steak.HoldKetchup();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is SteakosaurusBurger s)
                    {
                        if (s.Special.Contains("Hold Ketchup"))
                        {
                            s.AddKetchup();
                        }
                        else
                        {
                            s.HoldKetchup();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldMustardClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steak)
                {
                    if (steak.Special.Contains("Hold Mustard"))
                    {
                        steak.AddMustard();
                    }
                    else
                    {
                        steak.HoldMustard();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is SteakosaurusBurger s)
                    {
                        if (s.Special.Contains("Hold Mustard"))
                        {
                            s.AddMustard();
                        }
                        else
                        {
                            s.HoldMustard();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void DoneClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
