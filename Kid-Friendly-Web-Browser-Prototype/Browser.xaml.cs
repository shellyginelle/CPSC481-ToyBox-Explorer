using System.Windows;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Browser : Window
    {

        private int img_position_controller;

        public Browser()
        {
            InitializeComponent();
            // margin is initially at y
            img_position_controller = 195;
        }

        private void homeButtonClick(object sender, RoutedEventArgs e)
        {
            Hide();
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
    }
}
