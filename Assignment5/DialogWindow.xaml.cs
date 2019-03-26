using Assignment5.Model;
using System;
using System.ComponentModel;
using System.Windows;
using static Assignment5.Model.Multimedia;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly MainWindow _mainWindow;

        public DialogWindow()
        {
            InitializeComponent();
            Owner = App.Current.MainWindow;

            TypeComboBox.ItemsSource = Enum.GetValues(typeof(MediaType));

        }


        private MediaType _selectedMediaType;
        public MediaType SelectedMediaType
        {
            get => _selectedMediaType;
            set
            {
                _selectedMediaType = value;
                OnPropertyRaised("SelectedMediaType");
            }
        }

        private void SaveMultimedia_Click(object sender, RoutedEventArgs e)
        {
            Multimedia multimedia = new Multimedia(TitleTextBox.Text, 
                                                    ArtistTextBox.Text, 
                                                    GenreTextBox.Text,
                                                    SelectedMediaType);

            MultimediaElements.MultimediaList.Add(multimedia);
            this.Close();
        }


        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}