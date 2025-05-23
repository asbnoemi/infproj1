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
using System.Windows.Shapes;

namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
        public SecondWindow()
        {
            InitializeComponent();
        }

        public void GoJobs()
        {
            SecondContent.Content = new Jobs();
            CloseBttn.Visibility = Visibility.Visible;
            CloseBttn.IsEnabled = true;
        }
        public void closeBttn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        Question question = new Question();

        public void GoQuestion()
        {
            SecondContent.Content = question;
            CloseBttn.Visibility = Visibility.Hidden;
            CloseBttn.IsEnabled = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SecondContent.Content == question && question.ManualClose == true)
            {
                var result = MessageBox.Show(
                "A kilépés plussz hibával jár! \nBiztos ki akarsz lépni?",
                "Megerősítés",
                MessageBoxButton.YesNo);

                if (result != MessageBoxResult.Yes)
                {
                    
                    e.Cancel = true;
                }
                else
                {
                    mainwindow.faults++;
                    mainwindow.scores(mainwindow.wins, mainwindow.faults);
                }
            }
        }
    }
}
