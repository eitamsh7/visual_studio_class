using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProg
{
    class Item // בניית מחלקה - מספר שאלות של טליה בכתה
    {
        private int Num; // מספר
        private int CountNum; // כמות הפעמים בעץ
        private int Sum; // תוצאת החיבור

        // פעולה בונה
        public Item(int Num, int CountNum)
        {
            this.Num = Num;
            this.CountNum = CountNum;
            this.Sum = this.CountNum * this.Num;
        }

        public int GetNum()
        {
            return this.Num;
        }

        public override string ToString()
        {
            return "Num: " + this.Num + ", Count: " + this.CountNum + ", Sum: " + this.Sum;
        }
    }
}
