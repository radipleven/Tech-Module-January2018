using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> results = new List<int>(100);
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    results.Add(numbers[i]);
                }
            }


            results.Reverse();
            if (results.Count == 0)
            {
                Console.WriteLine("empty");
            }      
            Console.WriteLine(string.Join(" ",results));

        }
    }
}
