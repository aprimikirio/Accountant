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
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void ChkBxPubPos_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkPblPsNme.Foreground = Brushes.Black;
            TxtBlkPblPsNte.Foreground = Brushes.Black;
        }

        private void ChkBxPubPos_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtBlkPblPsNme.Foreground = Brushes.Gray;
            TxtBlkPblPsNte.Foreground = Brushes.Gray;
        }

        private void ChkBxPrvlg_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkPrvlgNme.Foreground = Brushes.Black;
            TxtBlkPrvlgNte.Foreground = Brushes.Black;
        }

        private void ChkBxPrvlg_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtBlkPrvlgNme.Foreground = Brushes.Gray;
            TxtBlkPrvlgNte.Foreground = Brushes.Gray;
        }        

        private void ChkBxQlf_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkAcdmDgr.Foreground = Brushes.Black;
            TxtBlkScntRnk.Foreground = Brushes.Black;
        }

        private void ChkBxQlf_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtBlkAcdmDgr.Foreground = Brushes.Gray; 
            TxtBlkScntRnk.Foreground = Brushes.Gray;
        }

        private void ChkBxPrvAc_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkHmCty.Foreground = Brushes.Black;
            TxtBlkHmStrt.Foreground = Brushes.Black;
            TxtBlkHmNmbr.Foreground = Brushes.Black;
            TxtBlkApNmbr.Foreground = Brushes.Black;
        }

        private void ChkBxPrvAc_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtBlkHmCty.Foreground = Brushes.Gray;
            TxtBlkHmStrt.Foreground = Brushes.Gray;
            TxtBlkHmNmbr.Foreground = Brushes.Gray;
            TxtBlkApNmbr.Foreground = Brushes.Gray;
        }

        private void ChkBxFUniv_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkBUHmCty.Foreground = Brushes.Black;
            TxtBlkBUHmStrt.Foreground = Brushes.Black;
            TxtBlkBUHmNmbr.Foreground = Brushes.Black;
            TxtBlkBUApNmbr.Foreground = Brushes.Black;
            TxtBlkBUDate.Foreground = Brushes.Black;
        }

        private void ChkBxFUniv_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtBlkBUHmCty.Foreground = Brushes.Gray;
            TxtBlkBUHmStrt.Foreground = Brushes.Gray;
            TxtBlkBUHmNmbr.Foreground = Brushes.Gray;
            TxtBlkBUApNmbr.Foreground = Brushes.Gray;
            TxtBlkBUDate.Foreground = Brushes.Gray;
        }

        private void ChkBxHstl_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkHstlNmb.Foreground = Brushes.Black;
            TxtBlkHstlRmNmb.Foreground = Brushes.Black;
        }

        private void ChkBxHstl_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtBlkHstlNmb.Foreground = Brushes.Gray;
            TxtBlkHstlRmNmb.Foreground = Brushes.Gray;
        }

        private void ChkBxDprt_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlkDprtmntalAdrs.Foreground = Brushes.Black;
            TxtBlkDprtmntalRmNmb.Foreground = Brushes.Black;
        }

        private void ChkBxDprt_Unchecked(object sender, RoutedEventArgs e)
        {

            TxtBlkDprtmntalAdrs.Foreground = Brushes.Gray;
            TxtBlkDprtmntalRmNmb.Foreground = Brushes.Gray;
        }
    }
}
