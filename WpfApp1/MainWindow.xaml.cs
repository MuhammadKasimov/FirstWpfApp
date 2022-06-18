using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            Video.Source = new Uri("C:/Users/muham/Pictures/clip.mp4");
            Video.Visibility = Visibility.Visible;
            Video.LoadedBehavior = MediaState.Manual;
            Video.Play();
            StopButt.Visibility = Visibility.Visible;
        }

        private void StopButt_Click(object sender, RoutedEventArgs e)
        {
            Video.Stop();
            Video.Visibility = Visibility.Hidden;
            StopButt.Visibility = Visibility.Hidden;
        }
    }
}
