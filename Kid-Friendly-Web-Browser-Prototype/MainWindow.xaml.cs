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
        private bool catGrid1;
        private bool catGrid2;
        private bool catGrid3;
        private bool catGridFavour;
        private bool favor;

        OnWebsite websiteControl = new OnWebsite();
        private int page;

        public MainWindow()
        {
            InitializeComponent();
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid1());
            catGrid1 = true;
            catGrid2 = false;
            catGrid3 = false;
            catGridFavour = false;
            favor = false;
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;

            CategoryGrid1.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);
            CategoryGrid2.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);
            CategoryGrid3.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);
            OnWebsite.home_Usr_Ctrl_Click += new EventHandler(home);
            OnWebsite.fav_Usr_Ctrl_Click += new EventHandler(fav);
            FavoritesUC.website_Usr_Ctrl_Click += new EventHandler(goToWebsite);
            resetThickness();
            games.BorderThickness = new Thickness(3);
        }

        private void resetThickness()
        {
            games.BorderThickness = new Thickness(0);
            video.BorderThickness = new Thickness(0);
            heart.BorderThickness = new Thickness(0);
            learn.BorderThickness = new Thickness(0);
        }

        private void goToWebsite(object sender, object EventArgs ) 
        {
            mainPanel.Children.Clear();
            mainPanel.Children.Add(websiteControl);
        }


        private void fav(object sender, object EventArgs)
        {

            if (favor)
            {
                favor = false;
            }
            else{
                favor = true;
            }
            if ((catGridFavour == true) && (favor == false))
            {
                CategoryGridDockPanel.Children.Clear();
            }

        }

        private void home(object sender, object EventArgs)
        {
            mainPanel.Children.Clear();
        }


        private void progressBarChange(object sender, EventArgs e)
        {
            // 600 seconds = 10 minutes MAX TIME FOR WEB BROWSER 
            for (int i = 0; i < 600; i++)
            {
                pbStatus.Dispatcher.Invoke(() => pbStatus.Value = i, System.Windows.Threading.DispatcherPriority.Background);
                Thread.Sleep(600);
            }

            TimeOut popup = new TimeOut(); //Create new window to the exit page 
            popup.Show();
            Close();
        }

    

        private void games_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Visible;
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid1());
            catGrid1 = true;
            catGrid2 = false;
            catGrid3 = false;
            catGridFavour = false;
            resetThickness();
            games.BorderThickness = new Thickness(3);

        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Visible;
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid2());
            catGrid1 = false;
            catGrid2 = true;
            catGrid3 = false;
            catGridFavour = false;
            resetThickness();
            video.BorderThickness = new Thickness(3);
        }



        private void learn_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Visible;
            CategoryGridDockPanel.Children.Clear();
            CategoryGridDockPanel.Children.Add(new CategoryGrid3());
            catGrid1 = false;
            catGrid2 = false;
            catGrid3 = true;
            catGridFavour = false;
            resetThickness();
            learn.BorderThickness = new Thickness(3);
        }

        private void heart_Click(object sender, RoutedEventArgs e)
        {
            catGrid1 = false;
            catGrid2 = false;
            catGrid3 = false;
            catGridFavour = true;
            leftArrow.Visibility = Visibility.Hidden;
            rightArrow.Visibility = Visibility.Hidden;

            if (favor)
            {
                CategoryGridDockPanel.Children.Clear();
                CategoryGridDockPanel.Children.Add(new FavoritesUC());
            }
            else
            {
                CategoryGridDockPanel.Children.Clear();
            }
            resetThickness();
            heart.BorderThickness = new Thickness(3);
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
                rightArrow.Visibility = Visibility.Visible;
            }
            else if (page == 3)
            {
                rightArrow.Visibility = Visibility.Hidden;
            }
            
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
                rightArrow.Visibility = Visibility.Visible;
            }
            else if (page == 3)
            {
                rightArrow.Visibility = Visibility.Hidden;
            }

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
