using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyManagement
{
    [Serializable]
    public class Data
    {
        public int Year { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Data()
        {
            Year = -1;
            Transactions = new List<Transaction>();
        }

        public Data(Data p_Data)
        {
            Year = p_Data.Year;
            Transactions = p_Data.Transactions;
        }

        public Data(int p_Year, List<Transaction> p_Transactions)
        {
            Year = p_Year;
            Transactions = p_Transactions;
        }
    }
}
