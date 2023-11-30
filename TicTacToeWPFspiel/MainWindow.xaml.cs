using System.Runtime.ConstrainedExecution;
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
        int player_choice   = 0;
        int cpu_choice      = 0;

        // CPU hat folgende Felder "geklickt"
        bool cpu_choosed1    = false;
        bool cpu_choosed2    = false;
        bool cpu_choosed3    = false;
        bool cpu_choosed4    = false;
        bool cpu_choosed5    = false;
        bool cpu_choosed6    = false;
        bool cpu_choosed7    = false;
        bool cpu_choosed8    = false;
        bool cpu_choosed9    = false;
        // Player hat folgende Felder geklickt !
        bool player_choosed1 = false;
        bool player_choosed2 = false;
        bool player_choosed3 = false;
        bool player_choosed4 = false;
        bool player_choosed5 = false;
        bool player_choosed6 = false;
        bool player_choosed7 = false;
        bool player_choosed8 = false;
        bool player_choosed9 = false;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BA1_Click(object sender, RoutedEventArgs e)
        {

            player_choice = 1;

            player_choosed1 = true;

            BA1.Visibility = Visibility.Hidden;
            BXA1.Visibility = Visibility.Visible;
            

            INFO.Visibility = Visibility.Visible;

            cpu_Choice();
        }
        private void cpu_Choice()
        {
            var rd_number_generated = new Random();

            Thread.Sleep(2000);

        J1:

                cpu_choice = rd_number_generated.Next(1, 10);


            if (cpu_choice == 1 && player_choosed1 != true)
                {
                    cpu_choice = 1;
                    BA1.Visibility = Visibility.Hidden;
                    BOA1.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 2 && player_choosed2 != true)
                {
                    cpu_choice = 2;
                    BA2.Visibility = Visibility.Hidden;
                    BOA2.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 3 && player_choosed3 != true)
                {
                    cpu_choice = 3;
                    BA3.Visibility = Visibility.Hidden;
                    BOA3.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 4 && player_choosed4 != true)
                {
                    cpu_choice = 4;
                    BB1.Visibility = Visibility.Hidden;
                    BOB1.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 5 && player_choosed5 != true)
                {
                    cpu_choice = 5;
                    BB2.Visibility = Visibility.Hidden;
                    BOB2.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 6 && player_choosed6 != true)
                {
                    cpu_choice = 6;
                    BB3.Visibility = Visibility.Hidden;
                    BOB3.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 7 && player_choosed7 != true)
                {
                    cpu_choice = 7;
                    BC1.Visibility = Visibility.Hidden;
                    BOC1.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 8 && player_choosed8 != true)
                {
                    cpu_choice = 8;
                    BC2.Visibility = Visibility.Hidden;
                    BOC2.Visibility = Visibility.Visible;
                }
                else if (cpu_choice == 9 && player_choosed9 != true)
                {
                    cpu_choice = 9;
                    BC3.Visibility = Visibility.Hidden;
                    BOC3.Visibility = Visibility.Visible;
                }
                else
                {
                    goto J1;
                }

                //INFO.Visibility = Visibility.Hidden;     
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