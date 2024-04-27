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
            stack.Push(1);
            stack.Push(22);
            //Peek() will retur the element at the top of the stack withaut removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

        }
    }
}