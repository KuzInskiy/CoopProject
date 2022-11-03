using CoopProject.Models;
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
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        Frame mainFrame;
        public RegistrationPage(Frame frame)
        {
            InitializeComponent();
            mainFrame = frame;
            
        }

        private void RegBTN_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text != null && PasswordTB.Text != null && RepeatPasswordTB.Text != null && PasswordTB.Text == RepeatPasswordTB.Text)
            {
                try
                {
                    Account account = new Account
                    {
                        Login = LoginTB.Text,
                        Password = PasswordTB.Text,
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AuthorizationPage());
        }
    }
}
