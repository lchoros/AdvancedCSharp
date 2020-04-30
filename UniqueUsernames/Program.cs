using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> usernames = new List<string>();


            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, usernames.Distinct()));
        }
    }
}
