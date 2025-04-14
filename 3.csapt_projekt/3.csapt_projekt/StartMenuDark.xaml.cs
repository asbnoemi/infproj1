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
    /// Interaction logic for StartMenuDark.xaml
    /// </summary>
    public partial class StartMenuDark : UserControl
    {
        public StartMenuDark()
        {
            InitializeComponent();
        }

        private int map = 1;
        
        public void mapchange(int job)
        {
            map = job;
        }
        private void Jobs_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow second = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
            if (second != null)
            {
                second.GoJobs();
            }
            else
            {
                second = new SecondWindow();
                second.GoJobs();
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.OpenSecondWindow();
            }
            
        }
        private void GoScores_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.GoScores();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Play(map);
        }
    }
}
