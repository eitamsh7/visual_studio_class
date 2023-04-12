using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStack
{
    public class Node<T>
    {
        private T Value;
        private Node<T> Next;
        public Node(T Value)
        {
            this.Value = Value;
            this.Next = null;
        }
        public Node(T Value, Node<T> Next)
        {
            this.Value = Value;
            this.Next = Next;
        }
        public T GetValue()
        {
            return this.Value;
        }
        public Node<T> GetNext()
        {
            return this.Next;
        }
        public void SetValue(T Value)
        {
            this.Value = Value;
        }
        public void SetNext(Node<T> Next)
        {
            this.Next = Next;
        }
        public bool HasNext()
        {
            return this.GetNext() != null;

        }
        public override string ToString()
        {
            return "" + this.Value;
        }
    }
}
