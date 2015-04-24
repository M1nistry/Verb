using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GumshoeIM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var userImage = new BitmapImage
            {
                BaseUri = new Uri(@"C:\Users\M1nistry\Pictures\Other\me.png")
            };
            imageUserPicture.Source = userImage;
        }

        private void canvasHeader_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            e.Handled = true;
            if (MenuMain.Height < 20) MenuMain.Height = 20;
        }

        private void Main_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
