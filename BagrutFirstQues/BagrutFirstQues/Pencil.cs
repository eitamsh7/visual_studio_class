using System;
using System.Collections.Generic;
using System.Text;

namespace BagrutFirstQues
{
    class Pencil // בגרות 2020 שאלה ראשונה מועד ב
    {
        private int Length; // תכונה של אורך העיפרון
        private bool Sharpened; // אמת אם העיפרון מחודד, אחרת שקר

        public Pencil(int Length, bool Sharpened) // פעולה בונה
        {
            this.Length = Length;
            this.Sharpened = Sharpened;
        }

        // פעולה המקבלת עצם אחר מסוג עיפרון. מחזירה אמת אם העיפרון הנוכחי ארוך יותר מהעיפרון האחר
        // אחרת היא מחזירה שקר. הנח שהעצם האחר אינו נאל
        public bool IsLonger(Pencil Other)
        {
            if (this.Length > Other.Length)
                return true;
            return false;
        }

        // פעולה המחזירה אמת אם העיפרון מחודד, אחרת היא מחזירה שקר
        public bool IsSharpened()
        {
            return this.Sharpened;
        }

    }
}
