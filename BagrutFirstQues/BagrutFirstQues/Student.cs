using System;
using System.Collections.Generic;
using System.Text;

namespace BagrutFirstQues
{
    class Student // בגרות 2016 שאלה ראשונה מועד א
    {
        private string Name; // שם התלמיד
        private int[] ArrTest; // מערך של ציונים

        public Student(string Name) // פעולה בונה
        {
            this.Name = Name;
            this.ArrTest = new int[3];
            for (int i = 0; i < this.ArrTest.Length; i++)
            {
                this.ArrTest[i] = 0;
            }
        }

        // פעולה המחזירה את הציון הממוצע של התלציד בשלושת המבחנים
        public double AverageGrade()
        {
            int Sum = 0;
            for (int i = 0; i < this.ArrTest.Length; i++)
            {
                Sum += this.ArrTest[i];
            }
            return Sum / this.ArrTest.Length;
        }
    }
}
