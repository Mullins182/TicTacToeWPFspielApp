using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;


namespace TicTacToeWPFspiel
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string BG_Video = "SnowfallStreet2.mp4";
        public SpielOptionen _options;
        public Game _runningGame       = new Game(BG_Video);

        public MainWindow()
        {

            InitializeComponent();

            _options = new SpielOptionen(BG_Video);

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

        private void ButtonAnimation(string x)
        {
            ColorAnimation ButtonColorEffect = new ColorAnimation();
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(2));
            ButtonColorEffect.From = Colors.Blue;
            ButtonColorEffect.To = Colors.Red;
            Storyboard.SetTargetName(ButtonColorEffect, x);
            Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ("(Button.Background).(SolidColorBrush.Color)"));
            Storyboard FarbAnimation = new Storyboard();
            FarbAnimation.AutoReverse = true;
            FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            FarbAnimation.Children.Add(ButtonColorEffect);
            FarbAnimation.Begin(quitGame);
        }

        private void backToGame_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(backToGame.Name);
        }

        private void backToGame_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        private void options_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(options.Name);
        }

        private void options_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
        }

        private void quitGame_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(quitGame.Name);
        }

        private void quitGame_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}