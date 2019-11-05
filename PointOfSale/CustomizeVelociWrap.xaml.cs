/* CustomizeVelociWrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="page">The page before this one</param>
        public CustomizeVelociWrap()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldDressingClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                {
                    if (wrap.Special.Contains("Hold Dressing"))
                    {
                        wrap.AddDressing();
                    }
                    else
                    {
                        wrap.HoldDressing();
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldLettuceClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                {
                    if (wrap.Special.Contains("Hold Lettuce"))
                    {
                        wrap.AddLettuce();
                    }
                    else
                    {
                        wrap.HoldLettuce();
                    }
                }
            }
        }

        /// <summary>
        /// This method contains the actions for when a button is clicked.
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void HoldCheeseClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                {
                    if (wrap.Special.Contains("Hold Cheese"))
                    {
                        wrap.AddCheese();
                    }
                    else
                    {
                        wrap.HoldCheese();
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
