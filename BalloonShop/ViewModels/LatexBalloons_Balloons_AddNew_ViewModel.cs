using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class LatexBalloons_Balloons_AddNew_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonTypeModel _balloobType;
    private LatexBalloonModel _newLatexBalloon;
    private string? _imageSource;
    private string? _photoImageSource;

    public LatexBalloonTypeModel BalloobType
    {
        get { return _balloobType; }
        set
        {
            _balloobType = value;
            OnPropertyChanged(nameof(BalloobType));
        }
    }
    public LatexBalloonModel NewLatexBalloon
    {
        get { return _newLatexBalloon; }
        set
        {
            _newLatexBalloon = value;
            OnPropertyChanged(nameof(NewLatexBalloon));
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
    public string PhotoImageSource
    {
        get { return _photoImageSource; }
        set
        {
            _photoImageSource = value;
            OnPropertyChanged(nameof(PhotoImageSource));
        }
    }

    public ICommand ChooseImageSourceCommand { get; }
    public ICommand ChoosePhotoImageSourceCommand { get; }

    public LatexBalloons_Balloons_AddNew_ViewModel()
    {
        ChooseImageSourceCommand = new ViewModelCommand(ExecuteChooseImageSourceCommand);
        ChoosePhotoImageSourceCommand = new ViewModelCommand(ExecuteChoosePhotoImageSourceCommand);

        ImageSource = Constants.ImageSourceDefaultValue;
        PhotoImageSource = Constants.ImageSourceDefaultValue;
        NewLatexBalloon = new LatexBalloonModel() { IsFlying = true, Quantity = 1, SizeInInches = 12 };
    }

    private void ExecuteChoosePhotoImageSourceCommand(object obj)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Виберіть зображення";
        openFileDialog.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
          "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
          "Portable Network Graphic (*.png)|*.png";
        if (openFileDialog.ShowDialog() == true)
        {
            PhotoImageSource = openFileDialog.FileName;
        }
    }

    private void ExecuteChooseImageSourceCommand(object obj)
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

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }


}
