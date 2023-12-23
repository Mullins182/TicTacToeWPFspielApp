using Accessibility;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using TicTacToeWPFspiel;

namespace TicTacToeWPFspiel
{
    /// <summary>
    /// Interaktionslogik für SpielOptionen.xaml
    /// </summary>
    public partial class SpielOptionen : Page
    {
        public static event EventHandler<string>? BGvideoChanged;
        public static event EventHandler<string>? BGaudioChanged;
        public static event EventHandler<string>? BGmusicOff;
        public static event EventHandler<string>? Menu_Choice_Sound;


        public SpielOptionen(string bgVid) 
        {
            InitializeComponent();
        }

        private void BG_1_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");            
            MainWindow.BG_Video = @"BG_Videos\SnowfallStreet2.mp4";
            BGvideoChanged?.Invoke(this, "...");      // Invoke ist der Trigger !
        }

        private void BG_2_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Video = @"BG_Videos\Snowflakes.mp4";
            BGvideoChanged?.Invoke(this, "Snowflake");      // Invoke ist der Trigger !
        }


        private void BG_3_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Video = @"BG_Videos\StarExploding.mp4";
            BGvideoChanged?.Invoke(this, "Star Exploding");      // Invoke ist der Trigger !
        }

        private void BG_4_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Video = @"BG_Videos\SnowfallStreet1.mp4";
            BGvideoChanged?.Invoke(this, "...");      // Invoke ist der Trigger !

        }

        private void BG_5_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Video = @"BG_Videos\Snowflakes2.mp4";
            BGvideoChanged?.Invoke(this, "Snowflake");      // Invoke ist der Trigger !
        }

        private void BGm_1_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Music = @"Music\ChristmasSwing.mp3";
            BGaudioChanged?.Invoke(this, "...");
        }

        private void BGm_2_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Music = @"Music\Schneefloeckchen.mp3";
            BGaudioChanged?.Invoke(this, "...");
        }

        private void BGm_2_Off(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            BGmusicOff?.Invoke(this, "...");
        }
    }
}