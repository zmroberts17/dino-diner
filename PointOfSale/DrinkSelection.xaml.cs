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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public void TopButtonClicked(object sender, RoutedEventArgs e)
        {
            if ((string) topButton.Content == "Flavor") {
                NavigationService.Navigate(new FlavorSelection());
            }
            else if ((string) topButton.Content == "Sweet") 
            {
                if (topButton.Background.Equals(Brushes.LightGreen))
                {
                    topButton.Background = Brushes.Gold;
                }
                else
                {
                    topButton.Background = Brushes.LightGreen;
                }
            }
            else if ((string) topButton.Content == "Decaf")
            {
                if (topButton.Background.Equals(Brushes.LightGreen))
                {
                    topButton.Background = Brushes.Gold;
                }
                else
                {
                    topButton.Background = Brushes.LightGreen;
                }
            }
        }

        public void MiddleButtonClicked(object sender, RoutedEventArgs e)
        {
            if ((string) middleButton.Content == "Add Lemon")
            {
                if (middleButton.Background == Brushes.LightGreen)
                {
                    middleButton.Background = Brushes.Gold;
                }
                else
                {
                    middleButton.Background = Brushes.LightGreen;
                }
            }
            else if ((string) middleButton.Content == "Add Room \n for Cream")
            {
                if (middleButton.Background == Brushes.LightGreen)
                {
                    middleButton.Background = Brushes.Gold;
                }
                else
                {
                    middleButton.Background = Brushes.LightGreen;
                }
            }
            
        }

        public void BottomButtonClicked(object sender, RoutedEventArgs e)
        {
            if (bottomButton.Background == Brushes.Gold)
            {
                bottomButton.Background = Brushes.LightGreen;
            }
            else
            {
                bottomButton.Background = Brushes.Gold;
            }
        }

        public void SodasaurusButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!sodasaurusButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.LightGreen;
                tyrannoteaButton.Background = Brushes.Gold;
                jurassicJavaButton.Background = Brushes.Gold;
                waterButton.Background = Brushes.Gold;

                topButton.Content = "Flavor";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "";
                middleButton.Background = Brushes.Gray;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
        }

        public void TyrannoteaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!tyrannoteaButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.Gold;
                tyrannoteaButton.Background = Brushes.LightGreen;
                jurassicJavaButton.Background = Brushes.Gold;
                waterButton.Background = Brushes.Gold;

                topButton.Content = "Sweet";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
        }

        public void JurassicJavaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!jurassicJavaButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.Gold;
                tyrannoteaButton.Background = Brushes.Gold;
                jurassicJavaButton.Background = Brushes.LightGreen;
                waterButton.Background = Brushes.Gold;

                topButton.Content = "Decaf";
                topButton.Background = Brushes.Gold;

                middleButton.Content = "Add Room \n for Cream";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.LightGreen;
            }
        }

        public void WaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!waterButton.Background.Equals(Brushes.LightGreen))
            {
                sodasaurusButton.Background = Brushes.Gold;
                tyrannoteaButton.Background = Brushes.Gold;
                jurassicJavaButton.Background = Brushes.Gold;
                waterButton.Background = Brushes.LightGreen;

                topButton.Content = "";
                topButton.Background = Brushes.Gray;

                middleButton.Content = "Add Lemon";
                middleButton.Background = Brushes.Gold;

                bottomButton.Content = "Hold Ice";
                bottomButton.Background = Brushes.Gold;
            }
        }
    }
}
