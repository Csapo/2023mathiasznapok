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
using System.Windows.Shapes;

namespace mathiasznapok
{
    /// <summary>
    /// Interaction logic for name.xaml
    /// </summary>
    public partial class name : Window
    {
        public name()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            game g = new game();
            g.Show();
            this.Close();
        }
    }
}
