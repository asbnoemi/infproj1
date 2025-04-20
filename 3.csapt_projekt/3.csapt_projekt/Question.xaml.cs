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


namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : UserControl
    {
        qestsC kerdes;


        public Question()
        {
            InitializeComponent();
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            kerdes = QuestRead.MeQ.randQestGen(mainwindow.difficulty);
            question.Content = kerdes.question;

            button1.Content = kerdes.options[0];
            button2.Content = kerdes.options[1];
            button3.Content = kerdes.options[2];
            button4.Content = kerdes.options[3];
        }
        
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
                mainwindow.scores(w, l);
                SecondWindow sec = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
                if (sec != null)
                {
                    sec.Close();
                }
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
                    sec.Close();
                }
            }
            

        }
    }
}
