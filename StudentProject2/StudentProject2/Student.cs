using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject2
{
    class Student
    {
        private int Code; // קוד תלמיד
        private string Name; //שם התלמיד
        private double Average; //ממוצע התלמיד
        //פעולה בונה
        public Student(int Code, string Name, double Average)
        {
            this.Code = Code;
            this.Name = Name;
            this.Average = Average;
        }

        //פעולות get
        public int GetCode()
        {
            return this.Code;
        }
        public string GetName()
        {
            return this.Name;
        }
        public double GetAverage()
        {
            return this.Average;
        }
        //פעולות set
        public void SetCode(int Code)
        {
            this.Code = Code;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetAverage(double Average)
        {
            this.Average = Average;
        }
        // פעולת to string
        public override string ToString()
        {
            return this.Code + ", " + this.Name + ", " + this.Average;
        }
    }
}


