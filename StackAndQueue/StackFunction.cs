using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class StackFunction
    {
        public Node top;
        public void push(int data)
        {
            Node node = new Node(data);
            if(this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(node.data+" is added to stack.");
        }
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("STack is Empty.");
                return;
            }
            Console.WriteLine("Popped element is :"+this.top.data);
            this.top = this.top.next;
        }
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is Empty...");
            }
            else
            {
                Console.WriteLine(top.data);
            }
        }
        public void Display()
        {
            int count = 0;
            Node temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("Stack is Empty......");
            }
            Console.WriteLine("Elements in the Stack are ......");
            while (temp!= null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nTotal Elements are  :"+count);

        }
    }
}
