﻿using System;
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
    /// Interaction logic for StartMenuDark.xaml
    /// </summary>
    public partial class StartMenuDark : UserControl
    {
        public StartMenuDark()
        {
            InitializeComponent();
        }

        

        private void GoScores_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.GoScores();
        }
    }
}
