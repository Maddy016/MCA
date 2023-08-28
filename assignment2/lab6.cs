using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empl emp = new Empl();
            emp.salary();
            Console.ReadLine();

        }
        partial class Empl
        {
            string employee_name = "Mradul gupta";
            string emmployee_address = "Kidwai nagar kanpur";
            int employee_age = 23;
            string employee_profile = "Full Stack Developer";
        }
        partial class Empl
        {
            public void salary()
            {
                Console.WriteLine("Salary based on emp job profile and experience:");
                Console.WriteLine(employee_name + " salary is: 50000");
            }
        }
    }
}
