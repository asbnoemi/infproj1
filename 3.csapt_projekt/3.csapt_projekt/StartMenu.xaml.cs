using _3.csapt_projekt.backend;
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

namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : UserControl

    {
        

        public StartMenu()
        {
            InitializeComponent();
            
        }
        
        private void Button_ClickMain(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Shave.Me.load();
            var a =new Shave.ScoreC()
            {
                Mep = 0,
                Score = 10,
                TimeMinut = 20
            };
            Shave.Me.scoreLs.Add(a);
            Shave.Me.ShaveFile();
            mainWindow.Show();
        }

        private void GoScores_Click(object sender, RoutedEventArgs e)
        {

          

        }
    }
}
