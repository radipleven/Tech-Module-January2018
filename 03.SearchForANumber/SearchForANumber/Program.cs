using System;
using System.Collections.Generic;
using System.Linq;


namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();  //1 2 3 4 5 6 //numbers.Count = 6;
            int[] manipulator = Console.ReadLine().Split().Select(int.Parse).ToArray(); //5 2 3
           
            numbers.RemoveRange(manipulator[0],numbers.Count-manipulator[0]);
             for (int i = 0 ; i < manipulator[1]; i++)
             {
                 numbers.RemoveAt(0);
             }
           
           
            

           if (numbers.Contains(manipulator[2]))
           {
               Console.WriteLine("YES!");
           }else if (!numbers.Contains(manipulator[2]))
           {
               Console.WriteLine("NO!");
           }

        }
    }
}
