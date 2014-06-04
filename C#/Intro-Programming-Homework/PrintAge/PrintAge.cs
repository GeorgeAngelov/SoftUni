using System;
class PrintAge
{
     static void Main()
     {
        int age = 0;
        Console.WriteLine("На колко години си?");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ти си на ");
        Console.Write(age);
        Console.Write(" години.");
        age = age + 10;
        Console.Write("След 10 години ще си на ");
        Console.Write(age);
      }
}