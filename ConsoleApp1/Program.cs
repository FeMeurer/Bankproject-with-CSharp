using ConsoleApp1.View;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   class Program : BaseObject
    {
        public Program(object parent) : base(parent)
        {
        }

        public void Run() 
        {
            ITransactionList transactionList = new TransactionList(this);
            ITransactionListView transactionListView = new TransactionListView(this, transactionList);
            transactionListView.Menu();
        }
    }
}
