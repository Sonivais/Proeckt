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

namespace yyy
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ButtonRaner_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void ButtonSponsor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
