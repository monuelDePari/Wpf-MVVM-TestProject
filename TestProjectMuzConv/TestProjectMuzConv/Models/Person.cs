using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TestProjectMuzConv.Models
{
    class Person : INotifyPropertyChanged
    {
        private string login;
        private string password;
        private string key;

        [Key]
        public int Id { get; set; }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string Key 
        { 
            get { return key; } 
            set 
            {
                key = value;
                OnPropertyChanged("Key");
            } 
        }

        public void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
