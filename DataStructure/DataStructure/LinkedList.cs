using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList<T>
    {
        public class Node
        {
            public T value;
            public Node next;

            public Node(T value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int count;


        public void AddLast(T item)
        {
            var node = new Node(item);

            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            count++;
        }

        

        public void AddFirst(T item)
        {
            var node = new Node(item);

            if (IsEmpty())
            {
                node.next = first;
            }
            else
            {
                first = last = node;
            }
            first = node;
            count++;
        }

        private bool IsEmpty()
        {
            return first == null || last == null;
        }

        public int IndexOf(T item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.value, item))
                {
                    return index;
                }
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) >= 0;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new System.ArgumentException("List is empty");
            }

            if (first == last)
            {
                first = last = null;
            }

            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }
            count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new System.ArgumentException("List is empty");
            }

            if (first == last)
            {
                first = last = null;
            }

            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }
            count--;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
            }
            current = current.next;
            return null;
        }

        public int size()
        {
            return count;
        }

        public T ReturnLast()
        {
            return last.value;
        }
    }
}
