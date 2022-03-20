﻿using Languages.page;
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

namespace Languages
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BaseClass.Base = new Entities();
            FrameClass.FrameMain = FrmMain;
        }

        private void GoAdmin_click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new AdminPage());


        }

        private void GoUsers_click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new UsersPage());
        }
    }
}
