using System;
using System.Collections.Generic;
using System.Text;

namespace BagrutFirstQues
{
    class Stam // בגרות 2016 שאלה ראשונה מועד ב
    {
        private int[] Arr; // מערך חד מימד מטיפוס שלם

        public Stam() // פעולה בונה
        {
            for (int i = 0; i < this.Arr.Length; i++)
            {
                this.Arr[i] = 0;
            }
        }

        // הפעולה קולטת מספר שלם ומדפיסה את סכום האיברים במערך שערכם קטן מהמספר שקיבלנו
        public void PrintLessThanNum(int Num)
        {
            int Sum = 0;
            for (int i = 0; i < this.Arr.Length; i++)
            {
                if (this.Arr[i] < Num)
                    Sum += this.Arr[i];
            }
            Console.WriteLine(Sum);
        }

    }
}
