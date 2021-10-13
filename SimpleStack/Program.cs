using System;
using System.Collections;

namespace SimpleStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(4);
            stack.Push(6);
            stack.Push(2);
            stack.Push(5);
            stack.Push(13);

            Console.WriteLine("Stack Elements are: ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            stack.Pop();
            stack.Pop();
            Console.WriteLine("After pop operation stack is: ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            if (stack.Count == 0)
                Console.WriteLine("Stack is not empty");
            else
            {
                Console.WriteLine("Stack is not empty");
            }

            ;

            Console.WriteLine(stack.Count == 4 ? "Stack is full" : "Stack is not full");
            stack.Push(15);
            stack.Push(23);
            stack.Push(9);
            stack.Push(17);
            if (stack.Count > 4)
                throw new StackOverflowException("cannot push data");
        }
    }
}
