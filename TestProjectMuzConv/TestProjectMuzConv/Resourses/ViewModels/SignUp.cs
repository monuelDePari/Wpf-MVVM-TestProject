using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Windows;
using TestProjectMuzConv.Models;

namespace TestProjectMuzConv.Resourses.ViewModels
{
    class SignUp : INotifyPropertyChanged
    {
        PersonContext personContextDB;

        private Person selectedPerson;

        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        public SignUp() { }

        private RelayCommand signUpWindow;
        private RelayCommand signInWindow;
        public RelayCommand SignUpWindow => signUpWindow ??
                    (signUpWindow = new RelayCommand(obj =>
                    {
                        using (personContextDB = new PersonContext())
                        {
                            Person person = new Person();
                            person = selectedPerson;
                            personContextDB.Persons.Add(person);
                            personContextDB.SaveChanges();
                        }
                    }));

        public RelayCommand SignInWindow => signInWindow ??
            (signInWindow = new RelayCommand(obj =>
                    {
                        
                    }));

        private void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
