using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace ViewModel
{
    public class DBOperations
    {
        DBModel db;
        public DBOperations()
        {
            db = new DBModel();
            db.Projects.Load();
            db.Customers.Load();
            db.Employees.Load();
            db.Notations.Load();
            db.Statuses.Load();
            db.Departments.Load();
            db.Services.Load();
            db.Statuses.Load();
            db.Positions.Load();
            db.Participations.Load();
            db.Roles.Load();
            db.Messages.Load();
        }

        public List<ProjectModel> GetAllProjects()
        {
            return db.Projects.Local.Select(i => ToProjectModel(i)).ToList();
        }
        public List<ProjectModel> GetAllMyProjects(int Id)//возвращает проекты сотрудника по ID
        {
            List<ProjectModel> P = new List<ProjectModel>();
            List<ParticipationModel> Part = GetAllParticipations();
            foreach(ParticipationModel part in Part)
            {
                if (part.Employee_ID == Id)
                    P.Add(GetProject(part.Project_ID));
            }
            return P;
        }
        public void AddProject(ProjectModel p)
        {
            db.Projects.Add(ToProject(new Project(), p));
        }
        public void UpdateProject(ProjectModel p)
        {
            Project p1 = db.Projects.Where(i => i.ID == p.ID).FirstOrDefault();
            db.Entry(ToProject(p1, p)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public ProjectModel GetProject(int Id)
        {
            return ToProjectModel(db.Projects.Find(Id));
        }
        public void DeleteProject(ProjectModel p)
        {
            db.Projects.Remove(db.Projects.Find(p.ID));
        }

        public List<RoleModel> GetAllRoles()
        {
            return db.Roles.Local.Select(i => ToRoleModel(i)).ToList();
        }
        public void AddRole(RoleModel p)
        {
            db.Roles.Add(ToRole(new Role(), p));
        }
        public void UpdateRole(RoleModel p)
        {
            Role p1 = db.Roles.Where(i => i.ID == p.ID).FirstOrDefault();
            db.Entry(ToRole(p1, p)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public RoleModel GetRole(int Id)
        {
            return ToRoleModel(db.Roles.Find(Id));
        }
        public void DeleteRole(RoleModel p)
        {
            db.Roles.Remove(db.Roles.Find(p.ID));
        }

        public List<MessageModel> GetAllMessagesFrom(int Id)
        {
            return db.Messages.Local.Select(i => ToMessageModel(i)).Where(i => i.FromUser == Id).ToList();
        }
        public List<MessageModel> GetAllMessagesTo(int Id)
        {
            return db.Messages.Local.Select(i => ToMessageModel(i)).Where(i => i.ToUser == Id).ToList();
        }
        public void AddMessage(MessageModel p)
        {
            db.Messages.Add(ToMessage(new Message(), p));
        }
        public void UpdateMessage(MessageModel p)
        {
            Message p1 = db.Messages.Where(i => i.ID == p.ID).FirstOrDefault();
            db.Entry(ToMessage(p1, p)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public MessageModel GetMessage(int Id)
        {
            return ToMessageModel(db.Messages.Find(Id));
        }
        public void DeleteMessage(MessageModel p)
        {
            db.Messages.Remove(db.Messages.Find(p.ID));
        }

        public List<NotationModel> GetAllNotations(int Id)
        {
            return db.Notations.Local.Select(i => ToNotationModel(i)).Where(i => i.Project_ID == Id).ToList();
        }
        public void AddNotation(NotationModel n)
        {
            db.Notations.Add(ToNotation(new Notation(), n));
        }
        public void UpdateNotation(NotationModel n)
        {
            Notation n1 = db.Notations.Where(i => i.ID == n.ID).FirstOrDefault();
            db.Entry(ToNotation(n1, n)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public NotationModel GetNotation(int Id)
        {
            return ToNotationModel(db.Notations.Find(Id));
        }
        public void DeleteNotation(NotationModel n)
        {
            db.Notations.Remove(db.Notations.Find(n.ID));
        }

        public List<CustomerModel> GetAllCustomers()
        {
            return db.Customers.Local.Select(i => ToCustomerModel(i)).ToList();
        }
        public void AddCustomer(CustomerModel c)
        {
            db.Customers.Add(ToCustomer(new Customer(), c));
        }
        public void UpdateCustomer(CustomerModel c)
        {
            Customer c1 = db.Customers.Where(i => i.ID == c.ID).FirstOrDefault();
            db.Entry(ToCustomer(c1, c)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public CustomerModel GetCustomer(int Id)
        {
            return ToCustomerModel(db.Customers.Find(Id));
        }
        public CustomerModel GetCustomerByName(CustomerModel c)
        {
            return ToCustomerModel(db.Customers.Where(i => i.Name == c.Name && i.Phone == c.Phone && i.Email == c.Email).FirstOrDefault());
        }
        public void DeleteCustomer(CustomerModel c)
        {
            db.Customers.Remove(db.Customers.Find(c.ID));
        }

        public List<EmployeeModel> GetAllEmployeesInProject()
        {
            var emps = db.Employees.Local.Select(i => ToEmployeeModel(i)).ToList();
            return emps;
        }
        public List<EmployeeModel> GetAllEmployees()
        {
            return db.Employees.Local.Select(i => ToEmployeeModel(i)).ToList();
        }
        public void UpdateEmployee(EmployeeModel c)
        {
            Employee c1 = db.Employees.Where(i => i.ID == c.ID).FirstOrDefault();
            db.Entry(ToEmployee(c1, c)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public EmployeeModel GetUser(string login, string password)
        {
            Employee emp = db.Employees.Where(i => i.Login == login && i.Password == password).FirstOrDefault();
            if (emp != null)
                return ToEmployeeModel(emp);
            else return null;
        }
        public void AddEmployee(EmployeeModel e)
        {
            db.Employees.Add(ToEmployee(new Employee(), e));
        }
        public EmployeeModel GetEmployee(int Id)
        {
            return ToEmployeeModel(db.Employees.Find(Id));
        }
        public void DeleteEmployee(EmployeeModel e)
        {
            db.Employees.Remove(db.Employees.Find(e.ID));
        }

        public List<StatusModel> GetAllStatuses()
        {
            return db.Statuses.Local.Select(i => ToStatusModel(i)).ToList();
        }
        public void AddStatus(StatusModel st)
        {
            db.Statuses.Add(ToStatus(new Status(), st));
        }
        public void UpdateStatus(StatusModel c)
        {
            Status c1 = db.Statuses.Where(i => i.ID == c.ID).FirstOrDefault();
            db.Entry(ToStatus(c1, c)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public StatusModel GetStatus(int Id)
        {
            return ToStatusModel(db.Statuses.Find(Id));
        }
        public void DeleteStatus(StatusModel st)
        {
            db.Statuses.Remove(db.Statuses.Find(st.ID));
        }

        public List<ServiceModel> GetAllServices()
        {
            return db.Services.Local.Select(i => ToServiceModel(i)).ToList();
        }
        public void AddService(ServiceModel s)
        {
            db.Services.Add(ToService(new Service(), s));
        }
        public void UpdateService(ServiceModel c)
        {
            Service c1 = db.Services.Where(i => i.ID == c.ID).FirstOrDefault();
            db.Entry(ToService(c1, c)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public ServiceModel GetService(int Id)
        {
            return ToServiceModel(db.Services.Find(Id));
        }
        public void DeleteService(ServiceModel s)
        {
            db.Services.Remove(db.Services.Find(s.ID));
        }

        public List<DepartmentModel> GetAllDepartments()
        {
            return db.Departments.Local.Select(i => ToDepartmentModel(i)).ToList();
        }
        public void AddDepartment(DepartmentModel d)
        {
            db.Departments.Add(ToDepartment(new Department(), d));
        }
        public void UpdateDepartment(DepartmentModel c)
        {
            Department c1 = db.Departments.Where(i => i.ID == c.ID).FirstOrDefault();
            db.Entry(ToDepartment(c1, c)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public DepartmentModel GetDepartment(int Id)
        {
            return ToDepartmentModel(db.Departments.Find(Id));
        }
        public void DeleteDepartment(DepartmentModel d)
        {
            db.Departments.Remove(db.Departments.Find(d.ID));
        }

        public List<PositionModel> GetAllPositions()
        {
            return db.Positions.Local.Select(i => ToPositionModel(i)).ToList();
        }
        public void AddPosition(PositionModel pos)
        {
            db.Positions.Add(ToPosition(new Position(), pos));
        }
        public void UpdatePosition(PositionModel c)
        {
            Position c1 = db.Positions.Where(i => i.ID == c.ID).FirstOrDefault();
            db.Entry(ToPosition(c1, c)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public PositionModel GetPosition(int Id)
        {
            return ToPositionModel(db.Positions.Find(Id));
        }
        public void DeletePosition(PositionModel pos)
        {
            db.Positions.Remove(db.Positions.Find(pos.ID));
        }

        public List<ParticipationModel> GetAllParticipations()
        {
            return db.Participations.Local.Select(i => ToParticipationModel(i)).ToList();
        }
        public List<ParticipationModel> GetAllParticipationsForUser(int Id)//показывает участия пользователя
        {
            return db.Participations.Local.Select(i => ToParticipationModel(i)).Where(k => k.Employee_ID == Id).ToList();
        }
        public List<ParticipationModel> GetAllParticipations(int Id)//список участий в проекте по ID
        {
            return db.Participations.Local.Select(i => ToParticipationModel(i)).Where(k => k.Project_ID == Id).ToList();
        }
        public void AddParticipation(ParticipationModel pt)
        {
            db.Participations.Add(ToParticipation(new Participation(), pt));
        }
        public void UpdateParticipation(ParticipationModel p)
        {
            Participation p1 = db.Participations.Where(i => i.Project_ID == p.Project_ID && i.Employee_ID == p.Employee_ID).FirstOrDefault();
            db.Entry(ToParticipation(p1, p)).State = EntityState.Modified;
            db.SaveChanges();
        }
        public ParticipationModel GetParticipation(int Id)
        {
            return ToParticipationModel(db.Participations.Find(Id));
        }
        public void DeleteParticipation(ParticipationModel pt)
        {
            db.Participations.Remove(db.Participations.Where(i => i.Employee_ID == pt.Employee_ID && i.Project_ID == pt.Project_ID).FirstOrDefault());
        }

        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public Project ToProject(Project p, ProjectModel p1)
        {
            p.ID = p1.ID;
            p.Name = p1.Name;
            p.Cost = p1.Cost;
            p.Customer_ID = p1.CustomerID;
            p.Date = p1.Date;
            p.EndDate = p1.EndDate;
            p.Status_ID = p1.StatusID;
            p.Head = p1.HeadID;
            p.web_address = p1.Web_address;
            p.Service_ID = p1.ServiceID;
            return p;
        }

        public ProjectModel ToProjectModel(Project p1)
        {
            ProjectModel p = new ProjectModel();
            p.ID = p1.ID;
            p.Name = p1.Name;
            p.Cost = p1.Cost;
            p.CustomerID = p1.Customer_ID;
            p.CustomerName = db.Customers.Where(i => i.ID == p1.Customer_ID).FirstOrDefault().Name;
            p.Date = p1.Date;
            p.EndDate = p1.EndDate;
            p.StatusID = p1.Status_ID;
            p.StatusName = db.Statuses.Where(i => i.ID == p1.Status_ID).FirstOrDefault().Name;
            p.HeadID = p1.Head;
            p.Head = (p.HeadID == null) ? "" : db.Employees.Where(i => i.ID == p1.Head).FirstOrDefault().Name;
            p.Web_address = p1.web_address;
            p.ServiceID = p1.Service_ID;
            p.ServiceName = db.Services.Where(i => i.ID == p1.Service_ID).FirstOrDefault().Name;
            return p;
        }

        public Customer ToCustomer(Customer c, CustomerModel c1)
        {
            c.ID = c1.ID;
            c.Name = c1.Name;
            c.Phone = c1.Phone;
            c.Email = c1.Email;
            return c;
        }

        public CustomerModel ToCustomerModel(Customer c1)
        {
            CustomerModel c = new CustomerModel();
            c.ID = c1.ID;
            c.Name = c1.Name;
            c.Phone = c1.Phone;
            c.Email = c1.Email;
            return c;
        }

        public Message ToMessage(Message c, MessageModel c1)
        {
            c.ID = c1.ID;
            c.MessageText = c1.MessageText;
            c.FromUser = c1.FromUser;
            c.ToUser = c1.ToUser;
            c.Date = c1.Date;
            return c;
        }

        public MessageModel ToMessageModel(Message c1)
        {
            MessageModel c = new MessageModel();
            c.ID = c1.ID;
            c.MessageText = c1.MessageText;
            c.FromUser = c1.FromUser;
            c.FromUserName = db.Employees.Where(i => i.ID == c1.FromUser).FirstOrDefault().Name;
            c.ToUser = c1.ToUser;
            c.ToUserName = db.Employees.Where(i => i.ID == c1.ToUser).FirstOrDefault().Name;
            c.Date = c1.Date;
            return c;
        }

        public Notation ToNotation(Notation n, NotationModel n1)
        {
            n.ID = n1.ID;
            n.Note = n1.Note;
            n.Project_ID = n1.Project_ID;
            n.Author = n1.Author;
            n.Date = n1.Date;
            return n;
        }

        public NotationModel ToNotationModel(Notation n1)
        {
            NotationModel n = new NotationModel();
            n.ID = n1.ID;
            n.Note = n1.Note;
            n.Author = n1.Author;
            n.AuthorName = db.Employees.Where(i => i.ID == n1.Author).FirstOrDefault().Name;
            n.Project_ID = n1.Project_ID;
            n.Date = n1.Date;
            return n;
        }

        public Employee ToEmployee(Employee e, EmployeeModel e1)
        {
            e.ID = e1.ID;
            e.Name = e1.Name;
            e.Phone = e1.Phone;
            e.Position_ID = e1.Position_ID;
            e.Address = e1.Address;
            e.Email = e1.Email;
            e.Salary = e1.Salary;
            e.DateOfBirth = e1.DateOfBirth;
            e.Department_ID = e1.Department_ID;
            e.Login = e1.Login;
            e.Password = e1.Password;
            return e;
        }

        public EmployeeModel ToEmployeeModel(Employee e1)
        {
            EmployeeModel e = new EmployeeModel();
            e.ID = e1.ID;
            e.Name = e1.Name;
            e.Phone = e1.Phone;
            e.Position_ID = e1.Position_ID;
            e.PositionName = db.Positions.Where(i => i.ID == e1.Position_ID).FirstOrDefault().Name;
            e.Address = e1.Address;
            e.Email = e1.Email;
            e.Salary = e1.Salary;
            e.DateOfBirth = e1.DateOfBirth;
            e.Department_ID = e1.Department_ID;
            e.DepartmentName = db.Departments.Where(i => i.ID == e1.Department_ID).FirstOrDefault().Name;
            e.Login = e1.Login;
            e.Password = e1.Password;
            return e;
        }

        public Status ToStatus(Status st, StatusModel st1) { return st = new Status { ID = st1.ID, Name = st1.Name}; }

        public StatusModel ToStatusModel(Status st) { return new StatusModel { ID = st.ID, Name = st.Name }; }

        public Service ToService(Service s, ServiceModel s1) { return s = new Service { ID = s1.ID, Name = s1.Name }; }

        public ServiceModel ToServiceModel(Service s) { return new ServiceModel { ID = s.ID, Name = s.Name }; }

        public Role ToRole(Role r, RoleModel r1) { return r = new Role { ID = r1.ID, Name = r1.Name }; }

        public RoleModel ToRoleModel(Role r) { return new RoleModel { ID = r.ID, Name = r.Name }; }

        public Position ToPosition(Position p, PositionModel p1) { return p = new Position { ID = p1.ID, Name = p1.Name }; }

        public PositionModel ToPositionModel(Position p) { return new PositionModel { ID = p.ID, Name = p.Name }; }

        public Department ToDepartment(Department d, DepartmentModel d1) { return d = new Department { ID = d1.ID, Name = d1.Name }; }

        public DepartmentModel ToDepartmentModel(Department d) { return new DepartmentModel { ID = d.ID, Name = d.Name }; }

        public Participation ToParticipation(Participation pt, ParticipationModel pt1)
        {
            pt1.EmployeeName = db.Employees.Where(i => i.ID == pt1.Employee_ID).FirstOrDefault().Name;
            pt1.RoleName = db.Roles.Where(i => i.ID == pt1.Role).FirstOrDefault().Name;
            return pt = new Participation {
                Employee_ID = pt1.Employee_ID,
                Project_ID = pt1.Project_ID,
                Role = pt1.Role,
                Award = pt1.Award
            };
        }

        public ParticipationModel ToParticipationModel(Participation pt)
        {
            return new ParticipationModel {
                Employee_ID = pt.Employee_ID,
                EmployeeName = db.Employees.Where(i => i.ID == pt.Employee_ID).FirstOrDefault().Name,
                Project_ID = pt.Project_ID,
                Role = pt.Role,
                RoleName = db.Roles.Where(i => i.ID == pt.Role).FirstOrDefault().Name,
                Award = pt.Award
            };
        }

        //public List<Participants> GetProjParticipants(int Id)
        //{
        //    var res = from pe in db.Participations
        //              join e in db.Employees on pe.Employee_ID equals e.ID
        //              join r in db.Roles on pe.Role equals r.ID
        //              where Id == pe.Project_ID
        //              select new Participants
        //              {
        //                  EmpID = e.ID,
        //                  Name = e.Name,
        //                  Role = r.Name
        //              };
        //    return res.ToList();
        //}


    }
}
