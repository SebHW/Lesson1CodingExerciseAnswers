using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            string[] wordsArray = words.Split(',');
            for(int i = 0; i<wordsArray.Length; i++)
            {
                if (Anagram(wordsArray[i], "star") == true)
                {
                    Console.WriteLine("star and {0} are perfect anagrams", wordsArray[i]);
                }
                else
                {
                    Console.WriteLine("star and {0} are NOT perfect anagrams", wordsArray[i]);
                }
            }
            Console.ReadLine();
        }
        public static bool Anagram(string word1, string word2)
        {
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            char[] word1Array = word1.ToCharArray();
            char[] word2Array = word2.ToCharArray();

            ///Dictionary<int, char> alphabet = new Dictionary<int, char>()
            ///{
            ///    { 1, 'a' },{ 2, 'b' },{ 3, 'c' },{ 4, 'd' },{ 5, 'e' },{ 6, 'f' },{ 7, 'g' },{ 8, 'h' },{ 9, 'i' },{ 10, 'j' },{ 11, 'k' },{ 12, 'l' },{ 13, 'm' },{ 14, 'n' },{ 15, 'o' },{ 16, 'p' },
            ///    { 17, 'q' },{ 18, 'r' },{ 19, 's' },{ 20, 't' },{ 21, 'u' },{ 22, 'v' },{ 23, 'w' },{ 24, 'x' },{ 25, 'y' },{ 26, 'z' },
            ///};
            if (word2Array.Length == word1Array.Length)
            {
                Array.Sort(word1Array);
                Array.Sort(word2Array);
                int matchingLetters = 0;
                for(int i=0; i<= (word1Array.Length); i++)
                {
                    if (word1Array[i] == word2Array[i])
                    {
                        matchingLetters++;
                        if (matchingLetters == word1Array.Length)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
