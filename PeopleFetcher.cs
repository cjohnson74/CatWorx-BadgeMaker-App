using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class PeopleFetcher
    {
        // code from GetEmployees in Program.cs
        static List<Employee> GetEmployees()
        {
            // Collect user values until the value is an empty string
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // Move the initial prompt inside the loop, so it repeats for each employee
                Console.WriteLine("Please enter a first name : (leave empty to exit): ");

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
    }
}