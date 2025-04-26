using _3.csapt_projekt.backend;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
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

namespace _3.csapt_projekt.maps
{
    /// <summary>
    /// Interaction logic for Map1.xaml
    /// </summary>
    public partial class Map1 : UserControl
    {
        private List<Button> ButtonList = new List<Button>();
        public Map1()
        {
            InitializeComponent();
            appfunction.maxfault = 10;
            appfunction.maxpoint = 7;
        }
        

        

        private void Question(Button usedbutton, List<Button> locked)
        {
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            mainwindow.Question_Click(usedbutton, locked);
        }

        private void Question_Click1(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            ButtonList.Clear();
            ButtonList.Add(firstrow1);
            ButtonList.Add(firstrow2);
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }

        private void Question_Click2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(secondrow2);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_Click3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(secondrow1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);

            
        }
        private void Question_Click4(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(thirdrow1);
            ButtonList.Add(thirdrow2);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);

            
        }
        private void Question_Click5(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void GoStartMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.GoStartMenu();
        }
    }
}
