using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
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

        public SignUp() {
            SelectedPerson = new Person();
        }

        private RelayCommand signUpWindow;
        private RelayCommand signInWindow;
        public RelayCommand SignUpWindow => signUpWindow ??
                    (signUpWindow = new RelayCommand(obj =>
                    {
                        using (personContextDB = new PersonContext())
                        {
                            personContextDB.Persons.Add(selectedPerson);
                            personContextDB.SaveChanges();
                        }
                    }));

        public RelayCommand SignInWindow => signInWindow ??
            (signInWindow = new RelayCommand(obj =>
                    {
                        using (personContextDB = new PersonContext())
                        {
                            Person user = personContextDB.Persons.Where(t => t.Login == SelectedPerson.Login && t.Password == SelectedPerson.Password).FirstOrDefault();
                            if (user != null)
                            {
                                if (user.Login == SelectedPerson.Login && user.Password == SelectedPerson.Password)
                                {
                                    MainWindow window = new MainWindow();
                                    window.Show();
                                }
                            }
                        }
                    }));

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
