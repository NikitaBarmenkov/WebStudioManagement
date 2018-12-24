using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace ViewModel
{
    public class MessageModel : INotifyPropertyChanged
    {
        private int id { get; set; }
        private string messageText { get; set; }
        private int fromUser { get; set; }
        private string fromUserName { get; set; }
        private int toUser { get; set; }
        private string toUserName { get; set; }
        private DateTime date { get; set; }
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public string MessageText
        {
            get { return messageText; }
            set
            {
                messageText = value;
                OnPropertyChanged("MessageText");
            }
        }
        public int FromUser
        {
            get { return fromUser; }
            set
            {
                fromUser = value;
                OnPropertyChanged("FromUser");
            }
        }
        public int ToUser
        {
            get { return toUser; }
            set
            {
                toUser = value;
                OnPropertyChanged("ToUser");
            }
        }
        public string FromUserName
        {
            get { return fromUserName; }
            set
            {
                fromUserName = value;
                OnPropertyChanged("FromUserName");
            }
        }
        public string ToUserName
        {
            get { return toUserName; }
            set
            {
                toUserName = value;
                OnPropertyChanged("ToUserName");
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
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
