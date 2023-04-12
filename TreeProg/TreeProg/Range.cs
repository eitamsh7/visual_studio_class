using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProg // בניית מחלקה - שאלת בגרות 2022 שאלה 4
{
    class Range
    {
        private int Low; // מספר שלם
        private int High; // מספר שלם

        public Range(int Low, int High)
        {
            this.Low = Low;
            this.High = High;
        }

        public int GetLow()
        {
            return this.Low;
        }
        public int GetHigh()
        {
            return this.High;
        }

        public void SetLow(int Low)
        {
            this.Low = Low;
        }
        public void SetHigh(int High)
        {
            this.High = High;
        }

        public override string ToString()
        {
            return "Low: " + this.Low + ", High: " + this.High;
        }

    }
}
