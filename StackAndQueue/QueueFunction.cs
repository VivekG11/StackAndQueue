using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    class QueueFunction
    {
        public Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if(this.front == null)
            {
                this.front = node;
            }
            else
            {
                Node temp = this.front;
                while(temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("inserted element is :"+node.data);
        }
        public void Dequeue()
        {
           
            if(this.front == null)
            {
                Console.WriteLine("Queue is empty...");
            }
            Node temp = this.front;
            this.front = this.front.next;
            Console.WriteLine("Deleted item is :"+temp.data);
        }
        public void Display()
        {
            if(this.front == null)
            {
                Console.WriteLine("Queue is Empty...");
            }
            Console.WriteLine("Elements in the Queue are....");
            Node temp = this.front;
            while(temp!=null)
            {
                Console.Write(temp.data+",");
                temp = temp.next;
            }
        }
    }
}
