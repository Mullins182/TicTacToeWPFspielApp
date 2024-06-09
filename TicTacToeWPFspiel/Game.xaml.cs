using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace TicTacToeWPFspiel
{
    public partial class Game : Page
    {
        public static event EventHandler<string>? PlayerWins;
        public static event EventHandler<string>? GameOver;
        public static event EventHandler<string>? ResetBGvideo;
        public static event EventHandler<string>? ChosenFieldSound;

        public ImageBrush playerSymbolImage     = new();
        public ImageBrush npcSymbolImage        = new();
        public static string playerSymbol       = "pack://application:,,,/Images/X.png";
        public static string npcSymbol          = "pack://application:,,,/Images/O.png";

        int cpu_choice          = 0;
        int NpcThinkTime        = 3333;
        int wait_for_snd_played = 444;
        bool game_ended         = false;
        bool leaveClickEventNow = false;
        bool waitForNpc         = false;

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

        //private static void InfoLabelAnimation(string x, Label y)
        //{
        //    ColorAnimation LabelColorEffect = new ColorAnimation();
        //    LabelColorEffect.Duration = new Duration(TimeSpan.FromSeconds(1));
        //    LabelColorEffect.From = Colors.LimeGreen;
        //    LabelColorEffect.To = Colors.OrangeRed;
        //    //ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
        //    Storyboard FarbAnimation = new Storyboard();
        //    Storyboard.SetTargetName(LabelColorEffect, x);
        //    Storyboard.SetTargetProperty(LabelColorEffect, new PropertyPath
        //    ("(Label.Foreground).(SolidColorBrush.Color)"));
        //    FarbAnimation.Children.Add(LabelColorEffect);
        //    FarbAnimation.AutoReverse = true;
        //    FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
        //    FarbAnimation.Begin(y);

        //    //ColorAnimation ButtonColorEffect = new ColorAnimation();
        //    //ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(2));
        //    //ButtonColorEffect.From = Colors.GreenYellow;
        //    //ButtonColorEffect.To = Colors.DarkRed;
        //    //Storyboard.SetTargetName(ButtonColorEffect, x);
        //    //Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
        //    //("(Button.Background).(SolidColorBrush.Color)"));
        //    ////Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
        //    ////("(Button.Foreground).(SolidColorBrush.Color)"));
        //    //Storyboard FarbAnimation = new Storyboard();
        //    ////FarbAnimation.AutoReverse = true;
        //    ////FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
        //    //FarbAnimation.Children.Add(ButtonColorEffect);
        //    //FarbAnimation.Begin(y);

        //    //ColorAnimationUsingKeyFrames ButtonColorEffect = new ColorAnimationUsingKeyFrames();
        //    //ColorAnimationUsingKeyFrames BackgroundAnimation = new ColorAnimationUsingKeyFrames();
        //    //BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
        //    //BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(100))));
        //    //ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(1));
        //    //ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(100))));
        //    ////ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
        //    //Storyboard.SetTargetName(ButtonColorEffect, x);
        //    //Storyboard.SetTargetProperty(BackgroundAnimation, new PropertyPath
        //    //("(Button.Background).(SolidColorBrush.Color)"));
        //    //Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
        //    //("(Button.Foreground).(SolidColorBrush.Color)"));
        //    //Storyboard FarbAnimation = new Storyboard();
        //    ////FarbAnimation.AutoReverse = true;
        //    ////FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
        //    //FarbAnimation.Children.Add(BackgroundAnimation);
        //    //FarbAnimation.Children.Add(ButtonColorEffect);
        //    //FarbAnimation.Begin(y);
        //}

        private async void BulbAnimation()
        {
            Bulb.Source         = new BitmapImage(new Uri("Images/Bulb1.png", UriKind.Relative));
            Bulb2.Source        = new BitmapImage(new Uri("Images/Bulb2.png", UriKind.Relative));
            Bulb.Visibility     = Visibility.Visible;
            Bulb2.Visibility    = Visibility.Visible;

            for (int i = 0; i < 12; i++)
            {
                await Task.Delay(150);
                Bulb.Source     = new BitmapImage(new Uri("Images/Bulb2.png", UriKind.Relative));
                Bulb2.Source    = new BitmapImage(new Uri("Images/Bulb1.png", UriKind.Relative));
                await Task.Delay(150);
                Bulb.Source     = new BitmapImage(new Uri("Images/Bulb1.png", UriKind.Relative));
                Bulb2.Source    = new BitmapImage(new Uri("Images/Bulb2.png", UriKind.Relative));
            }
        }
        private static void ButtonAnimation(string x, Button y)
        {

            ColorAnimationUsingKeyFrames ButtonColorEffect = new ColorAnimationUsingKeyFrames();
            ColorAnimationUsingKeyFrames BackgroundAnimation = new ColorAnimationUsingKeyFrames();
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(1));
            ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.DarkRed, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(100))));
            BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.LawnGreen, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(100))));
            //ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            Storyboard.SetTargetName(ButtonColorEffect, x);
            Storyboard.SetTargetProperty(BackgroundAnimation, new PropertyPath
            ("(Button.Background).(SolidColorBrush.Color)"));
            Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ("(Button.Foreground).(SolidColorBrush.Color)"));
            Storyboard FarbAnimation = new Storyboard();
            //FarbAnimation.AutoReverse = true;
            //FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            FarbAnimation.Children.Add(BackgroundAnimation);
            FarbAnimation.Children.Add(ButtonColorEffect);
            FarbAnimation.Begin(y);
        }

        private static void ButtonReverseAnimation(string x, Button y)
        {
            ColorAnimationUsingKeyFrames ButtonColorEffect = new ColorAnimationUsingKeyFrames();
            ColorAnimationUsingKeyFrames BackgroundAnimation = new ColorAnimationUsingKeyFrames();
            ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(1));
            ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.LawnGreen, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(200))));
            BackgroundAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            BackgroundAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.DarkRed, KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(200))));
            //ButtonColorEffect.KeyFrames.Add(new LinearColorKeyFrame(Colors.Black, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            Storyboard.SetTargetName(ButtonColorEffect, x);
            Storyboard.SetTargetProperty(BackgroundAnimation, new PropertyPath
            ("(Button.Background).(SolidColorBrush.Color)"));
            Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ("(Button.Foreground).(SolidColorBrush.Color)"));
            Storyboard FarbAnimation = new Storyboard();
            //FarbAnimation.AutoReverse = true;
            //FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            FarbAnimation.Children.Add(BackgroundAnimation);
            FarbAnimation.Children.Add(ButtonColorEffect);
            FarbAnimation.Begin(y);


            //ColorAnimation ButtonColorEffect = new ColorAnimation();
            //ButtonColorEffect.Duration = new Duration(TimeSpan.FromSeconds(2));
            //ButtonColorEffect.From = Colors.GreenYellow;
            //ButtonColorEffect.To = Colors.DarkRed;
            //Storyboard.SetTargetName(ButtonColorEffect, x);
            //Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            //("(Button.Background).(SolidColorBrush.Color)"));
            ////Storyboard.SetTargetProperty(ButtonColorEffect, new PropertyPath
            ////("(Button.Foreground).(SolidColorBrush.Color)"));
            //Storyboard FarbAnimation = new Storyboard();
            ////FarbAnimation.AutoReverse = true;
            ////FarbAnimation.RepeatBehavior = RepeatBehavior.Forever;
            //FarbAnimation.Children.Add(ButtonColorEffect);
            //FarbAnimation.Begin(y);
        }

        private void WinningConditionOrders()
        {
            PlayGrid.Opacity    = 0.49;
            restart.Opacity     = 0.45;
            //INFO.BorderBrush = new SolidColorBrush(Colors.Green);
            //INFO.BorderThickness = new Thickness(5);
            INFO.Content        = "DU HAST GEWONNEN !!!";
            INFO.Visibility     = Visibility.Visible;
            game_ended = true;
            restart.Visibility  = Visibility.Visible;
            PlayerWins?.Invoke(this, "DU HAST GEWONNEN !!!");      // Invoke ist der Trigger !

            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private void LoosingConditionOrders()
        {
            PlayGrid.Opacity    = 0.40;
            restart.Opacity     = 0.45;
            //INFO.BorderBrush = new SolidColorBrush(Colors.Green);
            //INFO.BorderThickness = new Thickness(5);
            INFO.Content        = "DU HAST LEIDER VERLOREN !!!";
            INFO.Visibility     = Visibility.Visible;
            game_ended          = true;
            restart.Visibility  = Visibility.Visible;
            GameOver?.Invoke(this, "GAME OVER");

            //leaveClickEventNow = true;
        }

        public Game()        
        {
            InitializeComponent();

            //InfoLabelAnimation(INFO.Name, INFO);

            SpielOptionen.PlayersymbolChanged   += SpielOptionen_PlayersymbolChanged;

            playerSymbolImage.ImageSource = new BitmapImage(new Uri(playerSymbol, UriKind.RelativeOrAbsolute));
            LPA1.Background = playerSymbolImage;
            LPA2.Background = playerSymbolImage;
            LPA3.Background = playerSymbolImage;
            LPB1.Background = playerSymbolImage;
            LPB2.Background = playerSymbolImage;
            LPB3.Background = playerSymbolImage;
            LPC1.Background = playerSymbolImage;
            LPC2.Background = playerSymbolImage;
            LPC3.Background = playerSymbolImage;

            npcSymbolImage.ImageSource = new BitmapImage(new Uri(npcSymbol, UriKind.RelativeOrAbsolute));
            LNA1.Background = npcSymbolImage;
            LNA2.Background = npcSymbolImage;
            LNA3.Background = npcSymbolImage;
            LNB1.Background = npcSymbolImage;
            LNB2.Background = npcSymbolImage;
            LNB3.Background = npcSymbolImage;
            LNC1.Background = npcSymbolImage;
            LNC2.Background = npcSymbolImage;
            LNC3.Background = npcSymbolImage;
        }

        private void SpielOptionen_PlayersymbolChanged(object? sender, string e)
        {
            playerSymbolImage.ImageSource   = new BitmapImage(new Uri(playerSymbol, UriKind.RelativeOrAbsolute));
            npcSymbolImage.ImageSource      = new BitmapImage(new Uri(npcSymbol, UriKind.RelativeOrAbsolute));
        }

        public void NpcLeaveClickEventAndCheckLooseCondition()
        {
            if (cpu_choosed1 && cpu_choosed2 && cpu_choosed3 == true)
            {
                LoosingConditionOrders();                
            }
            else if (cpu_choosed4 && cpu_choosed5 && cpu_choosed6 == true)
            {
                LoosingConditionOrders();
            }
            else if (cpu_choosed7 && cpu_choosed8 && cpu_choosed9 == true)
            {
                LoosingConditionOrders();
            }
            else if (cpu_choosed1 && cpu_choosed5 && cpu_choosed9 == true)
            {
                LoosingConditionOrders();
            }
            else if (cpu_choosed3 && cpu_choosed5 && cpu_choosed7 == true)
            {
                LoosingConditionOrders();
            }
            else if (cpu_choosed1 && cpu_choosed4 && cpu_choosed7 == true)
            {
                LoosingConditionOrders();
            }
            else if (cpu_choosed2 && cpu_choosed5 && cpu_choosed8 == true)
            {
                LoosingConditionOrders();
            }
            else if (cpu_choosed3 && cpu_choosed6 && cpu_choosed9 == true)
            {
                LoosingConditionOrders();
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                PlayGrid.Opacity = 0.40;
                restart.Opacity = 0.45;
                //INFO.BorderBrush = new SolidColorBrush(Colors.Green);
                //INFO.BorderThickness = new Thickness(5);
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;
                GameOver?.Invoke(this, "GAME OVER");

                leaveClickEventNow = true;
            }

            waitForNpc = false;
            leaveClickEventNow = true;
        }
        public void NpcPlayerBlocksHumanPLayer()
        {
            if (player_choosed1 && player_choosed5 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed9 && player_choosed5 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed9 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed2 && !cpu_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                LNA3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed3 && !cpu_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                LNA2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed3 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed5 && !cpu_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                LNB3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed6 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed6 && !cpu_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                LNB1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed3 && !cpu_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                LNC1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed7 && !cpu_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                LNA3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed3 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed5 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed9 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed9 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed8 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed7 && player_choosed9 && !cpu_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                LNC2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed8 && player_choosed9 && !cpu_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                LNC1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed4 && !cpu_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                LNC1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed1 && player_choosed7 && !cpu_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                LNB1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed4 && player_choosed7 && !cpu_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed5 && !cpu_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                LNC2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed2 && player_choosed8 && !cpu_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed5 && player_choosed8 && !cpu_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                LNA2.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed3 && player_choosed6 && !cpu_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed3 && player_choosed9 && !cpu_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                LNB3.Visibility = Visibility.Visible;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (player_choosed6 && player_choosed9 && !cpu_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                LNA3.Visibility = Visibility.Visible;
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
                LNA2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed1 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                LNA3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed3 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed1 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                LNA2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed4 && cpu_choosed5 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                LNB3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed5 && cpu_choosed6 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                LNB1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed4 && cpu_choosed6 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed7 && cpu_choosed8 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed8 && cpu_choosed9 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                LNC1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed7 && cpu_choosed9 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                LNC2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed4 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                LNC1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed4 && cpu_choosed7 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed7 && !player_choosed4)
            {
                FB1 = true;
                cpu_choosed4 = true;
                BB1.Visibility = Visibility.Hidden;
                LNB1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed5 && !player_choosed8)
            {
                FC2 = true;
                cpu_choosed8 = true;
                BC2.Visibility = Visibility.Hidden;
                LNC2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed5 && cpu_choosed8 && !player_choosed2)
            {
                FA2 = true;
                cpu_choosed2 = true;
                BA2.Visibility = Visibility.Hidden;
                LNA2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed2 && cpu_choosed8 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed6 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed6 && cpu_choosed9 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                LNA3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed9 && !player_choosed6)
            {
                FB3 = true;
                cpu_choosed6 = true;
                BB3.Visibility = Visibility.Hidden;
                LNB3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed5 && !player_choosed9)
            {
                FC3 = true;
                cpu_choosed9 = true;
                BC3.Visibility = Visibility.Hidden;
                LNC3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed9 && cpu_choosed5 && !player_choosed1)
            {
                FA1 = true;
                cpu_choosed1 = true;
                BA1.Visibility = Visibility.Hidden;
                LNA1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed1 && cpu_choosed9 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed7 && !player_choosed5)
            {
                FB2 = true;
                cpu_choosed5 = true;
                BB2.Visibility = Visibility.Hidden;
                LNB2.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed5 && cpu_choosed7 && !player_choosed3)
            {
                FA3 = true;
                cpu_choosed3 = true;
                BA3.Visibility = Visibility.Hidden;
                LNA3.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
            else if (cpu_choosed3 && cpu_choosed5 && !player_choosed7)
            {
                FC1 = true;
                cpu_choosed7 = true;
                BC1.Visibility = Visibility.Hidden;
                LNC1.Visibility = Visibility.Visible;
                leaveClickEventNow = true;
                NpcLeaveClickEventAndCheckLooseCondition();
            }
        }

        public void PlayerWinCheck()
        {
            if (player_choosed1 && player_choosed2 && player_choosed3)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed4 && player_choosed5 && player_choosed6)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed7 && player_choosed8 && player_choosed9)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed1 && player_choosed4 && player_choosed7)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed2 && player_choosed5 && player_choosed8)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed3 && player_choosed6 && player_choosed9)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed1 && player_choosed5 && player_choosed9)
            {
                WinningConditionOrders();
                return;
            }
            else if (player_choosed3 && player_choosed5 && player_choosed7)
            {
                WinningConditionOrders();
                return;
            }

            if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
            {
                PlayGrid.Opacity = 0.40;
                restart.Opacity = 0.45;
                //INFO.BorderBrush = new SolidColorBrush(Colors.Green);
                //INFO.BorderThickness = new Thickness(5);
                INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                INFO.Visibility = Visibility.Visible;
                game_ended = true;
                restart.Visibility = Visibility.Visible;

                GameOver?.Invoke(this, "GAME OVER");

                NpcLeaveClickEventAndCheckLooseCondition();
            }
        }

        public async void NpcLogic()
        {
            var rN = new Random();

        J1:

            cpu_choice = rN.Next(1, 10);

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
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed4 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
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
                        LNA1.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
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
                        LNA2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed6 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
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
                        LNA3.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
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
                        LNB1.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed2 && !player_choosed8)
                    {
                        if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed2 != true)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed9)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed7)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
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
                        LNB2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed9)
                    {
                        if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
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
                        LNB3.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNC3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed1 && !player_choosed4)
                    {
                        if (cpu_choosed1 != true)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed4 != true)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed5 && !player_choosed3)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
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
                        LNC1.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed5 != true)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed7 && !player_choosed9)
                    {
                        if (cpu_choosed7 != true)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed9 != true)
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                        LNC2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
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
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed8 != true)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                    }
                    else if (!player_choosed3 && !player_choosed6)
                    {
                        if (cpu_choosed3 != true)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (cpu_choosed6 != true)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
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
                        LNC3.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (!FA1)
                        {
                            FA1 = true;
                            cpu_choosed1 = true;
                            BA1.Visibility = Visibility.Hidden;
                            LNA1.Visibility = Visibility.Visible;
                        }
                        else if (!FA2)
                        {
                            FA2 = true;
                            cpu_choosed2 = true;
                            BA2.Visibility = Visibility.Hidden;
                            LNA2.Visibility = Visibility.Visible;
                        }
                        else if (!FA3)
                        {
                            FA3 = true;
                            cpu_choosed3 = true;
                            BA3.Visibility = Visibility.Hidden;
                            LNA3.Visibility = Visibility.Visible;
                        }
                        else if (!FB1)
                        {
                            FB1 = true;
                            cpu_choosed4 = true;
                            BB1.Visibility = Visibility.Hidden;
                            LNB1.Visibility = Visibility.Visible;
                        }
                        else if (!FB2)
                        {
                            FB2 = true;
                            cpu_choosed5 = true;
                            BB2.Visibility = Visibility.Hidden;
                            LNB2.Visibility = Visibility.Visible;
                        }
                        else if (!FB3)
                        {
                            FB3 = true;
                            cpu_choosed6 = true;
                            BB3.Visibility = Visibility.Hidden;
                            LNB3.Visibility = Visibility.Visible;
                        }
                        else if (!FC1)
                        {
                            FC1 = true;
                            cpu_choosed7 = true;
                            BC1.Visibility = Visibility.Hidden;
                            LNC1.Visibility = Visibility.Visible;
                        }
                        else if (!FC2)
                        {
                            FC2 = true;
                            cpu_choosed8 = true;
                            BC2.Visibility = Visibility.Hidden;
                            LNC2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            FC3 = true;
                            cpu_choosed9 = true;
                            BC3.Visibility = Visibility.Hidden;
                            LNC3.Visibility = Visibility.Visible;
                        }
                    }

                }
            }
            else
            {
                if (FA1 && FA2 && FA3 && FB1 && FB2 && FB3 && FC1 && FC2 && FC3)
                {
                    await Task.Delay(wait_for_snd_played);

                    INFO.Content = "SPIEL BEENDET...KEINER HAT GEWONNEN !";
                    INFO.Visibility = Visibility.Visible;
                    game_ended = true;
                    restart.Visibility = Visibility.Visible;
                    
                    waitForNpc = false;
                    return;
                }

                goto J1;
            }
        }

        private async void GameProgress(string playerSound, string npcSound)
        {
            waitForNpc              = true;
            leaveClickEventNow      = false;

            MainWindow.ChooseSound  = playerSound;

            ChosenFieldSound?.Invoke(this, "...");      // Invoke ist der Trigger !

            await Task.Delay(wait_for_snd_played);

            INFO.Visibility         = Visibility.Visible;


            PlayerWinCheck();

            if (leaveClickEventNow)
            {
                return;
            }

            BulbAnimation();

            await Task.Delay(NpcThinkTime);

            Bulb.Visibility         = Visibility.Hidden;
            Bulb2.Visibility        = Visibility.Hidden;

            MainWindow.ChooseSound  = npcSound;

            ChosenFieldSound?.Invoke(this, "...");      // Invoke ist der Trigger !

            NpcLogic();
            NpcLeaveClickEventAndCheckLooseCondition();
        }

        private void BA1_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FA1                 = true;
            player_choosed1     = true;
            BA1.Visibility      = Visibility.Hidden;
            LPA1.Visibility     = Visibility.Visible;

            playerSound = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BA2_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FA2                 = true;
            player_choosed2     = true;
            BA2.Visibility      = Visibility.Hidden;
            LPA2.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BA3_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FA3                 = true;
            player_choosed3     = true;
            BA3.Visibility      = Visibility.Hidden;
            LPA3.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BB1_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FB1                 = true;
            player_choosed4     = true;
            BB1.Visibility      = Visibility.Hidden;
            LPB1.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BB2_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FB2                 = true;
            player_choosed5     = true;
            BB2.Visibility      = Visibility.Hidden;
            LPB2.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BB3_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FB3                 = true;
            player_choosed6     = true;
            BB3.Visibility      = Visibility.Hidden;
            LPB3.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BC1_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FC1                 = true;
            player_choosed7     = true;
            BC1.Visibility      = Visibility.Hidden;
            LPC1.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BC2_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FC2                 = true;
            player_choosed8     = true;
            BC2.Visibility      = Visibility.Hidden;
            LPC2.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void BC3_Click(object sender, RoutedEventArgs e)
        {
            if (game_ended || waitForNpc) { return; }

            string playerSound  = "";
            string npcSound     = "";

            FC3                 = true;
            player_choosed9     = true;
            BC3.Visibility      = Visibility.Hidden;
            LPC3.Visibility     = Visibility.Visible;

            playerSound         = Game.playerSymbol == "pack://application:,,,/Images/Zuckerstangen.png" ? playerSound = @"Sounds\PencilX.wav"
                                                : Game.playerSymbol == "pack://application:,,,/Images/X.png"
                                                ? playerSound = @"Sounds\PencilX.wav" : @"Sounds\PencilO.wav";

            npcSound            = playerSound == @"Sounds\PencilX.wav" ? npcSound = @"Sounds\PencilO.wav" : npcSound = @"Sounds\PencilX.wav";

            GameProgress(playerSound, npcSound);
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            ResetBGvideo?.Invoke(this, "Reset");      // Invoke ist der Trigger !

            PlayGrid.Opacity    = 0.75;

            cpu_choice          = 0;
            cpu_choosed1        = false;
            cpu_choosed2        = false;
            cpu_choosed3        = false;
            cpu_choosed4        = false;
            cpu_choosed5        = false;
            cpu_choosed6        = false;
            cpu_choosed7        = false;
            cpu_choosed8        = false;
            cpu_choosed9        = false;
            player_choosed1     = false;
            player_choosed2     = false;
            player_choosed3     = false;
            player_choosed4     = false;
            player_choosed5     = false;
            player_choosed6     = false;
            player_choosed7     = false;
            player_choosed8     = false;
            player_choosed9     = false;
            FA1                 = false;
            FA2                 = false;
            FA3                 = false;
            FB1                 = false;
            FB2                 = false;
            FB3                 = false;
            FC1                 = false;
            FC2                 = false;
            FC3                 = false;

            INFO.Visibility     = Visibility.Hidden;
            INFO.Content        = "CPU DENKT ... BITTE WARTEN !";
            BA1.Visibility      = Visibility.Visible;
            BA2.Visibility      = Visibility.Visible;
            BA3.Visibility      = Visibility.Visible;
            BB1.Visibility      = Visibility.Visible;
            BB2.Visibility      = Visibility.Visible;
            BB3.Visibility      = Visibility.Visible;
            BC1.Visibility      = Visibility.Visible;
            BC2.Visibility      = Visibility.Visible;
            BC3.Visibility      = Visibility.Visible;
            LPA1.Visibility     = Visibility.Hidden;
            LPA2.Visibility     = Visibility.Hidden;
            LPA3.Visibility     = Visibility.Hidden;
            LNA1.Visibility     = Visibility.Hidden;
            LNA2.Visibility     = Visibility.Hidden;
            LNA3.Visibility     = Visibility.Hidden;
            LPB1.Visibility     = Visibility.Hidden;
            LPB2.Visibility     = Visibility.Hidden;
            LPB3.Visibility     = Visibility.Hidden;
            LNB1.Visibility     = Visibility.Hidden;
            LNB2.Visibility     = Visibility.Hidden;
            LNB3.Visibility     = Visibility.Hidden;
            LPC1.Visibility     = Visibility.Hidden;
            LPC2.Visibility     = Visibility.Hidden;
            LPC3.Visibility     = Visibility.Hidden;
            LNC1.Visibility     = Visibility.Hidden;
            LNC2.Visibility     = Visibility.Hidden;
            LNC3.Visibility     = Visibility.Hidden;
            restart.Visibility  = Visibility.Hidden;
            
            game_ended          = false;

        }

        private void restart_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonAnimation(restart.Name, restart);
        }

        private void restart_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ButtonReverseAnimation(restart.Name, restart);
        }
    }
}
