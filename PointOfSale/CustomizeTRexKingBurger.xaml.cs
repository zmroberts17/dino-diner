/* CustomizeTRexKingBurger.xaml.cs
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">The page before this one</param>
        public CustomizeTRexKingBurger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldBunClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Bun"))
                    {
                        king.AddBun();
                    }
                    else
                    {
                        king.HoldBun();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Bun"))
                        {
                            t.AddBun();
                        }
                        else
                        {
                            t.HoldBun();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldLettuceClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Lettuce"))
                    {
                        king.AddLettuce();
                    }
                    else
                    {
                        king.HoldLettuce();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Lettuce"))
                        {
                            t.AddLettuce();
                        }
                        else
                        {
                            t.HoldLettuce();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldTomatoClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Tomato"))
                    {
                        king.AddTomato();
                    }
                    else
                    {
                        king.HoldTomato();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Tomato"))
                        {
                            t.AddTomato();
                        }
                        else
                        {
                            t.HoldTomato();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldOnionClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Onion"))
                    {
                        king.AddOnion();
                    }
                    else
                    {
                        king.HoldOnion();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Onion"))
                        {
                            t.AddOnion();
                        }
                        else
                        {
                            t.HoldOnion();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldPickleClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Pickle"))
                    {
                        king.AddPickle();
                    }
                    else
                    {
                        king.HoldPickle();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Pickle"))
                        {
                            t.AddPickle();
                        }
                        else
                        {
                            t.HoldPickle();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldKetchupClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Ketchup"))
                    {
                        king.AddKetchup();
                    }
                    else
                    {
                        king.HoldKetchup();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Ketchup"))
                        {
                            t.AddKetchup();
                        }
                        else
                        {
                            t.HoldKetchup();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldMustardClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Mustard"))
                    {
                        king.AddMustard();
                    }
                    else
                    {
                        king.HoldMustard();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Mustard"))
                        {
                            t.AddMustard();
                        }
                        else
                        {
                            t.HoldMustard();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldMayoClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger king)
                {
                    if (king.Special.Contains("Hold Mayo"))
                    {
                        king.AddMayo();
                    }
                    else
                    {
                        king.HoldMayo();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is TRexKingBurger t)
                    {
                        if (t.Special.Contains("Hold Mayo"))
                        {
                            t.AddMayo();
                        }
                        else
                        {
                            t.HoldMayo();
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
