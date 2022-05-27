using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue<T>
    {
        LinkedList<T> myQueue = new LinkedList<T>();

        private int count = 0;

        public void Enqueue(T item)
        {
            myQueue.AddLast(item);
            count++;
        }

        public void Dequeue()
        {
            myQueue.RemoveFirst();
            count--;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int Size()
        {
            return count;
        }



    }
}
