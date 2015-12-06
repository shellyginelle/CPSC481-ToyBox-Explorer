using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CategoryGrid1 catGrid1 = new CategoryGrid1();
            CategoryGrid2 catGrid2 = new CategoryGrid2();
            CategoryGrid3 catGrid3 = new CategoryGrid3();

        }

        private void goToWebsite(object sender, RoutedEventArgs e)
        {

            Browser browserWindow = new Browser();
            browserWindow.Show();
            Close();
        }

        private void progressBarChange(object sender, EventArgs e)
        {
            // 1800 seconds = 30 minutes MAX TIME FOR WEB BROWSER 
            for (int i = 0; i < 200; i++)
            {
                pbStatus.Dispatcher.Invoke(() => pbStatus.Value = i, System.Windows.Threading.DispatcherPriority.Background);
                Thread.Sleep(200);
            }
        }

        private void games_Click(object sender, RoutedEventArgs e)
        {
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid1());
        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid2());
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid3());
        }
    }
}
