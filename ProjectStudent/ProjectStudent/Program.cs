using System;

namespace ProjectStudent
{
    class Program
    {
        // כתוב פעולה חיצונית המקבלת מערך ואת הציון שקלטתם, על המערך להחזיר כמה תלמידים קיבלו ציון גבוהה יותר מהציון שקלטנו
        public static int AboveGrade(ClassStudent[] Arr, double Grade)
        {
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].GetAve() > Grade)
                {
                    count++;
                }
            }
            return count;
        }

        // כתוב פעולה חיצונית המקבלת מערך של סטודנטים ומדפיסה את כל השמות של התלמידים שהציון שלהם מתחת ל-55
        public static void Under55(ClassStudent[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].GetAve() < 55)
                {
                    Console.WriteLine(Arr[i].GetName());
                }
            }
        }

        // כתוב פעולה המקבלת מערך של סטודנטים ומחזירה תלמיד(אובייקט) של התלמיד עם הציון הגבוהה ביותר
        public static ClassStudent HighestStudent(ClassStudent[] Arr)
        {
            ClassStudent HighestGrade = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (HighestGrade.GetAve() < Arr[i].GetAve())
                {
                    HighestGrade = Arr[i];
                }
            }
            return HighestGrade;
        }
        static void Main(string[] args)
        {
            ClassStudent S1 = new ClassStudent("Amir", -1);
            ClassStudent S2 = new ClassStudent("Eitam", 69);
            ClassStudent S3 = new ClassStudent("Daddy", 96);
            ClassStudent S4 = new ClassStudent("Chipopov", 55);
            ClassStudent S5 = new ClassStudent("Yair", 100);

            ClassStudent[] SArr = new ClassStudent[5];
            SArr[0] = S1;
            SArr[1] = S2;
            SArr[2] = S3;
            SArr[3] = S4;
            SArr[4] = S5;

            Console.WriteLine(AboveGrade(SArr, 70));
            Under55(SArr);
            Console.WriteLine(HighestStudent(SArr));
        }
    }
}
