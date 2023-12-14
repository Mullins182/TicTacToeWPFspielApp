using System;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;
using Color = System.Windows.Media.Color;


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

        private void ButtonAnimation(string x, Button y)
        {
            
            ColorAnimationUsingKeyFrames ButtonColorEffect = new ColorAnimationUsingKeyFrames();
            ColorAnimationUsingKeyFrames BackgroundAnimation = new ColorAnimationUsingKeyFrames();
            BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(3));
            BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(500))));
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(5));
            ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black,KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(500))));
            //ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            Storyboard.SetTargetName(ButtonColorEffect, x);
            Storyboard.SetTargetProperty(BackgroundAnimation, new PropertyPath
            ("(Button.Background).(SolidColorBrush.Color)"));
            Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ("(Button.Foreground).(SolidColorBrush.Color)"));
            Storyboard FarbAnimation = new Storyboard();
            //FarbAnimation.AutoReverse = true;
            //FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            FarbAnimation.Children.Add(BackgroundAnimation);
            FarbAnimation.Children.Add(ButtonColorEffect);
            FarbAnimation.Begin(y);
        }

        private void ButtonReverseAnimation(string x, Button y)
        {
            ColorAnimationUsingKeyFrames ButtonColorEffect = new ColorAnimationUsingKeyFrames();
            ColorAnimationUsingKeyFrames BackgroundAnimation = new ColorAnimationUsingKeyFrames();
            BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(3));
            BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.DarkRed, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(950))));
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(5));
            ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(950))));
            //ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            Storyboard.SetTargetName(ButtonColorEffect, x);
            Storyboard.SetTargetProperty(BackgroundAnimation, new PropertyPath
            ("(Button.Background).(SolidColorBrush.Color)"));
            Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ("(Button.Foreground).(SolidColorBrush.Color)"));
            Storyboard FarbAnimation = new Storyboard();
            //FarbAnimation.AutoReverse = true;
            //FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            FarbAnimation.Children.Add(BackgroundAnimation);
            FarbAnimation.Children.Add(ButtonColorEffect);
            FarbAnimation.Begin(y);


            //ColorAnimation ButtonColorEffect = new ColorAnimation();
            //ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(2));
            //ButtonColorEffect.From = Colors.GreenYellow;
            //ButtonColorEffect.To = Colors.DarkRed;
            //Storyboard.SetTargetName(ButtonColorEffect, x);
            //Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            //("(Button.Background).(SolidColorBrush.Color)"));
            ////Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ////("(Button.Foreground).(SolidColorBrush.Color)"));
            //Storyboard FarbAnimation = new Storyboard();
            ////FarbAnimation.AutoReverse = true;
            ////FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            //FarbAnimation.Children.Add(ButtonColorEffect);
            //FarbAnimation.Begin(y);
        }

        private void backToGame_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

            ButtonAnimation(backToGame.Name, backToGame);
        }

        private void backToGame_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonReverseAnimation(backToGame.Name, backToGame);
        }

        private void options_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(options.Name, options);
        }

        private void options_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonReverseAnimation(options.Name, options);
        }

        private void quitGame_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(quitGame.Name, quitGame);
        }

        private void quitGame_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonReverseAnimation(quitGame.Name, quitGame);
        }
    }
}