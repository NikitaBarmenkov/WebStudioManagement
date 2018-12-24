using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using ViewModel;

namespace WebStudio_coursework
{
    public class Data : INotifyPropertyChanged
    {
        private List<CustomerModel> customers { get; set; }
        private List<ProjectModel> mainprojects { get; set; }
        private List<ProjectModel> myprojects { get; set; }
        private List<MessageModel> messagesFrom { get; set; }
        private List<MessageModel> messagesTo { get; set; }
        private List<ServiceModel> services { get; set; }
        private List<DepartmentModel> departments { get; set; }
        private List<EmployeeModel> employees { get; set; }
        private List<NotationModel> notations { get; set; }
        private List<ParticipationModel> participations { get; set; }
        private List<PositionModel> positions { get; set; }
        private List<RoleModel> roles { get; set; }
        private List<StatusModel> statuses { get; set; }
        public List<CustomerModel> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                OnPropertyChanged("Customers");
            }
        }
        public List<ProjectModel> Mainprojects
        {
            get { return mainprojects; }
            set
            {
                mainprojects = value;
                OnPropertyChanged("Mainprojects");
            }
        }
        public List<ProjectModel> Myprojects
        {
            get { return myprojects; }
            set
            {
                myprojects = value;
                OnPropertyChanged("Myprojects");
            }
        }
        public List<MessageModel> MessagesFrom
        {
            get { return messagesFrom; }
            set
            {
                messagesFrom = value;
                OnPropertyChanged("MessagesFrom");
            }
        }
        public List<MessageModel> MessagesTo
        {
            get { return messagesTo; }
            set
            {
                messagesTo = value;
                OnPropertyChanged("MessagesTo");
            }
        }
        public List<ServiceModel> Services
        {
            get { return services; }
            set
            {
                services = value;
                OnPropertyChanged("Services");
            }
        }
        public List<DepartmentModel> Departments
        {
            get { return departments; }
            set
            {
                departments = value;
                OnPropertyChanged("Departments");
            }
        }
        public List<EmployeeModel> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }
        public List<NotationModel> Notations
        {
            get { return notations; }
            set
            {
                notations = value;
                OnPropertyChanged("Notations");
            }
        }
        public List<ParticipationModel> Participations
        {
            get { return participations; }
            set
            {
                participations = value;
                OnPropertyChanged("Participations");
            }
        }
        public List<PositionModel> Positions
        {
            get { return positions; }
            set
            {
                positions = value;
                OnPropertyChanged("Positions");
            }
        }
        public List<RoleModel> Roles
        {
            get { return roles; }
            set
            {
                roles = value;
                OnPropertyChanged("Roles");
            }
        }
        public List<StatusModel> Statuses
        {
            get { return statuses; }
            set
            {
                statuses = value;
                OnPropertyChanged("Statuses");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
