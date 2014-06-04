using System;
    class NumberSequence
    {
        static void Main()
        {
            int Num = 2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Num);
                if (Num>0)
                {
                    Num = (Num + 1)*(-1);
                }
                else
                {
                    Num = Num * (-1) + 1;
                }
            }
        }
    }
