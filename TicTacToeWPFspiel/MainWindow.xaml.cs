using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace TicTacToeWPFspiel
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Game GameWindow;
        //public SpielOptionen OptionsPage;    

        public MainWindow()
        {
            InitializeComponent();
                                       
            OptionsFrame.NavigationService.Navigate(new Game(this));    // Erstellt ein Gameobjekt und fügt es dem OptionsFrame hinzu und navigiert dorthin. This gibt adresse von MainWindow mit.
        }
    }
}