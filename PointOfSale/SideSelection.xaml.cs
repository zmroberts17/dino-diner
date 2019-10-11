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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        public void SelectSide(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string n = b.Name;

            if (fryButton.Name == n) fryButton.Background = Brushes.LightGreen;
            else fryButton.Background = Brushes.Gold;
            if (macButton.Name == n) macButton.Background = Brushes.LightGreen;
            else macButton.Background = Brushes.Gold;
            if (triButton.Name == n) triButton.Background = Brushes.LightGreen;
            else triButton.Background = Brushes.Gold;
            if (sticksButton.Name == n) sticksButton.Background = Brushes.LightGreen;
            else sticksButton.Background = Brushes.Gold;
        }
    }
}
