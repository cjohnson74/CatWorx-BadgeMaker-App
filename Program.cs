// See https://aka.ms/new-console-template for more information
using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Data Types
            // Strings
            string greeting = "Hello";
            greeting = greeting + " World";
            Console.WriteLine("greeting: " + greeting);

            // String Interpolation
            Console.WriteLine($"greating {greeting}");
            Console.WriteLine("greeting: {0}", greeting);

            // Numbers
            // How do you find the area of a square? Area = side * side
            double side = 3.14;
            double area = (side * side);
            Console.WriteLine("area: {0}", area);
            Console.WriteLine("area: {0}", area.GetType());
        }
    }
}
