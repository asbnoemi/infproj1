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
        private List<Rectangle> BrushList = new List<Rectangle>();
        public Map3()
        {
            InitializeComponent();
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
        }
        private void Question(Button usedbutton, List<Button> locked, List<Rectangle> rec)
        {
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            mainwindow.Question_Click(usedbutton, locked, rec);
        }
        private void Question_Starter(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(e1);
            BrushList.Add(starterRec);
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_E1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(m);
            BrushList.Add(e1Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(h);
            BrushList.Add(mRec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_H(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(o);
            BrushList.Add(hRec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_O(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(ha);
            BrushList.Add(oRec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_HA(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(he1);
            ButtonList.Add(he2);
            ButtonList.Add(he3);
            BrushList.Add(ha1Rec);
            BrushList.Add(ha2Rec);
            BrushList.Add(ha3Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_He1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(ny11);
            ButtonList.Add(ny12);
            ButtonList.Add(ny13);
            BrushList.Add(he11Rec);
            BrushList.Add(he12Rec);
            BrushList.Add(he13Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_He2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_He3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(ny3);
            BrushList.Add(he3Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_Ny11(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_Ny12(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(k21);
            ButtonList.Add(k22);
            BrushList.Add(ny121Rec);
            BrushList.Add(ny122Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_Ny13(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(k31);
            ButtonList.Add(k41);
            BrushList.Add(ny131Rec);
            BrushList.Add(ny132Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_Ny2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_Ny3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(ny2);
            BrushList.Add(ny3Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_K11(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_K21(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(k11);
            BrushList.Add(k21Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_K22(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_K31(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_K41(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(t);
            BrushList.Add(k41Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_T(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void GoStartMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.ScoreReset();
            mainWindow.GoStartMenu();
        }
    }
}
