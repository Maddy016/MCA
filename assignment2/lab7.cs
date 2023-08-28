using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle { radius = 5 };
            Rectangle rec = new Rectangle { width =6,height=4};
            Console.WriteLine("Circle Area: " + cir.Calculate_Area());
            Console.WriteLine("Rectangle Area: "+ rec.Calculate_Area());
        }
        abstract class Shape
        {
            public abstract double Calculate_Area();
        }
        class Circle : Shape
        {
            public double radius
            {
                get; set;
            }
            public override double Calculate_Area()
            {
                return Math.PI*radius*radius;
            }
        }
        class Rectangle : Shape
        {
            public double width 
            {
                get; set;
            }
            public double height
            {
                get; set;
            }
            public override double Calculate_Area()
            {
                return width * height;
            }
        }
    }
}
