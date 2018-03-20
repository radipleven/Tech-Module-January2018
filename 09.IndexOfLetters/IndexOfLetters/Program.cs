using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //KRATKO RESHENIE
            // string word = Console.ReadLine();
            // foreach (var element in word)
            //Console.WriteLine($"{element} -> {element - 'a'}");


            string word = Console.ReadLine();
            char[] letter = new char[word.Length];
            var count = 0;
            foreach (var element in word)
            {
                letter[count] = element;
                count++;
            }

            for (int i = 0; i < letter.Length; i++)
            {
                count = 0;
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (letter[i] == j)
                    {
                        Console.WriteLine($"{letter[i]} -> {count}");
                    }
                    count++;
                }
            }


        }
    }
}
