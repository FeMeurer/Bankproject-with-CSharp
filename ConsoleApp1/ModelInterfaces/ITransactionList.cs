using System.Collections.Generic;

namespace ConsoleApp1.Model
{
    interface ITransactionList
    {
        void Add(ITransaction transaction);
        IEnumerator<ITransaction> GetEnumerator();
        ITransaction getTransaction(int index);
        int IndexOf(ITransaction transaction);
        int Count();
        void Remove(int index);
        void Remove(ITransaction transaction);


    }
}