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

        public static event EventHandler home_Usr_Ctrl_Click;
        public static event EventHandler fav_Usr_Ctrl_Click;


        public OnWebsite()
        {
            InitializeComponent();
        }

        private void upScrollClick(object sender, RoutedEventArgs e)
        {
            img_position_controller += 450;
            if (img_position_controller >= 195)
            {
                img_position_controller = 195;
            }
            sesame_street_img.Margin = new Thickness(0, img_position_controller, 0, 0);
        }

        private void downScrollClick(object sender, RoutedEventArgs e)
        {
            img_position_controller -= 450;
            if (img_position_controller <= -1428)
            {
                img_position_controller = -1428;
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
            if (fav_Usr_Ctrl_Click != null)
            {
                fav_Usr_Ctrl_Click(this, new EventArgs());
            }
        }
    }
}
