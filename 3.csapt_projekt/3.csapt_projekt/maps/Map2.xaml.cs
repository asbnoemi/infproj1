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
    /// Interaction logic for Map2.xaml
    /// </summary>
    public partial class Map2 : UserControl
    {
        private List<Button> ButtonList = new List<Button>();
        public Map2()
        {
            InitializeComponent();
            appfunction.maxfault = 10;
            appfunction.maxpoint = 19;
        }
        private void Question(Button usedbutton, List<Button> locked)
        {
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            mainwindow.Question_Click(usedbutton, locked);
        }
        private void Question_Starter(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            ButtonList.Clear();
            ButtonList.Add(e1);
            ButtonList.Add(e2);
            ButtonList.Add(e2);
            ButtonList.Add(e3);
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_E1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!m1.IsEnabled)
            {
                ButtonList.Add(m1);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_E2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(m21);
            ButtonList.Add(m22);
            ButtonList.Add(m23);
            ButtonList.Add(m24);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_E3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(m31);
            ButtonList.Add(m32);
            ButtonList.Add(m33);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(h1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M21(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!m1.IsEnabled)
            {
                ButtonList.Add(m1);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M22(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(h2);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M23(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M24(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M31(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M32(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M33(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(h3);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_H1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(n1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_H2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(n2);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_H3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(n3);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_N1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_N2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_N3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(o1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_O1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void GoStartMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.ScoreReset();
            mainWindow.GoStartMenu();
        }
    }
}
