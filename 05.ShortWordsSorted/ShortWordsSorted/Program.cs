using System;
using System.Linq;
using System.Collections.Generic;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"\'\\/!? ".ToCharArray();

            string[] input = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine(string.Join(", ",input.Where(x => x.Length<5).Distinct().OrderBy(x=>x)));

        }
    }
}
