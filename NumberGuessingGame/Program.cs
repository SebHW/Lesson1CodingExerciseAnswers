using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int number = random.Next(1, 100);
            int guess = 0;
            int count = 6;
            while (number != guess)
            {
                Console.WriteLine("Please enter your guess between 1 and 99 inclusive, you have {0} guesses remaining", count);
                guess = int.Parse(Console.ReadLine());
                count--;
                if (guess > number)
                {
                    Console.WriteLine("Your guess was too large.");
                    if (count > 0)
                    {
                        Console.WriteLine("Have another guess.");
                    }
                }
                if (guess < number)
                {
                    Console.WriteLine("Your guess was too small.");
                    if (count > 0)
                    {
                        Console.WriteLine("Have another guess.");
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("After 6 guesses you didnt get it. Poor that. The number was {0}",number);
                    Console.ReadLine();
                    break;
                }
            }
            if (number == guess)
            {
                Console.WriteLine("Congrats you guessed correctly! The number was {0} and it only took you {1} guesses!", number, 6 - count);
                Console.ReadLine();
            }
        }
    }
}
