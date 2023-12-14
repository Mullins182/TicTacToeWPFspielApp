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

        public SpielOptionen(string bgVid) 
        {
            InitializeComponent();                        
        }

        private void BG_1_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "SnowfallStreet2.mp4";            
        }

        private void BG_2_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "Snowflakes.mp4";
        }


        private void BG_3_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.BG_Video = "StarExploding.mp4";            
        }
    }
}