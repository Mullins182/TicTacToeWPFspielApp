using System;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using static System.Net.Mime.MediaTypeNames;
using Color = System.Windows.Media.Color;


// Soundeffekte und Musik für Spiele gibt es u.A. bei "pixabay.com" !!!

namespace TicTacToeWPFspiel
{
    public partial class MainWindow : Window
    {
        public static string BG_Video       = @"BG_Videos\SnowfallStreet2.mp4";
        public static string BG_Music       = @"Music\alone_by_the_river.mp3";
        public static string confettiCannon = @"BG_Videos\ConfettiCannon.mp4";
        public static string gameOverVideo  = @"BG_Videos\GameOver.mp4";
        public static string Sound          = @"Sounds\Decide.mp3";
        public static string ChooseSound    = @"Sounds\PencilX.wav";

        private bool isFullscreenModeOn     = false;

        public SpielOptionen _options       = new(BG_Video);
        public Game _runningGame            = new();

        public void ChangeBackgroundVideo(object? sender, string e)
        {
            BackgroundVideo.Stop();
            BackgroundVideo.Source = new Uri(BG_Video, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
            BackgroundVideo.Play();
        }

        public void ConfettiCannon(object? sender, string e)
        {
            BackgroundVideo.Source = new Uri(confettiCannon, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }

        private void GameOverVideo(object? sender, string e)
        {            
            BackgroundVideo.Source = new Uri(gameOverVideo, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }

        private void ChangeBGmusic(object? sender, string e)
        {
            BGmusic.Source = new Uri(BG_Music, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
            BGmusic.Play();
        }

        private void BGmusicOff(object? sender, string e)
        {
            BGmusic.Stop();
        }

        private void MenuChoiceSound(object? sender, string e)
        {
            PlaySound.Source = new Uri(Sound, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
            PlaySound.Play();
        }

        private void ChoosedFieldSound(object? sender, string e)
        {
            PlaySound.Source = new Uri(ChooseSound, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
            PlaySound.Play();
        }

        public MainWindow()
        {
            
            InitializeComponent();

            Game_ini();

        }

        private void Game_ini()
        {
            if (!File.Exists(BG_Video))  // Dialogfenster öffnet wenn die Datei nicht im Programmverzeichnis existiert !
            {

                if (MessageBox.Show("Hintergrund-Videodatei (Game) nicht gefunden. Trotzdem starten ?", "FEHLER", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {

                }
                else
                {

                }
            }

            MenuGrid.Width = this.Width;

            BackgroundVideo.BeginInit();
            BackgroundVideo.Source = new Uri(BG_Video, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
            BGmusic.Source = new Uri(BG_Music, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
            BGmusic.Play();
            BackgroundVideo.Play();

            //_options = new SpielOptionen(BG_Video);

            NavigationFrame.Content = _runningGame;

            SpielOptionen.BGvideoChanged    += ChangeBackgroundVideo;
            SpielOptionen.BGaudioChanged    += ChangeBGmusic;
            SpielOptionen.BGmusicOff        += BGmusicOff;
            SpielOptionen.Menu_Choice_Sound += MenuChoiceSound;
            Game.PlayerWins                 += ConfettiCannon;
            Game.GameOver                   += GameOverVideo;
            Game.ResetBGvideo               += ChangeBackgroundVideo;
            Game.ChosenFieldSound           += ChoosedFieldSound;
        }

        private void FullscreenModeBtn_Click(object sender, RoutedEventArgs e)
        {
            isFullscreenModeOn  = isFullscreenModeOn ? false : true;
            this.WindowState    = isFullscreenModeOn ? WindowState.Maximized : WindowState.Normal;
            this.WindowStyle    = isFullscreenModeOn ? WindowStyle.None : WindowStyle.SingleBorderWindow;

            _runningGame.GameGrid.RowDefinitions[0].Height      = isFullscreenModeOn ? new GridLength(50, GridUnitType.Star) : new GridLength(30, GridUnitType.Star);
            _runningGame.GameGrid.RowDefinitions[1].Height      = isFullscreenModeOn ? new GridLength(13, GridUnitType.Star) : new GridLength(15, GridUnitType.Star);
            _runningGame.GameGrid.RowDefinitions[2].Height      = isFullscreenModeOn ? new GridLength(130, GridUnitType.Star) : new GridLength(100, GridUnitType.Star);
            _runningGame.GameGrid.RowDefinitions[3].Height      = isFullscreenModeOn ? new GridLength(15, GridUnitType.Star) : new GridLength(20, GridUnitType.Star);

            _runningGame.PlayGrid.ColumnDefinitions[0].Width    = isFullscreenModeOn ? new GridLength(167, GridUnitType.Pixel) : new GridLength(130, GridUnitType.Pixel);
            _runningGame.PlayGrid.ColumnDefinitions[1].Width    = isFullscreenModeOn ? new GridLength(167, GridUnitType.Pixel) : new GridLength(130, GridUnitType.Pixel);
            _runningGame.PlayGrid.ColumnDefinitions[2].Width    = isFullscreenModeOn ? new GridLength(167, GridUnitType.Pixel) : new GridLength(130, GridUnitType.Pixel);

            _runningGame.PlayGrid.RowDefinitions[0].Height      = isFullscreenModeOn ? new GridLength(167, GridUnitType.Pixel) : new GridLength(130, GridUnitType.Pixel);
            _runningGame.PlayGrid.RowDefinitions[1].Height      = isFullscreenModeOn ? new GridLength(167, GridUnitType.Pixel) : new GridLength(130, GridUnitType.Pixel);
            _runningGame.PlayGrid.RowDefinitions[2].Height      = isFullscreenModeOn ? new GridLength(167, GridUnitType.Pixel) : new GridLength(130, GridUnitType.Pixel);

            _runningGame.PlayGrid.Width         = isFullscreenModeOn ? 500 : 390;
            _runningGame.PlayGrid.Height        = isFullscreenModeOn ? 500 : 390;

            _runningGame.playGridLabelHeight    = isFullscreenModeOn ? 167 : 130;
            _runningGame.playGridLabelWidth     = isFullscreenModeOn ? 167 : 130;

            _runningGame.GameLabel.Height       = isFullscreenModeOn ? 200 : 180;
            _runningGame.GameLabel.Width        = isFullscreenModeOn ? 770 : 590;
            _runningGame.GameLabel.FontSize     = isFullscreenModeOn ? 170 : 120;

            FullscreenModeBtn.Content = isFullscreenModeOn ? "Fullscreen On" : "Fullscreen Off";

            _runningGame.PlayGridSizeIni();
        }

        private void options_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.NavigationService.Navigate(_options);
            options.Visibility              = Visibility.Hidden;
            quitGame.Visibility             = Visibility.Hidden;
            FullscreenModeBtn.Visibility    = Visibility.Hidden;
            backToGame.Visibility           = Visibility.Visible;
        }

        private void quitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void backToGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.NavigationService.Navigate(_runningGame);
            FullscreenModeBtn.Visibility = Visibility.Visible;
            backToGame.Visibility   = Visibility.Collapsed;
            options.Visibility      = Visibility.Visible;
            quitGame.Visibility     = Visibility.Visible;
            //BackgroundVideo.Source = new Uri(BG_Video, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }

        private static void ButtonAnimation(string x, Button y)
        {
            
            ColorAnimationUsingKeyFrames ButtonColorEffect = new();
            ColorAnimationUsingKeyFrames BackgroundAnimation = new();
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black,KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(200))));
            //BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(200))));
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

        private static void ButtonReverseAnimation(string x, Button y)
        {
            ColorAnimationUsingKeyFrames ButtonColorEffect = new ColorAnimationUsingKeyFrames();
            ColorAnimationUsingKeyFrames BackgroundAnimation = new ColorAnimationUsingKeyFrames();
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(350))));
            //BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.DarkRed, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(350))));
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

        private void TicTacToeHauptfenster_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MenuGrid.Width = this.Width;
        }

        private void backToGame_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(backToGame.Name, backToGame);
        }

        private void backToGame_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonReverseAnimation(backToGame.Name, backToGame);
        }
        private void FullscreenModeBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            ButtonAnimation(FullscreenModeBtn.Name, FullscreenModeBtn);
        }

        private void FullscreenModeBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            ButtonReverseAnimation(FullscreenModeBtn.Name, FullscreenModeBtn);
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
        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)   // Ereignishandler bei Playbackposition Video-Ende !
        {
            BackgroundVideo.Position = TimeSpan.FromMilliseconds(50);
            //_runningGame.INFO.Visibility = Visibility.Visible;
        }

        private void BGmusic_MediaEnded(object sender, RoutedEventArgs e)
        {
            BGmusic.Position = TimeSpan.Zero;   // Bei erreichen von Media-Ende wird die Playbackposition auf NULL zurückgesetzt und das Medium beginnt von Neuem !
        }
    }
}