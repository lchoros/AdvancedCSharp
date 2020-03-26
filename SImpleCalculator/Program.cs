using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> expression = new Stack<string>(Console.ReadLine().Split(' ').Reverse());

            while (expression.Count > 1)
            {
                int a = int.Parse(expression.Pop());
                char operand = char.Parse(expression.Pop());
                int b = int.Parse(expression.Pop());
                switch (operand)
                {
                    case '+':
                        expression.Push((a + b).ToString());
                        break;
                    case '-':
                        expression.Push((a - b).ToString());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(expression.Pop());
        }
    }
}
