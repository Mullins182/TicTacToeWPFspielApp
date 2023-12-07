using System.Runtime.ConstrainedExecution;
using System.Text;
using System;
using System.IO;
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
using TicTacToeWPFspiel.Properties;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;

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

            OptionsFrame.NavigationService.Navigate(new Game());
        }
    }
}