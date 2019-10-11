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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public void SelectEntree(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string n = b.Name;
            if (brontowurstButton.Name == n) brontowurstButton.Background = Brushes.LightGreen;
            else brontowurstButton.Background = Brushes.Gold;
            if (nuggetsButton.Name == n) nuggetsButton.Background = Brushes.LightGreen;
            else nuggetsButton.Background = Brushes.Gold;
            if (pbjButton.Name == n) pbjButton.Background = Brushes.LightGreen;
            else pbjButton.Background = Brushes.Gold;
            if (wingsButton.Name == n) wingsButton.Background = Brushes.LightGreen;
            else wingsButton.Background = Brushes.Gold;
            if (steakButton.Name == n) steakButton.Background = Brushes.LightGreen;
            else steakButton.Background = Brushes.Gold;
            if (trexButton.Name == n) trexButton.Background = Brushes.LightGreen;
            else trexButton.Background = Brushes.Gold;
            if (wrapButton.Name == n) wrapButton.Background = Brushes.LightGreen;
            else wrapButton.Background = Brushes.Gold;
        }
    }
}
