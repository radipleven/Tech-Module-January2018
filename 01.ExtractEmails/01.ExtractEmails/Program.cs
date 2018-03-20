using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\s{1}[0-9A-Za-z]+-*(\.)*(\w+-*)@(\w+(-\w+)*)(\.\w+)+\b(?<=\w)*";
            MatchCollection matches = Regex.Matches(input, pattern);


            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
