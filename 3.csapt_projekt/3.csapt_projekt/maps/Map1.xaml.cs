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
        private List<Rectangle> BrushList = new List<Rectangle>();
        MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
        public Map1()
        {
            InitializeComponent();
        }
        

        

        private void Question(Button usedbutton, List<Button> locked, List<Rectangle> rec)
        {
            
            mainwindow.Question_Click(usedbutton, locked, rec);
        }

        private void Question_Click1(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(firstrow1);
            ButtonList.Add(firstrow2);
            BrushList.Add(e1Rec);
            BrushList.Add(e2Rec);
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }

        private void Question_Click2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(secondrow2);
            BrushList.Add(m2Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_Click3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(secondrow1);
            BrushList.Add(m1Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);

            
        }
        private void Question_Click4(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(thirdrow1);
            ButtonList.Add(thirdrow2);
            BrushList.Add(h1Rec);
            BrushList.Add(h1Rec);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);

            
        }
        private void Question_Click5(object sender, RoutedEventArgs e)
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
