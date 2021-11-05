using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9_Prime_at_Nth_Pos
{
    class Program
    {
        static void Main(string[] args)
        {
            string primes = "2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97";
            string[] primeArray = primes.Split(',');
            Console.WriteLine("Please input the prime number you wish to find the next one up from");
            string prime = Console.ReadLine();
            int index = Array.IndexOf(primeArray, prime);
            Console.WriteLine("The next prime is {0}",primeArray[index + 1]);
            Console.ReadLine();
        }
    }
}
