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

namespace practise
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            Delete d=new Delete();
            this.NavigationService.Navigate(d);
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            Search ss=new Search();
            this.NavigationService.Navigate(ss);
        }
    }
}
