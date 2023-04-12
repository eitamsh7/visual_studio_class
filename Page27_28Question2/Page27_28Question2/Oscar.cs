using System;
using System.Collections.Generic;
using System.Text;

namespace Page27_28Question2
{
    class Oscar
    {
        // לכל קטגוריה יש מערך של שחקנים הזוכים בפרס
        private string Category; // שם הקטגוריה לזכייה בפרס
        private Actor[] ActorArr; // מערך של משתתפי התחרות
        private int NumOfActors; // מציין את מספר השחקנים שממתתפים בחרות

        // פעולה בונה
        public Oscar(string Category)
        {
            this.Category = Category;
            this.NumOfActors = 0;
            this.ActorArr = new Actor[37];
            for (int i = 0; i < this.ActorArr.Length; i++)
            {
                this.ActorArr[i] = null;
            }
        }

        // הפעולה בודקת האם השחקן קיים במערך
        public bool IsExist(Actor ActorToComp)
        {
            for (int i = 0; i < this.NumOfActors; i++)
            {
                if (this.ActorArr[i].GetID() == ActorToComp.GetID())
                    return true;
            }
            return false;
        }

        // הוספת שחקן חדש למערך למקום האחרון הפנוי
        public void AddActor(Actor ActorToAdd)
        {
            if (this.NumOfActors < ActorArr.Length && !IsExist(ActorToAdd)) // אם יש מקום במערך והשחקן שאנו רוצים להוסיף אינו נמצא כבר במערך
            {
                this.ActorArr[this.NumOfActors] = ActorToAdd;
                this.NumOfActors++; // קידום משתתפי התחרות באחד
            }
        }

        // מחיקת שחקן קייים מהמערך ושמירה על מערך תקין ללא רווחים
        public void RemoveActor(Actor ActorToOut)
        {
            Actor[] NewActorArr = new Actor[ActorArr.Length];
            int k = 0;
            if (IsExist(ActorToOut)) // בודקים האם השחקן שאנו רוצים להעיף נמצא כבר במערך
            {
                for (int i = 0; i < this.ActorArr.Length; i++)
                {
                    if (ActorArr[i] != ActorToOut) // אם השחקן שאנו רוצים להעיף לא נמצא נמצא במיקום הספציפי שבו אנו נמצאים במערך נרצה להעביר למערך החדש את אותו שחקן באותו מיקום מהמערך הישן
                    {
                        NewActorArr[k] = ActorArr[i]; 
                        k++;
                    }
                    this.NumOfActors--; // הורדת מספר השחקנים שזכו באחד
                }
                this.ActorArr = NewActorArr; // דריסת המערך הישן על ידי המערך החדש - ללא השחקן אותו העפנו
            }
        }

        // פעולה מתארת
        public override string ToString()
        {
            string S = "";
            S += "The Category is: " + this.Category + "\n";
            for (int i = 0; i < this.ActorArr.Length; i++)
            {
                S += this.ActorArr[i] + " ";
            }
            S+= "\n" + "\n" + "Number of Actors: " + this.NumOfActors + "\n";
            return S;
        }
    }
}
