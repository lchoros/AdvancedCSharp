using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            var stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals('('))
                {
                    stack.Push(i);
                    continue;
                }

                if (expression[i].Equals(')'))
                {
                    var startIndex = stack.Pop();
                    sb.AppendLine(expression.Substring(startIndex, i - startIndex + 1));
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
