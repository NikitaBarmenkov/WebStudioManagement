using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModel
{
    public class ParticipationModel : INotifyPropertyChanged
    {
        private int project_ID { get; set; }
        private int employee_ID { get; set; }
        private string employeeName { get; set; }
        private int role { get; set; }
        private string roleName { get; set; }
        private int award { get; set; }
        public int Project_ID
        {
            get { return project_ID; }
            set
            {
                project_ID = value;
                OnPropertyChanged("Project_ID");
            }
        }
        public int Employee_ID
        {
            get { return employee_ID; }
            set
            {
                employee_ID = value;
                OnPropertyChanged("Employee_ID");
            }
        }
        public int Award
        {
            get { return award; }
            set
            {
                award = value;
                OnPropertyChanged("Award");
            }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set
            {
                employeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }
        public int Role
        {
            get { return role; }
            set
            {
                role = value;
                OnPropertyChanged("Role");
            }
        }
        public string RoleName
        {
            get { return roleName; }
            set
            {
                roleName = value;
                OnPropertyChanged("RoleName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
