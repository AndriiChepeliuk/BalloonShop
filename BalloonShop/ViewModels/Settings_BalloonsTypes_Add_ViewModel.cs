using BalloonShop.Helpers;
using BalloonShop.Models.ProductType;
using Microsoft.Win32;
using System;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class Settings_BalloonsTypes_Add_ViewModel : ViewModelBase
{
    private ProductTypeModel _productType;

    public ProductTypeModel ProductType
    {
        get { return _productType; }
        set
        {
            _productType = value;
            OnPropertyChanged(nameof(ProductType));
        }
    }

    public ICommand ChoosePictureCommand { get; }
    public ICommand ClearProductTypeCommand { get; }

    public Settings_BalloonsTypes_Add_ViewModel()
    {
        ProductType = new ProductTypeModel();
        ProductType.ImageUri = Constants.ImageSourceDefaultValue;

        ChoosePictureCommand = new ViewModelCommand(ExecuteChoosePictureCommand);
        ClearProductTypeCommand = new ViewModelCommand(ExecuteClearProductTypeCommand);
    }

    private void ExecuteClearProductTypeCommand(object obj)
    {
        ProductType = new();
        ProductType.ImageUri = Constants.ImageSourceDefaultValue;
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
            ProductType.ImageUri = openFileDialog.FileName;
        }
    }
}
