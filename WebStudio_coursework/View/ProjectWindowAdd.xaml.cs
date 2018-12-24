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
using System.Windows.Shapes;
using ViewModel;

namespace WebStudio_coursework
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class ProjectWindowAdd : Window
    {
        ProjectWindowAddViewModel praddvm;
        public ProjectWindowAdd(ProjectModel p, CustomerModel c)
        {
            InitializeComponent();
            praddvm = new ProjectWindowAddViewModel(p, c);
            DataContext = praddvm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
