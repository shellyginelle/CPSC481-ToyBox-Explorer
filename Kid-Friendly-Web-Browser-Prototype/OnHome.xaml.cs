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

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for OnHome.xaml
    /// </summary>
    public partial class OnHome : UserControl
    {
        OnWebsite websiteControl = new OnWebsite();
        OnHome homeControl = new OnHome();

        public OnHome()
        {
            InitializeComponent();
        }

        private void goToWebsite(object sender, RoutedEventArgs e)
        {
            sesame.Visibility = Visibility.Hidden;
            dora.Visibility = Visibility.Hidden;
            turtles.Visibility = Visibility.Hidden;
            trees.Visibility = Visibility.Hidden;
            homeButton.Visibility = Visibility.Visible;

            gridPanel.Children.Clear();
            gridPanel.Children.Add(websiteControl);
        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            sesame.Visibility = Visibility.Visible;
            dora.Visibility = Visibility.Visible;
            turtles.Visibility = Visibility.Visible;
            trees.Visibility = Visibility.Visible;
            homeButton.Visibility = Visibility.Hidden;

            gridPanel.Children.Clear();
            gridPanel.Children.Add(homeControl);
        }
    }
}
