using Assignment5_WPF.Model;
using System;
using System.ComponentModel;
using System.Windows;
using static Assignment5_WPF.Model.Multimedia;


namespace Assignment5_WPF
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DialogWindow()
        {
            InitializeComponent();

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
                                                    YearTextBox.Text,
                                                    SelectedMediaType);

            MultimediaItems.MultimediaList.Add(multimedia);
            this.Close();
        }


        private void OnPropertyRaised(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}