using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace TicTacToeWPFspiel
{
    /// <summary>
    /// Interaktionslogik für Game.xaml
    /// </summary>
    public partial class Game : Page
    {

        int cpu_choice = 0;
        int NpcThinkTime = 2266;
        bool game_ended = false;
        bool leaveClickEventNow = false;
        bool waitForNpc = false;

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

        // NPC hat folgende Felder "geklickt"
        bool cpu_choosed1 = false;
        bool cpu_choosed2 = false;
        bool cpu_choosed3 = false;
        bool cpu_choosed4 = false;
        bool cpu_choosed5 = false;
        bool cpu_choosed6 = false;
        bool cpu_choosed7 = false;
        bool cpu_choosed8 = false;
        bool cpu_choosed9 = false;
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

        MainWindow MAIN;                    // Deklarieren eines Zeigers
        public Game(MainWindow main)        // Die Adresse des MainWindow übergeben, um Zugriff auf Objekte vom MainWindow zu haben !
        {
            this.MAIN = main;

            InitializeComponent();

            BackgroundVideo.Source = new Uri("SnowfallStreet2.mp4", UriKind.RelativeOrAbsolute); // Quellangabe für Mediaelement !

            if (!File.Exists("SnowfallStreet2.mp4"))  // Dialogfenster öffnet wenn die Datei nicht im Programmverzeichnis existiert !
            {

                if (MessageBox.Show("DATEI NICHT GEFUNDEN. Möchten Sie das Spiel trotzdem starten ?", "FEHLER", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {

                }
                else
                {

                }
            }
        }

        public void NpcLeaveClickEventAndCheckLooseCondition()
        {
            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                INFO.Content = "DU HAST LEIDER VERLOREN !!!";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
            }

            waitForNpc = false;
            leaveClickEventNow = true;
            //INFO.Visibility = Visibility.Hidden;
        }
        public void NpcPlayerBlocksHumanPLayer()
        {
            if (player_choosed1 && player_choosed5 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed9 && player_choosed5 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed9 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed2 && !cpu_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed3 && !cpu_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed3 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed5 && !cpu_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed6 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed6 && !cpu_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed3 && !cpu_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed7 && !cpu_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed3 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed5 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed9 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed9 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed8 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed9 && !cpu_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed8 && player_choosed9 && !cpu_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed4 && !cpu_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed7 && !cpu_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed7 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed5 && !cpu_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed8 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed8 && !cpu_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed3 && player_choosed6 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed3 && player_choosed9 && !cpu_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed6 && player_choosed9 && !cpu_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
        }

        public void NpcWinningMove()
        {
            if (cpu_choosed1 && cpu_choosed3 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                BOA3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed2 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed5 && cpu_choosed4 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed5 && cpu_choosed2 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                BOA2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed9 && cpu_choosed1 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                BOA1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                BOC1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                BOB1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                BOC2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                BOB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                BOC3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                BOB3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }

        }

        public void PlayerWinCheck()
        {
            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                INFO.Content = "DU HAST GEWONNEN !!! HERZLICHEN GLÜCKWUNSCH";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                exit.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }

        }

        public void NpcLogic()
        {
            var rd_number_generated = new Random();

        J1:

            cpu_choice = rd_number_generated.Next(1, 10);

            INFO.Visibility = Visibility.Hidden;

            NpcWinningMove();

            if (leaveClickEventNow)
            {
                return;
            }

            NpcPlayerBlocksHumanPLayer();

            if (leaveClickEventNow)
            {
                return;
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            BOA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            BOA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            BOA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            BOB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            BOB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            BOB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            BOC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            BOC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            BOC3.Visibility = Visibility.Visible;
                        }
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
                    waitForNpc = false;
                    return;
                }

                goto J1;
            }
        }

        private async void BA1_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FA1 = true;

            player_choosed1 = true;

            BA1.Visibility = Visibility.Hidden;
            BXA1.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BA2_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FA2 = true;

            var rd_number_generated = new Random();

            player_choosed2 = true;

            BA2.Visibility = Visibility.Hidden;
            BXA2.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BA3_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FA3 = true;

            var rd_number_generated = new Random();

            player_choosed3 = true;

            BA3.Visibility = Visibility.Hidden;
            BXA3.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BB1_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FB1 = true;

            var rd_number_generated = new Random();

            player_choosed4 = true;

            BB1.Visibility = Visibility.Hidden;
            BXB1.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BB2_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FB2 = true;

            var rd_number_generated = new Random();

            player_choosed5 = true;

            BB2.Visibility = Visibility.Hidden;
            BXB2.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BB3_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FB3 = true;

            var rd_number_generated = new Random();

            player_choosed6 = true;

            BB3.Visibility = Visibility.Hidden;
            BXB3.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BC1_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FC1 = true;

            var rd_number_generated = new Random();

            player_choosed7 = true;

            BC1.Visibility = Visibility.Hidden;
            BXC1.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BC2_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FC2 = true;

            var rd_number_generated = new Random();

            player_choosed8 = true;

            BC2.Visibility = Visibility.Hidden;
            BXC2.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private async void BC3_Click(object sender, RoutedEventArgs e)
        {

            if (game_ended || waitForNpc)
            {
                return;
            }

            waitForNpc = true;
            leaveClickEventNow = false;

            FC3 = true;

            var rd_number_generated = new Random();

            player_choosed9 = true;

            BC3.Visibility = Visibility.Hidden;
            BXC3.Visibility = Visibility.Visible;

            INFO.Visibility = Visibility.Visible;

            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            await Task.Delay(NpcThinkTime);

            NpcLogic();

            NpcLeaveClickEventAndCheckLooseCondition();
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
            MAIN.Close();
        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)   // Ereignishandler bei Playbackposition Video-Ende !
        {
            BackgroundVideo.Position = TimeSpan.Zero;           // Bei erreichen von Video-Ende wird die Playbackposition auf NULL zurückgesetzt und das Video beginnt von Neuem !
        }

        private void options_Click(object sender, RoutedEventArgs e)
        {

            //SpielOptionen OptionsSeite = new SpielOptionen();

            //OptionsFrame.Source = new Uri("SpielOptionen.xaml", UriKind.Relative);

            //OptionsFrame.NavigationService.Navigate(OptionsWindow(OptionsFrame));

            OptionsFrame.NavigationService.Navigate(new SpielOptionen(MAIN));       // Ersetzt den Inhalt von OptionsFrame mit einer neuen Seite vom Typ Spieloptionen.
        }
    }
}
