using System;
public static class PrimeTool
{
    public static bool IsPrime(int candidate)
    {
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        for (int i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}
    class Prime_Number_Check
    {
        static void Main()
        {
            string buff;
            Console.WriteLine("Input a positive Integer: ");
            buff = Console.ReadLine();
            int number;
            int.TryParse(buff, out number);
            bool prime = PrimeTool.IsPrime(number);
            if (prime)
            {
                Console.Write("Number is prime!");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Number is Not prime!");
                Console.ReadLine();
            }
        }
    }
