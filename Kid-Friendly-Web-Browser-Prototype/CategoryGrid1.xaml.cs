using System;
using System.Windows;
using System.Windows.Controls;

namespace Kid_Friendly_Web_Browser_Prototype
{
    /// <summary>
    /// Interaction logic for CategoryGrid1.xaml
    /// </summary>




    public partial class CategoryGrid1 : UserControl
    {

        public static event EventHandler website_Usr_Ctrl_Click;


        public CategoryGrid1()
        {
            InitializeComponent();
        }


        private void website_Click(object sender, RoutedEventArgs e)
        {
            if (website_Usr_Ctrl_Click != null)
            {
                website_Usr_Ctrl_Click(this, new EventArgs());
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../sound/tick.wav");
            player.Play();
        }


    }
}
