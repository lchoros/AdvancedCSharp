using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoaster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            ReadEmployees(n, employees);
            Print(employees);
        }

        static void Print(List<Employee> employees)
        {
            if (employees.Any())
            {
                var dep = employees.GroupBy(m => m.Department).Select(x => (Department: x.Key, Average: x.Average(m => m.Salary))).OrderByDescending(m=>m.Average).FirstOrDefault();
                Console.WriteLine($"Highest Avergae Salary: { dep.Department }");
                foreach (var empl in employees.Where(m => m.Department == dep.Department).OrderByDescending(m => m.Salary))
                {
                    Console.WriteLine($"{empl.Name} {empl.Salary:f2} {empl.Email} {empl.Age}");
                }
            }
        }

        static void ReadEmployees(int numberOfEmployees, List<Employee> employees)
        {
            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                var employee = new Employee(name, salary, position, department);
                employee.Email = "n/a";
                employee.Age = -1;
                if (input.Length == 5)
                {
                    if (input[4].Contains("@"))
                    {
                        employee.Email = input[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(input[4]);
                    }
                }
                else if (input.Length == 6)
                {
                    employee.Email = input[4];
                    employee.Age = int.Parse(input[5]);
                }
                employees.Add(employee);
            }
        }
    }
}
