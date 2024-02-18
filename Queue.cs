using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GAQueueDoublyLinkedList_EdnalynnLaxa
{
    internal class Queue<T>
    {
        class QueueNode<T>
        {
            // Define a generic class called Queue.
            // The 'T' here is a type parameter that allows this class to work
            // with various data types.
            public T Value { get; set; } // The value stored in the node.
            public QueueNode<T> Next { get; set; } // Reference to the next node in the queue.
            public QueueNode<T> Previous { get; set; } // Reference to the previous node in the queue.

            public QueueNode(T value)
            {
                Value = value; // Set the value of the node.
                Next = null; // Initially, the next node is null.
                Previous = null; // Initially, the previous node is null.
            }
            //What is a Queue Node

            //A queue node is a critical component of a queue, especially when implemented using a doubly linked list.It includes:

            //Data storage.
            //Pointers to the next and previous nodes.
            //Facilitation of queue operations like enqueue and dequeue.
        }


        private QueueNode<T> front; // The front node of the queue.
        private QueueNode<T> rear; // The rear node of the queue.
        private int count; // The number of elements in the queue.

        public int Count
        {
            get { return count; } // Getter for count.
        }

        public Queue()
        {
            front = null; // Initially, the front is null as the queue is empty.
            rear = null; // Initially, the rear is also null.
            count = 0; // The count of elements starts at 0.
        }
        // Explanation with comments:

        // private QueueNode<T> front;: This private field holds a reference to the front node
        // in the queue.
        //private QueueNode<T> front;: This private field holds a reference to the front node
        //in the queue.
        //private QueueNode<T> rear;: This private field holds a reference to the rear node
        //in the queue.
        //private int count;: This private field keeps track of the number of elements
        //in the queue.
        //public Queue() : The constructor initializes an empty queue.
        //Explanation for front and rear:
        //front and rear references are important in a queue to perform efficient enqueue and 
        //dequeue operations.front allows quick access to the first element for dequeue,
        //while rear facilitates
        //fast addition of new elements at the end of the queue.

        public void Enqueue(T value)
        {
            QueueNode<T> newNode = new QueueNode<T>(value); // Create a new node with the value.

            if (rear == null)
            {
                // If the queue is empty, both front and rear are the new node.
                front = newNode;
                rear = newNode;
            }
            else
            {
                // Link the new node after the current rear.
                rear.Next = newNode;
                newNode.Previous = rear;
                // Update the rear to be the new node.
                rear = newNode;
            }

            count++; // Increment the count of elements.
        }

        //Explanation:

        //Creates a new node.
        //If the queue is empty, sets both front and rear to the new node.
        //If not, links the new node at the rear.
        //Increments the count.

        public T Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty."); // Check for an empty queue.

            T value = front.Value; // Store the value to return.

            // Move the front pointer to the next node.
            front = front.Next;

            if (front == null)
                rear = null; // If the queue becomes empty, adjust the rear as well.
            else
                front.Previous = null; // Remove the reference to the dequeued node.

            count--; // Decrement the count of elements.
            return value; // Return the dequeued value.
        }
        //Explanation:

        //Checks if the queue is empty.
        //Retrieves the value of the front element.
        //Updates front to the next node.
        //Adjusts rear if necessary.
        //Decreases the count and returns the value.

        public T Peek()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty."); // Check for an empty queue.

            return front.Value; // Return the value of the front node.
        }
        //Explanation:
        //Checks if the queue is empty.
        //Returns the value of the front element without removing it.
        public void Clear()
        {
            front = null; // Reset the front to null.
            rear = null; // Reset the rear to null.
            count = 0; // Reset the count to 0.
        }
    }
}

