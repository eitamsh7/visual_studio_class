using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProg
{
    class Queue<T>
    {
        private Node<T> First;

        private Node<T> Last;
        //-----------------------------------
        public Queue()
        {
            this.First = null;

            this.Last = null;
        }
        //-----------------------------------
        public bool IsEmpty()
        {
            return (this.First == null);
        }

        public void Insert(T x)
        {
            Node<T> temp = new Node<T>(x);

            if (this.First == null)

                this.First = temp;
            else

                this.Last.SetNext(temp);

            this.Last = temp;
        }
        //-------------------------------------
        public T Remove()
        {
            T x = this.First.GetValue();

            First = First.GetNext();

            if (this.First == null)

                this.Last = null;

            return (x);
        }
        //-------------------------------------
        public T Head()
        {
            return (this.First.GetValue());
        }

        //-------------------------------------
        public Queue<T> CopyQueue()
        {
            Queue<T> CopyQ = new Queue<T>();
            Node<T> Pos = this.First;
            while (Pos != null)
            {

                CopyQ.Insert(Pos.GetValue());
                Pos = Pos.GetNext();
            }
            return CopyQ;
        }
        //-------------------------------------
        public override string ToString()
        {
            string st = "[";

            Node<T> pos = this.First;

            while (pos != null)
            {
                st += pos.GetValue();

                if (pos.GetNext() != null)

                    st += ",";

                pos = pos.GetNext();
            }
            st += "]";
            return (st);
        }
    }
}
