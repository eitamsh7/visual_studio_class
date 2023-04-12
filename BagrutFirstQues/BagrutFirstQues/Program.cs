using System;

namespace BagrutFirstQues
{
    class Program
    {
        // בגרות 2017 שאלה ראשונה 
        // טענת כניסה: הפעולה מקבלת מערך של מספרים שלמים
        // טענת יציאה: הפעולה מחזירה את האינדקס של האיבר שערכו הטוא הגדול ביותר במערך
        // אם המספר מופיע יותר מפעם אחת במערך, הפעולה תחזיר את האינדקס הקטן ביותר
        public static int Big(int[] Arr)
        {
            int MaxNum = Arr[0];
            int MaxNumIndex = 0;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] > MaxNum)
                {
                    MaxNum = Arr[i];
                    MaxNumIndex = i;
                }
            }
            return MaxNumIndex;
        }

        // בגרות 2019 שאלה ראשונה
        // טענת כניסה: מקבלת מערך מטיפוס מחרוזת ומספר שלם
        // טענת יציאה: הפעולה מחזירה את מספר המחרוזות במערך שאורכן שווה למספר השלם שקיבלנו
        public static int Exact(string[] Arr, int Num)
        {
            int Count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Length == Num)
                    Count++;
            }
            return Count;
        }

        // בגרות 2020 שאלה ראשונה מועד א
        // טענת כניסה: מקבלת מערך מטיפוס שלם ומספר שלם
        // טענת יציאה: הפעולה מחזירה את האינדקס הראשון של התא שסכום המספרים מתחילת המערך עד אליו כולל גדול מהמספר השלם שקיבלנו
        // אם אין תא כזה, הפעולה תחזיר מינוס אחד
        public static int Above(int[] Arr, int Num)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
                if (Sum > Num)
                    return i;
            }
            return -1;
        }

        // בגרות 2021 שאלה ראשונה מועד א
        // טענת כניסה: מקבלת מערך מטיפוס שלם ומספר שלם
        // טענת יציאה: הפעולה מחזירה מערך חדש מטיפוס שלם, הכולל רק את המספרים המופיעים במערך שאינם שווים למספר השלם שקיבלנו
        public static int[] Filter(int[] Arr, int Num)
        {
            int ArrLen = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != Num)
                    ArrLen++;
            }
            int[] NewArr = new int[ArrLen];
            int j = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != Num)
                {
                    NewArr[j] = Arr[i];
                    j++;
                }
            }
            return NewArr;
        }

        // בגרות 2021 שאלה ראשונה מועד א
        // טענת כניסה: הפעולה מקבלת מחרוזת
        // טענת יציאה: הפעולה מחזירה אמת אם המחרוזת היא מחרוזת כפולה אחרת מחזירה שקר
        public static bool IsDouble(string Str)
        {
            if (Str.Length % 2 != 0 || Str.Length == 0)
                return false;
            else
            {
                for (int i = 0; i < (Str.Length / 2); i++)
                {
                    if (Str[i] != Str[Str.Length / 2 + i])
                        return false;
                }
            }
            return true;
        }

        // בגרות 2022 שאלה ראשונה 
        // טענת כניסה: הפעולה מקבלת שני מערכים מטיפוס שלם ששונים בגודלם
        // טענת יציאה: הפעולה מחזירה מערך חדש מטיפוס שלם בגודל המערך הגדול מבין השניים
        // המערך המוחזר: מכיל את מכפלת הערכים המקבילים זה לזה במערכים השונים - המקבילים במיקום-באינדקס
        public static int[] Multiply(int[] Arr1, int[] Arr2)
        {
            int MinLen = Math.Min(Arr1.Length, Arr2.Length);
            int MaxLen = Math.Max(Arr1.Length, Arr2.Length);
            int[] NewArr = new int[MaxLen];
            for (int i = 0; i < MinLen; i++)
            {
                int Mul = Arr1[i] * Arr2[i];
                NewArr[i] = Mul;
            }
            if (Arr1.Length > Arr2.Length)
            {
                for (int i = MinLen; i < MaxLen; i++)
                {
                    NewArr[i] = Arr1[i];
                }
            }
            else
            {
                for (int i = MinLen; i < MaxLen; i++)
                {
                    NewArr[i] = Arr2[i];
                }
            }
            return NewArr;

        }

        // הדפסת מערך
        public static void PrintArr(int[] Arr)
        {
            Console.Write("[");
            for (int i = 0; i < Arr.Length; i++)
            {
                if (i == Arr.Length -1)
                    Console.Write(Arr[i]);
                else
                    Console.Write(Arr[i] + " ,");

            }
            Console.Write("]");
        }


        static void Main(string[] args)
        {
            // בגרות 2020 שאלה ראשונה מועד ב
            Pencil pencil1 = new Pencil(12, true);
            Pencil pencil2 = new Pencil(13, true);
            if (pencil1.IsLonger(pencil2) && pencil1.IsSharpened())
                Console.WriteLine("I choose pencil1");
            else
            {
                if (pencil2.IsSharpened())
                    Console.WriteLine("I choose pencil2");
                else
                    Console.WriteLine("pencil2 need to be sharpened");
            }
            // פלט מבגרות 2020 שאלה ראשונה מועד ב - סעיף ב: I choose pencil2

            // בדיקת שאלת בגרות 2021 שאלה ראשונה מועד א
            int[] Arr1 = { 6, 9, 2, 2, 9, 4, -3 };
            PrintArr(Filter(Arr1, 9));
            Console.WriteLine();

            // בדיקת שאלת בגרות 2021 שאלה ראשונה מועד ב
            string Str = "abcabc";
            Console.WriteLine(IsDouble(Str));
            Console.WriteLine();

            // בדיקת שאלת בגרות 2022 שאלה ראשונה
            int[] Arr2 = { 1, -4, 4, 9, 2 };
            int[] Arr3 = { 9, 2, 0, -1, 3, 11, 23 };
            PrintArr(Multiply(Arr2, Arr3));





        }
    }
}
