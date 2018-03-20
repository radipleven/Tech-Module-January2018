using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(0x)?([0-9]|[A-F])+\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            var matchedPhones = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();


            Console.WriteLine(string.Join(" ", matchedPhones));


            //Console.WriteLine(string.Join(" ", matches));

        }
    }
}
