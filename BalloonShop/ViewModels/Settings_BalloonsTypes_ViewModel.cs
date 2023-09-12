using BalloonShop.Views;
using System.Windows;
using System.Windows.Input;

namespace BalloonShop.ViewModels;

public class Settings_BalloonsTypes_ViewModel : ViewModelBase
{
    private MainWindow window;

    public ICommand AddNewBalloonTypeCommand { get; }

    public Settings_BalloonsTypes_ViewModel()
    {
        AddNewBalloonTypeCommand = new ViewModelCommand(ExecuteAddNewBalloonTypeCommand);
    }

    private void ExecuteAddNewBalloonTypeCommand(object obj)
    {
        LoadWindow();
        window.ExecutePage(AppPages.Settings_BalloonsTypes_Add_Page);
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }
}
