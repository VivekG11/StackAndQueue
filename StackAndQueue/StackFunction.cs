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
            Console.WriteLine(node.data+" is added to stack.");
            
        }
        public void Display()
        {
            int count = 0;
            Node temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("Stack is Empty......");
            }
            Console.WriteLine("Elements in he Stack are ......");
            while (temp!= null)
            {
                Console.Write(temp.data+",");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nTotal Elements are  :"+count);

        }
    }
}
