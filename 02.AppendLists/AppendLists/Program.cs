using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

           List<string> separateLists = input.Split('|').ToList();
           

            separateLists.Reverse();
            foreach (var text in separateLists)
            {
                var textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var joined = string.Join(" ", textArr);
                Console.Write(joined + " ");
            }
            Console.WriteLine();

        }
    }
}
