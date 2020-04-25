using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using TestProjectMuzConv.Models;

namespace TestProjectMuzConv.Resourses.ViewModels
{
    class YoutubeDataViewModel : INotifyPropertyChanged
    {
        public string YoutubePlaylistsId { get; set; }

        private YoutubePersonInfo personInfo;

        public ObservableCollection<YoutubePersonInfo> YoutubePersonInfos { get; set; }

        public YoutubePersonInfo PersonInfo
        {
            get { return personInfo; }
            set
            {
                personInfo = value;
                OnPropertyChanged("PersonInfo");
            }
        }

        public YoutubeDataViewModel()
        {
            YoutubePersonInfos = new ObservableCollection<YoutubePersonInfo>();
            var t = Task.Run(() => GetPlaylistsID());
            t.Wait();
        }

        public async Task GetPlaylistsID()
        {
            UserCredential credential;
            using (var stream = new FileStream(ConfigurationManager.AppSettings["path"], FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = this.GetType().ToString()
            });

            var playlistListRequest = youtubeService.Playlists.List("snippet");
            playlistListRequest.Mine = true;

            var playlistListResponse = await playlistListRequest.ExecuteAsync();

            foreach (var playlist in playlistListResponse.Items)
            {
                var playlistListId = playlist.Id;

                var title = playlist.Snippet.Title;

                var channelTitle = playlist.Snippet.ChannelTitle;

                var publishedAt = playlist.Snippet.PublishedAt;

                var description = playlist.Snippet.Description;

                YoutubePersonInfo person = new YoutubePersonInfo();
                person.YoutubePlaylistsId = playlistListId;

                person.Title = title;

                person.ChannelTitle = channelTitle;

                person.PublishedAt = publishedAt.ToString();

                person.Description = description;

                YoutubePersonInfos.Insert(0, person);
                personInfo = person;
            }
        }

        private RelayCommand closeLoginWindow;
        public RelayCommand CloseLoginWindow => closeLoginWindow ??
                    (closeLoginWindow = new RelayCommand(obj =>
                    {
                        Application.Current.Windows[2].Close();
                    }));

        private void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
