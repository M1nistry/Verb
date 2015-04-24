using System;
using System.Windows;
using System.Windows.Controls;

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
            //imageUserPicture.Source = new BitmapImage(new Uri(@"U:\test1.png", UriKind.Relative));
        }

        private void canvasHeader_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            e.Handled = true;
            //if (MenuMain.Height < 20) MenuMain.Height = 20;
        }
    }
}