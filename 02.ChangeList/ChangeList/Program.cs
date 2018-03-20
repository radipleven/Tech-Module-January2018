using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = new string[2];
             command = Console.ReadLine().Split().ToArray();

            while (command[0]!="Odd"&&command[0]!="Even")
            {
                int element = int.Parse(command[1]);
                
                if (command[0]== "Delete")
                {
                    numbers.RemoveAll(item => item == element);

                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, element);                   
                }
                command = Console.ReadLine().Split().ToArray();
            }
            if (command[0] == "Even")
            {
                foreach (var item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            else if (command[0] == "Odd")
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
