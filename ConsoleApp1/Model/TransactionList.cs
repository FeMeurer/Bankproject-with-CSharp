using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class TransactionList : BaseObject, IEnumerable<ITransaction>, ITransactionList
    {
        private IList<ITransaction> transList;

        public TransactionList(Object parent) : base(parent)
        {
            this.TransList = new List<ITransaction>();
        }

        internal IList<ITransaction> TransList { get => transList; set => transList = value; }

        public void Add(ITransaction transaction)
        {
            transList.Add(transaction);
        }

        public void Remove(ITransaction transaction)
        {
            transList.Remove(transaction);
        }

        public void Remove(int index)
        {
            if (index <  0 || index >= transList.Count)
            {
                Console.WriteLine("Position does not exist.");
            } 
            else
            {
                transList.RemoveAt(index);
            }
        }

        public int IndexOf(ITransaction transaction)
        {
            return transList.IndexOf(transaction);
        }

        public ITransaction getTransaction(int index)
        {
            return transList[index];
        }

        public int Count()
        {
            return transList.Count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)transList).GetEnumerator();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            return transList.GetEnumerator();
        }
    }
}
