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
        private bool catGrid1 = false;
        private bool catGrid2 = false;
        private bool catGrid3 = false;

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
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid1());
            catGrid1 = true;
            catGrid2 = false;
            catGrid3 = false;
        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid2());
            catGrid1 = false;
            catGrid2 = true;
            catGrid3 = false;
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid3());
            catGrid1 = false;
            catGrid2 = false;
            catGrid3 = true;
        }

        private void arrowRight_Click(object sender, RoutedEventArgs e)
        {
            if (catGrid1)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid2());
                catGrid1 = false;
                catGrid2 = true;
                catGrid3 = false;
            }

            else if (catGrid2)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid3());
                catGrid1 = false;
                catGrid2 = false;
                catGrid3 = true;
            }

            else
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid1());
                catGrid1 = true;
                catGrid2 = false;
                catGrid3 = false;
            }
        }

        private void arrowLeft_Click(object sender, RoutedEventArgs e)
        {
            if (catGrid3)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid2());
                catGrid1 = false;
                catGrid2 = true;
                catGrid3 = false;
            }

            else if (catGrid2)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid1());
                catGrid1 = true;
                catGrid2 = false;
                catGrid3 = false;
            }

            else
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new CategoryGrid3());
                catGrid1 = false;
                catGrid2 = false;
                catGrid3 = true;
            }
        }
    }
}
