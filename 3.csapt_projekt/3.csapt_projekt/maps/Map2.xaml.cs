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
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Resources.ResXFileRef;

namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for Map2.xaml
    /// </summary>
    public partial class Map2 : UserControl
    {
        private List<Button> ButtonList = new List<Button>();
        private List<Rectangle> BrushList = new List<Rectangle>();
        public Map2()
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
        Brush greenStroke = Brushes.Green;
        private void Question_Starter(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(e1);
            ButtonList.Add(e2);
            ButtonList.Add(e3);
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(FirstStroke);
            BrushList.Add(SecondStroke);
            BrushList.Add(ThirdStroke);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_E1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(m1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(e1Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_E2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(m21);
            ButtonList.Add(m22);
            ButtonList.Add(m23);
            ButtonList.Add(m24);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(e21Rec);
            BrushList.Add(e22Rec);
            BrushList.Add(e23Rec);
            BrushList.Add(e24Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_E3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(m31);
            ButtonList.Add(m32);
            ButtonList.Add(m33);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(e31Rec);
            BrushList.Add(e32Rec);
            BrushList.Add(e33Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(h1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(m1Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M21(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M22(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(h2);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(m22Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M23(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M24(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M31(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M32(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_M33(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(h3);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(m33Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_H1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(n1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(h1Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_H2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(n2);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(h2Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_H3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(n3);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(h3Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_N1(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_N2(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_N3(object sender, RoutedEventArgs e)
        {
            ButtonList.Clear();
            BrushList.Clear();
            ButtonList.Add(o1);
            Button UsedButton = sender as Button;
            ButtonList.Add((Button)UsedButton);
            BrushList.Add(n3Rec);
            Question(UsedButton, ButtonList, BrushList);
        }
        private void Question_O1(object sender, RoutedEventArgs e)
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
