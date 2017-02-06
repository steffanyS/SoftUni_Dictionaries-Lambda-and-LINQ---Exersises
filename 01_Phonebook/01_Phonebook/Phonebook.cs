using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            var input = Console.ReadLine().Split(' ').ToList();

            while (input[0] != "END")
            {
                if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }

                if (input[0] == "A")
                {
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        phonebook.Add(input[1], input[2]);
                    }
                    else
                    {
                        phonebook[input[1]] = input[2];
                    }
                }

                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
