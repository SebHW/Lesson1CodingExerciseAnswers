using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sales = "1,2,1,1,0,3,1,0,0,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0,0,0,0,0,0,0,0,0";
            string[] salesArray = sales.Split(',');
            Console.WriteLine(LongestSequence(salesArray));
            Console.ReadLine();
        }
        public static int LongestSequence(string[] x)
        {
            int longestSequence = 0;
            int count = 0;
            string currentChar;
            string previousChar;
            for (int i = 1; i < x.Length; i++)
            {
                currentChar = x[i];
                previousChar = x[i - 1];
                if (previousChar == currentChar)
                {
                    count++;
                }
                if (count > longestSequence)
                {
                    longestSequence = count + 1;
                }
                if (currentChar != previousChar)
                {
                    count = 0;
                }
            }
            return longestSequence;
        }
    }
}
