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
using static _3.csapt_projekt.backend.QuestRead;


namespace _3.csapt_projekt
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : UserControl
    {
        public Question()
        {
            InitializeComponent();
            qestsC kerdes = QuestRead.MeQ.randQestGen(1);

            question.Content = kerdes;
        }



    }
}
