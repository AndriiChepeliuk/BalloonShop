using BalloonShop.Views;
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

namespace BalloonShop.Pages
{
    /// <summary>
    /// Interaction logic for App_Settings_Page.xaml
    /// </summary>
    public partial class App_Settings_Page : UserControl
    {
        private MainWindow window;

        public App_Settings_Page()
        {
            InitializeComponent();
        }

        private void LoadWindow()
        {
            if (window == null)
            {
                window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            }
        }

        private void Settings_ColorSettings_Page_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Settings_ColorSettings_Page);
        }

        private void Settings_BalloonsTypes_Page_ElementClick(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.Settings_BalloonsTypes_Page);
        }
    }
}
