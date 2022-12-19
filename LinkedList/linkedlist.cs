using LinkedList;
using System;
namespace LinkedList
{
    class linkedlist
    {
        internal Node head;
        public linkedlist()
        {
            this.head = null;
        }
        internal void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        internal void Display()
        {
            if (head == null)
                System.Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}