using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var parentheses = Console.ReadLine();
            int inputLength = parentheses.Length;
            Dictionary<char, char> pairs = new Dictionary<char, char>();
            bool isBalanced = true;
            if (inputLength % 2 == 0)
            {
                int inputHalf = inputLength / 2;
                Queue<char> leftSide = new Queue<char>(parentheses.Skip(inputHalf));
                Stack<char> rightSide = new Stack<char>(parentheses.Take(inputHalf));

                while (true)
                {
                    char l = leftSide.Dequeue();
                    char r = rightSide.Pop();
                    if (pairs[l] != r)
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            else
            {
                isBalanced = false;
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
