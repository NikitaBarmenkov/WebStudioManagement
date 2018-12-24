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
    /// Логика взаимодействия для CustomerWindowAdd.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        CustomerWindowViewModel csw;
        public CustomerWindow(CustomerModel c)
        {
            InitializeComponent();
            csw = new CustomerWindowViewModel(c);
            DataContext = csw;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
