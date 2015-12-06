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
        private Boolean addedToFaves = false;
        private int page;
        private bool gamesGrid = false;
        private bool videosGrid = false;
        private bool learnGrid = false;

        public MainWindow()
        {
            InitializeComponent();
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
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

            rightArrow.Visibility = Visibility.Hidden;
            leftArrow.Visibility = Visibility.Hidden;

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

            rightArrow.Visibility = Visibility.Visible;
            leftArrow.Visibility = Visibility.Visible;

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
            page = 1;
            gamesGrid = true;
            TopLeft.Visibility = Visibility.Visible;
            TopRight.Visibility = Visibility.Visible;
            BotLeft.Visibility = Visibility.Visible;
            BotRight.Visibility = Visibility.Visible;

            TopLeft.Content = FindResource("Trees");
            TopRight.Content = FindResource("Dora");
            BotLeft.Content = FindResource("Sesame");
            BotRight.Content = FindResource("Turtles");
        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            videosGrid = true;
            TopLeft.Visibility = Visibility.Visible;
            TopRight.Visibility = Visibility.Visible;
            BotLeft.Visibility = Visibility.Visible;
            BotRight.Visibility = Visibility.Visible;

            TopLeft.Content = FindResource("Sesame");
            TopRight.Content = FindResource("Turtles");
            BotLeft.Content = FindResource("Trees");
            BotRight.Content = FindResource("Dora");
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            learnGrid = true;
            TopLeft.Visibility = Visibility.Visible;
            TopRight.Visibility = Visibility.Visible;
            BotLeft.Visibility = Visibility.Visible;
            BotRight.Visibility = Visibility.Visible;

            TopLeft.Content = FindResource("Turtles");
            TopRight.Content = FindResource("Sesame");
            BotLeft.Content = FindResource("Dora");
            BotRight.Content = FindResource("Trees");
        }

        private void faves_Click(object sender, RoutedEventArgs e)
        {
            rightArrow.Visibility = Visibility.Hidden;

            if (addedToFaves)
            {
                TopLeft.Content = FindResource("Sesame");
                TopRight.Visibility = Visibility.Hidden;
                BotLeft.Visibility = Visibility.Hidden;
                BotRight.Visibility = Visibility.Hidden;
            } else
            {
                TopLeft.Visibility = Visibility.Hidden;
                TopRight.Visibility = Visibility.Hidden;
                BotLeft.Visibility = Visibility.Hidden;
                BotRight.Visibility = Visibility.Hidden;
            }
        }

        private void addFave_Click(object sender, RoutedEventArgs e)
        {
            addedToFaves = true;
        }

        private void rightArrow_Click(object sender, RoutedEventArgs e)
        {
            page++;
            if (page == 1)
            {
                leftArrow.Visibility = Visibility.Hidden;
            }
            else if (page == 2)
            {
                leftArrow.Visibility = Visibility.Visible;
            }
            else if (page == 3)
            {
                rightArrow.Visibility = Visibility.Hidden;
            }

            if (gamesGrid)
            {
                gamesGrid = false;
                videosGrid = true;
                learnGrid = false;
                TopLeft.Visibility = Visibility.Visible;
                TopRight.Visibility = Visibility.Visible;
                BotLeft.Visibility = Visibility.Visible;
                BotRight.Visibility = Visibility.Visible;

                TopLeft.Content = FindResource("Sesame");
                TopRight.Content = FindResource("Turtles");
                BotLeft.Content = FindResource("Trees");
                BotRight.Content = FindResource("Dora");
            }

            else if (videosGrid)
            {
                gamesGrid = false;
                videosGrid = false;
                learnGrid = true;
                TopLeft.Visibility = Visibility.Visible;
                TopRight.Visibility = Visibility.Visible;
                BotLeft.Visibility = Visibility.Visible;
                BotRight.Visibility = Visibility.Visible;

                TopLeft.Content = FindResource("Turtles");
                TopRight.Content = FindResource("Sesame");
                BotLeft.Content = FindResource("Dora");
                BotRight.Content = FindResource("Trees");
            }

            else
            {
                gamesGrid = true;
                videosGrid = false;
                learnGrid = false;
                TopLeft.Visibility = Visibility.Visible;
                TopRight.Visibility = Visibility.Visible;
                BotLeft.Visibility = Visibility.Visible;
                BotRight.Visibility = Visibility.Visible;

                TopLeft.Content = FindResource("Trees");
                TopRight.Content = FindResource("Dora");
                BotLeft.Content = FindResource("Sesame");
                BotRight.Content = FindResource("Turtles");
            }
        }

        private void leftArrow_Click(object sender, RoutedEventArgs e)
        {
            page--;
            if (page == 1)
            {
                leftArrow.Visibility = Visibility.Hidden;
                rightArrow.Visibility = Visibility.Visible;
            }
            else if (page == 2)
            {
                leftArrow.Visibility = Visibility.Visible;
            }
            else if (page == 3)
            {
                rightArrow.Visibility = Visibility.Hidden;
            }

            if (gamesGrid)
            {
                gamesGrid = false;
                videosGrid = true;
                learnGrid = false;
                TopLeft.Visibility = Visibility.Visible;
                TopRight.Visibility = Visibility.Visible;
                BotLeft.Visibility = Visibility.Visible;
                BotRight.Visibility = Visibility.Visible;

                TopLeft.Content = FindResource("Trees");
                TopRight.Content = FindResource("Dora");
                BotLeft.Content = FindResource("Sesame");
                BotRight.Content = FindResource("Turtles");

            }

            else if (videosGrid)
            {
                gamesGrid = true;
                videosGrid = false;
                learnGrid = false;
                TopLeft.Visibility = Visibility.Visible;
                TopRight.Visibility = Visibility.Visible;
                BotLeft.Visibility = Visibility.Visible;
                BotRight.Visibility = Visibility.Visible;

                TopLeft.Content = FindResource("Turtles");
                TopRight.Content = FindResource("Sesame");
                BotLeft.Content = FindResource("Dora");
                BotRight.Content = FindResource("Trees");
            }

            else
            {
                gamesGrid = false;
                videosGrid = false;
                learnGrid = true;
                TopLeft.Visibility = Visibility.Visible;
                TopRight.Visibility = Visibility.Visible;
                BotLeft.Visibility = Visibility.Visible;
                BotRight.Visibility = Visibility.Visible;

                TopLeft.Content = FindResource("Sesame");
                TopRight.Content = FindResource("Turtles");
                BotLeft.Content = FindResource("Trees");
                BotRight.Content = FindResource("Dora");
            }
        }
    }
}
