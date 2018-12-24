using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;
using ViewModel;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Input;

namespace WebStudio_coursework
{
    public class LoginWindowViewModel : INotifyPropertyChanged
    {
        public RelayCommand LoginCommand { get; set; }
        private string _login;
        LoginService logs;
        CurrentUser user;

        public LoginWindowViewModel(CurrentUser user)
        {
            LoginCommand = new RelayCommand(ToLogin, i=>true);
            logs = new LoginService();
            this.user = user;
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; NotifyPropertyChanged("Login"); }
        }

        private void ToLogin (object parametr)
        {
            PasswordBox passwordBox = parametr as PasswordBox;
            user.User = logs.Check(Login, passwordBox.Password);
            if (user.User != null)
            {
                MainWindow m = new MainWindow(user);
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Данной учётной записи не существует");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
