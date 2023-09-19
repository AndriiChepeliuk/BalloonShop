using BalloonShop.Helpers;
using BalloonShop.Models.BalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class Settings_LatexBalloons_BalloonsTypes_Add_ViewModel : ViewModelBase
{
    private MainWindow window;

    private BalloonTypeModel _balloonType;
    private string? _imageSource;

    public BalloonTypeModel BalloonType
    {
        get { return _balloonType; }
        set
        {
            _balloonType = value;
            OnPropertyChanged(nameof(BalloonType));
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
    public ICommand ClearBalloonTypeCommand { get; }
    public ICommand AddBalloonTypeCommand { get; }

    public Settings_LatexBalloons_BalloonsTypes_Add_ViewModel()
    {
        BalloonType = new BalloonTypeModel();
        ImageSource = Constants.ImageSourceDefaultValue;

        ChoosePictureCommand = new ViewModelCommand(ExecuteChoosePictureCommand);
        ClearBalloonTypeCommand = new ViewModelCommand(ExecuteClearBalloonTypeCommand);
        AddBalloonTypeCommand = new ViewModelCommand(ExecuteAddBalloonTypeCommand);
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }

    private void ExecuteAddBalloonTypeCommand(object obj)
    {
        if (!string.IsNullOrEmpty(ImageSource))
        {
            BalloonType.ImageByteCode = ImageHelper.ConvertImageToByteArray(ImageSource);
            BalloonType.BalloonType = "Латексні кульки";
        }

        BalloonTypeModelService.AddProductType(BalloonType);

        BalloonType = new BalloonTypeModel();
        ImageSource = Constants.ImageSourceDefaultValue;

        LoadWindow();
        window.ExecutePage(AppPages.Settings_LatexBalloons_BalloonsTypes_Page);
    }

    private void ExecuteClearBalloonTypeCommand(object obj)
    {
        BalloonType = new();
        ImageSource = Constants.ImageSourceDefaultValue;
    }

    private void ExecuteChoosePictureCommand(object obj)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Виберіть зображення";
        openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
          "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
          "Portable Network Graphic (*.png)|*.png";
        if (openFileDialog.ShowDialog() == true)
        {
            ImageSource = openFileDialog.FileName;
        }
    }
}
