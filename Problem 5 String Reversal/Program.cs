using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World";
            char[] helloArray = hello.ToCharArray();
            Array.Reverse(helloArray);
            for(int i = 0; i<helloArray.Length; i++)
            {
                Console.Write(helloArray[i]);
            }
            Console.ReadLine();
        }
    }
}
