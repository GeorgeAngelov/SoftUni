using System;
    class Print_a_Deck_of_52_Cards
    {
        static void Main()
        {
            for (int n = 2; n < 14; n++)
            {
                switch (n)
                {
                    case 11: Console.WriteLine("J ♣  J ♦  J ♥  J ♠"); break;
                    case 12: Console.WriteLine("Q ♣  Q ♦  Q ♥  Q ♠"); break;
                    case 13: Console.WriteLine("K ♣  K ♦  K ♥  K ♠"); break;
                    case 14: Console.WriteLine("A ♣  A ♦  A ♥  A ♠"); break;
                    default: Console.WriteLine("{0} ♣  {0} ♦  {0} ♥  {0} ♠", n); break;
                }
            }
        }
    }
