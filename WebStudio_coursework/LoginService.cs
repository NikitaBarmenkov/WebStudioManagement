using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class LoginService
    {
        DBOperations db;
        EmployeeModel user;
        public LoginService()
        {
            db = new DBOperations();
            user = new EmployeeModel();
        }

        public EmployeeModel Check(string l, string p)
        {
            return user = db.GetUser(l, p);
        }
    }
}
