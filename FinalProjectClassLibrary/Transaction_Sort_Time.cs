using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectClassLibrary
{
    internal class Transaction_Sort_Time
    {
        public int Compare(Transaction? x, Transaction? y)  //sort by time
        {
            return -(x.TranctionTime.CompareTo(y.TranctionTime));
        }
    }
}
