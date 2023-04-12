using System;
using System.Collections.Generic;
using System.Text;

namespace FarmManagement
{
    class Farm
    {
        private string OwnerFarmName; // שם בעל המשק
        private int OwnerFarmCode; // קוד בעל המשק
        private Tree[] AllTrees; // אוסף של עצי הפרי במשק כולו
        private int NumOfTrees; // המיקום הפנוי הבא באוסף עצי הפרי. מספר העצים במשק

        public Farm(string OwnerFarmName, int OwnerFarmCode) // פעולה בונה
        {
            this.OwnerFarmName = OwnerFarmName;
            this.OwnerFarmCode = OwnerFarmCode;
            this.AllTrees = new Tree[500];
            for (int i = 0; i < this.AllTrees.Length; i++)
            {
                this.AllTrees[i] = null;
            }
            this.NumOfTrees = 0;
        }

        // ~~~~~~~~~~~~~~~~~~~~~~ פעולות מאחזרות ומעדכנות ~~~~~~~~~~~~~~~~~~~~~~

        public string GetOwnerFarmName()
        {
            return this.OwnerFarmName;
        }
        public int GetOwnerFarmCode()
        {
            return this.OwnerFarmCode;
        }
        public Tree[] GetAllTrees()
        {
            return this.AllTrees;
        }
        public int GetNumOfTrees()
        {
            return this.NumOfTrees;
        }

        public void SetOwnerFarmName(string OwnerFarmName)
        {
            this.OwnerFarmName = OwnerFarmName;
        }
        public void SetOwnerFarmCode(int OwnerFarmCode)
        {
            this.OwnerFarmCode = OwnerFarmCode;
        }
        public void SetAllTrees(Tree[] AllTrees)
        {
            this.AllTrees = AllTrees;
        }
        public void SetNumOfTrees(int NumOfTrees)
        {
            this.NumOfTrees = NumOfTrees;
        }

        // איתור עץ. הפעולה מחזירה את המיקום במערך, האינדקס של התא אם מצאנו, אחרת הפעולה תחזיר מינוס אחד 
        public int IsExistTree(Tree T)
        {
            for (int i = 0; i < this.NumOfTrees; i++)
            {
                if (this.AllTrees[i].GetTreeCode() == T.GetTreeCode())
                    return i;
            }
            return -1;
        }

        // הוספת עץ למשק
        public void AddTree(Tree T)
        {
            if (this.NumOfTrees < AllTrees.Length && this.IsExistTree(T) == -1)
            {
                this.AllTrees[this.NumOfTrees] = T;
                this.NumOfTrees++;
            }
        }

        // פעולה המחזירה את סך הפירות שנקטפו במשק
        public int TreeCountPicked()  
        {
            int Sum = 0;
            for (int i = 0; i < this.NumOfTrees; i++)
            {
                Sum += this.AllTrees[i].GetTreeCountPicked();
            }
            return Sum;
        }

        // מחיקת חדר מהאוסף, ושמירה על סדר המערך- יש משמעות לסדר המערך. שמירה ללא רווחים
        public void DeleteTree(Tree T)
        {
            int Place = this.IsExistTree(T);
            if (Place != -1)
            {
                for (int i = Place; i < this.NumOfTrees - 1; i++)
                {
                    this.AllTrees[i] = this.AllTrees[i + 1];
                }
                this.AllTrees[NumOfTrees - 1] = null;
                NumOfTrees--;
            }
        }

        // פעולה המחזירה את העצים שקטפו מהם יותר מ100 פירות
        public Tree[] MoreThan100(Tree[] NewAllTreesArr)
        {
            int J = 0;
            for (int i = 0; i < this.NumOfTrees-1; i++)
            {
                if (AllTrees[i].GetTreeCountPicked() >= 100)
                {
                    NewAllTreesArr[J] = this.AllTrees[i];
                }
            }
            return NewAllTreesArr;
        }

        // פעולה מתארת
        public override string ToString()
        {
            string S = "";
            for (int i = 0; i < this.NumOfTrees; i++)
            {
                S += this.AllTrees[i].ToString() + "\n" + "\n";
            }
            return "Farm Owner Name: " + this.OwnerFarmName + "    " + "Farm Owner Code: " + this.OwnerFarmCode + '\n' + '\n' + S;
        }

    }
}
