using BalloonShop.Models.Color;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Models.Manufacturer;
using BalloonShop.Models.Material;

namespace BalloonShop.Models.LatexBalloon;

public class LatexBalloonModel : ModelBase
{
    private string _name;
    private string _description;
    private string _imageUri;
    private int _sizeInInches;
    private int _sizeInCentimeters;
    private float _volume;
    private bool _isFlying;
    private decimal _balloonCost;
    private decimal _heliumCost;
    private decimal _balloonPrice;
    private decimal _balloonPriceWithAir;
    private decimal _balloonPriceWithHelium;
    private string _code;
    private LatexBalloonTypeModel _productType;
    private ColorModel _color;
    private ManufacturerModel _manufacturer;
    private MaterialModel _material;

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
    public string Description
    {
        get { return _description; }
        set
        {
            _description = value;
            OnPropertyChanged(nameof(Description));
        }
    }
    public string ImageUri
    {
        get { return _imageUri; }
        set
        {
            _imageUri = value;
            OnPropertyChanged(nameof(ImageUri));
        }
    }
    public int SizeInInches
    {
        get { return _sizeInInches; }
        set
        {
            _sizeInInches = value;
            OnPropertyChanged(nameof(SizeInInches));
        }
    }
    public int SizeInCentimeters
    {
        get { return _sizeInCentimeters; }
        set
        {
            _sizeInCentimeters = value;
            OnPropertyChanged(nameof(SizeInCentimeters));
        }
    }
    public float Volume
    {
        get { return _volume; }
        set
        {
            _volume = value;
            OnPropertyChanged(nameof(Volume));
        }
    }
    public bool IsFlying
    {
        get { return _isFlying; }
        set
        {
            _isFlying = value;
            OnPropertyChanged(nameof(IsFlying));
        }
    }
    public decimal BalloonCost
    {
        get { return _balloonCost; }
        set
        {
            _balloonCost = value;
            OnPropertyChanged(nameof(BalloonCost));
        }
    }
    public decimal HeliumCost
    {
        get { return _heliumCost; }
        set
        {
            _heliumCost = value;
            OnPropertyChanged(nameof(HeliumCost));
        }
    }
    public decimal BalloonPrice
    {
        get { return _balloonPrice; }
        set
        {
            _balloonPrice = value;
            OnPropertyChanged(nameof(BalloonPrice));
        }
    }
    public decimal BalloonCostWithAir
    {
        get { return _balloonPriceWithAir; }
        set
        {
            _balloonPriceWithAir = value;
            OnPropertyChanged(nameof(BalloonCostWithAir));
        }
    }
    public decimal BalloonCostWithHelium
    {
        get { return _balloonPriceWithHelium; }
        set
        {
            _balloonPriceWithHelium = value;
            OnPropertyChanged(nameof(BalloonCostWithHelium));
        }
    }
    public string Code
    {
        get { return _code; }
        set
        {
            _code = value;
            OnPropertyChanged(nameof(Code));
        }
    }
    public int ProductTypeId { get; set; }
    public LatexBalloonTypeModel ProductType
    {
        get { return _productType; }
        set
        {
            _productType = value;
            OnPropertyChanged(nameof(ProductType));
        }
    }
    public int ColorId { get; set; }
    public ColorModel Color
    {
        get { return _color; }
        set
        {
            _color = value;
            OnPropertyChanged(nameof(Color));
        }
    }
    public int ManufacturerId { get; set; }
    public ManufacturerModel Manufacturer
    {
        get { return _manufacturer; }
        set
        {
            _manufacturer = value;
            OnPropertyChanged(nameof(Manufacturer));
        }
    }
    public int MaterialId { get; set; }
    public MaterialModel Material
    {
        get { return _material; }
        set
        {
            _material = value;
            OnPropertyChanged(nameof(Material));
        }
    }
}
