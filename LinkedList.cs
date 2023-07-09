using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_DSLinkedList
{
    internal class LinkedList
    {
        private Node head;
        public LinkedList()
        {
            head = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            // 2. When Item is added at the end.
            else
            {
                Node currentNode = head;
                while(currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
        }
        public void Display()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void Remove(int data)
        {
            // 1. Head is null
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            // 2. Head is not null.
            else
            {
                // a. Delete Head.
                if (head.data == data)
                {
                    head = head.next;
                }
                else
                {
                    Node currentNode = head;
                    Node prevNode = null;
                    while(currentNode.next != null && currentNode.data != data) 
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    if (currentNode == null)
                    {
                        Console.WriteLine("Data not found in the linked list");
                        return;
                    }
                    prevNode.next = currentNode.next;
                }
            }
        }
    }
}
