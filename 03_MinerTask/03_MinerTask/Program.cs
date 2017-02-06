using System;
using System.Collections.Generic;

namespace _03_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string input = Console.ReadLine();


            while (input != "stop")
            {
                if (resourses.ContainsKey(input))
                {
                    resourses[input] += int.Parse(Console.ReadLine());
                }
                else
                {
                    resourses.Add(input, int.Parse(Console.ReadLine()));
                }
                input = Console.ReadLine();
            }

            foreach (var resourse in resourses)
            {
                Console.WriteLine("{0} -> {1}", resourse.Key, resourse.Value);
            }
        }
    }
}
