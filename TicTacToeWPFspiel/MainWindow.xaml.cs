using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BA1_Click(object sender, RoutedEventArgs e)
        {
            BA1.Visibility  = Visibility.Hidden;
            BXA1.Visibility = Visibility.Visible;
        }

        private void BA2_Click(object sender, RoutedEventArgs e)
        {
            BA2.Visibility  = Visibility.Hidden;
            BXA2.Visibility = Visibility.Visible;
        }

        private void BA3_Click(object sender, RoutedEventArgs e)
        {
            BA3.Visibility  = Visibility.Hidden;
            BXA3.Visibility = Visibility.Visible;
        }

        private void BB1_Click(object sender, RoutedEventArgs e)
        {
            BB1.Visibility  = Visibility.Hidden;
            BXB1.Visibility = Visibility.Visible;
        }

        private void BB2_Click(object sender, RoutedEventArgs e)
        {
            BB2.Visibility  = Visibility.Hidden;
            BXB2.Visibility = Visibility.Visible;
        }

        private void BB3_Click(object sender, RoutedEventArgs e)
        {
            BB3.Visibility  = Visibility.Hidden;
            BXB3.Visibility = Visibility.Visible;
        }

        private void BC1_Click(object sender, RoutedEventArgs e)
        {
            BC1.Visibility  = Visibility.Hidden;
            BXC1.Visibility = Visibility.Visible;
        }

        private void BC2_Click(object sender, RoutedEventArgs e)
        {
            BC2.Visibility  = Visibility.Hidden;
            BXC2.Visibility = Visibility.Visible;
        }

        private void BC3_Click(object sender, RoutedEventArgs e)
        {
            BC3.Visibility  = Visibility.Hidden;
            BXC3.Visibility = Visibility.Visible;
        }
    }
}