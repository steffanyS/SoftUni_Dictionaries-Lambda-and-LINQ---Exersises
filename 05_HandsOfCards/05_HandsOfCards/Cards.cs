using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HandsOfCards
{
    class Cards
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cards = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            var stringInput = new List<string>();

            while (input != "JOKER")
            {
                stringInput = input.Split(new[] { ' ', ',', ':' }).ToList();
                if (cards.ContainsKey(stringInput[0]))
                {
                    cards[stringInput[0]].AddRange(stringInput.GetRange(1, stringInput.Count-1).Distinct().ToList());
                }
                else
                {
                    cards.Add(stringInput[0], stringInput.GetRange(1, stringInput.Count-1).Distinct().ToList());
                }

                input = Console.ReadLine();
            }

            int sum = 0;
            int p = 0;
            int t = 0;

            foreach (var person in cards)
            {
                for (int i = 0; i < person.Value.Count; i++)
                {
                    switch (person.Value[i][0])
                    {
                        case '2':
                            p = 2; break;
                        case '3':
                            p = 3; break;
                        case '4':
                            p = 4; break;
                        case '5':
                            p = 5; break;
                        case '6':
                            p = 6; break;
                        case '7':
                            p = 7; break;
                        case '8':
                            p = 8; break;
                        case '9':
                            p = 9; break;
                        case '1':
                            p = 10; break;
                        case 'J':
                            p = 11; break;
                        case 'Q':
                            p = 12; break;
                        case 'K':
                            p = 13; break;
                        case 'A':
                            p = 14; break;
                    }

                    switch (person.Value[i][person.Value[i].Length-1])
                    {
                        case 'S':
                            t = 4; break;
                        case 'H':
                            t = 3; break;
                        case 'D':
                            t = 2; break;
                        case 'C':
                            t = 1; break;
                    }

                    sum += p*t;
                }

                Console.WriteLine("{0}:{1}",person.Key,sum);
                sum = 0;
            }


        }
    }
}
