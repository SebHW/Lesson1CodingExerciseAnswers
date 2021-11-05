using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Star_Piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 5;
            for (int i = 0; i < height; i++)
            {
                int spaces = (height - 1 - i);
                int stars = (2 * i + 1);
                string resultSpaces = new String(' ', spaces);
                string resultStars = new String('*', stars);
                Console.WriteLine(resultSpaces + resultStars);
            }
            Console.ReadLine();
        }
    }
}
