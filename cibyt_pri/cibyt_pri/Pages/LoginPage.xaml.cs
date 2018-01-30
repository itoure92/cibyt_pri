using System;
using System.Windows;
using System.Windows.Controls;

namespace cibyt_pri
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void sign_in_Click(object sender, RoutedEventArgs e)
        {
            if (verifyId_Password(this.login.Text, this.password.Password))
            {
                ((WindowViewModel)WindowViewModel.GetWindow().DataContext).CurrentPage = PageType.HomePage;
                ((WindowViewModel)WindowViewModel.GetWindow().DataContext).OnPropertyChanged("CurrentPage");
            }
            else
                MessageBox.Show("Uncorrect Login or Password - Try again");
            
        }

        //Verify the login and password of the user - use the database
        private Boolean verifyId_Password(string id, string password)
        {
            if (id.Equals("ibrah") && password.Equals("toure"))
                return true;
            return false;
        }

        private void sign_up_Click(object sender, RoutedEventArgs e)
        {
            ((WindowViewModel)WindowViewModel.GetWindow().DataContext).CurrentPage = PageType.NewUser;
            ((WindowViewModel)WindowViewModel.GetWindow().DataContext).OnPropertyChanged("CurrentPage");
        }

        //Ask for the mail address of the user and send him an email with a random password
        //He has to reconnect with the random password and has to change his old password
        private void Forget_password_Click(object sender, RoutedEventArgs e)
        {
            ((WindowViewModel)WindowViewModel.GetWindow().DataContext).CurrentPage = PageType.ForgetPasswordPage;
            ((WindowViewModel)WindowViewModel.GetWindow().DataContext).OnPropertyChanged("CurrentPage");
        }
    }
}
