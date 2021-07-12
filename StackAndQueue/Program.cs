using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Insert operation.......");
            StackFunction stack = new StackFunction();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Display();
        }
    }
}
