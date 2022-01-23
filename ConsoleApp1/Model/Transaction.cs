using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Transaction : BaseObject, ITransaction
    {
        private float amount;
        private string receiver;
        private string iban;
        private string bic;
        private string purpose;
        private DateTime date;

        public Transaction(Object parent, float amount, string receiver, string iban, string bic, string purpose, DateTime date) : base(parent)
        {
            this.Amount = amount;
            this.Receiver = receiver;
            this.Iban = iban;
            this.Bic = bic;
            this.Purpose = purpose;
            this.Date = date;
        }

        public float Amount { get => amount; set => amount = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public string Iban { get => iban; set => iban = value; }
        public string Bic { get => bic; set => bic = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
