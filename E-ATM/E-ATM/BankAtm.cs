using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ATM
{
    class BankAtm
    {
        private static int _balance = 0;
        public static string Name;
        

        public static void IncreaseBalance(int balance)
        {
            if (balance >= 0)
            {
                _balance += balance;
            }
        }

        public static void SetBalance(int balance)
        {
            if (balance >= 0)
            {
                _balance = balance;
            }
        }

        public static void DecreaseBalance(int balance)
        {
            if (balance >= 0)
            {
                _balance -= balance;
            }
        }

        public static int GetBalance()
        {
            return _balance;
        }
    }
}
