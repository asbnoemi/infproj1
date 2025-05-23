﻿using _3.csapt_projekt.backend;
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
            TimeSpan ts;
            string time1 = "";
            string time2 = "";
            string time3 = "";

            if (top3index[0] != -1)
            {
                ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[top3index[0]].TimeMinut);
                time1 = $"{ts.Minutes}:{ts.Seconds:D2}";
                firstScore.Text = (Shave.Me.scoreLs[top3index[0]].Score).ToString();
                firstScore.Text += "\nmap " + (Shave.Me.scoreLs[top3index[0]].Mep).ToString();
            }
            else 
            {
                firstScore.Text = "";
            }

            if (top3index[1] != -1)
            {
                ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[top3index[1]].TimeMinut);
                time2 = $"{ts.Minutes}:{ts.Seconds:D2}";
                secondScore.Text = (Shave.Me.scoreLs[top3index[1]].Score).ToString();
                secondScore.Text += "\nmap " + (Shave.Me.scoreLs[top3index[1]].Mep).ToString();
            }
            else
            {
                firstScore.Text = "";
            }
            if (top3index[2] != -1)
            {
                ts = TimeSpan.FromSeconds(Shave.Me.scoreLs[top3index[2]].TimeMinut);
                time3 = $"{ts.Minutes}:{ts.Seconds:D2}";
                thirdScore.Text = (Shave.Me.scoreLs[top3index[2]].Score).ToString();
                thirdScore.Text += "\nmap " + (Shave.Me.scoreLs[top3index[2]].Mep).ToString();
            }
            else
            {
                firstScore.Text = "";
            }


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
