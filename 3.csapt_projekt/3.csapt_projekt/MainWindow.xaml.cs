﻿using _3.csapt_projekt.backend;
using _3.csapt_projekt.maps;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
using static _3.csapt_projekt.backend.Shave;
using static _3.csapt_projekt.Question;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.Eventing.Reader;

namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int difficulty = 1;
        public List<Button> enabled = new List<Button>();
        public List<Rectangle> brushes = new List<Rectangle>();
        public List<Button> CopButtons = new List<Button>();
        public int time = 0;
        Stopwatch stopwatch = new Stopwatch();
        public void ButtonEnableer()
        {
            foreach (Button button in enabled)
            {
                if (button.IsEnabled == false)
                {
                    button.IsEnabled = true;
                }
                else
                {
                    button.IsEnabled = false;
                }
                
            }
        }
        public void ChangeColor()
        {
            foreach(Rectangle rec in brushes)
            {
                Brush greenStroke = Brushes.Green;
                rec.Stroke= greenStroke;
                rec.Fill = greenStroke;
            }
        }
        public int maps = 1;
        public void mapchange(int job)
        {
            maps = job;
        }
        public int winlose;
        public void Question_Click(Button Button, List<Button> locked, List<Rectangle> changeColor)
        {
            int diff = int.Parse(Button.Content as string);
            SecondWindow second = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
            if (second != null)
            {
                difficulty = diff;
                enabled = locked;
                brushes = changeColor;
                second.GoQuestion();
            }
            else
            {
                difficulty = diff;
                enabled = locked;
                brushes = changeColor;
                second = new SecondWindow();
                second.GoQuestion();
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.OpenSecondWindow();
            }
            winlose =appfunction.WinLous;
            if (winlose == 1)
            {
                MainContent.Content = new Win();
                save();
            }
            else if(winlose == 2)
            {
                MainContent.Content = new GameOver();
            }
            
            winlose = appfunction.WinLous;
            
        }
        List<UserControl> jobs = new List<UserControl>();
        private Map1 map1;
        private Map2 map2;
        private Map3 map3;

        
        
        public MainWindow()
        {
            InitializeComponent();
            //MainContent.Content = new StartMenu(); // Alapértelmezett nézet
            QuestRead.MeQ.load();
            MainContent.Content = new StartMenuDark();
        }

        public void GoStartMenu()
        {
            //MainContent.Content = new StartMenu();
            MainContent.Content = new StartMenuDark();
        }
        
        public void Play()
        {
            switch (maps)
            {
                case 1:
                    map1 = new Map1();
                    MainContent.Content = null;
                    GameContent.Content = map1;
                    stopwatch.Start();
                    appfunction.maxfault = 5;
                    appfunction.maxpoint = 7;
                    ScoreReset();
                    MaxHiba();
                    break;
                case 2:
                    map2 = new Map2();
                    MainContent.Content = null;
                    GameContent.Content = map2;
                    stopwatch.Start();
                    appfunction.maxfault = 7;
                    appfunction.maxpoint = 19;
                    ScoreReset();
                    MaxHiba();
                    break;
                case 3:
                    map3 = new Map3();
                    MainContent.Content = null;
                    GameContent.Content = map3;
                    stopwatch.Start();
                    appfunction.maxpoint = 20;
                    appfunction.maxfault = 40;
                    ScoreReset();
                    MaxHiba();
                    break;
            }
        }

        public void save()
        {
            stopwatch.Stop();
            Shave.Me.scoreLs.Add(new ScoreC
            {
                TimeMinut = stopwatch.Elapsed.Seconds,
                Mep = maps,
                Score = wins
            });
            Shave.Me.ShaveFile();
        }

        public void GoScores()
        {
            MainContent.Content = new Scores();
        }
        public void OpenSecondWindow()
        {
            SecondWindow second = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
            if (second == null)
            {
                second = new SecondWindow();
            }
            second.Show();
        }
        public int wins = 0;
        public int faults = 0;
        public void scores(int w, int l)
        {

            wins = w;
            faults = l;

            pont.Content = "pont: " + w.ToString();
            hiba.Content = "hiba: " + l.ToString();
            appfunction.WinLous = appfunction.Victori(appfunction.maxpoint, appfunction.maxfault, w, l);
            winlose = appfunction.WinLous;
            if (winlose == 1)
            {
                save();
            }
        }
        public void ScoreReset()
        {
            wins = 0;
            faults = 0;
            pont.Content = "pont: 0" ;
            hiba.Content = "hiba: 0" ;
        }
        public void MaxHiba()
        {
            maxHiba.Content = "Maxhiba: " + appfunction.maxfault;
        }

        public void Cop()
        {
            if (CopButtons.Contains(enabled[0]))
            {
                appfunction.WinLous = 2;
            }
        }
    }
}