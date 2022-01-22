namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Method declared as "static
        public static void PrintEmployee(List<Employee> employees)
        {
            // I will print each employee name to the console until the employee count is less than 0
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }
    }
}