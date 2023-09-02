using BalloonShop.Models.Color;
using BalloonShop.Services;
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
    /// Interaction logic for Settings_ColorSettings_Page.xaml
    /// </summary>
    public partial class Settings_ColorSettings_Page : UserControl
    {
        public Settings_ColorSettings_Page()
        {
            InitializeComponent();
        }

        private void addColorButton_Click(object sender, RoutedEventArgs e)
        {
            ColorModel newColor = new ColorModel();
            newColor.Name = "Red";
            newColor.RelatedProduct = "Defoult";

            ColorModelService.AddColor(newColor);
        }
    }
}
