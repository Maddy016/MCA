using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving_Account acc = new Saving_Account();
            acc.Interest(100000,10.5);
            Console.ReadLine();
        }
        class BankAccount 
        {
            public BankAccount()
            {
                int Account_number = 5478613;
                double Balance =4887621.10;
            } 
        }
        sealed class Saving_Account : BankAccount
        {
           
            public void Interest(double Balance,double rate)
            {
                Console.WriteLine("Your Interest: "+(rate * Balance)); 
            }
        }
    }
}
