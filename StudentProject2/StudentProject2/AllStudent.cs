using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject2
{
    class AllStudent
    {
        private Student[] ArrS; // מערך של תלמידים, מערך של אובייקטים
        private int NumOfStudent; // מספר התלמידים בפועל

        public AllStudent()
        {
            this.ArrS = new Student[10];
            for (int i = 0; i < this.ArrS.Length; i++)
            {
                this.ArrS[i] = null;
            }
            this.NumOfStudent = 0;
        }

        // הפעולה תקבל תלמיד ותחפש אותו אם קיים, אם הוא קיים תחזיר את מיקומו במערך, ואם הוא לא קיים תחזיר מינוס אחד
        public int IsExist(Student S)
        {
            for (int i = 0; i < this.NumOfStudent; i++)
            {
                if (this.ArrS[i].GetCode() == S.GetCode())
                    return i;
            }
            return -1;
        }

        // הוספת תלמיד למערך בתנאי שיש מקום במערך והתלמיד לא נמצא שם
        public void AddStudent(Student S)
        {
            int Place = IsExist(S);
            if (this.NumOfStudent < this.ArrS.Length && Place == -1)
            {
                this.ArrS[this.NumOfStudent] = S;
                this.NumOfStudent++;
            }
        }

        public override string ToString()
        {
            string S = " ";
            S += this.NumOfStudent + "\n";
            for (int i = 0; i < this.NumOfStudent; i++)
            {
                S += this.ArrS[i] +"\n";
            }
            return S;
        }
    }
}
