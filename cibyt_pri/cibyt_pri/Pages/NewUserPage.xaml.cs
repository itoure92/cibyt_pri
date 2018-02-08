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

namespace cibyt_pri.Pages
{
    /// <summary>
    /// Logique d'interaction pour NewUserPage.xaml
    /// </summary>
    public partial class NewUserPage : Page
    {
        public NewUserPage()
        {
            InitializeComponent();
        }

        //Create a new account for a user - Store all information to the DB
        private void Create_Account_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            ((WindowViewModel)WindowViewModel.GetWindow().DataContext).CurrentPage = PageType.Login;
            ((WindowViewModel)WindowViewModel.GetWindow().DataContext).OnPropertyChanged("CurrentPage");
        }
    }
}
