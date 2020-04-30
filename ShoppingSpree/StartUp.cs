using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] allPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in allPeople)
            {
                string[] token = p.Split("=");
                string name = token[0];
                decimal money = decimal.Parse(token[1]);
                try
                {
                    var person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string[] allProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in allProducts)
            {
                string[] token = p.Split("=");
                string name = token[0];
                decimal cost = decimal.Parse(token[1]);
                try
                {
                    var product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] input = command.Split(" ");
                string name = input[0];
                string productName = input[1];
                var person = people.FirstOrDefault(m => m.Name == name);
                var product = products.FirstOrDefault(m => m.Name == productName);
                if (person != null && product != null)
                {
                    if (person.Money >= product.Cost)
                    {
                        person.Pay(product.Cost);
                        person.Bag.Add(productName);
                        Console.WriteLine($"{name} bought {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} can't afford {productName}");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var p in people)
            {
                if (p.Bag.Count > 0)
                {
                    Console.WriteLine($"{p.Name} - {string.Join(", ", p.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{p.Name} - Nothing bought");
                }
            }
        }
    }
}
