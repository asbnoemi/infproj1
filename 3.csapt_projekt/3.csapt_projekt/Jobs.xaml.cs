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
    /// Interaction logic for Jobs.xaml
    /// </summary>
    public partial class Jobs : UserControl
    {
        public Jobs()
        {
            InitializeComponent();
        }
        
        private void mapchange_Click(object sender, RoutedEventArgs e)
        {
            Button UsedButton = sender as Button;

            if (UsedButton != null)
            {

                string ButtonName = UsedButton.Name;
                int job = int.Parse(ButtonName.Substring(3).ToString());
                StartMenuDark startMenuDark = new StartMenuDark();
                startMenuDark.mapchange(job);
            }
        }
    }
}
