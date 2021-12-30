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
        }
    }
}
