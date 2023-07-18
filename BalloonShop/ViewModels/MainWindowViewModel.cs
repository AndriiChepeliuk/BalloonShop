using FontAwesome.Sharp;
using System;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _currentChildView;
    private string _caption;
    private IconChar _icon;

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
    public IconChar Icon
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

        ExecuteShowLatexBalloonsViewCommand(null);
    }

    private void ExecuteShowFoilBalloonsViewCommand(object obj)
    {
        CurrentChildView = new FoilBalloonsViewModel();
    }

    private void ExecuteShowLatexBalloonsViewCommand(object obj)
    {
        CurrentChildView = new LatexBalloonsViewModel();
    }
}
