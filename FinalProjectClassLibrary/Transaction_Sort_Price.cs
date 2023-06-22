using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectClassLibrary
{
    internal class Transaction_Sort_Price : IComparer<Transaction>  //sort price
    {
        public int Compare(Transaction? x, Transaction? y)
        {
            return -(x.Total.CompareTo(y.Total));
        }
    }
}
