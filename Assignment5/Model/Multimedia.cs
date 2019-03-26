using System.Collections.Generic;
using System.ComponentModel;

namespace Assignment5.Model
{
    public class Multimedia : INotifyPropertyChanged
    {
        public enum MediaType{
            CD,
            DVD
        };

        private string _title;
        private string _artist;
        private string _genre;
        private MediaType _type;

        public event PropertyChangedEventHandler PropertyChanged;

        public Multimedia(string title, string artist, string genre, MediaType type)
        {
            _title = title;
            _artist = artist;
            _genre = genre;
            _type = type;
        }
        
        public string Title
        {
            get => _title;
            set {
                _title = value;
                OnPropertyRaised(nameof(Title));
            }
        }

        public string Artist
        {
            get => _artist;
            set
            {
                _artist = value;
                OnPropertyRaised(nameof(Artist));
            }
        }

        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value;
                OnPropertyRaised(nameof(_genre));
            }
        }

        public MediaType Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyRaised(nameof(Type));
            }
        }
        private Multimedia _selectedMultimedia;
        public Multimedia SelectedMultimedia
        {
            get => _selectedMultimedia;
            set
            {
                _selectedMultimedia = value;
                OnPropertyRaised("SelectedMultimedia");
            }
        }

        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public override string ToString()
        {
            return $"{Title} - {Artist}";
        }
    }
}
