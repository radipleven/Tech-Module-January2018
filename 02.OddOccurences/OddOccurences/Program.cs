using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var num in words)                   
            {                                            
                if (counts.ContainsKey(num))                
                {                                          
                    counts[num]++;                          
                }
                else
                {
                    counts[num] = 1;
                }
            }
            List<string> results = new List<string>();

            foreach (var x in counts.Keys)
            {
                
                if (counts[x] % 2 != 0)
                {                   
                    results.Add(x);                              
                }                                                                       

            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
