using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeCalculator
{
    class Program
    {
        static int start = 0;
        static int end = 100;
        static List<int> primes = new List<int>();

        static void Main(string[] args)
        {
            for (int i = start; i < end + 1; i++) // Populate list
                primes.Add(i);

            // Filter out non prime numbers
            primes = new List<int>(primes.Where(x => x % 2 != 0 || x == 2));
            primes = new List<int>(primes.Where(x => x % 3 != 0 || x == 3));
            primes = new List<int>(primes.Where(x => x % 5 != 0 || x == 5));
            primes = new List<int>(primes.Where(x => x % 7 != 0 || x == 7));
            primes = new List<int>(primes.Where(x => x % 11 != 0 || x == 11));
            primes = new List<int>(primes.Where(x => x % 13 != 0 || x == 13));
            
            // Print primes to console
            string output = "";
            for (int i = 0; i < primes.Count; i++)
                output += primes[i].ToString() + "\n";
            Console.WriteLine(output);
        }
    }
}
