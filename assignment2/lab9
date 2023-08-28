using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.start_engine();
            car.stop_engine();
            Console.ReadLine();
        }
        class Vehicle
        {
            public void start_engine()
            {
                Console.WriteLine("Engine has started");
            }
            public void stop_engine()
            {
                Console.WriteLine("Engine has stopped");
            }
        }
        sealed class Car : Vehicle
        {
            public Car()
            {
                Console.WriteLine("car");

            }
        }
    }
}
