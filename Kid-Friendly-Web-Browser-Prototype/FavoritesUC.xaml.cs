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
    /// Interaction logic for FavoritesUC.xaml
    /// </summary>
    public partial class FavoritesUC : UserControl
    {
        public static event EventHandler website_Usr_Ctrl_Click;

        public FavoritesUC()
        {
            InitializeComponent();
        }

        private void website_Click(object sender, RoutedEventArgs e)
        {
            if (website_Usr_Ctrl_Click != null)
            {
                website_Usr_Ctrl_Click(this, new EventArgs());
            }
        }
    }
}
