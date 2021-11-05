using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_TwoSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 5, 7, 5, 9 };
            Console.WriteLine("Please input the number you wish to check agains the array:");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("The indices in the array that sum to the number inputted are " + TwoSums(numbers, sum));
            Console.ReadLine();
        }
        public static Tuple<int,int> TwoSums(int[] list, int x)
        {
            for (int i = 0; i<list.Length; i++)
            {
                for (int j = i+1; j<list.Length; j++)
                {
                    if (list[i] + list [j] == x)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }
            return null;
        }
    }
}
