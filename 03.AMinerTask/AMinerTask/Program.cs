using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (command != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resources.Keys.Contains(command) == false)
                {
                    resources.Add(command,quantity);
                }
                else
                {
                    resources[command] += quantity;
                }
                command = Console.ReadLine();
                
            }
            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key,item.Value);
            }
        }
    }
}
