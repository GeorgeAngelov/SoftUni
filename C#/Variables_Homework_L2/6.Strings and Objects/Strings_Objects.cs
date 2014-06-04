using System;
    class Strings_Objects
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secontWord = "World";
            object sentance = firstWord + " " + secontWord;
            string cast = sentance.ToString();
            Console.WriteLine(sentance);
            Console.WriteLine("Casting: {0}",cast);
        }
    }
