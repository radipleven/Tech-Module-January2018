using System;
using System.Text;
using System.Collections.Generic;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(' ');
            string text = Console.ReadLine();
            
            
            foreach (var banWord in banWords)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(text);

        }
    }
}
