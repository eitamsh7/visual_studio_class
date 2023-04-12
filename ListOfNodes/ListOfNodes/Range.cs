using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfNodes
{
    class Range
    {
        private int From; // האיבר הראשון ברצף
        private int To; // האיבר האחרון ברצף
        public Range(int From, int To)
        {
            this.From = From;
            this.To = To;
        }
        public int GetFrom()
        {
            return this.From;
        }

        public int GetTo()
        {
            return this.To;
        }

        public override string ToString()
        {
            return "[" + this.From + " , " + this.To + "]";
        }
    }
}
