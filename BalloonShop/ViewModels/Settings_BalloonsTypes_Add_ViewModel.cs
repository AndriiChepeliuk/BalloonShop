using BalloonShop.Helpers;
using BalloonShop.Models.BalloonType;
using BalloonShop.Services;
using Microsoft.Win32;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class Settings_BalloonsTypes_Add_ViewModel : ViewModelBase
{
    private BalloonTypeModel _productType;
    private string? _imageSource;

    public BalloonTypeModel ProductType
    {
        get { return _productType; }
        set
        {
            _productType = value;
            OnPropertyChanged(nameof(ProductType));
        }
    }
    public string ImageSource
    {
        get { return _imageSource; }
        set
        {
            _imageSource = value;
            OnPropertyChanged(nameof(ImageSource));
        }
    }

    public ICommand ChoosePictureCommand { get; }
    public ICommand ClearProductTypeCommand { get; }
    public ICommand AddProductTypeCommand { get; }

    public Settings_BalloonsTypes_Add_ViewModel()
    {
        ProductType = new BalloonTypeModel();
        ImageSource = Constants.ImageSourceDefaultValue;

        ChoosePictureCommand = new ViewModelCommand(ExecuteChoosePictureCommand);
        ClearProductTypeCommand = new ViewModelCommand(ExecuteClearProductTypeCommand);
        AddProductTypeCommand = new ViewModelCommand(ExecuteAddProductTypeCommand);
    }

    private void ExecuteAddProductTypeCommand(object obj)
    {
        if(!string.IsNullOrEmpty(ImageSource))
        {
            ProductType.ImageByteCode = ImageHelper.ConvertImageToByteArray(ImageSource);
        }

        ProductTypeModelService.AddProductType(ProductType);

        ProductType = new BalloonTypeModel();
        ImageSource = Constants.ImageSourceDefaultValue;
    }

    private void ExecuteClearProductTypeCommand(object obj)
    {
        ProductType = new();
        ImageSource = Constants.ImageSourceDefaultValue;
    }

    private void ExecuteChoosePictureCommand(object obj)
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
