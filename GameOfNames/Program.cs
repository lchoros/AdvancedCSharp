using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());

            Dictionary<string, int> leaderboard = new Dictionary<string, int>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                for (int letter = 0; letter < playerName.Length; letter++)
                {
                    int asciiCode = playerName[letter];
                    if (asciiCode % 2 == 0)
                    {
                        points += asciiCode;
                    }
                    else
                    {
                        points -= asciiCode;
                    }
                }
                leaderboard.Add(playerName, points);
            }
            var result = leaderboard.Aggregate((x, y) => x.Value > y.Value ? x : y);
            var result2 = leaderboard.OrderByDescending(m => m.Value).FirstOrDefault();
            Console.WriteLine("The winner is {0} - {1} points", result2.Key, result2.Value);
        }
    }
}
