using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BaseObject
    {
        private Object parent;
        private int id;
        private static int counter;

        public BaseObject(object parent)
        {
            this.Parent = parent;
            this.Id = counter++;
        }

        public object Parent { get => parent; set => parent = value; }
        public int Id { get => id; set => id = value; }
    }
}
