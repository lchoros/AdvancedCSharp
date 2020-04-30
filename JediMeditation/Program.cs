using System;
using System.Collections.Generic;
using System.Linq;

namespace JediMeditation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> jedis = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < input.Length; j++)
                {
                    jedis.Add(input[j]);
                }
            }
            var masters = jedis.Where(m => m[0] == 'm').ToList();
            var knights = jedis.Where(m => m[0] == 'k').ToList();
            var padawans = jedis.Where(m => m[0] == 'p').ToList();
            var toshkoSlav = jedis.Where(m => m[0] == 't' || m[0] == 's').ToList();
            var yodas = jedis.Where(m => m[0] == 'y').ToList();

            if(yodas.Any())
            {
                Console.Write($"{string.Join(" ", masters)} ");
                Console.Write($"{string.Join(" ", knights)} ");
                Console.Write($"{string.Join(" ", toshkoSlav)} ");
                Console.Write($"{string.Join(" ", padawans)}");
            }
            else
            {
                Console.Write($"{string.Join(" ", toshkoSlav)} ");
                Console.Write($"{string.Join(" ", masters)} ");
                Console.Write($"{string.Join(" ", knights)} ");
                Console.Write($"{string.Join(" ", padawans)} ");
            }
        }
    }
}
