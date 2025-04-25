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
            int time1 = Shave.Me.scoreLs[top3index[0]].TimeMinut / 60;
            int time2 = Shave.Me.scoreLs[top3index[1]].TimeMinut / 60;
            int time3 = Shave.Me.scoreLs[top3index[2]].TimeMinut / 60;
            first.Text = time1.ToString();
            second.Text = time2.ToString();
            third.Text = time3.ToString();
            List<string> ScoreComboBox = new List<string>();
            for (int i = 0; i < Shave.Me.scoreLs.Count; i++)
            {
                ScoreComboBox.Add("map: " + Shave.Me.scoreLs[i].Mep.ToString() + " pont: " + Shave.Me.scoreLs[i].Score.ToString() + " idő:" + (Shave.Me.scoreLs[i].TimeMinut / 60).ToString());
            }
            ComboBox.ItemsSource = ScoreComboBox;
        }

        private void GoStartMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.GoStartMenu();
        }
    }
    
}
