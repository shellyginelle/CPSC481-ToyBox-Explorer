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
        private bool backButtonHandle;


        public OnWebsite()
        {
            InitializeComponent();
            heart_on_off = 0;
            backButtonHandle = false;
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            backButton.Content = FindResource("back_grey");
            cookieImg.Visibility = Visibility.Hidden;
            if (backButtonHandle)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/tick.wav");
                player.Play();
                backButtonHandle = false;

            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/pageBounce.wav");
                player.Play();
            }
        }

        private void newPage_Click(object sender, RoutedEventArgs e)
        {
            backButtonHandle = true;
            backButton.Content = FindResource("back");
            cookieImg.Visibility = Visibility.Visible;
        }

        private void upScrollClick(object sender, RoutedEventArgs e)
        {
            img_position_controller += 450;
            if (img_position_controller >= 130)
            {
                img_position_controller = 130;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/pageBounce.wav");
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/tick.wav");
                player.Play();
            }
            sesame_street_img.Margin = new Thickness(0, img_position_controller, 0, 0);
            
        }

        private void downScrollClick(object sender, RoutedEventArgs e)
        {
            img_position_controller -= 450;
            if (img_position_controller <= -1493)
            {
                img_position_controller = -1493;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/pageBounce.wav");
                player.Play();
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/tick.wav");
                player.Play();
            }
            sesame_street_img.Margin = new Thickness(0, img_position_controller, 0, 0);
        
        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            if (home_Usr_Ctrl_Click != null)
            {
                home_Usr_Ctrl_Click(this, new EventArgs());
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/tick.wav");
            player.Play();
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
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/tick.wav");
            player.Play();
        }
    }
}
