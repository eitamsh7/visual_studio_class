using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectQueue
{
    class Student // שאלת בגרות 2016 מועד א שאלה 1
    {
        private string Name; // שם התלמיד
        private int[] ArrTest; // מערך חד מימדי - בכל תא במערך באוחסן ציון של תלמיד במבחן

        public Student(string Name)
        {
            this.Name = Name;
            for (int i = 0; i < this.ArrTest.Length; i++)
            {
                this.ArrTest[i] = 0;
            }
        }

        public double Average() // ממוצע הציונים במערך של הציונים
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
