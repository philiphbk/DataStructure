using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack<T>
    {
        LinkedList<T> myStack = new LinkedList<T>();

        private int count;

        public void push(T item)
        {
            myStack.AddLast(item);
            count++;
        }

        public void pop()
        {
            myStack.RemoveLast();
            count--;
        }

        public T peek()
        {
            if (isEmpty())
                throw new ArgumentNullException("count");
            return myStack.ReturnLast();
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int size()
        {
            return count;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
