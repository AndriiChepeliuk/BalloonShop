using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BalloonShop.UserControls
{
    /// <summary>
    /// Interaction logic for LatexBalloonEntityElement.xaml
    /// </summary>
    public partial class LatexBalloonEntityElement : UserControl
    {
        public LatexBalloonEntityElement()
        {
            InitializeComponent();
        }

        public string BalloonName
        {
            get { return (string)GetValue(BalloonNameProperty); }
            set { SetValue(BalloonNameProperty, value); }
        }
        public static readonly DependencyProperty BalloonNameProperty = DependencyProperty.Register("BalloonName", typeof(string), typeof(LatexBalloonEntityElement));

        public string BalloonCount
        {
            get { return (string)GetValue(BalloonCountProperty); }
            set { SetValue(BalloonCountProperty, value); }
        }
        public static readonly DependencyProperty BalloonCountProperty = DependencyProperty.Register("BalloonCount", typeof(string), typeof(LatexBalloonEntityElement));

        public decimal BalloonPrice
        {
            get { return (decimal)GetValue(BalloonPriceProperty); }
            set { SetValue(BalloonPriceProperty, value); }
        }
        public static readonly DependencyProperty BalloonPriceProperty = DependencyProperty.Register("BalloonPrice", typeof(decimal), typeof(LatexBalloonEntityElement));

        public decimal BalloonPriceWithAir
        {
            get { return (decimal)GetValue(BalloonPriceWithAirProperty); }
            set { SetValue(BalloonPriceWithAirProperty, value); }
        }
        public static readonly DependencyProperty BalloonPriceWithAirProperty = DependencyProperty.Register("BalloonPriceWithAir", typeof(decimal), typeof(LatexBalloonEntityElement));

        public decimal BalloonPriceWithHelium
        {
            get { return (decimal)GetValue(BalloonPriceWithHeliumProperty); }
            set { SetValue(BalloonPriceWithHeliumProperty, value); }
        }
        public static readonly DependencyProperty BalloonPriceWithHeliumProperty = DependencyProperty.Register("BalloonPriceWithHelium", typeof(decimal), typeof(LatexBalloonEntityElement));

        public BitmapImage ImageBitmap
        {
            get { return (BitmapImage)GetValue(ImageBitmapProperty); }
            set { SetValue(ImageBitmapProperty, value); }
        }
        public static readonly DependencyProperty ImageBitmapProperty = DependencyProperty.Register("ImageBitmap", typeof(BitmapImage), typeof(LatexBalloonEntityElement));
    }
}
