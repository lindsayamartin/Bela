using System;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrInput = input.Split(' ');
            int hands = Int32.Parse(arrInput[0]) * 4;
            char Domiant = Convert.ToChar(arrInput[1]);
            int points = 0;

            for (int x = 0; x < hands; x++)
            {
                string cards = Console.ReadLine();
                switch (cards[0])
                {
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    case 'J':
                        if (cards[1] == Domiant)
                        {
                            points += 20;
                        }
                        else
                        {
                            points += 2;
                        }
                        break;
                    case 'T':
                        points += 10;
                        break;
                    case '9':
                        if (cards[1] == Domiant)
                        {
                            points += 14;
                        }
                        else
                        {
                            points += 0;
                        }
                        break;
                    case '8':
                        points += 0;
                        break;
                    case '7':
                        points += 0;
                        break;
                }
            }
            Console.WriteLine(points);
        }
    }
}
