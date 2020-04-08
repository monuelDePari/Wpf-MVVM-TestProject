using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMuzConv.Models
{
    class YoutubePersonInfo : INotifyPropertyChanged
    {
        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set
            {
                nickName = value;
                if (nickName != null)
                    OnPropertyChanged("nickName");
            }
        }

        private string youtubePlaylistsId;

        public string YoutubePlaylistsId
        {
            get { return youtubePlaylistsId; }
            set
            {
                youtubePlaylistsId = value;
                if (youtubePlaylistsId != null)
                    OnPropertyChanged("youtubePlaylistsId");
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                if (title != null)
                    OnPropertyChanged("title");
            }
        }

        private string channelTitle;

        public string ChannelTitle
        {
            get { return channelTitle; }
            set
            {
                channelTitle = value;
                if (channelTitle != null)
                    OnPropertyChanged("channelTitle");
            }
        }

        private string publishedAt;

        public string PublishedAt
        {
            get { return publishedAt; }
            set
            {
                publishedAt = value;
                if (publishedAt != null)
                    OnPropertyChanged("publishedAt");
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                if (description != null)
                    OnPropertyChanged("defaultLanguage");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string initials = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(initials));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
