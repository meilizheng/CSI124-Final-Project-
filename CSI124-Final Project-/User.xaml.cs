using FinalProjectClassLibrary;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Transaction = FinalProjectClassLibrary.Transaction;
using CsvHelper;
using System.Numerics;

namespace CSI124_Final_Project_
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Window
    {
        const string filePath = "transaction.csv";
        List<Transaction> loadedTransactions = new List<Transaction>();

        public User()
        {
            InitializeComponent();
            Preload();
            LoadCSVFile(filePath, loadedTransactions);

        }

        public void Preload()
        {
            List<Transaction> transactions = new List<Transaction>();    //create a new instance;
            {
                new Transaction("apple", 26);  //add new transaction
                new Transaction("egg", 34);
                new Transaction("flower", 56);
            };
            lvUserDisplay.ItemsSource = transactions;  //display transaction information in list view box.
            SaveCSVFile(filePath, transactions);
        }

        public void SaveCSVFile<T>(string filePath, List<T>list)   //create CSV file
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            using (var stream = File.Open(filePath, FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, ci))
            {
                csvWriter.WriteRecords(list);
                writer.Flush();
            }
        }


        public void LoadCSVFile(string filePath, List<Transaction> list)  //Load CSV file
        {
            using (StreamReader sr = new StreamReader(filePath))             
            {
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture);               
            }
        }

        private void btnAddTransaction_Click(object sender, RoutedEventArgs e)  //add new transaction;
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            DateTime dateTime = DateTime.Now;

            loadedTransactions.Add(new Transaction(name, price));
            lvUserDisplay.ItemsSource = loadedTransactions;
            lvUserDisplay.Items.Refresh();
        }

        private void btnExportNewCSV_Click(object sender, RoutedEventArgs e)  //save CSV file
        {
            SaveCSVFile(filePath, loadedTransactions);
        }

        private void btnPrice_Click(object sender, RoutedEventArgs e)   //sort price.
        {
            lvUserDisplay.Items.Refresh();
            lvUserDisplay.ItemsSource = loadedTransactions;
            loadedTransactions.Sort();
         
        }

        private void btnName_Click(object sender, RoutedEventArgs e)  //sort by name
        {
            lvUserDisplay.Items.Refresh();
            lvUserDisplay.ItemsSource = loadedTransactions;
            loadedTransactions.Sort();
        }

        private void btnTransactionTime_Click(object sender, RoutedEventArgs e)  //sort by time
        {
            lvUserDisplay.Items.Refresh();
            lvUserDisplay.ItemsSource = loadedTransactions;
            loadedTransactions.Sort();
        }

        private void btnSaveTransaction_Click(object sender, RoutedEventArgs e)
        {
            SaveCSVFile(filePath, loadedTransactions);
        }
    }
}
