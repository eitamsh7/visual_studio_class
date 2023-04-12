using System;
using System.Collections.Generic;
using System.Text;

namespace FarmManagement
{
    class Town
    {
        private string TownName; // שם המושב
        private Farm[] AllFarms; // אוסף המשקים במושב כולו
        private int NumOfarms; // המיקום הפנוי הבא באוסף המשקים. מספר המשקים במושב
        public Town(string TownName)
        {
            this.TownName = TownName;
            this.AllFarms = new Farm[1000];
            for (int i = 0; i < this.AllFarms.Length; i++)
            {
                this.AllFarms[i] = null;
            }
            this.NumOfarms = 0;
        }

        // ~~~~~~~~~~~~~~~~~~~~~~ פעולות מאחזרות ומעדכנות ~~~~~~~~~~~~~~~~~~~~~~

        public string GetTownName()
        {
            return this.TownName;
        }
        public Farm[] GetAllFarms()
        {
            return this.AllFarms;
        }
        public int GetNumOfFarms()
        {
            return this.NumOfarms;
        }

        public void SetTownName(string TownName)
        {
            this.TownName = TownName;
        }
        public void SetAllFarms(Farm[] AllFarms)
        {
            this.AllFarms = AllFarms;
        }
        public void SetNumOfarms(int NumOfarms)
        {
            this.NumOfarms = NumOfarms;
        }

        // איתור משק במושב. הפעולה מחזירה את המיקום במערך, האינדקס של התא אם מצאנו, אחרת הפעולה תחזיר מינוס אחד 
        public int IsExistFarm(Farm F)
        {
            for (int i = 0; i < this.NumOfarms; i++)
            {
                if (this.AllFarms[i].GetOwnerFarmCode() == F.GetOwnerFarmCode())
                    return i;
            }
            return -1;
        }

        // הוספת משק במושב
        public void AddFarm(Farm F)
        {
            if (this.NumOfarms < AllFarms.Length && this.IsExistFarm(F) == -1)
            {
                this.AllFarms[this.NumOfarms] = F;
                this.NumOfarms++;
            }
        }

        // פעולה מתארת
        public override string ToString()
        {
            string S = "";
            for (int i = 0; i < this.NumOfarms; i++)
            {
                S += this.AllFarms[i].ToString() + "\n" + "\n";
            }
            return "Town Name: " + this.TownName + '\n' + '\n' + S; ;
        }
    }
}
