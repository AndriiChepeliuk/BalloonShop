using BalloonShop.Models.LatexBalloon;
using BalloonShop.Services;
using BalloonShop.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
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
        var latexBalloonsOfSpecificType = new ObservableCollection<LatexBalloonModel>(
                        LatexBalloonModelService.GetLatexBalloonsWithSpecificType(_latexBalloon.LatexBalloonType.Id)
                        );
        LoadWindow();

        if (window.container.Content is UserControl)
        {
            (window.container.Content as UserControl).DataContext = null;
            GC.Collect();
        }

        window.container.Content = new Pages.LatexBalloons_Balloons_Page(_latexBalloon.LatexBalloonType, latexBalloonsOfSpecificType);

        window.titleText.Text = _latexBalloon.LatexBalloonType.Name;
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
