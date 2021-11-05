using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10_Next_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number you wish to find the next prime number from");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            Console.WriteLine(number);
            Console.WriteLine(number);
            number++;
            while (IsPrime(number) == false)
            {
                number++;
            }
            Console.WriteLine("{0} is the next prime number up from the one you inputted",number);
            Console.ReadLine();
        }
        public static Boolean IsPrime(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            if (x <= 3)
            {
                return true;
            }
            if (x % 2 == 0 || x % 3 == 0)
            {
                return false;
            }
            else
            {
                for(int i = 5; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0 || x % (i+2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
    }
}
