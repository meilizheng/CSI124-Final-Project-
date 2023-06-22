using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectClassLibrary
{
    public class Transaction : IComparable<Transaction>
    {
        List<Transaction> _transactions;  //creat filed
        DateTime _tranctionTime;
        string _name;
        decimal _price;
        decimal _tax;
        decimal _total;

        public DateTime TranctionTime { get => _tranctionTime; set => _tranctionTime = value; }  //create instructor;
        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        public decimal Total { get => _total; set => _total = value; }

        public Transaction(string name, decimal price) //create property
        {
            _name = name;
            _price = price;
        }

        public Transaction() { }  //defual property;

        public int CompareTo(Transaction other)  //compare price;
        {
            if (this._price < other._price)
            {
                return -1;
            }
            else if (this._price > other._price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void TotalPrice()  //caltulate total price;
        {
            Total = Price + Price * 1.10m;

        }
    }
}
