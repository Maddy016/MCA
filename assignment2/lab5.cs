using System;
using ns;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            perFirstName = "Mradul";
            per.LastName = "Gupta";
            per.PrintFullName();
        }
        public partial class Person

        {
            public void PrintFullName()
            {
                Console.WriteLine($"{FirstName}{LastName}");
            }
        }

    }
}
