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

        private void Question_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.OpenSecondWindow();
        }
    }
}
