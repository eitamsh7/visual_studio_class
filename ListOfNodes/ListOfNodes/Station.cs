using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfNodes
{
    class Station
    {
        private int X; // המיקום איקס של התחנה
        private int Y; // המיקום הווי של התחנה

        public Station(int X, int Y) // פעולה בונה
        {
            this.X = X;
            this.Y = Y;
        }

        // חישוב מרחק בין תחנות 
        public double Distance(Station Other)
        {
            double X = Math.Pow((this.X - Other.X), 2);
            double Y = Math.Pow((this.Y - Other.Y), 2);
            return Math.Sqrt(X + Y);
        }
        public override string ToString()
        {
            return "[" + this.X + ", " + this.Y + "]";
        }
    } 
}
