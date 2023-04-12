using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQueue
{
    public class Stack<T>
    {
        private Node<T> First;

        public Stack()
        {
            this.First = null;
        }

        public bool IsEmpty()
        {
            return this.First == null;

        }

        public void Push(T x)
        {
            this.First = new Node<T>(x, this.First);
        }

        public T Pop()
        {
            T x = this.First.GetValue();
            this.First = this.First.GetNext();

            return x;
        }

        public T Top()
        {
            return this.First.GetValue();
        }

        public override string ToString()
        {
            string str = "[";

            Node<T> pos = this.First;
            while (pos != null)
            {
                str = str + pos.GetValue().ToString();
                if (pos.GetNext() != null)
                    str = str += ",";
                pos = pos.GetNext();
            }
            str = str + "]";
            return str;
        }
    }
}
