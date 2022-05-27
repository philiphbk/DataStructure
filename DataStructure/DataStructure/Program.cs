using System;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.push(1);
            stack.push(2);  
            stack.push(3);  
            stack.push(4);  

            stack.push(5);  

            stack.peek();
            Console.WriteLine(stack.peek());
        }
    }
}
