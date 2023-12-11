using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;


namespace TicTacToeWPFspiel
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string BG_Video = "SnowfallStreet2.mp4";

        Game            _runningGame    = new Game(BG_Video);
        SpielOptionen   _options        = new SpielOptionen();

        public MainWindow()
        {
            InitializeComponent();

            NavigationFrame.Content = _runningGame;
        }

        private void options_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(_options);
            options.Visibility = Visibility.Collapsed;
            quitGame.Visibility = Visibility.Collapsed;
            backToGame.Visibility = Visibility.Visible;
        }

        private void quitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void backToGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(_runningGame);
            backToGame.Visibility = Visibility.Collapsed;
            options.Visibility = Visibility.Visible;
            quitGame.Visibility = Visibility.Visible;
            _runningGame.BackgroundVideo.Source = new Uri(BG_Video, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }
    }
}