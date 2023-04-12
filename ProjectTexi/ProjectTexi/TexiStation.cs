using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTexi
{
    class TexiStation
    {
        private string StationName; // שם התחנה
        private Texi[] TexiArr; // מערך של מוניות
        private int NumOfTexies; // מספר המוניות בפועל בתחנה


        public TexiStation(string StationName)
        {
            this.StationName = StationName;
            this.NumOfTexies = 0;
            this.TexiArr = new Texi[80];
            for (int i = 0; i < this.TexiArr.Length; i++)
            {
                this.TexiArr[i] = null;
            }
        }

        // פעולת עזר המקבלת מונית ומחזירה אמת אם המונית נמצאת בתחנה אחרת שקר
        public bool IsExist(Texi T)
        {
            for (int i = 0; i < NumOfTexies; i++)
            {
                if (this.TexiArr[i].GetTexiID() == T.GetTexiID())
                    return true;
            }
            return false;
        }

        // פעולה המוסיפה מונית למערך המוניות בתחנה
        public void AddTexi(Texi T) 
        {
            if (this.NumOfTexies < this.TexiArr.Length && !IsExist(T))
            {
                this.TexiArr[this.NumOfTexies] = T;
                this.NumOfTexies++;
            }
        }

        // פעולות מאחזרות
        public int GetNumOfTexies()
        {
            return this.NumOfTexies;
        }

        public Texi[] GetTexiArr()
        {
            return this.TexiArr;
        }

        public override string ToString() // פעולה מתארת את המוניות בתחנה
        {
            string S = this.StationName + "\n" + "\n";
            for (int i = 0; i < this.NumOfTexies; i++)
            {
                S += TexiArr[i] + "\n";
            }
            return S;
        }




    }

}
