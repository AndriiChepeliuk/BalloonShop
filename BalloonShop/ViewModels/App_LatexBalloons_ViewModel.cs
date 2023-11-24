using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class App_LatexBalloons_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonTypeModel _selectedBalloobType;
    private ObservableCollection<LatexBalloonTypeModel> _balloonTypes;

    public LatexBalloonTypeModel SelectedBalloobType
    {
        get { return _selectedBalloobType; }
        set
        {
            _selectedBalloobType = value;
            OnPropertyChanged(nameof(SelectedBalloobType));
        }
    }
    public ObservableCollection<LatexBalloonTypeModel> BalloonTypes
    {
        get { return _balloonTypes; }
        set
        {
            _balloonTypes = value;
            OnPropertyChanged(nameof(BalloonTypes));
        }
    }

    public ICommand AddNewBalloonTypeCommand { get; }

    public App_LatexBalloons_ViewModel()
    {
        BalloonTypes = new ObservableCollection<LatexBalloonTypeModel>(LatexBalloonTypeModelService.GetAllLatexBalloonTypes());
        AddNewBalloonTypeCommand = new ViewModelCommand(ExecuteAddNewBalloonTypeCommand);
    }

    private void ExecuteAddNewBalloonTypeCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.LatexBalloons_Balloons_Page);
        window.titleText.Text = _selectedBalloobType.Name;
        window.titleImage.Source = _selectedBalloobType.Image;
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
