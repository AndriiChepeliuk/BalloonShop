﻿using BalloonShop.Models.LatexBalloonType;
using BalloonShop.ViewModels;
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
    /// Interaction logic for LatexBalloons_Balloons_AddNew_Page.xaml
    /// </summary>
    public partial class LatexBalloons_Balloons_AddNew_Page : UserControl
    {
        public LatexBalloons_Balloons_AddNew_Page()
        {
            InitializeComponent();
        }

        public LatexBalloons_Balloons_AddNew_Page(LatexBalloonTypeModel balloobType)
        {
            InitializeComponent();

            var dataContext = DataContext as LatexBalloons_Balloons_AddNew_ViewModel;

            if (dataContext != null)
            {
                dataContext.BalloobType = balloobType;
            }
        }
    }
}
