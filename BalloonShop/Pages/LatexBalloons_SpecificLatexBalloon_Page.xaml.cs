﻿using BalloonShop.Models.LatexBalloon;
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
    /// Interaction logic for LatexBalloons_SpecificLatexBalloon_Page.xaml
    /// </summary>
    public partial class LatexBalloons_SpecificLatexBalloon_Page : UserControl
    {
        public LatexBalloons_SpecificLatexBalloon_Page()
        {
            InitializeComponent();
        }
        public LatexBalloons_SpecificLatexBalloon_Page(LatexBalloonModel latexBalloon)
        {
            InitializeComponent();

            var dataContext = DataContext as LatexBalloons_SpecificLatexBalloon_ViewModel;

            if (dataContext != null)
            {
                dataContext.LatexBalloon = latexBalloon;
            }
        }
    }
}
