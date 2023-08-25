using System.Runtime.InteropServices;
using System;
using System.Windows;
using System.Windows.Interop;

namespace BalloonShop.Views
{
    public enum AppPages
    {
        FoilBalloons_Page, 
        LatexBalloons_Page, 
        LatexBalloons_WithImages_Page,
        LatexBalloons_WithoutImage_Page,
        LatexBalloons_SetsOfBalloons_Page,
        LatexBalloons_Hearts_Page
    }

    public partial class MainWindow : Window
    {

        private MainWindow window;

        private Pages.LatexBalloons_Page latexBalloons_Page = new Pages.LatexBalloons_Page();
        private Pages.FoilBalloons_Page foilBalloons_Page = new Pages.FoilBalloons_Page();
        private Pages.LatexBalloons_WithImages_Page latexBalloons_WithImages_Page = new Pages.LatexBalloons_WithImages_Page();
        private Pages.LatexBalloons_WithoutImage_Page latexBalloons_WithoutImage_Page = new Pages.LatexBalloons_WithoutImage_Page();
        private Pages.LatexBalloons_SetsOfBalloons_Page latexBalloons_SetsOfBalloons_Page = new Pages.LatexBalloons_SetsOfBalloons_Page();
        private Pages.LatexBalloons_Hearts_Page latexBalloons_Hearts_Page = new Pages.LatexBalloons_Hearts_Page();

        public MainWindow()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlControlBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void ExecutePage(AppPages page)
        {
            switch (page)
            {
                case AppPages.LatexBalloons_Page:
                    container.Content = latexBalloons_Page;
                    break;
                case AppPages.FoilBalloons_Page:
                    container.Content = foilBalloons_Page;
                    break;
                case AppPages.LatexBalloons_WithImages_Page:
                    container.Content = latexBalloons_WithImages_Page;
                    break;
                case AppPages.LatexBalloons_WithoutImage_Page:
                    container.Content = latexBalloons_WithoutImage_Page; 
                    break;
                case AppPages.LatexBalloons_SetsOfBalloons_Page:
                    container.Content = latexBalloons_SetsOfBalloons_Page;
                    break;
                case AppPages.LatexBalloons_Hearts_Page:
                    container.Content = latexBalloons_Hearts_Page;
                    break;
            }
        }

        private void LoadWindow()
        {
            if (window == null)
            {
                window = Window.GetWindow(App.Current.MainWindow) as MainWindow;
            }
        }

        private void ShowLatexBalloons_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.LatexBalloons_Page);
        }

        private void ShowFoilBalloons_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.FoilBalloons_Page);
        }
    }
}
