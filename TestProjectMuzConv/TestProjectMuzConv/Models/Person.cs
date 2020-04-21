using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestProjectMuzConv.Models
{
    class Person : INotifyPropertyChanged
    {
        private string login;
        private string password;
        private string key;

        public int Id { get; set; }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                if (login != null)
                    OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                if (password != null)
                    OnPropertyChanged("Password");
            }
        }

        public string Key 
        { 
            get { return key; } 
            set 
            {
                key = value;
                if (key != null)
                {
                    OnPropertyChanged("Key");
                }
            } 
        }

        public void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
