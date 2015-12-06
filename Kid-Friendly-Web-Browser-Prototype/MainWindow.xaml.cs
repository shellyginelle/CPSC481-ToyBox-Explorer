using System;
using System.Threading;
using System.Windows;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OnWebsite websiteControl = new OnWebsite();

        public MainWindow()
        {
            InitializeComponent();
            homeButton.Visibility = Visibility.Hidden;
        }

        private void goToWebsite(object sender, RoutedEventArgs e)
        {
            sesame.Visibility = Visibility.Hidden;
            dora.Visibility = Visibility.Hidden;
            turtles.Visibility = Visibility.Hidden;
            trees.Visibility = Visibility.Hidden;

            games.Visibility = Visibility.Hidden;
            video.Visibility = Visibility.Hidden;
            learn.Visibility = Visibility.Hidden;
            fave.Visibility = Visibility.Hidden;

            buttonRight.Visibility = Visibility.Hidden;
            buttonLeft.Visibility = Visibility.Hidden;

            search.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;

            homeButton.Visibility = Visibility.Visible;

            mainPanel.Children.Clear();
            mainPanel.Children.Add(websiteControl);
        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            sesame.Visibility = Visibility.Visible;
            dora.Visibility = Visibility.Visible;
            turtles.Visibility = Visibility.Visible;
            trees.Visibility = Visibility.Visible;

            games.Visibility = Visibility.Visible;
            video.Visibility = Visibility.Visible;
            learn.Visibility = Visibility.Visible;
            fave.Visibility = Visibility.Visible;

            buttonRight.Visibility = Visibility.Visible;
            buttonLeft.Visibility = Visibility.Visible;

            search.Visibility = Visibility.Visible;
            settings.Visibility = Visibility.Visible;

            homeButton.Visibility = Visibility.Hidden;

            mainPanel.Children.Clear();
        }

        private void progressBarChange(object sender, EventArgs e)
        {
            // 1800 seconds = 30 minutes MAX TIME FOR WEB BROWSER 
            for (int i = 0; i < 1800; i++)
            {
                pbStatus.Dispatcher.Invoke(() => pbStatus.Value = i, System.Windows.Threading.DispatcherPriority.Background);
                Thread.Sleep(1800);
            }
           
            TimeOut popup = new TimeOut(); //Create new window to the exit page 
            popup.Show();
            Close();
        }

    }
}
