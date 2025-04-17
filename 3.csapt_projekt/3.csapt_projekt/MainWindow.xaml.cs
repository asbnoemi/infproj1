using _3.csapt_projekt.backend;
using _3.csapt_projekt.maps;
using System;
using System.Collections.Generic;
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

namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int difficulty = 1;
        public void Question_Click(int diff)
        {
            SecondWindow second = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
            if (second != null)
            {
                difficulty = diff;
                second.GoQuestion();
            }
            else
            {
                difficulty = diff;
                second = new SecondWindow();
                second.GoQuestion();
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.OpenSecondWindow();
            }
        }

        private Map1 map1;

        public void UpdateMapLabel(int w, int l)
        {
            map1?.scores(w, l);
        }
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

        public void Play(int maps)
        {
            switch (maps)
            {
                case 1:
                    map1 = new Map1();
                    MainContent.Content = map1;
                    break;
            }
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
    }
}