using Accessibility;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using TicTacToeWPFspiel;

namespace TicTacToeWPFspiel
{
    public partial class SpielOptionen : Page
    {
        public static event EventHandler<string>? BGvideoChanged;
        public static event EventHandler<string>? BGaudioChanged;
        public static event EventHandler<string>? BGmusicOff;
        public static event EventHandler<string>? Menu_Choice_Sound;
        public static event EventHandler<string>? PlayersymbolChanged;

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
        private void BGm_3_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Music = @"Music\retro_wave_style_track.mp3";
            BGaudioChanged?.Invoke(this, "...");
        }

        private void BGm_4_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            MainWindow.BG_Music = @"Music\alone_by_the_river.mp3";
            BGaudioChanged?.Invoke(this, "...");
        }

        private void BGmOff(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            BGmusicOff?.Invoke(this, "...");
        }

        private void Symbol1_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            Game.playerSymbol   = "pack://application:,,,/Images/Zuckerstangen.png";
            Game.npcSymbol      = "pack://application:,,,/Images/Donut.png";
            PlayersymbolChanged?.Invoke(this, "...");
        }

        private void Symbol2_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            Game.playerSymbol   = "pack://application:,,,/Images/Donut.png";
            Game.npcSymbol      = "pack://application:,,,/Images/Zuckerstangen.png";
            PlayersymbolChanged?.Invoke(this, "...");
        }

        private void Symbol3_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            Game.playerSymbol   = "pack://application:,,,/Images/X.png";
            Game.npcSymbol      = "pack://application:,,,/Images/O.png";
            PlayersymbolChanged?.Invoke(this, "...");
        }

        private void Symbol4_Checked(object sender, RoutedEventArgs e)
        {
            Menu_Choice_Sound?.Invoke(this, "...");
            Game.playerSymbol   = "pack://application:,,,/Images/O.png";
            Game.npcSymbol      = "pack://application:,,,/Images/X.png";
            PlayersymbolChanged?.Invoke(this, "...");
        }
    }
}