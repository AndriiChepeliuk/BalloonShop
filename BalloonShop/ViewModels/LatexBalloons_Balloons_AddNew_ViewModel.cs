using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using Microsoft.Win32;
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
    private string _visibilityOfCountOfBalloonsInSetField;
    private bool _isSetOfBalloons;
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
    public string VisibilityOfCountOfBalloonsInSetField
    {
        get { return _visibilityOfCountOfBalloonsInSetField; }
        set
        {
            _visibilityOfCountOfBalloonsInSetField = value;
            OnPropertyChanged(nameof(VisibilityOfCountOfBalloonsInSetField));
        }
    }
    public bool IsSetOfBalloons
    {
        get { return _isSetOfBalloons; }
        set
        {
            _isSetOfBalloons = value;
            NewLatexBalloon.IsSetOfBalloons = value;
            if (value)
            {
                VisibilityOfCountOfBalloonsInSetField = "Visible";
            }
            else
            {
                VisibilityOfCountOfBalloonsInSetField = "Hidden";
            }
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

    public LatexBalloons_Balloons_AddNew_ViewModel()
    {
        ChooseImageSourceCommand = new ViewModelCommand(ExecuteChooseImageSourceCommand);
        ChoosePhotoImageSourceCommand = new ViewModelCommand(ExecuteChoosePhotoImageSourceCommand);
        AddNewLatexBalloonCommand = new ViewModelCommand(ExecuteAddNewLatexBalloonCommand);

        ImageSource = Constants.ImageSourceDefaultValue;
        PhotoImageSource = Constants.ImageSourceDefaultValue;
        VisibilityOfCountOfBalloonsInSetField = "Hidden";
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
