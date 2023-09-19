﻿using BalloonShop.Models.BalloonType;
using BalloonShop.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class Settings_LatexBalloons_BalloonsTypes_ViewModel : ViewModelBase
{
    private MainWindow window;
    private ObservableCollection<BalloonTypeModel> _balloonTypes;

    public ObservableCollection<BalloonTypeModel> BalloonTypes
    {
        get { return _balloonTypes; }
        set
        {
            _balloonTypes = value;
            OnPropertyChanged(nameof(BalloonTypes));
        }
    }

    public ICommand AddNewBalloonTypeCommand { get; }

    public Settings_LatexBalloons_BalloonsTypes_ViewModel()
    {
        AddNewBalloonTypeCommand = new ViewModelCommand(ExecuteAddNewBalloonTypeCommand);
    }

    private void ExecuteAddNewBalloonTypeCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.Settings_LatexBalloons_BalloonsTypes_Add_Page);
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}