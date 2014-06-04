using System;
    class PrintLongSequence
    {
        static void Main()
        {
            int Num = 2;
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(Num);
                Console.Write(" ; ");
                if (Num > 0)
                {
                    Num = (Num + 1) * (-1);
                }
                else
                {
                    Num = Num * (-1) + 1;
                }
            }
        }
}
