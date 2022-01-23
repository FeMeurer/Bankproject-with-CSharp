using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.View
{
    class TransactionView : BaseObject, ITransactionView
    {
        private ITransaction transaction;

        public TransactionView(Object parent, ITransaction transaction) : base(parent)
        {
            this.Transaction = transaction;
        }

        internal ITransaction Transaction { get => transaction; set => transaction = value; }

        public void Menu()
        {
            string input = "";
            while (input != "back") 
            {
                Console.WriteLine("Enter something: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "show":
                        Show();
                        break;
                    case "back":
                        break;
                    default:
                        Console.WriteLine("Command unknown");
                        break;
                }
            } 
        }

        public void Show()
        {
            Console.WriteLine("Receiver: " + Transaction.Receiver);
            Console.WriteLine("IBAN: " + Transaction.Iban);
            Console.WriteLine("BIC: " + Transaction.Bic);
            Console.WriteLine("Purpose: " + Transaction.Purpose);
            Console.WriteLine("Amount: " + Transaction.Amount);
            Console.WriteLine("Date: " + Transaction.Date);
        }
    }
}
