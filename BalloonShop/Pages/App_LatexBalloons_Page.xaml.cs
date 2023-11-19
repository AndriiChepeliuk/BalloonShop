using BalloonShop.ViewModels;
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
    /// Interaction logic for App_LatexBalloons_Page.xaml
    /// </summary>
    public partial class App_LatexBalloons_Page : UserControl
    {
        private MainWindow window;

        public App_LatexBalloons_Page()
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

        //private void LatexBalloons_WithImages_Page_ElementClick(object sender, RoutedEventArgs e)
        //{
        //    LoadWindow();
        //    window.ExecutePage(AppPages.LatexBalloons_WithImages_Page);
        //}

        //private void LatexBalloons_WithoutImage_Page_ElementClick(object sender, RoutedEventArgs e)
        //{
        //    LoadWindow();
        //    window.ExecutePage(AppPages.LatexBalloons_WithoutImage_Page);
        //}

        //private void LatexBalloons_SetsOfBalloons_Page_ElementClick(object sender, RoutedEventArgs e)
        //{
        //    LoadWindow();
        //    window.ExecutePage(AppPages.LatexBalloons_SetsOfBalloons_Page);
        //}

        //private void LatexBalloons_Hearts_Page_ElementClick(object sender, RoutedEventArgs e)
        //{
        //    LoadWindow();
        //    window.ExecutePage(AppPages.LatexBalloons_Hearts_Page);
        //}

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dataContext = DataContext as App_LatexBalloons_ViewModel;
            if (dataContext != null)
            {
                dataContext.AddNewBalloonTypeCommand.Execute(this);
            }
        }
    }
}
