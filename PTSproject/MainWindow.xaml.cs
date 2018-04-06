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

namespace PTSproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            UserData.GenerateTestUserData();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SessionWIndow sw = new SessionWIndow();

            string username = txbUserLogin.Text;
            string password = txbPassLogin.Text;

            LoginValidation val = new LoginValidation(username, password);
            User user = null;
            bool isLoginSuccessful = val.ValidateUserInput(ref user);

            if (isLoginSuccessful)
            {
                string pageType = null;
                    
                switch (user.userType)
                {
                    case UserType.ADMIN: pageType = "AdminPage.xaml"; sw.Title = "AdminSession"; break;
                    case UserType.SELLER: pageType = "SellerPage.xaml"; sw.Title = "SellerSession"; break;
                    case UserType.CUSTOMER: pageType = "CustomerPage.xaml"; sw.Title = "CustomerSession"; break;
                }

                sw.Source = new Uri(pageType, UriKind.Relative);
                
                this.Close();
                sw.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            SessionWIndow sw = new SessionWIndow();
            sw.Source = new Uri("AnonymousPage.xaml", UriKind.Relative);
            sw.Title = "AnonymousSession";
            this.Close();
            sw.Show();
        }
    }
}
