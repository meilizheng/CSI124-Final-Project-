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

        List<Account> _members = new List<Account>();
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            lbDebug.ItemsSource = _members;   
        }

        public void Preload()
        {
            _members.Add(new Account("Meili", "Zheng", "meilizheng@gmail.com", "meili"));
            _members.Add(new Account("Belle", "Miao", "bellemaio@gmail.com", "belle"));
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = textEmail.Text;
            string password = TextPassword.Text;

            if(IsValidUser(email, password))
            {
                new Workout().Show();
            }
            else
            {
                MessageBox.Show("Please entered a valid information");
            }
        }


        public bool IsValidUser(string email, string password)
        {
            foreach (var account in _members)
            {
                if(email == account.Email && password == account.Password)
                {
                    return true;
                }
            }
            return false;
        }

        private void lbDebug_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selected = (Account)lbDebug.SelectedItem;
            textEmail.Text = selected.Email;
            TextPassword.Text = selected?.Password;
        }
    }
}
