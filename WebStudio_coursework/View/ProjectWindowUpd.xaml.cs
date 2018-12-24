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
    /// Логика взаимодействия для UpdateWindow.xaml
    /// </summary>
    public partial class ProjectWindowUpd : Window
    {
        ProjectWindowUpdViewModel preditw;
        public ProjectWindowUpd(ProjectModel p, CurrentUser user, int k)
        {
            InitializeComponent();
            preditw = new ProjectWindowUpdViewModel(p, user);
            DataContext = preditw;
            if (k == 0)
                SetControlsForUser(p, user);
            else SetControlsForView();
        }

        private void SetControlsForUser(ProjectModel p, CurrentUser user)
        {
            if (user.User.Position_ID != 4)// не администратор
            if (user.User.ID != p.HeadID)
            {
                tb_updpr_name.IsHitTestVisible = false;
                tb_updpr_webaddress.IsHitTestVisible = false;
                tb_updpr_cost.IsHitTestVisible = false;
                cb_updpr_status.IsHitTestVisible = false;
                cb_updpr_service.IsHitTestVisible = false;
                cb_updpr_customer.IsHitTestVisible = false;
                cb_updpr_head.IsHitTestVisible = false;
                dt_updpr_startdate.IsHitTestVisible = false;
                dt_updpr_enddate.IsHitTestVisible = false;
                dgv.IsHitTestVisible = false;
                ParticipationsManagement.IsEnabled = false;
                ParticipationsManagement.Visibility = Visibility.Hidden;
            }
            else cb_updpr_head.IsHitTestVisible = false;
        }

        private void SetControlsForView()
        {
            tb_updpr_name.IsHitTestVisible = false;
            tb_updpr_webaddress.IsHitTestVisible = false;
            tb_updpr_cost.IsHitTestVisible = false;
            cb_updpr_status.IsHitTestVisible = false;
            cb_updpr_service.IsHitTestVisible = false;
            cb_updpr_customer.IsHitTestVisible = false;
            cb_updpr_head.IsHitTestVisible = false;
            dt_updpr_startdate.IsHitTestVisible = false;
            dt_updpr_enddate.IsHitTestVisible = false;
            dgv.IsHitTestVisible = false;
            ParticipationsManagement.IsEnabled = false;
            ParticipationsManagement.Visibility = Visibility.Hidden;
            cb_updpr_head.IsHitTestVisible = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
