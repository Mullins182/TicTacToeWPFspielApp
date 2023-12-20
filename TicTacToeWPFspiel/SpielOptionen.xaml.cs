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

        public SpielOptionen(string bgVid) 
        {
            InitializeComponent();
        }

        private void BG_1_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "SnowfallStreet2.mp4";
            BGvideoChanged?.Invoke(this, "...");      // Invoke ist der Trigger !
        }

        private void BG_2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "Snowflakes.mp4";
            BGvideoChanged?.Invoke(this, "Snowflake");      // Invoke ist der Trigger !
        }


        private void BG_3_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "StarExploding.mp4";
            BGvideoChanged?.Invoke(this, "Star Exploding");      // Invoke ist der Trigger !
        }

        private void BG_4_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "SnowfallStreet1.mp4";
            BGvideoChanged?.Invoke(this, "...");      // Invoke ist der Trigger !

        }

        private void BGm_1_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Music = "ChristmasSwing.mp3";
            BGaudioChanged?.Invoke(this, "...");
        }

        private void BGm_2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Music = "Schneefloeckchen.mp3";
            BGaudioChanged?.Invoke(this, "...");
        }
    }
}