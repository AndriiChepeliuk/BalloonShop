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

    public ICommand ShowLatexBalloons_Balloons_AddNew_PageCommand { get; }

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
        ShowLatexBalloons_Balloons_AddNew_PageCommand = new ViewModelCommand(ExecuteShowLatexBalloons_Balloons_AddNew_PageCommand);
    }

    private void ExecuteShowLatexBalloons_Balloons_AddNew_PageCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.LatexBalloons_Balloons_AddNew_Page);
        window.DataContext = new LatexBalloons_Balloons_AddNew_ViewModel();
        window.titleText.Text = "Додати нову латексну кульку";
        //window.titleImage.Source = _latexBalloonType.Image;
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
