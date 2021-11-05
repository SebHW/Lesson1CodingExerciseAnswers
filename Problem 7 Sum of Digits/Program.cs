using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number the digits of which you wish to sum:");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            int total = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                total = total + digit;
                number = number / 10;
            }
            Console.WriteLine("The total is {0}", total);
            Console.ReadLine();
        }
    }
}
