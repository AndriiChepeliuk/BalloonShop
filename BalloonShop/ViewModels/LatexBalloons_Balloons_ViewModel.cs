using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class LatexBalloons_Balloons_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonTypeModel _latexBalloonType;
    private ObservableCollection<LatexBalloonModel> _latexBalloons;

    public ICommand ShowImageCommand { get; }

    public LatexBalloonTypeModel LatexBalloonType
    {
        get { return _latexBalloonType; }
        set
        {
            _latexBalloonType = value;
            OnPropertyChanged(nameof(LatexBalloonType));
        }
    }
    public ObservableCollection<LatexBalloonModel> LatexBalloons
    {
        get { return _latexBalloons; }
        set
        {
            _latexBalloons = value;
            OnPropertyChanged(nameof(LatexBalloons));
        }
    }


    public LatexBalloons_Balloons_ViewModel()
    {
        ShowImageCommand = new ViewModelCommand(ExecuteShowImageCommand);
    }

    private void ExecuteShowImageCommand(object obj)
    {
        LoadWindow();
        var tt = window.container.DataContext;
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
