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

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("BalloonName", typeof(string), typeof(LatexBalloonEntityElement));

        public BitmapImage ImageBitmap
        {
            get { return (BitmapImage)GetValue(ImageBitmapProperty); }
            set { SetValue(ImageBitmapProperty, value); }
        }
        public static readonly DependencyProperty ImageBitmapProperty = DependencyProperty.Register("ImageBitmap", typeof(BitmapImage), typeof(LatexBalloonEntityElement));
    }
}
