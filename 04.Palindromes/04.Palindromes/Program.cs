using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] {'.',' ',',','!','?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> toPrint = new List<string>();

            foreach (var word in words)
            {
                if (word == ReverseString(word))
                {
                    toPrint.Add(word);
                }
            }
            toPrint.Sort();
            List<string> unique = toPrint.Distinct().ToList();
            Console.WriteLine(string.Join(", ",unique));

        }
        static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
