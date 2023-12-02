using System.Runtime.ConstrainedExecution;
using System.Text;
using System;
using System.Windows;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace TicTacToeWPFspiel
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cpu_choice       = 0;
        bool game_ended      = false;

        // Diese Variablen bestimmen ob ein Feld von Spieler oder CPU bereits gewählt wurde !
        bool FA1 = false;
        bool FA2 = false;
        bool FA3 = false;
        bool FB1 = false;
        bool FB2 = false;
        bool FB3 = false;
        bool FC1 = false;
        bool FC2 = false;
        bool FC3 = false;

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

        private async void BA1_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended == true)
            {
                return;
            }
            
            FA1 = true;

            var rd_number_generated = new Random();

            player_choosed1 = true;

            BA1.Visibility = Visibility.Hidden;
            BXA1.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;
            
            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;

            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;

            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                    FA1 = true;
                    cpu_choosed1 = true;
                    BA1.Visibility = Visibility.Hidden;
                    BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                    FA2 = true;
                    cpu_choosed2 = true;
                    BA2.Visibility = Visibility.Hidden;
                    BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                    FA3 = true;
                    cpu_choosed3 = true;
                    BA3.Visibility = Visibility.Hidden;
                    BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                    FB1 = true;
                    cpu_choosed4 = true;
                    BB1.Visibility = Visibility.Hidden;
                    BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                    FB2 = true;
                    cpu_choosed5 = true;
                    BB2.Visibility = Visibility.Hidden;
                    BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                    FB3 = true;
                    cpu_choosed6 = true;
                    BB3.Visibility = Visibility.Hidden;
                    BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                    FC1 = true;
                    cpu_choosed7 = true;
                    BC1.Visibility = Visibility.Hidden;
                    BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                    FC2 = true;
                    cpu_choosed8 = true;
                    BC2.Visibility = Visibility.Hidden;
                    BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                    FC3 = true;
                    cpu_choosed9 = true;
                    BC3.Visibility = Visibility.Hidden;
                    BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BA2_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FA2 = true;

            var rd_number_generated = new Random();

            player_choosed2 = true;

            BA2.Visibility  = Visibility.Hidden;
            BXA2.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                return;

            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BA3_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FA3 = true;

            var rd_number_generated = new Random();

            player_choosed3 = true;

            BA3.Visibility  = Visibility.Hidden;
            BXA3.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BB1_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FB1 = true;

            var rd_number_generated = new Random();

            player_choosed4 = true;

            BB1.Visibility  = Visibility.Hidden;
            BXB1.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BB2_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FB2 = true;

            var rd_number_generated = new Random();

            player_choosed5 = true;

            BB2.Visibility  = Visibility.Hidden;
            BXB2.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BB3_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FB3 = true;

            var rd_number_generated = new Random();

            player_choosed6 = true;

            BB3.Visibility  = Visibility.Hidden;
            BXB3.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }


            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BC1_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FC1 = true;

            var rd_number_generated = new Random();

            player_choosed7 = true;

            BC1.Visibility  = Visibility.Hidden;
            BXC1.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }


            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BC2_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FC2 = true;

            var rd_number_generated = new Random();

            player_choosed8 = true;

            BC2.Visibility  = Visibility.Hidden;
            BXC2.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }


            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }

            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            INFO.Visibility = Visibility.Hidden;

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private async void BC3_Click(object sender, RoutedEventArgs e)
        {
            if (INFO.Content.ToString() != "CPU DENKT ... BITTE WARTEN !")
            {
                return;
            }

            FC3 = true;

            var rd_number_generated = new Random();

            player_choosed9 = true;

            BC3.Visibility  = Visibility.Hidden;
            BXC3.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            await Task.Delay(3000);

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                goto J2;
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                goto J2;
            }


            if (cpu_choice == 1 && player_choosed1 != true)
            {
                if (cpu_choosed1 == true)
                {
                    if (!player_choosed2 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed3 || !player_choosed4 && !player_choosed7 || !player_choosed5 && !player_choosed9)
                    {
                        FA1 = true;
                        cpu_choosed1 = true;
                        BA1.Visibility = Visibility.Hidden;
                        BOA1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 2 && player_choosed2 != true)
            {
                if (cpu_choosed2 == true)
                {
                    if (!player_choosed3 && !player_choosed1)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed1 && !player_choosed3 || !player_choosed5 && !player_choosed8)
                    {
                        FA2 = true;
                        cpu_choosed2 = true;
                        BA2.Visibility = Visibility.Hidden;
                        BOA2.Visibility = Visibility.Visible;
                    }
                }

            }
            else if (cpu_choice == 3 && player_choosed3 != true)
            {
                if (cpu_choosed3 == true)
                {
                    if (!player_choosed2 && !player_choosed1)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed2 && !player_choosed1 || !player_choosed5 && !player_choosed7 || !player_choosed6 && !player_choosed9)
                    {
                        FA3 = true;
                        cpu_choosed3 = true;
                        BA3.Visibility = Visibility.Hidden;
                        BOA3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 4 && player_choosed4 != true)
            {
                if (cpu_choosed4 == true)
                {
                    if (!player_choosed5 && !player_choosed6)
                    {
                        if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed5 && !player_choosed6 || !player_choosed1 && !player_choosed7)
                    {
                        FB1 = true;
                        cpu_choosed4 = true;
                        BB1.Visibility = Visibility.Hidden;
                        BOB1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 5 && player_choosed5 != true)
            {
                if (cpu_choosed5 == true)
                {
                    if (!player_choosed4 && !player_choosed6)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed6 || !player_choosed2 && !player_choosed8 || !player_choosed1 && !player_choosed9 || !player_choosed3 && !player_choosed7)
                    {
                        FB2 = true;
                        cpu_choosed5 = true;
                        BB2.Visibility = Visibility.Hidden;
                        BOB2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 6 && player_choosed6 != true)
            {
                if (cpu_choosed6 == true)
                {
                    if (!player_choosed4 && !player_choosed5)
                    {
                        if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed5 || !player_choosed3 && !player_choosed9)
                    {
                        FB3 = true;
                        cpu_choosed6 = true;
                        BB3.Visibility = Visibility.Hidden;
                        BOB3.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 7 && player_choosed7 != true)
            {
                if (cpu_choosed7 == true)
                {
                    if (!player_choosed9 && !player_choosed8)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed4 && !player_choosed1 || !player_choosed8 && !player_choosed9 || !player_choosed5 && !player_choosed3)
                    {
                        FC1 = true;
                        cpu_choosed7 = true;
                        BC1.Visibility = Visibility.Hidden;
                        BOC1.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 8 && player_choosed8 != true)
            {
                if (cpu_choosed8 == true)
                {
                    if (!player_choosed5 && !player_choosed2)
                    {
                        if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed7 && !player_choosed9 || !player_choosed2 && !player_choosed5)
                    {
                        FC2 = true;
                        cpu_choosed8 = true;
                        BC2.Visibility = Visibility.Hidden;
                        BOC2.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (cpu_choice == 9 && player_choosed9 != true)
            {
                if (cpu_choosed9 == true)
                {
                    if (!player_choosed7 && !player_choosed8)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        goto J1;
                    }
                }
                else
                {
                    if (!player_choosed8 && !player_choosed7 || !player_choosed6 && !player_choosed3 || !player_choosed5 && !player_choosed1)
                    {
                        FC3 = true;
                        cpu_choosed9 = true;
                        BC3.Visibility = Visibility.Hidden;
                        BOC3.Visibility = Visibility.Visible;
                    }
                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    exit.Visibility = Visibility.Visible;
                    return;
                }

                goto J1;
            }

            J2:

            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
            }

            INFO.Visibility = Visibility.Hidden;
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            cpu_choice = 0;
            cpu_choosed1 = false;
            cpu_choosed2 = false;
            cpu_choosed3 = false;
            cpu_choosed4 = false;
            cpu_choosed5 = false;
            cpu_choosed6 = false;
            cpu_choosed7 = false;
            cpu_choosed8 = false;
            cpu_choosed9 = false;
            player_choosed1 = false;
            player_choosed2 = false;
            player_choosed3 = false;
            player_choosed4 = false;
            player_choosed5 = false;
            player_choosed6 = false;
            player_choosed7 = false;
            player_choosed8 = false;
            player_choosed9 = false;
            FA1 = false;
            FA2 = false;
            FA3 = false;
            FB1 = false;
            FB2 = false;
            FB3 = false;
            FC1 = false;
            FC2 = false;
            FC3 = false;



            INFO.Visibility = Visibility.Hidden;
            INFO.Content = "CPU DENKT ... BITTE WARTEN !";
            BA1.Visibility = Visibility.Visible;
            BA2.Visibility = Visibility.Visible;
            BA3.Visibility = Visibility.Visible;
            BB1.Visibility = Visibility.Visible;
            BB2.Visibility = Visibility.Visible;
            BB3.Visibility = Visibility.Visible;
            BC1.Visibility = Visibility.Visible;
            BC2.Visibility = Visibility.Visible;
            BC3.Visibility = Visibility.Visible;
            BXA1.Visibility = Visibility.Hidden;
            BXA2.Visibility = Visibility.Hidden;
            BXA3.Visibility = Visibility.Hidden;
            BOA1.Visibility = Visibility.Hidden;
            BOA2.Visibility = Visibility.Hidden;
            BOA3.Visibility = Visibility.Hidden;
            BXB1.Visibility = Visibility.Hidden;
            BXB2.Visibility = Visibility.Hidden;
            BXB3.Visibility = Visibility.Hidden;
            BOB1.Visibility = Visibility.Hidden;
            BOB2.Visibility = Visibility.Hidden;
            BOB3.Visibility = Visibility.Hidden;
            BXC1.Visibility = Visibility.Hidden;
            BXC2.Visibility = Visibility.Hidden;
            BXC3.Visibility = Visibility.Hidden;
            BOC1.Visibility = Visibility.Hidden;
            BOC2.Visibility = Visibility.Hidden;
            BOC3.Visibility = Visibility.Hidden;
            restart.Visibility = Visibility.Hidden;
            exit.Visibility = Visibility.Visible;
            game_ended = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}