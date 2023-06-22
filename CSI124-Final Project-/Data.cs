using FinalProjectClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace CSI124_Final_Project_
{
    internal class Data
    {
        public static UserAccount _currentAccount;
        private static List<UserAccount> _accounts = new List<UserAccount>();
        public static string userInformation = "members.json";

        public static List<UserAccount> Accounts { get => _accounts; }
        static string TransactionExtension = "_Transaction.csv";


        static Data()
        {
           LoadAccounts();
        }
        public static void Preload()  //Add user to account list;
        {
            _accounts.Add(new UserAccount("MeiliZheng", "meili", "meili123", UserRole.User));
            _accounts.Add(new UserAccount("Belle", "belle", "belle123", UserRole.User));
            _accounts.Add(new UserAccount("Claire", "claire", "claire123", UserRole.User));
            _accounts.Add(new UserAccount("Winnie", "winnie", "winnie123", UserRole.Admin));
            SaveAccounts();
        }

        public static string UserExercises()
        {
            return _currentAccount.Name + TransactionExtension;
        }
        public static void SaveAccounts()   //create a jso file
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonManager = JsonSerializer.Serialize(_accounts, jso);
            File.WriteAllText(Data.userInformation, jsonManager);
        }

        public static void LoadAccounts()
        {
            if (File.Exists(userInformation))
            {
                string listFromFile = File.ReadAllText(userInformation);
                _accounts = JsonSerializer.Deserialize<List<UserAccount>>(listFromFile);
            }
            else
            {
                Preload();
            }
        }
       
    }
}
