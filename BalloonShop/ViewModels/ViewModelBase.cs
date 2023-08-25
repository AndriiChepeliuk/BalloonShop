using System.ComponentModel;

namespace BalloonShop.ViewModels;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public ViewModelBase _currentChildView;

    public event PropertyChangedEventHandler? PropertyChanged;
    public ViewModelBase CurrentChildView
    {
        get
        {
            return _currentChildView;
        }
        set
        {
            _currentChildView = value;
            OnPropertyChanged(nameof(CurrentChildView));
        }
    }

    public void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public void PassCurrentChildView(ViewModelBase currentChildView)
    {
        if (currentChildView != null)
        {
            CurrentChildView = currentChildView;
        }

    }
}
