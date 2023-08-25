using BalloonShop.Helpers.Entities;
using System;
using System.Collections.Generic;

namespace BalloonShop.ViewModels;

public class LatexBalloonsViewModel : ViewModelBase
{
    public ViewModelBase _currentChild;

    private readonly List<MenuItem> _latexBalloonsItems;

    private MenuItem _selectedMenuItem;

    public List<MenuItem> LatexBalloonsItems { get { return _latexBalloonsItems; } }
    public MenuItem SelectedMenuItem
    {
        get { return _selectedMenuItem; }
        set
        {
            _selectedMenuItem = value;
            OnPropertyChanged(nameof(SelectedMenuItem));
        }
    }

    public LatexBalloonsViewModel()
    {
        _latexBalloonsItems = new() {
        new MenuItem
        {
            Name = "Без малюнка",
            ImageUri = "\\Data\\MenuImages\\LatexBalloons\\Латексні_без_малюнку_оригінал.png",
            ShowNextViewCommand = new ViewModelCommand(ExecuteShowLatexBalloonsWithoutImageViewCommand)
        },
        new MenuItem
        {
            Name = "З малюнком",
            ImageUri = "\\Data\\MenuImages\\LatexBalloons\\Латексні_з_малюнком_оригінал.png",
            ShowNextViewCommand = new ViewModelCommand(ExecuteShowLatexBalloonsWithImagesViewCommand)
        },
        new MenuItem
        {
            Name = "Набори кульок",
            ImageUri = "\\Data\\MenuImages\\LatexBalloons\\Набори_кульок_оригінал.png",
            ShowNextViewCommand = new ViewModelCommand(ExecuteShowLatexBalloonsSetsOfBalloonsViewCommand)
        },
        new MenuItem
        {
            Name = "Серця",
            ImageUri = "\\Data\\MenuImages\\LatexBalloons\\Латексні_серця_оригінал.png",
            ShowNextViewCommand = new ViewModelCommand(ExecuteShowLatexBalloonsHeartsViewCommand)
        }};
    }

    private void ExecuteShowLatexBalloonsHeartsViewCommand(object obj)
    {
        base.CurrentChildView = new FoilBalloonsViewModel();
    }

    private void ExecuteShowLatexBalloonsSetsOfBalloonsViewCommand(object obj)
    {

    }

    private void ExecuteShowLatexBalloonsWithImagesViewCommand(object obj)
    {

    }

    private void ExecuteShowLatexBalloonsWithoutImageViewCommand(object obj)
    {

    }
}
