// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            // Collect user values until the value is an empty string
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // Move the initial prompt inside the loop, so it repeats for each employee
                Console.WriteLine("Please enter a name : (leave empty to exit): ");

                // change input to firstName
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }

                // add a Console.ReadLine() for each value
                Console.WriteLine("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();
                // Create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                // Add currentEmployee, not a string
                employees.Add(currentEmployee);
            }
            // This is important! It will return a List of strings
            return employees;
        }
        static void PrintEmployees(List<Employee> employees)
        {
            // I will print each employee name to the console until the employee count is less than 0
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = GetEmployees();
            // This is our employee-printing code that takes in the employee list created above
            PrintEmployees(employees);


            // ================================= Intro to C# ===================================== //

            // Console.WriteLine("Hello, World!");

            // // Data Types
            // // Strings
            // string greeting = "Hello";
            // greeting = greeting + " World";
            // Console.WriteLine("greeting: " + greeting);

            // // String Interpolation
            // Console.WriteLine($"greating {greeting}");
            // Console.WriteLine("greeting: {0}", greeting);

            // // Numbers
            // // How do you find the area of a square? Area = side * side
            // double side = 3.14;
            // double area = (side * side);
            // Console.WriteLine("area: {0}", area);
            // Console.WriteLine("area: {0}", area.GetType());

            // // Math Operators

            // Console.WriteLine(2 * 3); // 6  // Basic Arithmetic: +, -, /, *
            // Console.WriteLine(10 % 3); // 1  // Modulus Op => remainder of 10/3
            // Console.WriteLine(1 + 2 * 3); // 7  // order of operations
            // Console.WriteLine(10 / 3.0); // 3.333333  // int's and doubles
            // Console.WriteLine(10 / 3); // 3  // int's
            // Console.WriteLine("12" + "3"); // 123  // What happens here?

            // int num = 10;
            // num += 100; // 10 + 100 = 110
            // Console.WriteLine(num); // 110
            // num++; // 110 + 1 = 111
            // Console.WriteLine(num); // 111

            // // Booleans

            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice"); // output: drink
            // Console.WriteLine(!isCold ? "drink" : "add ice"); // output: add ice

            // // Data Type Conversions

            // string stringNum = "2";
            // Console.WriteLine(stringNum.GetType()); // System.String
            // int newInt = Convert.ToInt16(stringNum);
            // Console.WriteLine(newInt.GetType()); // System.Int32
            // Console.WriteLine(newInt + newInt); // 4

            // // Data Structures

            // // Dictionaries

            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();

            // myScoreBoard.Add("firstInning", 10);
            // myScoreBoard.Add("secondInning", 20);
            // myScoreBoard.Add("thirdInning", 30);
            // myScoreBoard.Add("fourthInning", 40);
            // myScoreBoard.Add("fifthInning", 50);

            // // Alternative example of how you can pass a comma-separated list of key-value pairs in braces,
            // // for each entry we wish to create
            // Dictionary<string, int> myScoreBoard2 = new Dictionary<string, int>(){
            //     { "firstInning", 10 },
            //     { "secondInning", 20},
            //     { "thirdInning", 30},
            //     { "fourthInning", 40},
            //     { "fifthInning", 50}
            // };

            // Console.WriteLine("----------------");
            // Console.WriteLine("  Scoreboard");
            // Console.WriteLine("----------------");
            // Console.WriteLine("Inning |  Score");
            // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

            // // Arrays

            // string[] favFoods = new String[3]{ "pizza", "doughnuts", "icecream" };
            // string firstFood = favFoods[0];
            // string secondFood = favFoods[1];
            // string thirdFood = favFoods[2];
            // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

            // // Lists

            // List<string> employees = new List<string>() { "Genesis", "Carson" };

            // employees.Add("Hendrix");
            // employees.Add("Jaxx");
            // employees.Add("Lana");

            // Console.WriteLine("My employees include {0}, {1}, {2}, {3}, {4}.", employees[0], employees[1], employees[2], employees[3], employees[4]);

            // // Loops

            // for (int i = 0; i < employees.Count; i++) {
            //     Console.WriteLine(employees[i]);
            // }
        }
    }
}
