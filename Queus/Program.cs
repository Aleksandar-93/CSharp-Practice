using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining a queue of intigers
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the que is : {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the que is : {0}", queue.Peek()); 
            queue.Enqueue(3);
            Console.WriteLine("The value at the front of the que is : {0}", queue.Peek());

            while (queue.Count > 0)
            {
                //Dequeue() will return the element that was removed from te que
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
                //print the que count
                Console.WriteLine("Current que count is : {0}", queue.Count);
            }
        }
    }

    class Order
    {
        //order ID
        public int OrderId { get; set; }
        //quantity of the order
        public int OrderQuantity { get; set; }
        //Simple constructor
        public Order(int id,int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            //print the message
            Console.WriteLine($"Order {OrderId} processed!.");
        }

    }
}