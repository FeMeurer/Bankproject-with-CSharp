using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.View
{
    class TransactionListView : BaseObject, ITransactionListView
    {
        private ITransactionList transactionList;

        public TransactionListView(Object parent, ITransactionList transactionList) : base(parent)
        {
            this.transactionList = transactionList;
        }

        //Test
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
                    case "add":
                        Add();
                        break;
                    case "select":
                        Select();
                        break;
                    case "remove":
                        Remove();
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
            foreach (ITransaction transaction in transactionList)
            {
                Console.WriteLine("Position: " + transactionList.IndexOf(transaction));
                ITransactionView transactionView = new TransactionView(this, transaction);
                transactionView.Show();
                Console.WriteLine();
            }
        }

        public void Add()
        {
            Console.WriteLine("Enter Receiver: ");
            string receiver = Console.ReadLine();

            Console.WriteLine("Enter IBAN: ");
            string iban = Console.ReadLine();

            Console.WriteLine("Enter BIC: ");
            string bic = Console.ReadLine();

            Console.WriteLine("Enter purpose: ");
            string purpose = Console.ReadLine();

            Console.WriteLine("Enter amount to transfer: ");
            float amount = float.Parse(Console.ReadLine());

            DateTime dateTime = DateTime.Now;
            ITransaction transaction = new Transaction(this, amount, receiver, iban, bic, purpose, dateTime);
            transactionList.Add(transaction);
        }

        public void Remove()
        {
            Console.WriteLine("Enter postion number to remove");
            Console.WriteLine("Position: ");
            int position = int.Parse(Console.ReadLine());
            transactionList.Remove(position);
        }

        public void Select()
        {
            Console.WriteLine("Enter position number to select");
            Console.WriteLine("Position: ");
            int position = int.Parse(Console.ReadLine());

            if (position < 0 || position >= transactionList.Count())
            {
                Console.WriteLine("Position does not exist.");
            }
            else
            {

                ITransaction transaction = transactionList.getTransaction(position);
                ITransactionView transactionView = new TransactionView(this, transaction);
                transactionView.Menu();
            }

        }
    }
}
