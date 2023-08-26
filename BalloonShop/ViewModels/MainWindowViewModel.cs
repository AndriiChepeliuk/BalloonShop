using BalloonShop.Views;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    //-----------------------
    private MainWindow window;

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
    //-----------------------

    private ViewModelBase _currentChildView;
    private string _caption;
    private string _icon;

    public ViewModelBase CurrentChildView
    {
        get
        {
            return _currentChildView;
        }
        set
        {
            _currentChildView = value;
            OnPropertyChanged(nameof(CurrentChildView));
        }
    }
    public string Caption
    {
        get
        {
            return _caption;
        }
        set
        {
            _caption = value;
            OnPropertyChanged(nameof(Caption));
        }
    }
    public string Icon
    {
        get
        {
            return _icon;
        }
        set
        {
            _icon = value;
            OnPropertyChanged(nameof(Icon));
        }
    }

    public ICommand ShowLatexBalloonsViewCommand { get; }
    public ICommand ShowFoilBalloonsViewCommand { get; }

    public MainWindowViewModel()
    {
        ShowLatexBalloonsViewCommand = new ViewModelCommand(ExecuteShowLatexBalloonsViewCommand);
        ShowFoilBalloonsViewCommand = new ViewModelCommand(ExecuteShowFoilBalloonsViewCommand);

        //ExecuteShowLatexBalloonsViewCommand(null);
    }

    private void ExecuteShowFoilBalloonsViewCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.App_FoilBalloons_Page);

        //CurrentChildView = new FoilBalloonsViewModel();
        //CurrentChildView.PassCurrentChildView(_currentChildView);
        //Caption = "Фольговані кульки";
        //Icon = "\\Data\\Icons\\icons8-star-64_grey.png";
    }

    private void ExecuteShowLatexBalloonsViewCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.App_LatexBalloons_Page);

        //CurrentChildView = new LatexBalloonsViewModel();
        //CurrentChildView.PassCurrentChildView(_currentChildView);
        //Caption = "Латексні кульки";
        //Icon = "\\Data\\Icons\\icons8-hearts_balloons-60_grey.png";
    }
}
