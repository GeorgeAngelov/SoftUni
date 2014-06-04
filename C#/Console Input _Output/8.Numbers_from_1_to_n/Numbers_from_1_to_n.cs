using System;
    class Numbers_from_1_to_n
    {
        static void Main()
        {
            Console.WriteLine("Entar a Number: ");
            string buff = Console.ReadLine();
            int num;
            int.TryParse(buff, out num);
            int value = 0;
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Numbers {0}",value=++value);
            }
        }
    }
