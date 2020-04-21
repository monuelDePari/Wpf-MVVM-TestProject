using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using TestProjectMuzConv.Models;
using TestProjectMuzConv.Resourses.View;
using System.Windows;

namespace TestProjectMuzConv.Resourses.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        //public string Login { get; set; }

        //private Person selectedPerson;

        //public Person SelectedPerson
        //{
        //    get { return selectedPerson; }
        //    set
        //    {
        //        selectedPerson = value;
        //        OnPropertyChanged("SelectedPerson");
        //    }
        //}

        public LoginViewModel() { }

        private RelayCommand loginToYoutube;
        public RelayCommand LoginToYoutube
        {
            get
            {
                return loginToYoutube ??
                    (loginToYoutube = new RelayCommand(obj =>
                    {
                        //Person person = new Person();
                        //person.Login = Login;
                        //selectedPerson = person;
                        InfoWindow youtubeWindow = new InfoWindow();
                        youtubeWindow.Show();
                    }));
            }
        }

        private RelayCommand closeLoginWindow;
        public RelayCommand CloseLoginWindow => closeLoginWindow ??
                    (closeLoginWindow = new RelayCommand(obj =>
                    {
                        Application.Current.Windows[0].Close();
                    }));

        private void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
