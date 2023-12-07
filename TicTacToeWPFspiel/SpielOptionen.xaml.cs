using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
