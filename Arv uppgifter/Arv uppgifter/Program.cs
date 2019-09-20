using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_uppgifter
{
    class Program
    {
        static void Main()
        {
            Shape shape;
            Console.WriteLine("Skriv in höjd och bred på triangeln/rektangeln.");
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            shape = new Triangle(width, height);
            Console.WriteLine("Triangle Area: " + shape.Area());
            Console.WriteLine("Triangle Circumference: " + shape.Circumference());

            shape = new Rectangle(width, height);
            Console.WriteLine("Rectangle Area: " + shape.Area());
            Console.WriteLine("Rectangle Circumference: " + shape.Circumference());
            Console.ReadLine();
        }
    }
}
