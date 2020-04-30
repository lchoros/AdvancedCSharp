using System;

namespace CoordinatesFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            char[] specialCharacters = new char[] { '!', '@', '#', '$', '?' }; 
            while (command != "Last note")
            {
                string[] tokens = command.Split(new string[] { "=", "<<" }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string peekName = tokens[0];
                    if (int.TryParse(tokens[1], out int peekLength))
                    {

                    }

                }

                command = Console.ReadLine();

            }
        }
    }
}
