using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel;

namespace WebStudio_coursework
{
    public class MainWindowViewModel
    {
        DBOperations db;
        public CurrentUser user { get; set; }
        public Data d1 { get; set; }
        //ПРОЕКТЫ
        public RelayCommand view_pr { get; set; }
        public RelayCommand add_pr { get; set; }//добавить проект
        public RelayCommand edit_pr { get; set; }//изменить проект
        public RelayCommand del_pr { get; set; }//удалить проект
        //МОИ ПРОЕКТЫ
        public RelayCommand edit_mypr { get; set; }//просмотр моего проекта
        //СООБЩЕНИЯ
        public RelayCommand add_mes { get; set; }
        public RelayCommand del_mes { get; set; }
        public RelayCommand refresh_mes { get; set; }
        //ЗАКАЗЧИКИ
        public RelayCommand add_cus { get; set; }//добавить заказчика
        public RelayCommand edit_cus { get; set; }//изменить заказчика
        public RelayCommand del_cus { get; set; }//удалить заказчика
        //СОТРУДНИКИ
        public RelayCommand add_emp { get; set; }//добавить сотрудника
        public RelayCommand edit_emp { get; set; }//изменить сотрудника
        public RelayCommand del_emp { get; set; }//удалить сотрудника
        //ОТДЕЛЫ
        public RelayCommand add_dep { get; set; }//добавить отдел
        public RelayCommand edit_dep { get; set; }//изменить отдел
        public RelayCommand del_dep { get; set; }//удалить отдел
        //РОЛИ
        public RelayCommand add_rol { get; set; }//добавить роль
        public RelayCommand edit_rol { get; set; }//изменить роль
        public RelayCommand del_rol { get; set; }//удалить роль
        //УСЛУГИ
        public RelayCommand add_ser { get; set; }//добавить услугу
        public RelayCommand edit_ser { get; set; }//изменить услугу
        public RelayCommand del_ser { get; set; }//удалить услугу
        //СТАТУСЫ
        public RelayCommand add_st { get; set; }//добавить статус
        public RelayCommand edit_st { get; set; }//изменить статус
        public RelayCommand del_st { get; set; }//удалить статус
        //ВЫБРАННЫЕ ЭЛЕМЕНТЫ
        public CustomerModel sel_cus { get; set; }//выбранный заказчик
        public ProjectModel my_sel_pr { get; set; }//мой выбранный проект
        public ProjectModel sel_pr { get; set; }//выбранный проект
        public EmployeeModel sel_emp { get; set; }
        public DepartmentModel sel_dep { get; set; }
        public RoleModel sel_rol { get; set; }
        public ServiceModel sel_ser { get; set; }
        public StatusModel sel_st { get; set; }
        public MessageModel sel_mes { get; set; }
        public MainWindowViewModel(CurrentUser curUser)
        {
            db = new DBOperations();
            user = curUser;
            SetCommandBindings();
            d1 = new Data();
            SetData();
        }

        private void SetCommandBindings()
        {
            view_pr = new RelayCommand(ViewProject);
            add_pr = new RelayCommand(AddProject);
            edit_pr = new RelayCommand(EditProject);
            del_pr = new RelayCommand(DeleteProject);
            edit_mypr = new RelayCommand(ShowMyProject);
            add_mes = new RelayCommand(AddMessage);
            del_mes = new RelayCommand(DeleteMessage);
            refresh_mes = new RelayCommand(RefreshMessages);
            add_cus = new RelayCommand(AddCustomer);
            edit_cus = new RelayCommand(EditCustomer);
            del_cus = new RelayCommand(DeleteCustomer);
            add_emp = new RelayCommand(AddEmployee);
            edit_emp = new RelayCommand(EditEmployee);
            del_emp = new RelayCommand(DeleteEmployee);
            add_dep = new RelayCommand(AddDepartment);
            edit_dep = new RelayCommand(EditDepartment);
            del_dep = new RelayCommand(DeleteDepartment);
            add_rol = new RelayCommand(AddRole);
            edit_rol = new RelayCommand(EditRole);
            del_rol = new RelayCommand(DeleteRole);
            add_ser = new RelayCommand(AddService);
            edit_ser = new RelayCommand(EditService);
            del_ser = new RelayCommand(DeleteService);
            add_st = new RelayCommand(AddStatus);
            edit_st = new RelayCommand(EditStatus);
            del_st = new RelayCommand(DeleteStatus);
        }

