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

namespace ModernUINavigationApp1.Pages
{
    /// <summary>
    /// Interaction logic for Entreprise.xaml
    /// </summary>
    public partial class Entreprise : UserControl
    {
        public Entreprise()
        {
            InitializeComponent();
        }

        private void ButtonModifier_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            Entreprise page = new Entreprise();
            nav.Navigate(page); 
        }
    }
}
