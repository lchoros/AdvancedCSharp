using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //ction<string[]> printNames = new Action<string[]>(ConsolePrint);
            //printNames(input);

            Action<string> printAction = Console.WriteLine;
            input.ToList().ForEach(printAction);
        }

        //static void ConsolePrint(string[] names)
        //{
        //    Console.WriteLine(string.Join(Environment.NewLine, names));
        //}
    }
}
