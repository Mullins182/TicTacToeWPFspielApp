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

        //public string Video = "";

        public SpielOptionen(string bgVid) 
        {
            InitializeComponent();
            //Video = bgVid;
                        
            if (!File.Exists(bgVid))  // Dialogfenster öffnet wenn die Datei nicht im Programmverzeichnis existiert !
            {

                if (MessageBox.Show("Hintergrund-Videodatei (Optionen) nicht gefunden. Trotzdem starten ?", "FEHLER", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {

                }
                else
                {

                }
            }

            BackgroundVideoOptions.Source = new Uri(bgVid, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }


        private void BG_1_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "SnowfallStreet2.mp4";
            BackgroundVideoOptions.Source = new Uri(MainWindow.BG_Video, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }

        private void BG_2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "Snowflakes.mp4";
            BackgroundVideoOptions.Source = new Uri(MainWindow.BG_Video, UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !
        }

        private void BackgroundVideoOptions_MediaEnded(object sender, RoutedEventArgs e)
        {
            BackgroundVideoOptions.Position = TimeSpan.Zero;           // Bei erreichen von Video-Ende wird die Playbackposition auf NULL zurückgesetzt und das Video beginnt von Neuem !
        }
    }
}