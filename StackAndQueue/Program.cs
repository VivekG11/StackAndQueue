using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Insert operation.......");
            QueueFunction queue = new QueueFunction();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
            
        }
    }
}
