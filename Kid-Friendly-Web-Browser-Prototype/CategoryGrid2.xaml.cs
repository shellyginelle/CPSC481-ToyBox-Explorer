using System;
using System.Windows;
using System.Windows.Controls;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for CategoryGrid2.xaml
    /// </summary>
    public partial class CategoryGrid2 : UserControl
    {

        public static event EventHandler website_Usr_Ctrl_Click;


        public CategoryGrid2()
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
