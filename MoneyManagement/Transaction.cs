using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyManagement
{
    [Serializable]
    public class Transaction
    {
        public string TransactionID { get; set; }
        public int Action { get; set; }
        public int Amount { get; set; }
        public string Reason { get; set; }
        public DateTime Time { get; set; }

        public Transaction()
        {
            TransactionID = "";
            Action = (int)Ultity.Action.Deposit;
            Amount = -1;
            Reason = null;
            Time = DateTime.MinValue;
        }

        public Transaction(string p_TransactionID, Ultity.Action p_Action, int p_Amount, string p_Reason, DateTime p_Time)
        {
            TransactionID = p_TransactionID;
            Action = (int)p_Action;
            Amount = p_Amount;
            Reason = p_Reason;
            Time = p_Time;
        }
    }
}
