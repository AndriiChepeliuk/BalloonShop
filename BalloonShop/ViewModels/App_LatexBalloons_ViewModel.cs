﻿using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class App_LatexBalloons_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonTypeModel _selectedBalloobType;
    private ObservableCollection<LatexBalloonTypeModel> _balloonTypes;
    private ObservableCollection<LatexBalloonModel> _latexBalloonsOfSpecificType;

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
    public ObservableCollection<LatexBalloonModel> LatexBalloonsOfSpecificType
    {
        get { return _latexBalloonsOfSpecificType; }
        set
        {
            _latexBalloonsOfSpecificType = value;
            OnPropertyChanged(nameof(LatexBalloonsOfSpecificType));
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
        if (_selectedBalloobType != null)
        {
            LatexBalloonsOfSpecificType = new ObservableCollection<LatexBalloonModel>(
                        LatexBalloonModelService.GetLatexBalloonsWithSpecificType(_selectedBalloobType.Id));

            LoadWindow();

            if (window.container.Content is UserControl)
            {
                (window.container.Content as UserControl).DataContext = null;
                GC.Collect();
            }

            window.container.Content = new Pages.LatexBalloons_Balloons_Page(_selectedBalloobType, _latexBalloonsOfSpecificType);

            window.titleText.Text = _selectedBalloobType.Name;
            window.titleImage.Source = _selectedBalloobType.Image;
        }
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
