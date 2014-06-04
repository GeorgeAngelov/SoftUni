using System;
class Bank_Acc_Data
{
    static void Main()
    {
        string Name="Petar";
        string MiName="Iordanov";
        string LaName = "Ganchev";
        decimal Balance = 1500000;
        string BankName = "UniCreditBank";
        ulong IBAN = 9993338882223335544;
        long CrCaNum1 = 766644433322;
        long CrCaNum2 = 555333555445;
        long CrCaNum3 = 666444555664;
        Console.WriteLine("Name: {0}\n Middle Name: {1}\n Last Name: {2}\n Balance {3}\n Bank Name: {4}\n IBAN: {5}\n  Cr.Card Num 1 : {6}\n  Cr.Card Num 2 : {7}\n  Cr.Card Num 3 : {8}",Name,MiName,LaName,Balance,BankName,IBAN,CrCaNum1,CrCaNum2,CrCaNum3);
    }
}