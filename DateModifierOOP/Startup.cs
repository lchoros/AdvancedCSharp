using System;

namespace DateModifierOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFrom = Console.ReadLine();
            string dateTo = Console.ReadLine();
            var dateModifier = new DateModifier();
            Console.WriteLine(dateModifier.CalculateDateDifference(dateFrom, dateTo));
        }
    }
}
