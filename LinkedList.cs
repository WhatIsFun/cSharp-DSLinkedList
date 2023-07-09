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
            if (position < 1) // To check if the position is more than 1
            {
                Console.WriteLine("position should be equal or more than 1");
                return;
            }
            else if (position == 1) // To set a head 
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                // To set the nodes between and the tail
                Node currentNode = new Node(data);
                currentNode = head;
                for (int i = 1; i < position-1; i++)
                {
                    if (currentNode != null)
                    {
                        currentNode = currentNode.next;
                    }
                }
                if (currentNode != null)
                {
                    newNode.next = currentNode.next;
                    currentNode.next = newNode;
                }
                else
                {
                    Console.WriteLine("The previous node is null"); // if there is no previous node will print this like: the tail node in p5 and i enter p7.
                }
            }
        }
    }
}
