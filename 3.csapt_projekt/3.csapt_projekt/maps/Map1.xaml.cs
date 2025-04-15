using _3.csapt_projekt.backend;
using System;
using System.Collections;
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

namespace _3.csapt_projekt.maps
{
    /// <summary>
    /// Interaction logic for Map1.xaml
    /// </summary>
    public partial class Map1 : UserControl
    {
        public Map1()
        {
            InitializeComponent();
        }
        public int wins = 0;
        public int faults = 0;
        private void Question_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow second = Application.Current.Windows.OfType<SecondWindow>().FirstOrDefault();
            if (second != null)
            {
                second.GoQuestion();
            }
            else
            {
                second = new SecondWindow();
                second.GoQuestion();
                MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
                mainWindow.OpenSecondWindow();
            }
        }
    }
}
