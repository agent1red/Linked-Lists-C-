using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();

            myList.insertFirst(100);
            myList.insertFirst(5);
            myList.insertFirst(7);
            myList.insertFirst(8);
            myList.insertFirst(1);
            myList.printList();
            myList.deleteFirst();
            myList.printList();
        }

        // singlyLinkedList class points from left to right in one direction 

        public class SinglyLinkedList
        {
            private Node first;

            // method to check if the node is empty 
            public bool isEmpty()
            {
                return (first == null);
            }

            // method to insert data into the list 
            public void insertFirst(int data)
            {
                // create a new Node 
                Node newNode = new Node
                {
                    data = data,// assign the data to the node data 
                    next = first // newNode.next is equal to Node.first 
                };
                first = newNode; //
            }

            public Node deleteFirst()
            {
                // deleting is as  simple as just re-pointing to our new Node.head 
                Node temp = first;
                first = first.next; // assign new first node after deleting 
                return temp;
            }

            public void printList()
            {
                Console.Write("List (first -- last) ");
                Node current = first;
                while (current != null)
                {
                    current.displaynode();
                    current = current.next;
                }

                Console.WriteLine();
            }

          
        }
        public class Node
        {
            public int data;
            public Node next; // recursive as we are using the Node class itself

            // method to display node 
            public void displaynode()
            {
                Console.Write("(" + data + ") --->");
            }
        }
    }
}
