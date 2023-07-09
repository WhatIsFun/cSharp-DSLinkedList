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
    }
}
