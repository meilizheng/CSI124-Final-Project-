using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProjectClassLibrary
{
    public enum UserRole { Admin, User }  //use enum create a usre role field
    public class UserAccount
    {
        string _name;          //create field
        string _userName;
        string _password;

        public UserAccount() { }  //defualt constructor;

        public UserAccount(string name, string userName, string password, UserRole userRole)  //create property
        {
            _name = name;
            _userName = userName;
            _password = password;
            UserRole = userRole;
        }

        

        public string Name { get => _name; set => _name = value; }   //creat property
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public UserRole UserRole { get; set ; }

        public override string ToString()
        {
            return $"{_name} - {_password}";
        }
    }
}
