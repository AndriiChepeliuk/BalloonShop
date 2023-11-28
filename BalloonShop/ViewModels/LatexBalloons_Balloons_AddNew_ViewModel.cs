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
    private LatexBalloonTypeModel _selectedBalloobType;
    private LatexBalloonModel _newLatexBalloon;
    private string? _imageSource;
    private string? _photoImageSource;

    public LatexBalloonTypeModel SelectedBalloobType
    {
        get { return _selectedBalloobType; }
        set
        {
            _selectedBalloobType = value;
            OnPropertyChanged(nameof(SelectedBalloobType));
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

    public LatexBalloons_Balloons_AddNew_ViewModel()
    {
        NewLatexBalloon = new LatexBalloonModel();
        NewLatexBalloon.Name = "Name";
        ImageSource = Constants.ImageSourceDefaultValue;
        PhotoImageSource = Constants.ImageSourceDefaultValue;
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }


}
