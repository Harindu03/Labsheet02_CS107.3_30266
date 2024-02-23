using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet02_Q2
{
    internal class BankAccount

    {
        public int AccountNumber;
        public double Balance;

        public BankAccount ( double InitialBal)
        {
            
            Balance = InitialBal;

        }
        public void deposit (double amount)
        {
            Balance += amount;
        }
    }
}
