using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinalProjectClassLibrary;


namespace CSI124_Final_Project_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<UserAccount> _members = new List<UserAccount>();
        public MainWindow()
        {
            InitializeComponent();
            _members = Data.Accounts;
            //lbDebug.ItemsSource = Data.Accounts;   
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string password = TextPassword.Text;


            if (IsValidUser(name, password))          //if user name and password is valid login in to user and admin 
            {            

                if (Data._currentAccount.UserRole == UserRole.Admin)
                {
                    new Admin().Show();             //if user role is admin open admin interface
                }
                else if (Data._currentAccount.UserRole == UserRole.User)
                {
                    new User().Show();  //if user role is user open user interface
                }
            }
            else
            {
                MessageBox.Show("Please enter valid information.");
            }
        }


        public bool IsValidUser(string name, string password)    
        {
            foreach (var account in _members)
            {
                if(name == account.UserName && password == account.Password)
                {
                    Data._currentAccount = account;
                    return true;
                }
            }
            return false;
        }
    }
}
