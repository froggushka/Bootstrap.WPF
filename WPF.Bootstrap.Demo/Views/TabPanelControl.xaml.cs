﻿using System;
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
using WPF.Bootstrap.Demo.ViewModels;

namespace WPF.Bootstrap.Demo.Views
{
    /// <summary>
    /// Interaction logic for TabPanelControl.xaml
    /// </summary>
    public partial class TabPanelControl : UserControl
    {
        public TabPanelControl()
        {
            InitializeComponent();

            DataContext = new TabInPanelViewModel();
        }
    }
}
