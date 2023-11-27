using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using System.Collections.ObjectModel;
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

    public ICommand ShowSpecificGroupOfLatexBalloons_Command { get; }

    public App_LatexBalloons_ViewModel()
    {
        BalloonTypes = new ObservableCollection<LatexBalloonTypeModel>(LatexBalloonTypeModelService.GetAllLatexBalloonTypes());
        ShowSpecificGroupOfLatexBalloons_Command = new ViewModelCommand(ExecuteShowSpecificGroupOfLatexBalloons_Command);
    }

    private void ExecuteShowSpecificGroupOfLatexBalloons_Command(object obj)
    {
        LoadWindow();
        //window.ExecutePage(AppPages.LatexBalloons_Balloons_Page);
        window.container.Content = new Pages.LatexBalloons_Balloons_Page();
        var newViewModel = new LatexBalloons_Balloons_ViewModel();
        newViewModel.LatexBalloonType = _selectedBalloobType;
        newViewModel.LatexBalloons = new ObservableCollection<LatexBalloonModel>(LatexBalloonModelService.GetAllLatexBalloons());

        window.DataContext = newViewModel;
        window.titleText.Text = newViewModel.LatexBalloonType.Name;//_selectedBalloobType.Name;
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
