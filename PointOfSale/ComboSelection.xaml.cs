/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This determines the parameter for the next page
        /// </summary>
        /// <param name="e">The entree selected</param>
        public void SelectCombo(Entree e)
        {
            CretaceousCombo combo = new CretaceousCombo(e);
            if (DataContext is Order order)
            {
                order.Add(combo);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectBrontowurstCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new Brontowurst());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The butt
        /// on clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectDinoNuggetsCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new DinoNuggets());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new PrehistoricPBJ());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectPterodactylWingsCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new PterodactylWings());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectSteakosaurusCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new SteakosaurusBurger());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectTRexKingCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new TRexKingBurger());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void SelectVelociWrapCombo(object sender, RoutedEventArgs e)
        {
            SelectCombo(new VelociWrap());
        }

        /// <summary>
        /// The action after a combo is selected
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The action of clicking</param>
        public void DoneClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
