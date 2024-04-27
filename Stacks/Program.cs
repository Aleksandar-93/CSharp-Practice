using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a new stack 
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using Push()
            //Peek() will retur the element at the top of the stack withaut removing it

            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            // remove item Pop() last item added
            int myStackItem = stack.Pop();
            Console.WriteLine("Popped Item : {0}", myStackItem);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());


        }
    }
}