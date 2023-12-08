using System.Windows;
using System.Windows.Controls;

namespace TicTacToeWPFspiel
{
    /// <summary>
    /// Interaktionslogik für SpielOptionen.xaml
    /// </summary>
    public partial class SpielOptionen : Page
    {
        MainWindow MAIN;
        public SpielOptionen(MainWindow MAIN) 
        {
            this.MAIN = MAIN;                           // Adresse des Mainwindow übergeben
            //this.OptionsFrame = Game.OptionsFrame;
            InitializeComponent();


            
        }


        private void backToMain_Click(object sender, RoutedEventArgs e)
        {
            

            MAIN.OptionsFrame.NavigationService.Navigate(new Game(MAIN));
        }
    }
}
