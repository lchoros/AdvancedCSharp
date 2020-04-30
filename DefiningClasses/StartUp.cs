using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> family = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                var person = new Person(name, age);
                family.Add(person);
            }

            var oldestPerson = family.FirstOrDefault(m => m.Age == family.Max(y => y.Age));

            foreach (var person in family.Where(m=>m.Age > 30).OrderBy(m=>m.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