        private void SetData()
        {
            d1.Customers = db.GetAllCustomers();
            d1.Mainprojects = db.GetAllProjects();
            d1.Myprojects = db.GetAllMyProjects(user.User.ID);
            d1.Employees = db.GetAllEmployeesInProject();//////////
            d1.Departments = db.GetAllDepartments();
            d1.Positions = db.GetAllPositions();
            d1.Roles = db.GetAllRoles();
            d1.Services = db.GetAllServices();
            d1.Statuses = db.GetAllStatuses();
            d1.MessagesFrom = db.GetAllMessagesFrom(user.User.ID);
            d1.MessagesTo = db.GetAllMessagesTo(user.User.ID);
        }

        private void AddProject(object sender)
        {
            sel_pr = new ProjectModel();
            sel_cus = new CustomerModel();
            ProjectWindowAdd newwin = new ProjectWindowAdd(sel_pr, sel_cus);

            CustomerModel newcs = new CustomerModel();

            if (newwin.ShowDialog() == true)
            {
                if (sel_pr.CustomerID == 0)//новый заказчик
                {
                    db.AddCustomer(sel_cus);
                    db.Save();
                }
                sel_pr.CustomerID = db.GetCustomerByName(sel_cus).ID;
                sel_pr.StatusID = 5;//статус "Поступил"
                db.AddProject(sel_pr);
                db.Save();
                d1.Mainprojects = db.GetAllProjects();
                d1.Customers = db.GetAllCustomers();
            }
        }

