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
        public Map1()
        {
            InitializeComponent();
        }
        public int wins = 0;
        public int faults = 0;

        public void scores(int w, int l)
        {
            
            wins = wins + w;
            faults = faults + l;

            pont.Content = "pont: " + wins.ToString();
            hiba.Content = "hiba: " + faults.ToString();
        }
        private void Question_Click1(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;
            int button = int.Parse(UsedButton.Content as string);
            MainWindow mainwindow = Application.Current.Windows
                            .OfType<MainWindow>()
                            .FirstOrDefault();
            mainwindow.Question_Click(button);

        }
    }
}
