using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectStack
{
    class TwoItems         // שאלה בגרות 2018 שאלה 4
    {
        private int Num1; // מספר בראש המחסנית
        private int Num2; // המספר בתחתית המחסנית

        public TwoItems(int Num1, int Num2) // פעולה בונה
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }

        public override string ToString()
        {
            return "[" + this.Num1 + " , " + this.Num2 + "]";
        }
    }
}
