using System.ComponentModel;
using System;

namespace BalloonShop.Models;

public class ModelBase : INotifyPropertyChanged, ICloneable
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
