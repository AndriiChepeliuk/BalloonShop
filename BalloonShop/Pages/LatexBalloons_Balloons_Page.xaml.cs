using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using BalloonShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for LatexBalloons_Balloons_Page.xaml
    /// </summary>
    public partial class LatexBalloons_Balloons_Page : UserControl
    {
        public LatexBalloons_Balloons_Page()
        {
            InitializeComponent();
        }

        public LatexBalloons_Balloons_Page(LatexBalloonTypeModel balloobType, ObservableCollection<LatexBalloonModel> latexBalloonsOfSpecificType)
        {
            InitializeComponent();

            var dataContext = DataContext as LatexBalloons_Balloons_ViewModel;

            if (dataContext != null)
            {
                dataContext.LatexBalloonType = balloobType;
                dataContext.LatexBalloons = latexBalloonsOfSpecificType;
            }

            GC.Collect();
        }

        private void ShowSpecificLatexBalloon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var dataContext = DataContext as LatexBalloons_Balloons_ViewModel;

            if (dataContext != null)
            {
                dataContext.ShowSpecificLatexBalloon_PageCommand.Execute(this);
            }
        }
    }
}
