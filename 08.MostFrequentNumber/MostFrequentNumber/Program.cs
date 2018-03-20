﻿using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var countHelper = 0;
            long digit = numbers[0];
            for (long i = 0; i < numbers.Length - 1; i++)
            {
                var count = 0;
                for (long j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count > countHelper)
                {
                    digit = numbers[i];
                    countHelper = count;
                }
            }
            Console.WriteLine(digit);
        }
    }
}
