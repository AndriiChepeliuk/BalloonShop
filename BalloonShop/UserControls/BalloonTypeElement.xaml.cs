using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BalloonShop.UserControls
{
    /// <summary>
    /// Interaction logic for BalloonTypeElement.xaml
    /// </summary>
    public partial class BalloonTypeElement : UserControl
    {
        public BalloonTypeElement()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent ElementClickEvent =
            EventManager.RegisterRoutedEvent("ElementClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(BalloonTypeElement));

        public event RoutedEventHandler ElementClick
        {
            add { AddHandler(ElementClickEvent, value); }
            remove { RemoveHandler(ElementClickEvent, value); }
        }

        void Button_Click(object sender, RoutedEventArgs e) => RaiseEvent(new RoutedEventArgs(ElementClickEvent));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(BalloonTypeElement));

        public BitmapImage ImageBitmap
        {
            get { return (BitmapImage)GetValue(ImageBitmapProperty); }
            set { SetValue(ImageBitmapProperty, value); }
        }
        public static readonly DependencyProperty ImageBitmapProperty = DependencyProperty.Register("ImageBitmap", typeof(BitmapImage), typeof(BalloonTypeElement));
    }
}
