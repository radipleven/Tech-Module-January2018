using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string dateStrings = Console.ReadLine();
            MatchCollection dates = Regex.Matches(dateStrings, pattern);

             foreach (Match date in dates)
             {
                 var day = date.Groups["day"].Value;
                 var month = date.Groups["month"].Value;
                 var year = date.Groups["year"].Value;
                 Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
             }


           
        }
    }
}
