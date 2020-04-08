using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestProjectMuzConv.Models
{
    class Person : INotifyPropertyChanged
    {
        private string login;

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                if (login != null)
                    OnPropertyChanged("login");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
