using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(200);
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bomb[0]==numbers[i])
                {
                    if (true)
                    {
                        numbers.RemoveRange(i - bomb[1], bomb[1]);
                    }
                    numbers.RemoveRange(i, bomb[1]);
                    numbers.Remove(bomb[0]);
               }
                
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
