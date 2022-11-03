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

namespace CoopProject.Pages
{
    /// <summary>
    /// Interaction logic for AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Frame mainFrame;
        public AuthorizationPage(Frame frame)
        {
            InitializeComponent();
            mainFrame = frame;
        }

        private void AuthBTN_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTB.Text != "" && PasswordTB.Text !="")
            {
             Models.Account account = context.cont.Accounts.Where(c => c.Login ==LoginTB.Text && c.Password == PasswordTB.Text).FirstOrDefault();
                if(account != null)
                {
                    MessageBox.Show("Успешная Авторизация");
                }

            }
        }

        private void ReturnBTN_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Pages.RegistrationPage(mainFrame));
        }
    }
}
