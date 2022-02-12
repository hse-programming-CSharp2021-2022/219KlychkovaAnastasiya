using System;
using System.Collections.Generic;


namespace Task1
{
    class Stack<T>
    {
        public LinkedList<T> stack { get; private set; }

        public void Push(T node)
        {
            stack.AddLast(node);
        }
        public T Pop()
        {
            if (stack.Count != 0)
            {
                T node = stack.Last.Value;
                stack.RemoveLast();
                return node;
            }
            else
                throw new NullReferenceException();
        }
        public T Peek()
        {
            if (stack.Count != 0)
            {
                return stack.Last.Value;
            }
            else
                throw new NullReferenceException();
        }
    }
}
