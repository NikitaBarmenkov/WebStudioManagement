using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class ProjectWindowAddViewModel
    {
        DBOperations db;
        public Data d1 { get; set; }
        public ProjectModel Pr { get; set; }
        public CustomerModel Cs { get; set; }
        public ProjectWindowAddViewModel(ProjectModel p, CustomerModel c)
        {
            db = new DBOperations();
            d1 = new Data();
            Pr = p;
            Cs = c;
            Pr.Cost = 0;
            Pr.ServiceID = 4;
            d1.Statuses = db.GetAllStatuses();
            d1.Services = db.GetAllServices();
            d1.Employees = db.GetAllEmployees();
            d1.Customers = db.GetAllCustomers();
            Pr.Date = DateTime.Now;
        }

        private void CheckCustomer()
        {
            foreach (CustomerModel c in d1.Customers)
            {
                if (c.Name == Cs.Name && c.Phone == Cs.Phone && c.Email == Cs.Email)
                {
                    Pr.CustomerID = c.ID;
                    break;
                }
                else Pr.CustomerID = 0;
            }
        }
    }
}
