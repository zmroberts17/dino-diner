/* CustomizeDinoNuggets.xaml.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">The page before this one</param>
        public CustomizeDinoNuggets()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void AddNuggetClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets nuggets)
                {
                    nuggets.AddNugget();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is DinoNuggets d)
                    {
                        d.AddNugget();
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void RemoveNuggetClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets nuggets)
                {
                    nuggets.RemoveNugget();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is DinoNuggets d)
                    {
                        d.RemoveNugget();
                    }
                }
            }
        }

        /// <summary>
        /// The method contains the actions for when a button is clicked
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void DoneClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
