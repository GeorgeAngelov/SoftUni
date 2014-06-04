using System;
    class Play_with_Int_Double_and_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please chose one: ");
            Console.WriteLine("1) ----> int");
            Console.WriteLine("2) ----> double");
            Console.WriteLine("3) ----> string");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": 
                    Console.WriteLine("Input a number: ");
                    int numInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(++numInt);break;
                case "2":
                    Console.WriteLine("Input a number: ");
                    double numDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(numDouble+1.0f);break;
                case "3":
                    Console.WriteLine("Input a string: ");
                    string STR = Console.ReadLine();
                    STR = STR + "*";
                    Console.WriteLine(STR);break;
                default: Console.WriteLine("Not a valid choice"); break;
            }
        }
    }
