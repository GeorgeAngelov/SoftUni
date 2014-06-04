using System;
    class Four_Digit_Number
    {
        static void Main()
        {
            int firstDigit;
            int secondDigit;
            int thirdDigit;
            int forthDigit;
            Console.WriteLine("Въвведи число 4-ри цифрено: ");
            string buff = Console.ReadLine();
            int number;
              if (!int.TryParse(buff, out number))
                  Console.WriteLine("Моля въведи правилно число:");
            buff = number.ToString().Substring(0, 1);
            int.TryParse(buff, out firstDigit);
            secondDigit = ((number / 10) % 10);
            thirdDigit = ((number / 100) % 10);
            forthDigit = ((number) % 10);
            int SumOfDigits = firstDigit + secondDigit+thirdDigit+forthDigit;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Сумата е: {0}",SumOfDigits);
            Console.WriteLine("----------------------------------------------------------------------------");
            int reverseInt = firstDigit + secondDigit * 100 + thirdDigit * 10 + forthDigit*1000 ;
            Console.WriteLine("{0} на обратно: {1}",number,reverseInt);
            Console.WriteLine("----------------------------------------------------------------------------");
            int swap1 = firstDigit*100 + secondDigit + thirdDigit * 10 + forthDigit*1000;
            Console.WriteLine("{0} със сменена първа цифра: {1}", number,swap1);
            Console.WriteLine("----------------------------------------------------------------------------");
            int swap2and3 = firstDigit*1000 + secondDigit * 100 + thirdDigit * 10 + forthDigit;
            Console.WriteLine("{0} с разменени 2 и 3 цифра: {1}", number, swap2and3);
        }

        private static void Substring(int p1, int p2)
        {
            throw new NotImplementedException();
        }
    }
