using cibyt_pri.Pages;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cibyt_pri
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean isclicked = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string key = "sbShowLeftMenu";
            if (isclicked)
            {
                key = "sbShowLeftMenu";
                isclicked = false;
            }
            else
            {
                key = "sbHideLeftMenu";
                isclicked = true;
            }
            Storyboard sb = Resources[key] as Storyboard;
            sb.Begin(this.st_panel);
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Main.Content = new HomePage();
        }

        private void Profile_setting_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Main.Content = new ProfileSettingPage();
        }
    }
}
