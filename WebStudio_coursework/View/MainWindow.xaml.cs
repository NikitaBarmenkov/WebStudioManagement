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
using System.Data.Entity;
using System.Data.SqlClient;
using ViewModel;

namespace WebStudio_coursework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mw;
        public MainWindow(CurrentUser curUser)
        {
            InitializeComponent();
            mw = new MainWindowViewModel(curUser);
            DataContext = mw;
            CheckCurrentUser(curUser);
        }

        private void CheckCurrentUser(CurrentUser curUser)
        {
            if (curUser.User.Position_ID != 4)//не администратор
            {
                tab_customers.IsEnabled = false;
                tab_customers.Visibility = Visibility.Hidden;
                tab_employees.IsEnabled = false;
                tab_employees.Visibility = Visibility.Hidden;
                tab_departments.IsEnabled = false;
                tab_departments.Visibility = Visibility.Hidden;
                tab_roles.IsEnabled = false;
                tab_roles.Visibility = Visibility.Hidden;
                tab_services.IsEnabled = false;
                tab_services.Visibility = Visibility.Hidden;
                tab_statuses.IsEnabled = false;
                tab_statuses.Visibility = Visibility.Hidden;
                if (curUser.User.DepartmentName != "Прием заказов")//не из отдела приема заказов
                {
                    button_add_project.IsEnabled = false;
                    button_add_project.Visibility = Visibility.Hidden;
                }
                else
                {
                    MyProjects.IsEnabled = false;
                    MyProjects.Visibility = Visibility.Hidden;
                }
                button_edit_project.IsEnabled = false;
                button_edit_project.Visibility = Visibility.Hidden;
                button_delete_project.IsEnabled = false;
                button_delete_project.Visibility = Visibility.Hidden;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}