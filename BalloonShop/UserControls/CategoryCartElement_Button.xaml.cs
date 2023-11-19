using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BalloonShop.UserControls
{
    /// <summary>
    /// Interaction logic for CategoryCartElement_Button.xaml
    /// </summary>
    public partial class CategoryCartElement_Button : UserControl
    {
        public CategoryCartElement_Button()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent ElementClickEvent =
            EventManager.RegisterRoutedEvent("ElementClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CategoryCartElement_Button));

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
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(CategoryCartElement_Button));

        public BitmapImage ImageBitmap
        {
            get { return (BitmapImage)GetValue(ImageBitmapProperty); }
            set { SetValue(ImageBitmapProperty, value); }
        }
        public static readonly DependencyProperty ImageBitmapProperty = DependencyProperty.Register("ImageBitmap", typeof(BitmapImage), typeof(CategoryCartElement_Button));
    }
}
