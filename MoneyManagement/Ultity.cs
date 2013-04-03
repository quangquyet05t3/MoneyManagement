using System;

namespace MoneyManagement
{
    [Serializable]
    public static class Ultity
    {
        public enum Action : int
        {
            Deposit = 1,
            Withdraw = 2,
            Lend = 3,
            Borrow = 4
        }

        public enum DataType : int
        {
            Day = 1,
            Month = 2,
            Year = 3
        }

        public const int YearStart = 2012;
        public const int MonthStart = 1;
        public const int DayStart = 1;
    }
}
