using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //KODA NE RABOTI - DAVA 10/100
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sequenceLenth = new int[numbers.Length];
            sequenceLenth = FindLongestSequenceOfEqualElements(numbers, sequenceLenth);
            //Print result        
            int digit = sequenceLenth[0];
            for (int i = 0; i < sequenceLenth.Length; i++)
            {
                sequenceLenth[i] = digit;
            }
            Console.WriteLine(string.Join(" ", sequenceLenth));
        }
        static int[] FindLongestSequenceOfEqualElements(int[] numbers, int[] sequenceLenth)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var countHelper = 0;
                var count = 0;
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > countHelper)
                {
                    sequenceLenth = new int[count + 1];
                    sequenceLenth[0] = numbers[i];
                    countHelper = count;
                }
            }
            return sequenceLenth;
        }
    }
}
