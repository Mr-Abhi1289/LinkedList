
using System;
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedlist list = new linkedlist();
            list.Append(56);           
            list.Append(70);
            list.Insert(2, 30);
            list.Display();
        }
    }
}


