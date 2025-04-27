using _3.csapt_projekt.backend;
using _3.csapt_projekt.maps;
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
using static _3.csapt_projekt.backend.QuestRead;
using static _3.csapt_projekt.backend.appfunction;
using System.Runtime.Remoting.Messaging;


namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : UserControl
    {
        qestsC kerdes;
        Random rand = new Random();
        List<string> q = new List<string>();
        List<string> shuffle = new List<string>();
        public Question()
        {
            InitializeComponent();
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            kerdes = QuestRead.MeQ.randQestGen(mainwindow.difficulty);
            question.Content = kerdes.question;
            switch (mainwindow.difficulty)
            {
                case 1:
                    difficulty.Content = "kérdés nehézsége: Könnyű";
                    break;
                case 2:
                    difficulty.Content = "kérdés nehézsége: Közepes";
                    break;
                case 3:
                    difficulty.Content = "kérdés nehézsége: Nehéz";
                    break;
            }
            q = kerdes.options;
            shuffle = q.OrderBy(x => rand.Next()).ToList();
            button1.Content = shuffle[0];
            button2.Content = shuffle[1];
            button3.Content = shuffle[2];
            button4.Content = shuffle[3];
        }
        public int winlose;

        private async void answer_Click(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            string button = UsedButton.Content as string;
            Map1 map1 = new Map1();

            bool answer;
            int w = 0, l = 0;

            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            (answer, w, l) = QuestRead.MeQ.Qestverification(button, kerdes.id, mainwindow.wins, mainwindow.faults);

            if (answer)
            {

                eredmeny.Content = "Jó válasz";
                eredmeny.Foreground = new SolidColorBrush(Colors.White);
                eredmeny.Visibility = Visibility.Visible;
                await Task.Delay(1000);
                mainwindow.ButtonEnableer();
                mainwindow.ChangeColor();
                mainwindow.scores(w, l);
                SecondWindow sec = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
                if (sec != null)
                {
                    appfunction.WinLous = appfunction.Victori(appfunction.maxpoint, appfunction.maxfault, w, l);
                    winlose = appfunction.WinLous;
                    if (winlose == 1)
                    {
                        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                        mainwindow.GameContent.Content = new Win();
                        w = 0;
                        l = 0;
                        mainwindow.wins = 0;
                        mainwindow.faults = 0;
                        winlose = 0;
                        appfunction.WinLous = 0;
                    }
                    else if (winlose == 2)
                    {
                        MainWindow gameover = Application.Current.MainWindow as MainWindow;
                        gameover.GameContent.Content = new GameOver();
                        w = 0;
                        l = 0;
                        mainwindow.wins = 0;
                        mainwindow.faults = 0;
                        winlose = 0;
                        appfunction.WinLous = 0;
                    }
                    sec.Close();
                }// MainWindow mainWindow = Application.Current.MainWindow as MainWindow; mainWindow.Play();
            }
            else
            {
                eredmeny.Content = "Rossz válasz";
                eredmeny.Foreground = new SolidColorBrush(Colors.Red);
                eredmeny.Visibility = Visibility.Visible;
                mainwindow.scores(w, l);
                await Task.Delay(1000);
                SecondWindow sec = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
                if (sec != null)
                {
                    appfunction.WinLous = appfunction.Victori(appfunction.maxpoint,appfunction.maxfault, w, l);
                    winlose = appfunction.WinLous;
                    if (winlose == 1)
                    {
                        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                        mainwindow.GameContent.Content = new Win();
                        w = 0;
                        l = 0;
                        mainwindow.wins = 0;
                        mainwindow.faults = 0;
                        winlose = 0;
                        appfunction.WinLous = 0;
                    }
                    else if (winlose == 2)
                    {
                        MainWindow gameover = Application.Current.MainWindow as MainWindow;
                        gameover.GameContent.Content = new GameOver();
                        w = 0;
                        l = 0;
                        mainwindow.wins = 0;
                        mainwindow.faults = 0;
                        winlose = 0;
                        appfunction.WinLous = 0;
                    }
                    sec.Close();
                }
            }

            
        }
    }
}
