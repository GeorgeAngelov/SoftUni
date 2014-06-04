using System;
    class Print_Company_Information
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Input Company Name: ");
            string compName = Console.ReadLine();
            Console.WriteLine("Input Company Address: ");
            string compAddress = Console.ReadLine();
            Console.WriteLine("Input Company Phone number: ");
            string compPhone = Console.ReadLine();
            Console.WriteLine("Input Company Fax number: ");
            string compFaxNum = Console.ReadLine();
            Console.WriteLine("Input Company Web site: ");
            string compWeb = Console.ReadLine();
            Console.WriteLine("Input Manager`s first name: ");
            string manFirstName = Console.ReadLine();
            Console.WriteLine("Input Manager`s last name: ");
            string manLastName = Console.ReadLine();
            Console.WriteLine("Input Manager`s age: ");
            string buff = Console.ReadLine();
            int Age;
            int.TryParse(buff, out Age);
            Console.WriteLine("Input Manager`s Phone Number: ");
            string manPhoneNum = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0} \nAdress: {1} \nTel. {2}",compName,compAddress,compPhone);
            if (compFaxNum != null)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}",compFaxNum);
            }
            Console.Write("Web site: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(compWeb);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Manager: {0}  {1} (age \n{2} tel.: {3})",manFirstName,manLastName, Age,manPhoneNum);
        }
    }
