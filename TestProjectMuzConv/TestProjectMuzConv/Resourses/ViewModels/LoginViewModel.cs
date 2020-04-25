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
        public LoginViewModel() { }

        private RelayCommand loginToYoutube;
        public RelayCommand LoginToYoutube
        {
            get
            {
                return loginToYoutube ??
                    (loginToYoutube = new RelayCommand(obj =>
                    {
                        InfoWindow youtubeWindow = new InfoWindow();
                        youtubeWindow.Show();
                    }));
            }
        }

        private RelayCommand closeLoginWindow;
        public RelayCommand CloseLoginWindow => closeLoginWindow ??
                    (closeLoginWindow = new RelayCommand(obj =>
                    {
                        Application.Current.Windows[1].Close();
                    }));

        private void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
