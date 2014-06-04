using System;
    class Quotes_in_Strings
    {
        static void Main(string[] args)
        {
            string firstPart = @"The ""use"" of quotations";
            string secondPart = "causes difficulties.";
            string firstPartwithOut = "The \"use\" of quotations";
            Console.WriteLine(firstPart+" "+secondPart);
            Console.WriteLine(firstPartwithOut+" "+secondPart);
        }
    }
