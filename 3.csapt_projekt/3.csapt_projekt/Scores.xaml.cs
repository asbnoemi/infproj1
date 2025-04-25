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
    /// Interaction logic for Scores.xaml
    /// </summary>
    public partial class Scores : UserControl
    {
        public Scores()
        {
            InitializeComponent();
            
            int[] top3index = new int[3] { 0, 0, 0 };
            top3index = Shave.Me.roppscore();
            first.Text = Shave.Me.scoreLs[top3index[0]].Score.ToString();
            second.Text = Shave.Me.scoreLs[top3index[1]].Score.ToString();
            third.Text = Shave.Me.scoreLs[top3index[2]].Score.ToString();
        }

        private void GoStartMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.GoStartMenu();
        }
    }
    
}
