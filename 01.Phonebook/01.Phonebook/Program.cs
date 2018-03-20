using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
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

                command = Console.ReadLine();
            }


           


        }
    }
}
