using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class EmployeeWindowViewModel
    {
        public Data d { get; set; }
        DBOperations db;
        public EmployeeModel user { get; set; }
        public EmployeeWindowViewModel(EmployeeModel c)
        {
            db = new DBOperations();
            d = new Data();
            user = c;
            d.Positions = db.GetAllPositions();
            d.Departments = db.GetAllDepartments();
        }
    }
}
