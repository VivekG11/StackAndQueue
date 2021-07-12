using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Insert operation.......");
            QueueFunction queue = new QueueFunction();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
            
        }
    }
}
