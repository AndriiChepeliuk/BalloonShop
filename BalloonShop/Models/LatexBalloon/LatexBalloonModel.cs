using BalloonShop.Models.LatexBalloonType;
using BalloonShop.Models.Material;
using System.Windows.Media.Imaging;

namespace BalloonShop.Models.LatexBalloon;

public class LatexBalloonModel : ModelBase
{
    private string _name;
    private string _description;
    private BitmapImage _image;
    private BitmapImage _photoImage;
    private int _quantity;
    private int _sizeInInches;
    private int _sizeInCentimeters;
    private float _volume;
    private bool _isFlying;
    private decimal _balloonCost;
    private decimal _heliumCost;
    private decimal _balloonCostWithHelium;
    private decimal _balloonPrice;
    private decimal _balloonPriceWithAir;
    private decimal _balloonPriceWithHelium;
    private string _code;
    private LatexBalloonTypeModel _latexBalloonType;
    //private ColorModel _color;
    //private ManufacturerModel _manufacturer;
    //private MaterialModel _material;

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
    public byte[]? ImageByteCode { get; set; }
    public byte[]? PhotoImageByteCode { get; set; }
    public BitmapImage Image
    {
        get { return _image; }
        set
        {
            _image = value;
            OnPropertyChanged(nameof(Image));
        }
    }
    public BitmapImage PhotoImage
    {
        get { return _photoImage; }
        set
        {
            _photoImage = value;
            OnPropertyChanged(nameof(PhotoImage));
        }
    }
    public int Quantity
    {
        get { return _quantity; }
        set
        {
            _quantity = value;
            OnPropertyChanged(nameof(Quantity));
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
            BalloonCostWithHelium = _balloonCost + _heliumCost;
        }
    }
    public decimal BalloonCostWithHelium
    {
        get { return _balloonCostWithHelium; }
        set
        {
            _balloonCostWithHelium = value;
            OnPropertyChanged(nameof(BalloonCostWithHelium));
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
    public decimal BalloonPriceWithAir
    {
        get { return _balloonPriceWithAir; }
        set
        {
            _balloonPriceWithAir = value;
            OnPropertyChanged(nameof(BalloonPriceWithAir));
        }
    }
    public decimal BalloonPriceWithHelium
    {
        get { return _balloonPriceWithHelium; }
        set
        {
            _balloonPriceWithHelium = value;
            OnPropertyChanged(nameof(BalloonPriceWithHelium));
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
    public int LatexBalloonTypeId { get; set; }
    public LatexBalloonTypeModel LatexBalloonType
    {
        get { return _latexBalloonType; }
        set
        {
            _latexBalloonType = value;
            OnPropertyChanged(nameof(LatexBalloonType));
        }
    }
    //public int ColorId { get; set; }
    //public ColorModel Color
    //{
    //    get { return _color; }
    //    set
    //    {
    //        _color = value;
    //        OnPropertyChanged(nameof(Color));
    //    }
    //}

    //public int ManufacturerId { get; set; }
    //public ManufacturerModel Manufacturer
    //{
    //    get { return _manufacturer; }
    //    set
    //    {
    //        _manufacturer = value;
    //        OnPropertyChanged(nameof(Manufacturer));
    //    }
    //}
    //public int MaterialId { get; set; }
    //public MaterialModel Material
    //{
    //    get { return _material; }
    //    set
    //    {
    //        _material = value;
    //        OnPropertyChanged(nameof(Material));
    //    }
    //}
}
