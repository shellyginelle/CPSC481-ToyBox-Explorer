using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for OnWebsite.xaml
    /// </summary>
    public partial class OnWebsite : UserControl
    {
        private int img_position_controller;

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
    }
}
