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
            CategoryGrid1 catGrid = new CategoryGrid1();
            Window window = new Window
            {
                Title = "My User Control Dialog",
                Content = new CategoryGrid1()
            };

            window.ShowDialog();

        }
    }
}
