using System;
    class Bits_Exchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
        uint number = uint.Parse(Console.ReadLine());
        uint maskSmall;
        uint result = number;
        uint maskBig;

        for (int position = 3; position < 6; position++)
        {
            int changeTo = position + 21;
            uint moveSmallBit = number >> position;
            uint smallBit = moveSmallBit & 1;
            uint moveBigBit = number >> changeTo;
            uint bigBit = moveBigBit & 1;

            if (smallBit != bigBit)
            {
                if (smallBit == 0)
                {
                    maskSmall = (uint)(1 << position);
                    result = result | maskSmall;
                }
                else
                {
                    maskSmall = (uint)(~(1 << position));
                    result = result & maskSmall;
                }

                if (bigBit == 0)
                {
                    maskBig = (uint)(1 << changeTo);
                    result = result | maskBig;
                }
                else
                {
                    maskBig = (uint)(~(1 << changeTo));
                    result = result & maskBig;
                }
            }

        }
        Console.WriteLine("Binary result");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Decimal result");
        Console.WriteLine(result);
    }
        }
