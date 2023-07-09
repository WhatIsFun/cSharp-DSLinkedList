using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_DSLinkedList
{
    internal class LinkedList
    {
        public Node head;
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
        public void InsertByPosition(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;
            if (position < 1)
            {
                Console.Write("position should be equal or more than 1");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node prevNode = new Node(data);
                prevNode = head;
                for (int i = 1; i < position-1; i++)
                {
                    if (prevNode != null)
                    {
                        prevNode = prevNode.next;
                    }
                }
                if (prevNode != null)
                {
                    newNode.next = prevNode.next;
                    prevNode = newNode;

                }
                else
                {
                    Console.WriteLine("The previous node is null");
                }
            }
        }
    }
}
