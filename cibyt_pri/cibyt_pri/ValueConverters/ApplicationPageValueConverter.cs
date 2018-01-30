using cibyt_pri.DataModel;
using cibyt_pri.Pages;
using System;
using System.Diagnostics;
using System.Globalization;

namespace cibyt_pri
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            //ApplicationPage page = (ApplicationPage)value;
            switch ((PageType)value)
            {
                case PageType.Login:
                    ((MainWindow)WindowViewModel.GetWindow()).setVisibilitySt_panel(false);
                    return new LoginPage();
                case PageType.HomePage:
                   ((MainWindow)WindowViewModel.GetWindow()).setVisibilitySt_panel(true);
                    return new HomePage();
                case PageType.GameSettingPage:
                    ((MainWindow)WindowViewModel.GetWindow()).setVisibilitySt_panel(true);
                    return new GameSettingPage();
                case PageType.ProfilSettingPage:
                    ((MainWindow)WindowViewModel.GetWindow()).setVisibilitySt_panel(true);
                    return new ProfileSettingPage();
                case PageType.NewUser:
                    ((MainWindow)WindowViewModel.GetWindow()).setVisibilitySt_panel(false);
                    return new NewUserPage();
                case PageType.ForgetPasswordPage:
                    ((MainWindow)WindowViewModel.GetWindow()).setVisibilitySt_panel(false);
                    return new ForgetPasswordPage();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}