using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhoneBookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
            //A stoi za ADD 
            while (command != "END")                                                                                // S stoi za PRINT
            {
                string[] neshta = command.Split(' ').ToArray();

                if (neshta[0] == "A")  // ako purvoto neshto e A
                {
                    phoneBook[neshta[1]] = neshta[2];           //Nakov = 0888086935 deklariram vuv phonebook
                }
                else if (neshta[0] == "S") // ako purvoto neshto e S koeto znachi da printiram
                {
                    if (phoneBook.ContainsKey(neshta[1])) //ako phonebook ima takuv kluch koito sum podal zaqvka da se PRINTIRA
                    {

                        Console.WriteLine("{0} -> {1}", neshta[1], phoneBook[neshta[1]]); //go printiram zaedno s negovoto value
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", neshta[1]); // inache kazvam che nqma takuv
                    }

                }
                if (command == "ListAll")
                {
                    foreach (var pair in phoneBook)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
