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

            // Math Operators

            Console.WriteLine(2 * 3); // 6  // Basic Arithmetic: +, -, /, *
            Console.WriteLine(10 % 3); // 1  // Modulus Op => remainder of 10/3
            Console.WriteLine(1 + 2 * 3); // 7  // order of operations
            Console.WriteLine(10 / 3.0); // 3.333333  // int's and doubles
            Console.WriteLine(10 / 3); // 3  // int's
            Console.WriteLine("12" + "3"); // 123  // What happens here?

            int num = 10;
            num += 100; // 10 + 100 = 110
            Console.WriteLine(num); // 110
            num ++; // 110 + 1 = 111
            Console.WriteLine(num); // 111
        }
    }
}
