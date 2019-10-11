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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public void SelectFlavor(object sender, RoutedEventArgs e)
        {
            Button b = (Button) sender;
            string n = b.Name;
            if (cherryButton.Name != n) cherryButton.Background = Brushes.Gold;
            else cherryButton.Background = Brushes.LightGreen;
            if (chocolateButton.Name != n) chocolateButton.Background = Brushes.Gold;
            else chocolateButton.Background = Brushes.LightGreen;
            if (colaButton.Name != n) colaButton.Background = Brushes.Gold;
            else colaButton.Background = Brushes.LightGreen;
            if (limeButton.Name != n) limeButton.Background = Brushes.Gold;
            else limeButton.Background = Brushes.LightGreen;
            if (orangeButton.Name != n) orangeButton.Background = Brushes.Gold;
            else orangeButton.Background = Brushes.LightGreen;
            if (rootBeerButton.Name != n) rootBeerButton.Background = Brushes.Gold;
            else rootBeerButton.Background = Brushes.LightGreen;
            if (vanillaButton.Name != n) vanillaButton.Background = Brushes.Gold;
            else vanillaButton.Background = Brushes.LightGreen;
        }
    }
}
