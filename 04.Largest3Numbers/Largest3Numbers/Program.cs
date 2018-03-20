using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (numbers.Count<3)
            {
                Console.WriteLine(string.Join(" ",numbers.OrderByDescending(x => x)));
            }
            else
            {
                Console.Write(numbers.Max() + " ");
                numbers.Remove(numbers.Max());
                Console.Write(numbers.Max() + " ");
                numbers.Remove(numbers.Max());
                Console.WriteLine(numbers.Max());
                
            }

        }
    }
}
