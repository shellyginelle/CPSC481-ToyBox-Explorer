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
using System.Windows.Shapes;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for TimeOut.xaml
    /// </summary>
    public partial class TimeOut : Window
    {
        public TimeOut()
        {
            InitializeComponent();
        }

        private void resetBrowser(object sender, RoutedEventArgs e)
        {
            MainWindow newBrowser = new MainWindow();
            newBrowser.Show();
        }

        private void exitBrowser(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
