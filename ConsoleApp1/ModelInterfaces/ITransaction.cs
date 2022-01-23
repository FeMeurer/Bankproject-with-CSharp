using System;

namespace ConsoleApp1
{
    interface ITransaction
    {
        float Amount { get; set; }
        string Bic { get; set; }
        DateTime Date { get; set; }
        string Iban { get; set; }
        string Purpose { get; set; }
        string Receiver { get; set; }
    }
}