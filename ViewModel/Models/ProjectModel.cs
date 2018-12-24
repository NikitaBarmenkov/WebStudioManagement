using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ViewModel
{
    public class ProjectModel : INotifyPropertyChanged
    {
        private int id { get; set; }
        private string name { get; set; }
        private int statusId { get; set; }
        private string statusName { get; set; }
        private int? cost { get; set; }
        private int customerId { get; set; }
        private string customerName { get; set; }
        private int serviceId { get; set; }
        private string serviceName { get; set; }
        private string web_address { get; set; }
        private int? headId { get; set; }
        private string head { get; set; }
        private DateTime date { get; set; }
        private DateTime? endDate { get; set; }
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
        public int StatusID
        {
            get { return statusId; }
            set
            {
                statusId = value;
                OnPropertyChanged("StatusID");
            }
        }
        public string StatusName
        {
            get { return statusName; }
            set
            {
                statusName = value;
                OnPropertyChanged("StatusName");
            }
        }
        public int? Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged("Cost");
            }
        }
        public int CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }
        public int ServiceID
        {
            get { return serviceId; }
            set
            {
                serviceId = value;
                OnPropertyChanged("ServiceID");
            }
        }
        public string ServiceName
        {
            get { return serviceName; }
            set
            {
                serviceName = value;
                OnPropertyChanged("serviceName");
            }
        }
        public string Web_address
        {
            get { return web_address; }
            set
            {
                web_address = value;
                OnPropertyChanged("Web_address");
            }
        }
        public int? HeadID
        {
            get { return headId; }
            set
            {
                headId = value;
                OnPropertyChanged("HeadID");
            }
        }
        public string Head
        {
            get { return head; }
            set
            {
                head = value;
                OnPropertyChanged("Head");
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public DateTime? EndDate
        {
            get { return endDate; }
            set
            {
                endDate = value;
                OnPropertyChanged("EndDate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
