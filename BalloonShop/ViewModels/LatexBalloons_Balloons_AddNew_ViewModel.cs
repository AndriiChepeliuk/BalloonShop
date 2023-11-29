using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using System.Collections.ObjectModel;
using System.Windows;

namespace BalloonShop.ViewModels;

public class LatexBalloons_Balloons_AddNew_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonTypeModel _balloobType;
    private LatexBalloonModel _newLatexBalloon;
    private string? _imageSource;
    private string? _photoImageSource;
    private decimal _balloonCostWithHelium;

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
    public decimal BalloonCostWithHelium
    {
        get { return _balloonCostWithHelium; }
        set
        {
            _balloonCostWithHelium = value;
            OnPropertyChanged(nameof(BalloonCostWithHelium));
        }
    }

    public LatexBalloons_Balloons_AddNew_ViewModel()
    {
        ImageSource = Constants.ImageSourceDefaultValue;
        PhotoImageSource = Constants.ImageSourceDefaultValue;
        NewLatexBalloon = new LatexBalloonModel() { IsFlying = true, Quantity = 1, SizeInInches = 12 };
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }


}
