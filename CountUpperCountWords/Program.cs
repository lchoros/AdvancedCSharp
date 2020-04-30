using System;
using System.Collections.Generic;
using System.Linq;

namespace CountUpperCountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                            .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Action<string> print = Console.WriteLine;
            Func<string, bool> upper = u => char.IsUpper(u[0]);

            Console.WriteLine(string.Join(Environment.NewLine, text
                .Where(w => char.IsUpper(w[0]))));
        }
    }
}
