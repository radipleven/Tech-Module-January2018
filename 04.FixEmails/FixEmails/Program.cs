using System;
using System.Linq;
using System.Collections.Generic;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Dictionary<string, string> peopleMails = new Dictionary<string,string>();
            while (name != "stop")
            {
                string email = Console.ReadLine().ToLower();
                peopleMails.Add(name, email);


                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    peopleMails.Remove(name);
                }
                name = Console.ReadLine();

            }
            foreach (var person in peopleMails)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
