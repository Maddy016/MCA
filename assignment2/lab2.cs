using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankaccount account = new Bankaccount();
            account.display();
            Console.ReadLine();
        }
        public class Bankaccount
        {
            double account_number;
            string account_holdername;
            double account_balance = 10000;          
            double addmoney = 60000;
            double withdrawalmoney = 2000;
            public void deposit()
            {
                account_balance += addmoney;
            }
            public void withdrawal()
            {
                account_balance -= withdrawalmoney;
            }
            public void display()
            {
                Console.WriteLine("Add money to your account: " + addmoney);
                Console.WriteLine("deducted money to your account: " + withdrawalmoney);
                Console.WriteLine("Money after depositing: " + (account_balance + addmoney));
                Console.WriteLine("Money after withdrawal: " + (account_balance - withdrawalmoney));
            }
        }
    }
}
