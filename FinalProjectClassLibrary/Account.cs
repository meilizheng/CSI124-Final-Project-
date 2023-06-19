using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectClassLibrary
{
    public class Account
    {
        string _firstName;
        string _lastName;
        string _email;
        string _idNumber;
        string _phone;
        string _password;
        string _location;

        
        public Account() { }

        public Account(string firstName, string lastName, string email, string phone, string password, string location)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phone = phone;
            _password = password;
            _location = location;
        }

        public Account(string firstName, string lastName, string email, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string IdNumber { get => _idNumber; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Password { get => _password; set => _password = value; }
        public string Location { get => _location; set => _location = value; }

        public override string ToString()
        {
            return $"{_firstName} - {_email} - {_password}";
        }
    }

}