        public void EditProject(object sender)
        {
            if (sel_pr != null)
            {
                ProjectWindowUpd upwin = new ProjectWindowUpd(sel_pr, user, 0);

                if (upwin.ShowDialog() == true)
                {
                    db.UpdateProject(sel_pr);
                    db.Save();
                    d1.Mainprojects = db.GetAllProjects();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите проект!");
            }
        }

        public void ViewProject(object sender)
        {
            if (sel_pr != null)
            {
                ProjectWindowUpd upwin = new ProjectWindowUpd(sel_pr, user, 1);

                if (upwin.ShowDialog() == true)
                {
                    db.UpdateProject(sel_pr);
                    db.Save();
                    d1.Mainprojects = db.GetAllProjects();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите проект!");
            }
        }

        private void DeleteProject(object sender)
        {
            if (sel_pr != null)
            {
                db.DeleteProject(sel_pr);
                db.Save();
                d1.Mainprojects = db.GetAllProjects();
            }
            else { MessageBox.Show("Пожалуйста, выберите проект!"); }
        }

        public void ShowMyProject(object sender)
        {
            if (my_sel_pr != null)
            {
                ProjectWindowUpd upwin = new ProjectWindowUpd(my_sel_pr, user, 0);

                if (upwin.ShowDialog() == true)
                {
                    db.UpdateProject(my_sel_pr);
                    db.Save();
                    d1.Myprojects = db.GetAllMyProjects(user.User.ID);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите проект!");
            }
        }

        private void AddMessage(object sender)
        {
            sel_mes = new MessageModel();
            MessageWindow cw = new MessageWindow(sel_mes, user);

            if (cw.ShowDialog() == true)
            {
                db.AddMessage(sel_mes);
                db.Save();
                d1.MessagesFrom = db.GetAllMessagesFrom(user.User.ID);
            }
        }

        private void DeleteMessage(object sender)
        {
            if (sel_mes != null)
            {
                db.DeleteMessage(sel_mes);
                db.Save();
                d1.MessagesFrom = db.GetAllMessagesFrom(user.User.ID);
                d1.MessagesTo = db.GetAllMessagesTo(user.User.ID);
            }
            else { MessageBox.Show("Сообщение не выбрано"); }
        }

        private void RefreshMessages(object senser)
        {
            d1.MessagesTo = db.GetAllMessagesTo(user.User.ID);
        }

        private void AddCustomer(object sender)
        {
            sel_cus = new CustomerModel();
            CustomerWindow cw = new CustomerWindow(sel_cus);

            if (cw.ShowDialog() == true)
            {
                db.AddCustomer(sel_cus);
                db.Save();
                d1.Customers = db.GetAllCustomers();
            }
        }

        private void EditCustomer(object sender)
        {
            if (sel_cus != null)
            {
                CustomerWindow cw = new CustomerWindow(sel_cus);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateCustomer(sel_cus);
                    db.Save();
                    d1.Mainprojects = db.GetAllProjects();
                }
            }
            else { MessageBox.Show("Пожалуйста, выберите заказчика!"); }
        }

        private void DeleteCustomer(object sender)
        {
            if (sel_cus != null)
            {
                db.DeleteCustomer(sel_cus);
                db.Save();
                d1.Customers = db.GetAllCustomers();
            }
            else { MessageBox.Show("Пожалуйста, выберите заказчика!"); }
        }

        private void AddEmployee(object sender)
        {
            sel_emp = new EmployeeModel();
            EmployeeWindow cw = new EmployeeWindow(sel_emp);

            if (cw.ShowDialog() == true)
            {
                db.AddEmployee(sel_emp);
                db.Save();
                SetData();
            }
        }

        private void EditEmployee(object sender)
        {
            if (sel_emp != null)
            {
                EmployeeWindow cw = new EmployeeWindow(sel_emp);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateEmployee(sel_emp);
                    db.Save();
                    SetData();
                }
            }
            else { MessageBox.Show("Пожалуйста, выберите сотрудника!"); }
        }

        private void DeleteEmployee(object sender)
        {
            if (sel_emp != null)
            {
                db.DeleteEmployee(sel_emp);
                db.Save();
                SetData();
            }
            else { MessageBox.Show("Пожалуйста, выберите сотрудника!"); }
        }

        private void AddDepartment(object sender)
        {
            sel_dep = new DepartmentModel();
            DepartmentWindow cw = new DepartmentWindow(sel_dep);

            if (cw.ShowDialog() == true)
            {
                db.AddDepartment(sel_dep);
                db.Save();
                SetData();
            }
        }

        private void EditDepartment(object sender)
        {
            if (sel_dep != null)
            {
                DepartmentWindow cw = new DepartmentWindow(sel_dep);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateDepartment(sel_dep);
                    db.Save();
                    SetData();
                }
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void DeleteDepartment(object sender)
        {
            if (sel_dep != null)
            {
                db.DeleteDepartment(sel_dep);
                db.Save();
                SetData();
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void AddRole(object sender)
        {
            sel_rol = new RoleModel();
            RoleWindow cw = new RoleWindow(sel_rol);

            if (cw.ShowDialog() == true)
            {
                db.AddRole(sel_rol);
                db.Save();
                SetData();
            }
        }

        private void EditRole(object sender)
        {
            if (sel_rol != null)
            {
                RoleWindow cw = new RoleWindow(sel_rol);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateRole(sel_rol);
                    db.Save();
                    SetData();
                }
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void DeleteRole(object sender)
        {
            if (sel_rol != null)
            {
                db.DeleteRole(sel_rol);
                db.Save();
                SetData();
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void AddService(object sender)
        {
            sel_ser = new ServiceModel();
            ServiceWindow cw = new ServiceWindow(sel_ser);

            if (cw.ShowDialog() == true)
            {
                db.AddService(sel_ser);
                db.Save();
                SetData();
            }
        }

        private void EditService(object sender)
        {
            if (sel_ser != null)
            {
                ServiceWindow cw = new ServiceWindow(sel_ser);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateService(sel_ser);
                    db.Save();
                    SetData();
                }
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void DeleteService(object sender)
        {
            if (sel_ser != null)
            {
                db.DeleteService(sel_ser);
                db.Save();
                SetData();
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void AddStatus(object sender)
        {
            sel_st = new StatusModel();
            StatusWindow cw = new StatusWindow(sel_st);

            if (cw.ShowDialog() == true)
            {
                db.AddStatus(sel_st);
                db.Save();
                SetData();
            }
        }

        private void EditStatus(object sender)
        {
            if (sel_st != null)
            {
                StatusWindow cw = new StatusWindow(sel_st);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateStatus(sel_st);
                    db.Save();
                    SetData();
                }
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void DeleteStatus(object sender)
        {
            if (sel_st != null)
            {
                db.DeleteStatus(sel_st);
                db.Save();
                SetData();
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }
    }
}
