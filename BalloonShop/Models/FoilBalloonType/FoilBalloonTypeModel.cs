﻿using BalloonShop.Models.FoilBalloon;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace BalloonShop.Models.FoilBalloonType;

public class FoilBalloonTypeModel : ModelBase
{
    private string _name;
    private string _balloonCategory;
    private string _balloonType;
    private BitmapImage _image;
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
    public string BalloonCategory
    {
        get { return _balloonCategory; }
        set
        {
            _balloonCategory = value;
            OnPropertyChanged(nameof(BalloonCategory));
        }
    }
    public string BalloonType
    {
        get { return _balloonType; }
        set
        {
            _balloonType = value;
            OnPropertyChanged(nameof(BalloonType));
        }
    }

    public byte[]? ImageByteCode { get; set; }
    public BitmapImage Image
    {
        get { return _image; }
        set
        {
            _image = value;
            OnPropertyChanged(nameof(Image));
        }
    }

    //public string RelatedProduct
    //{
    //    get { return _relatedProduct; }
    //    set
    //    {
    //        _relatedProduct = value;
    //        OnPropertyChanged(nameof(RelatedProduct));
    //    }
    //}

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
