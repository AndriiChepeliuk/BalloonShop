using BalloonShop.Models.FoilBalloon;
using BalloonShop.Models.LatexBalloon;
using System.Collections.ObjectModel;

namespace BalloonShop.Models.Material;

public class MaterialModel : ModelBase
{
    private string _name;
    private string _relatedProduct;
    private ObservableCollection<LatexBalloonModel> _latexBalloons;
    private ObservableCollection<FoilBalloonModel> _foilBalloons;

    public int Id { get; private set; }
    public string Name
    {
        get { return _name; }
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
    public string RelatedProduct
    {
        get { return _relatedProduct; }
        set
        {
            _relatedProduct = value;
            OnPropertyChanged(nameof(RelatedProduct));
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
    public ObservableCollection<FoilBalloonModel> FoilBalloons
    {
        get { return _foilBalloons; }
        set
        {
            _foilBalloons = value;
            OnPropertyChanged(nameof(FoilBalloons));
        }
    }
}
