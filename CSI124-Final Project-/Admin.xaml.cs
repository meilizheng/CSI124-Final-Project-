using FinalProjectClassLibrary;
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
using System.Windows.Shapes;

namespace CSI124_Final_Project_
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            PreloadComboBox();
        }

        public void PreloadComboBox()  //preload combo box;
        {
            cbRole.Items.Add("User");
            cbRole.Items.Add("Admin");
            cbRole.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)  //add admin 
        {
            string name = txtName.Text;
            string userName = txtUserName.Text;
           

            UserAccount userAccount = new UserAccount();  //create a new instance;
            userAccount.Name = name;
            userAccount.UserName = userName;
            if (cbRole.SelectedIndex == 1)   //if index 1 has been chosen user role is admin;
            {
                userAccount.UserRole = UserRole.Admin;
            }
            else
            {
                userAccount.UserRole= UserRole.User;  //else is user
            }
            lvAddUser.Items.Add(userAccount);
        }
    }
}
