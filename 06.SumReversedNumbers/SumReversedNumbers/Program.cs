using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
          
           List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += ReverseInt(numbers[i]);
            }

            Console.WriteLine(sum);


        }
        static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
