/* CustomizePrehistoricPBJ.xaml.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">The page before this one</param>
        public CustomizePrehistoricPBJ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method includes the actions once a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldPeanutButterClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    if (pbj.Special.Contains("Hold Peanut Butter"))
                    {
                        pbj.AddPeanutButter();
                    }
                    else
                    {
                        pbj.HoldPeanutButter();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is PrehistoricPBJ p)
                    {
                        if (p.Special.Contains("Hold Peanut Butter"))
                        {
                            p.AddPeanutButter();
                        }
                        else
                        {
                            p.HoldPeanutButter();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method includes the actions once a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldJellyClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ pbj)
                {
                    if (pbj.Special.Contains("Hold Jelly"))
                    {
                        pbj.AddJelly();
                    }
                    else
                    {
                        pbj.HoldJelly();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is PrehistoricPBJ p)
                    {
                        if (p.Special.Contains("Hold Jelly"))
                        {
                            p.AddJelly();
                        }
                        else
                        {
                            p.HoldJelly();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This method includes the actions once a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void DoneClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
