using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParrty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();


            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    guests.Add(input);
                }
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }

            int guestsCount = guests.Count();
            int vipGuestsCount = vipGuests.Count();

            Console.WriteLine(guestsCount + vipGuestsCount);
            if (vipGuestsCount > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipGuests));
            }

            if (guestsCount > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, guests));
            }
        }
    }
}
