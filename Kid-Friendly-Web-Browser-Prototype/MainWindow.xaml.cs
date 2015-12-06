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
            favourite.Visibility = Visibility.Hidden;
        }

        private void goToWebsite(object sender, RoutedEventArgs e)
        {
            TopLeft.Visibility = Visibility.Hidden;
            TopRight.Visibility = Visibility.Hidden;
            BotLeft.Visibility = Visibility.Hidden;
            BotRight.Visibility = Visibility.Hidden;

            games.Visibility = Visibility.Hidden;
            video.Visibility = Visibility.Hidden;
            learn.Visibility = Visibility.Hidden;
            fave.Visibility = Visibility.Hidden;

            buttonRight.Visibility = Visibility.Hidden;
            buttonLeft.Visibility = Visibility.Hidden;

            search.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;

            homeButton.Visibility = Visibility.Visible;
            favourite.Visibility = Visibility.Visible;

            mainPanel.Children.Clear();
            mainPanel.Children.Add(websiteControl);
        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            TopLeft.Visibility = Visibility.Visible;
            TopRight.Visibility = Visibility.Visible;
            BotLeft.Visibility = Visibility.Visible;
            BotRight.Visibility = Visibility.Visible;

            games.Visibility = Visibility.Visible;
            video.Visibility = Visibility.Visible;
            learn.Visibility = Visibility.Visible;
            fave.Visibility = Visibility.Visible;

            buttonRight.Visibility = Visibility.Visible;
            buttonLeft.Visibility = Visibility.Visible;

            search.Visibility = Visibility.Visible;
            settings.Visibility = Visibility.Visible;

            homeButton.Visibility = Visibility.Hidden;
            favourite.Visibility = Visibility.Hidden;

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

        private void games_Click(object sender, RoutedEventArgs e)
        {
            TopLeft.Content = FindResource("Trees");
            TopRight.Content = FindResource("Dora");
            BotLeft.Content = FindResource("Sesame");
            BotRight.Content = FindResource("Turtles");
        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {
            TopLeft.Content = FindResource("Sesame");
            TopRight.Content = FindResource("Turtles");
            BotLeft.Content = FindResource("Trees");
            BotRight.Content = FindResource("Dora");
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            TopLeft.Content = FindResource("Turtles");
            TopRight.Content = FindResource("Sesame");
            BotLeft.Content = FindResource("Dora");
            BotRight.Content = FindResource("Trees");
        }

    }
}
