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

           while (stack.Count > 0) {
                //pop() will return element that was removed from stack
                Console.WriteLine("Top top value {0} was removed from the stack", stack.Pop());
                //print the stack count
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            // Defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("the numbers in my array are :");
            // foreach number in our array
            foreach(int number in numbers)
            {
                //print it
                Console.Write(number + " ");
                //push it inot our stack(add)
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("the numbers in reverse :");
            // as long as our stack is not empty
            while(myStack.Count > 0)
            {
                //Pop it and store it in variable
                int number = myStack.Pop();
                // print the value we poped 
                Console.Write(number + " ");
            }

        }
    }
}