using System;
using System.Windows;
using System.Windows.Controls;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for OnWebsite.xaml
    /// </summary>
    public partial class OnWebsite : UserControl
    {
        private int img_position_controller;

        private int heart_on_off;

        public static event EventHandler home_Usr_Ctrl_Click;
        public static event EventHandler fav_Usr_Ctrl_Click;


        public OnWebsite()
        {
            InitializeComponent();
            heart_on_off = 0;
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            cookieImg.Visibility = Visibility.Hidden;
        }
        private void newPage_Click(object sender, RoutedEventArgs e)
        {
            cookieImg.Visibility = Visibility.Visible;
        }

        private void upScrollClick(object sender, RoutedEventArgs e)
        {
            img_position_controller += 450;
            if (img_position_controller >= 130)
            {
                img_position_controller = 130;
            }
            sesame_street_img.Margin = new Thickness(0, img_position_controller, 0, 0);
        }

        private void downScrollClick(object sender, RoutedEventArgs e)
        {
            img_position_controller -= 450;
            if (img_position_controller <= -1493)
            {
                img_position_controller = -1493;
            }
            sesame_street_img.Margin = new Thickness(0, img_position_controller, 0, 0);
        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            if (home_Usr_Ctrl_Click != null)
            {
                home_Usr_Ctrl_Click(this, new EventArgs());
            }
        }


        private void addFave_Click(object sender, RoutedEventArgs e)
        {
            if (heart_on_off == 0)
            {
                heart_on_off = 1;
                favourite.Content = FindResource("heart_full");
            }
            else
            {
                heart_on_off = 0;
                favourite.Content = FindResource("heart_empty");
            }

            if (fav_Usr_Ctrl_Click != null)
            {
                fav_Usr_Ctrl_Click(this, new EventArgs());
            }
        }
    }
}
