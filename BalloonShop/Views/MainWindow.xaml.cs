using System.Runtime.InteropServices;
using System;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace BalloonShop.Views
{
    public enum AppPages
    {
        App_LatexBalloons_Page,
        App_FoilBalloons_Page,
        App_Settings_Page,
        LatexBalloons_Hearts_Page,
        Settings_LatexBalloons_Page,
        Settings_LatexBalloons_BalloonsTypes_Page,
        Settings_LatexBalloons_BalloonsTypes_Add_Page,
        Settings_LatexBalloons_Colors_Page,
        Settings_FoilBalloons_Page,
        Settings_ColorSettings_Page,
        Settings_BalloonsTypes_Page,
        Settings_BalloonsTypes_Add_Page
    }

    public partial class MainWindow : Window
    {
        private MainWindow window;

        private Pages.App_LatexBalloons_Page app_LatexBalloons_Page = new Pages.App_LatexBalloons_Page();
        private Pages.App_FoilBalloons_Page app_FoilBalloons_Page = new Pages.App_FoilBalloons_Page();
        private Pages.App_Settings_Page app_Settings_Page = new Pages.App_Settings_Page();
        private Pages.LatexBalloons_Hearts_Page latexBalloons_Hearts_Page = new Pages.LatexBalloons_Hearts_Page();
        private Pages.Settings_LatexBalloons_Page settings_LatexBalloons_Page = new Pages.Settings_LatexBalloons_Page();
        private Pages.Settings_LatexBalloons_BalloonsTypes_Page settings_LatexBalloons_BalloonsTypes_Page = new Pages.Settings_LatexBalloons_BalloonsTypes_Page();
        private Pages.Settings_LatexBalloons_BalloonsTypes_Add_Page settings_LatexBalloons_BalloonsTypes_Add_Page = new Pages.Settings_LatexBalloons_BalloonsTypes_Add_Page();
        private Pages.Settings_LatexBalloons_Colors_Page settings_LatexBalloons_Colors_Page = new Pages.Settings_LatexBalloons_Colors_Page();
        private Pages.Settings_FoilBalloons_Page settings_FoilBalloons_Page = new Pages.Settings_FoilBalloons_Page();


        private Pages.Settings_ColorSettings_Page settings_ColorSettings_Page = new Pages.Settings_ColorSettings_Page();

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
                case AppPages.App_LatexBalloons_Page:
                    container.Content = app_LatexBalloons_Page = new();
                    titleText.Text = "Латексні кульки";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\icons8-hearts_balloons-60_grey.png", UriKind.Relative));
                    break;
                case AppPages.App_FoilBalloons_Page:
                    container.Content = app_FoilBalloons_Page = new();
                    titleText.Text = "Фольговані кульки";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\icons8-star-64_grey.png", UriKind.Relative));
                    break;
                case AppPages.App_Settings_Page:
                    container.Content = app_Settings_Page = new();
                    titleText.Text = "Налаштування";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\icons8-settings-50_grey.png", UriKind.Relative));
                    break;
                case AppPages.LatexBalloons_Hearts_Page:
                    container.Content = latexBalloons_Hearts_Page = new();
                    titleText.Text = "Латексні кульки серця";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\LatexBalloonsIcons\\LatexBalloons_Hearts_Icon.png", UriKind.Relative));
                    break;
                case AppPages.Settings_LatexBalloons_Page:
                    container.Content = settings_LatexBalloons_Page = new();
                    titleText.Text = "Налаштування для латексних кульок";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\SettingsIcons\\latex-balloons_settings_icon_grey.png", UriKind.Relative));
                    break;
                case AppPages.Settings_LatexBalloons_BalloonsTypes_Page:
                    container.Content = settings_LatexBalloons_BalloonsTypes_Page = new();
                    titleText.Text = "Типи латексних кульок";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\SettingsIcons\\balloon-types_grey.png", UriKind.Relative));
                    break;
                case AppPages.Settings_LatexBalloons_BalloonsTypes_Add_Page:
                    container.Content = settings_LatexBalloons_BalloonsTypes_Add_Page = new();
                    titleText.Text = "Додати новий тип латексних кульок";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\SettingsIcons\\balloon-types_grey.png", UriKind.Relative));
                    break;
                case AppPages.Settings_LatexBalloons_Colors_Page:
                    container.Content = settings_LatexBalloons_Colors_Page = new();
                    titleText.Text = "Доступні кольори для латексних кульок";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\SettingsIcons\\color-settings_grey.png", UriKind.Relative));
                    break;
                case AppPages.Settings_FoilBalloons_Page:
                    container.Content = settings_FoilBalloons_Page = new();
                    titleText.Text = "Налаштування для фольгованих кульок";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\SettingsIcons\\foil-balloons_settings_icon_grey.png", UriKind.Relative));
                    break;
                case AppPages.Settings_ColorSettings_Page:
                    container.Content = settings_ColorSettings_Page = new();
                    titleText.Text = "Виробники";
                    titleImage.Source = new BitmapImage(new Uri("\\Data\\Icons\\SettingsIcons\\icons8-manufacture-100.png", UriKind.Relative));
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
            window.ExecutePage(AppPages.App_LatexBalloons_Page);
        }

        private void ShowFoilBalloons_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.App_FoilBalloons_Page);
        }

        private void ShowSettings_Click(object sender, RoutedEventArgs e)
        {
            LoadWindow();
            window.ExecutePage(AppPages.App_Settings_Page);
        }
    }
}
