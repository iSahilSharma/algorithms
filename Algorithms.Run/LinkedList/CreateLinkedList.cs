using System;
using System.Collections.Generic;

namespace Algorithms.LinkedList
{
    // Generic class to act as node of a linked list based on the type passed
    public class Node<T>
    {
        // Each node holds a value of type T
        public T Data { get; set; }

        // Each node has a reference to the next node in the list
        public Node<T> Next { get; set; }
    }

    // Generic class to act as LinkedList based on the type passed.
    public class GenericLinkedList<T>
    {
        // The list is initially empty.
        private Node<T> head = null;

        // Add a node at the beginning of the list with T as its data value.
        public void AddNode(T data)
        {
            Node<T> node = new Node<T>
            {
                Data = data,
                Next = head
            };

            head = node;
        }


        public List<Node<T>> Node { get; set; }
    }

    // Create a single linkedlist in C#
    // A linked list is a collection of nodes linked together. Each node contains two attributes - data and link
    // Data attribute contains the data for the node and link contains the link to next node.
    static class CreateLinkedList
    {
        public static LinkedList<string> Create()
        {
            GenericLinkedList<string> linkedList = new GenericLinkedList<string>();
            linkedList.AddNode("One");

            Console.WriteLine(linkedList.  );
            return null;

        }
    }
}