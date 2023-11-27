using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Services;
using BalloonShop.Views;
using System.Collections.ObjectModel;
using System.Windows;

namespace BalloonShop.ViewModels;

public class LatexBalloons_Balloons_AddNew_ViewModel : ViewModelBase
{
    private MainWindow window;
    private LatexBalloonTypeModel _selectedBalloobType;
    private ObservableCollection<LatexBalloonTypeModel> _balloonTypes;

    public ObservableCollection<LatexBalloonTypeModel> BalloonTypes
    {
        get { return _balloonTypes; }
        set
        {
            _balloonTypes = value;
            OnPropertyChanged(nameof(BalloonTypes));
        }
    }
    public LatexBalloonTypeModel SelectedBalloobType
    {
        get { return _selectedBalloobType; }
        set
        {
            _selectedBalloobType = value;
            OnPropertyChanged(nameof(SelectedBalloobType));
        }
    }

    public LatexBalloons_Balloons_AddNew_ViewModel()
    {
        BalloonTypes = new ObservableCollection<LatexBalloonTypeModel>(LatexBalloonTypeModelService.GetAllLatexBalloonTypes());
    }

    private void LoadWindow()
    {
        if (window == null)
        {
            window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
        }
    }


}
