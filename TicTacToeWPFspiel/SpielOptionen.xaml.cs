using System.Windows;
using System.Windows.Controls;

namespace TicTacToeWPFspiel
{
    /// <summary>
    /// Interaktionslogik für SpielOptionen.xaml
    /// </summary>
    public partial class SpielOptionen : Page
    {
        Frame OptionsFrame;                             // Klassenverfügbare Property, die die Referenz zum Frame speichert !

        public SpielOptionen(Frame OptionsFrame)        // Referenz von OptionsFrame übergeben. (Zeiger)
        {
            this.OptionsFrame = OptionsFrame;           // Hier wird die Referenz zu OptionsFrame an Property übergeben 
            InitializeComponent();
        }


        private void backToMain_Click(object sender, RoutedEventArgs e)
        {            
            OptionsFrame.NavigationService.Navigate(new Game());
        }
    }
}
