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
    private LatexBalloonModel _selectedLatexBalloon;

    public ICommand ShowLatexBalloons_Balloons_AddNew_PageCommand { get; }
    public ICommand ShowSpecificLatexBalloon_PageCommand { get; }
    public ICommand GoBackToLatexBalloons_PageCommand { get; }

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
    public LatexBalloonModel SelectedLatexBalloon
    {
        get { return _selectedLatexBalloon; }
        set
        {
            _selectedLatexBalloon = value;
            OnPropertyChanged(nameof(SelectedLatexBalloon));
        }
    }

    public LatexBalloons_Balloons_ViewModel()
    {
        ShowLatexBalloons_Balloons_AddNew_PageCommand = new ViewModelCommand(ExecuteShowLatexBalloons_Balloons_AddNew_PageCommand);
        ShowSpecificLatexBalloon_PageCommand = new ViewModelCommand(ExecuteShowSpecificLatexBalloon_PageCommand);
        GoBackToLatexBalloons_PageCommand = new ViewModelCommand(ExecuteGoBackToLatexBalloons_PageCommand);
    }

    private void ExecuteShowSpecificLatexBalloon_PageCommand(object obj)
    {
        if (_selectedLatexBalloon != null)
        {
            LoadWindow();

            window.container.Content = new Pages.LatexBalloons_SpecificLatexBalloon_Page(_selectedLatexBalloon);
            window.titleText.Text = _selectedLatexBalloon.Name;
        }
    }

    private void ExecuteGoBackToLatexBalloons_PageCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.App_LatexBalloons_Page);
    }

    private void ExecuteShowLatexBalloons_Balloons_AddNew_PageCommand(object obj)
    {
        LoadWindow();
        window.container.Content = new Pages.LatexBalloons_Balloons_AddNew_Page(_latexBalloonType);

        window.titleText.Text = "Додати нову латексну кульку" + " '" + _latexBalloonType.Name + "'";
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
