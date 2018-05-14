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
using Xceed.Wpf.Toolkit;

namespace WRK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ViceMainWindow : Window
    {
        public ViceMainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 3;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 4;
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 5;
        }
        private void Srch_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 6;
        }

        private void Acs_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 7;
        }
        private void Log_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 8;
        }
        private void Added_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedIndex = 9;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        
    }
}
