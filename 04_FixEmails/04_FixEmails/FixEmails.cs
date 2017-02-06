using System;
using System.Collections.Generic;

namespace _04_FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();


            while (name != "stop")
            {
                var email = Console.ReadLine();
                if (!((email[email.Length-1] == 'k' || email[email.Length-1] == 's') && email[email.Length - 2] == 'u'))
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }

            foreach (var names in emails)
            {
                Console.WriteLine("{0} -> {1}", names.Key, names.Value);
            }
        }
    }
}
