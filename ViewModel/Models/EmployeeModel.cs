using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ViewModel
{
    public class EmployeeModel : INotifyPropertyChanged
    {
        private int id { get; set; }
        private string name { get; set; }
        private int position_ID { get; set; }
        private string positionName { get; set; }
        private double salary { get; set; }
        private int department_ID { get; set; }
        private string departmentName { get; set; }
        private string login { get; set; }
        private string password { get; set; }
        private DateTime dateOfBirth { get; set; }
        private string address { get; set; }
        private string email { get; set; }
        private string phone { get; set; }
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public int Position_ID
        {
            get { return position_ID; }
            set
            {
                position_ID = value;
                OnPropertyChanged("Position_ID");
            }
        }
        public string PositionName
        {
            get { return positionName; }
            set
            {
                positionName = value;
                OnPropertyChanged("PositionName");
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }
        public int Department_ID
        {
            get { return department_ID; }
            set
            {
                department_ID = value;
                OnPropertyChanged("Department_ID");
            }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set
            {
                departmentName = value;
                OnPropertyChanged("DepartmentName");
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
