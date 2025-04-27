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

namespace _3.csapt_projekt.maps
{
    /// <summary>
    /// Interaction logic for Map3.xaml
    /// </summary>
    public partial class Map3 : UserControl
    {
        private List<Button> ButtonList = new List<Button>();
        public Map3()
        {
            InitializeComponent();
            appfunction.maxpoint = 20;
            appfunction.maxfault = 5;
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            mainwindow.MaxHiba();
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
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_E1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(m);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_M(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(h);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_H(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(o);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_O(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            ButtonList.Add(ha);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_HA(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!he1.IsEnabled)
            {
                ButtonList.Add(he1);
            }
            if (!he2.IsEnabled)
            {
                ButtonList.Add(he2);
            }
            if (!he3.IsEnabled)
            {
                ButtonList.Add(he3);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_He1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!ny11.IsEnabled)
            {
                ButtonList.Add(ny11);
            }
            if (!ny12.IsEnabled)
            {
                ButtonList.Add(ny12);
            }
            if (!ny13.IsEnabled)
            {
                ButtonList.Add(ny13);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_He2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!ny2.IsEnabled)
            {
                ButtonList.Add(ny2);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_He3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!ny2.IsEnabled)
            {
                ButtonList.Add(ny2);
            }
            if (!ny3.IsEnabled)
            {
                ButtonList.Add(ny3);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_Ny11(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!k11.IsEnabled)
            {
                ButtonList.Add(k11);
            }
            
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_Ny12(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!k21.IsEnabled)
            {
                ButtonList.Add(k21);
            }
            if (!k22.IsEnabled)
            {
                ButtonList.Add(k22);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_Ny13(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!k31.IsEnabled)
            {
                ButtonList.Add(k31);
            }
            if (!k41.IsEnabled)
            {
                ButtonList.Add(k41);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_Ny2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!he3.IsEnabled)
            {
                ButtonList.Add(he3);
            }
            if (!ny3.IsEnabled)
            {
                ButtonList.Add(ny3);
            }
            if (!he2.IsEnabled)
            {
                ButtonList.Add(he2);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_Ny3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!he3.IsEnabled)
            {
                ButtonList.Add(he3);
            }
            if (!ny2.IsEnabled)
            {
                ButtonList.Add(ny2);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_K11(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!k21.IsEnabled)
            {
                ButtonList.Add(k21);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_K21(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!ny12.IsEnabled)
            {
                ButtonList.Add(ny12);
            }
            if (!k11.IsEnabled)
            {
                ButtonList.Add(k11);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_K22(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_K31(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_K41(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            if (!t.IsEnabled)
            {
                ButtonList.Add(t);
            }
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList);
        }
        private void Question_T(object sender, RoutedEventArgs e)
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
