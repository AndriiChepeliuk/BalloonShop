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
    private bool _isSetOfBalloons;
    private bool _isOneBalloon;
    private int _balloonPriceMarkupInPercentage;
    private int _balloonPriceWithAirMarkupInPercentage;
    private int _balloonPriceWithHeliumMarkupInPercentage;

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
    public bool IsOneBalloon
    {
        get { return _isOneBalloon; }
        set
        {
            _isOneBalloon = value;
            OnPropertyChanged(nameof(IsOneBalloon));
        }
    }
    public bool IsSetOfBalloons
    {
        get { return _isSetOfBalloons; }
        set
        {
            _isSetOfBalloons = value;
            NewLatexBalloon.IsSetOfBalloons = value;
            IsOneBalloon = !value;
            OnPropertyChanged(nameof(IsSetOfBalloons));
        }
    }
    public int BalloonPriceMarkupInPercentage
    {
        get { return _balloonPriceMarkupInPercentage; }
        set
        {
            _balloonPriceMarkupInPercentage = value;
            OnPropertyChanged(nameof(BalloonPriceMarkupInPercentage));
        }
    }
    public int BalloonPriceWithAirMarkupInPercentage
    {
        get { return _balloonPriceWithAirMarkupInPercentage; }
        set
        {
            _balloonPriceWithAirMarkupInPercentage = value;
            OnPropertyChanged(nameof(BalloonPriceWithAirMarkupInPercentage));
        }
    }
    public int BalloonPriceWithHeliumMarkupInPercentage
    {
        get { return _balloonPriceWithHeliumMarkupInPercentage; }
        set
        {
            _balloonPriceWithHeliumMarkupInPercentage = value;
            OnPropertyChanged(nameof(BalloonPriceWithHeliumMarkupInPercentage));
        }
    }

    public ICommand ChooseImageSourceCommand { get; }
    public ICommand ChoosePhotoImageSourceCommand { get; }
    public ICommand AddNewLatexBalloonCommand { get; }
    public ICommand CancelAddingNewLatexBalloonCommand { get; }

    public LatexBalloons_Balloons_AddNew_ViewModel()
    {
        ChooseImageSourceCommand = new ViewModelCommand(ExecuteChooseImageSourceCommand);
        ChoosePhotoImageSourceCommand = new ViewModelCommand(ExecuteChoosePhotoImageSourceCommand);
        AddNewLatexBalloonCommand = new ViewModelCommand(ExecuteAddNewLatexBalloonCommand, CanExecuteAddNewLatexBalloonCommand);
        CancelAddingNewLatexBalloonCommand = new ViewModelCommand(ExecuteCancelAddingNewLatexBalloonCommand);

        ImageSource = Constants.ImageSourceDefaultValue;
        PhotoImageSource = Constants.ImageSourceDefaultValue;
        IsOneBalloon = true;
        NewLatexBalloon = new LatexBalloonModel()
        {
            IsFlying = true,
            CountOfBalloonsInSet = 1,
            Quantity = 1,
            SizeInInches = 12,
            BalloonPriceMarkupInPercentage = 0,
            BalloonPriceWithAirMarkupInPercentage = 0,
            BalloonPriceWithHeliumMarkupInPercentage = 0
        };
    }

    private bool CanExecuteAddNewLatexBalloonCommand(object obj)
    {
        return !(string.IsNullOrWhiteSpace(NewLatexBalloon.Name) || string.IsNullOrWhiteSpace(NewLatexBalloon.Description));
    }

    private void ExecuteCancelAddingNewLatexBalloonCommand(object obj)
    {
        var latexBalloonsOfSpecificType = new ObservableCollection<LatexBalloonModel>(
                        LatexBalloonModelService.GetLatexBalloonsWithSpecificType(_balloobType.Id)
                        );

        LoadWindow();

        window.container.Content = new Pages.LatexBalloons_Balloons_Page(_balloobType, latexBalloonsOfSpecificType);

        window.titleText.Text = _balloobType.Name;
        window.titleImage.Source = _balloobType.Image;
    }

    private void ExecuteAddNewLatexBalloonCommand(object obj)
    {
        if (!string.IsNullOrEmpty(ImageSource) || !string.IsNullOrEmpty(PhotoImageSource))
        {
            NewLatexBalloon.ImageByteCode = ImageHelper.ConvertImageToByteArray(ImageSource);
            NewLatexBalloon.PhotoImageByteCode = ImageHelper.ConvertImageToByteArray(PhotoImageSource);
        }

        LatexBalloonModelService.AddLatexBalloon(NewLatexBalloon, _balloobType.Id);

        ImageSource = PhotoImageSource = Constants.ImageSourceDefaultValue;
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
