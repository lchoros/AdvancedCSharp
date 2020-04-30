using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] record = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = record[0];
                decimal grade = decimal.Parse(record[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                }
                studentGrades[name].Add(grade);
            }

            foreach (var student in studentGrades)
            {
                Console.Write("{0} -> ", student.Key);
                foreach (var grade in student.Value)
                {
                    Console.Write("{0:f2} ", grade);
                }
                Console.Write("(avg: {0:f2})", student.Value.Average());
                Console.WriteLine();
            }
        }
    }
}
