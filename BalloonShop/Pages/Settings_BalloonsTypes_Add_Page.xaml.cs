using BalloonShop.Models.ProductType;
using Microsoft.Win32;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace BalloonShop.Pages
{
    /// <summary>
    /// Interaction logic for Settings_BalloonsTypes_Add_Page.xaml
    /// </summary>
    public partial class Settings_BalloonsTypes_Add_Page : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string? _imageSourceDefaultValue = "\\Data\\System_Images\\DefaultImage.jpg";
        private string? _imageSource;
        private ProductTypeModel _productType;

        public string ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }

        public ProductTypeModel ProductType
        {
            get { return _productType; }
            set
            {
                _productType = value;
                OnPropertyChanged(nameof(ProductType));
            }
        }

        public Settings_BalloonsTypes_Add_Page()
        {
            InitializeComponent();

            ImageSource = _imageSourceDefaultValue;
        }

        private void addPicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a picture";
            openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                ImageSource = openFileDialog.FileName;
            }
        }
    }
}
