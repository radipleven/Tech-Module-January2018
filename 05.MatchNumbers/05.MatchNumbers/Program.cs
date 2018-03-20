using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
            string dateStrings = Console.ReadLine();
            MatchCollection dates = Regex.Matches(dateStrings, pattern);

             foreach (Match date in dates)
             {
                 
                 Console.Write(date + " ");
             }

            
        }
    }
}
