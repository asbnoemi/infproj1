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
            TimeSpan ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[top3index[0]].TimeMinut);
            string time1 = $"{ts.Minutes}:{ts.Seconds:D2}";
            ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[top3index[1]].TimeMinut);
            string time2 = $"{ts.Minutes}:{ts.Seconds:D2}";
            ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[top3index[2]].TimeMinut);
            string time3 = $"{ts.Minutes}:{ts.Seconds:D2}";

            firstScore.Text = (Shave.Me.scoreLs[top3index[0]].Score).ToString();
            firstScore.Text += "\nmap " + (Shave.Me.scoreLs[top3index[0]].Mep).ToString();
            secondScore.Text = (Shave.Me.scoreLs[top3index[1]].Score).ToString();
            secondScore.Text += "\nmap " + (Shave.Me.scoreLs[top3index[1]].Mep).ToString();
            thirdScore.Text = (Shave.Me.scoreLs[top3index[2]].Score).ToString();
            thirdScore.Text += "\nmap " + (Shave.Me.scoreLs[top3index[2]].Mep).ToString();
            //int sec1 = Shave.Me.scoreLs[top3index[0]].TimeMinut / 60;
            //string time1 = sec1 / 60 + ":" + sec1 % 60;
            //int sec2 = Shave.Me.scoreLs[top3index[1]].TimeMinut / 60;
            //string time2 = sec2 / 60 + ":" + sec2 % 60;
            //int sec3 = Shave.Me.scoreLs[top3index[2]].TimeMinut / 60;
            //string time3 = sec3 / 60 + ":" + sec3 % 60;
            first.Text = time1.ToString();
            second.Text = time2.ToString();
            third.Text = time3.ToString();
            List<string> ScoreComboBox = new List<string>();
            for (int i = 0; i < Shave.Me.scoreLs.Count; i++)
            {
                ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[i].TimeMinut);
                string time = $"{ts.Minutes}:{ts.Seconds:D2}";
                ScoreComboBox.Add("map: " + Shave.Me.scoreLs[i].Mep.ToString() + " pont: " + Shave.Me.scoreLs[i].Score.ToString() + " idő:" + time);
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
