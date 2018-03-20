using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
                
       
        }
    }
}
