using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();

            string pattern = @"\+359([-|\s])2\1[\d]{3}\1[\d]{4}\b";
            MatchCollection matches = Regex.Matches(input, pattern);                                               
            Console.WriteLine(string.Join(", ", matches));

        }
    }
}
