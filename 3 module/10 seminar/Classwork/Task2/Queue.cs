using System;
using System.Collections.Generic;

namespace Task2
{
    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node(T value, Node<T> next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
    class Queue<T>
    {
        Node<T> firstNode = null;
        Node<T> lastNode = null;
        public int Size { get; private set; } = 0;
        public bool IsEmpty { get => firstNode == null; }
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            Size++;
            if (firstNode == null)
            {
                firstNode = node;
            }
            if (lastNode == null)
            {
                lastNode = node;
            }
            else
            {
                lastNode.next = node;
                lastNode = node;
            }
        }
        public T Dequeue()
        {
            if (firstNode == null)
            {
                throw new NullReferenceException("Queue is empty");
            }
            T value = firstNode.value;
            firstNode = firstNode.next;
            if (firstNode == null)
            {
                lastNode = null;
            }
            Size--;
            return value;
        }
        public T Top()
        {
            if (firstNode == null)
            {
                throw new NullReferenceException("Queue is empty");
            }
            return firstNode.value;
        }
    }
    
}
