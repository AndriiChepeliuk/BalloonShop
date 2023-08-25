using System.Windows.Input;

namespace BalloonShop.Helpers.Entities;

public class MenuItem
{
    public string ImageUri { get; set; }
    public string Name { get; set; }
    public ICommand ShowNextViewCommand { get; set; }
}
