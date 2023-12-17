using BalloonShop.Models.LatexBalloon;
using BalloonShop.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class LatexBalloons_SpecificLatexBalloon_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonModel _latexBalloon;

    public LatexBalloonModel LatexBalloon
    {
        get { return _latexBalloon; }
        set
        {
            _latexBalloon = value;
            OnPropertyChanged(nameof(LatexBalloon));
        }
    }

    public ICommand GoBackToLatexBalloonsOfSpecCategorie_PageCommand { get; }

    public LatexBalloons_SpecificLatexBalloon_ViewModel()
    {
        GoBackToLatexBalloonsOfSpecCategorie_PageCommand = new ViewModelCommand(ExecuteGoBackToLatexBalloonsOfSpecCategorie_PageCommand);
    }

    private void ExecuteGoBackToLatexBalloonsOfSpecCategorie_PageCommand(object obj)
    {
        throw new NotImplementedException();
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
