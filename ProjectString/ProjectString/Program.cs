using System;

namespace ProjectString
{
    class Program
    {
        // שאלה ראשונה
        public static int CountWords(String St)
        {
            int count = 1;
            string st1 = " ";
            for (int i = 0; i < St.Length; i++)
            {
                if (St[i] == st1[i])
                    count++;
            }
            return count;
        }



        // שאלה שנייה
        public static int CountInSt (string st, string stA)
        {

        }
        static void Main(string[] args)
        {
            // כתוב פעולה המקבלת מחזורת ומחזירה כמה מילים היו במחזרות 
            // הערה: כל מילה מסתיימת ברווח

            //כתוב פעולה המקבלת מחרוזת ותו הפעולה תחזיר כמה פעמים התו הופיע במחרוזת


            //כתוב פעולה המקבלת מחרוזת עם רווחים בין מילה למילה (מספר הרווחים לא ידוע) הפעולה תחזיר
            //בכמה מילים התו האחרון בכל מילה יהיה שווה לתו הראשון במילה העוקבת לו 


            // כתוב פעולה המקבלת מערך של מחרודות ומחזירה את המחרוזת עם האורך הגדול ביותר במערך
        }
    }
}
