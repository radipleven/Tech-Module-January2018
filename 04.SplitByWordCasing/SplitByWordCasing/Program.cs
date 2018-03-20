using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
               .Split(new char[] {   ',',';',':','.','!','(',')','\"','/','\\','[',']' ,'\'', ' ' },
               StringSplitOptions.RemoveEmptyEntries).ToList();


            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                string currentWord = text[i];
                int lowerCaseLetters = 0;
                int upperCaseLetters = 0;

                foreach (char letter in currentWord)
                {
                    if (letter >= 65 && letter <= 90)
                    {
                        upperCaseLetters++;
                    }
                    else if (letter >= 97 && letter <= 122)
                    {
                        lowerCaseLetters++;
                    }
                }
                if (lowerCaseLetters == currentWord.Length)
                {
                    lowerCase.Add(currentWord);
                }
                else if (upperCaseLetters == currentWord.Length)
                {
                    upperCase.Add(currentWord);
                }
                else
                {
                    mixedCase.Add(currentWord);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
