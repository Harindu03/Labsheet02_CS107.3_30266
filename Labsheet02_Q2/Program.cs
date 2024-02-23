using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet02_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount Acc1 = new BankAccount(1000);

            Console.WriteLine("Enter account number: ");
            Acc1.AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the deposited amount");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Acc1. deposit(depositAmount);
            Console.WriteLine("new balance is " + Acc1.Balance);

        }
    }
}
