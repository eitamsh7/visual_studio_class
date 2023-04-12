using System;
using System.Collections.Generic;
using System.Text;

namespace BagrutFirstQues
{
    class AllNumbers // בגרות 2018 שאלה ראשונה
    {
        private int[] ArrNum; // מערך חד מימד מטיפוס שלם

        public AllNumbers() // פעולה בונה
        {
            for (int i = 0; i < this.ArrNum.Length; i++)
            {
                this.ArrNum[i] = 0;
            }
        }

        // הפעולה מחזירה את הערך של המספר האי זוגי האחרון במערך
        public int LastOddValue()
        {
            int LastOddNum = 0;
            for (int i = 0; i < this.ArrNum.Length; i++)
            {
                if (ArrNum[i] % 2 != 0)
                    LastOddNum = ArrNum[i];
            }
            return LastOddNum;
        }
    }
}
