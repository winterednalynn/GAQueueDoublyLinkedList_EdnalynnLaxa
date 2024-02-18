using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GAQueueDoublyLinkedList_EdnalynnLaxa
{
    //Edna Lynn Laxa 
    //Computer Programming V 
    //Assignment: Queue with Doubly Linked List
    //February 17, 2024 
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            //By utilizing a doubly linked list implementation, the Enqueue method effectively
            //adds a new element to the back of the queue. In addition to handling
            //the empty queue scenario, it also builds a new node, updates the back pointer,
            //ties it to the queue structure, and increases the element count.

            // Dequeue an element
            Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            //Using a doubly linked list implementation, this Dequeue method efficiently
            //removes and returns the front member from a queue. It checks to make sure the queue
            //isn't empty, gets the value of the front element, updates the front pointer to point to
            //the subsequent element, deals with the situation when the queue is empty,
            //updates the new front element's previous pointer (if needed),
            //reduces the number of elements, and returns the dequeued value.

            // Peek at the front element
            Console.WriteLine($"Front element: {queue.Peek()}");

            //All that this Peek method does is see if the queue is empty, and if it is,
            //it throws an exception. Without changing the queue itself, it returns the value
            //of the front element if it is not empty. This makes it possible to inspect the front
            //element
            //without changing the order of the queue or eliminating any elements.

            // Display count
            Console.WriteLine($"Count: {queue.Count}");

            Console.ReadLine();

            //Ednalynn's Understanding: 
            //Using a doubly linked list to build a queue offers an effective and dynamic
            //method of managing components in accordance with the FIFO principle.
            //It works well in scenarios where there is a requirement for regular additions
            //and deletions from the front and rear, as well as the possibility of
            //occasionally needing to peep at the front element.
        }
    }
}
