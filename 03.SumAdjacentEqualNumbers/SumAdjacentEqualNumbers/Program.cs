using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers[i] *= 2;
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
